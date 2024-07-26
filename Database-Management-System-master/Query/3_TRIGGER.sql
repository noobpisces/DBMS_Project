USE DANG_KY_MON_HOC;
GO

--6 a
--DROP TRIGGER Trigger_TrungLichDangKyLop
CREATE TRIGGER Trigger_TrungLichDangKyLop --Trigger ngăn chặn học viên đăng ký lớp học trùng lịch, môn, hoặc quá 35 tín chỉ
ON DKMH
INSTEAD OF INSERT
AS
BEGIN
	DECLARE @I_MaHocVien CHAR(10), @I_MaLop CHAR(18) --Khai báo 2 biến chưa MaHocVien và Malop của học viên đăng kí
	SELECT @I_MaHocVien = i.MaHocVien, @I_MaLop = i.MaLop
	FROM inserted i

	DECLARE @TimeTable1 TABLE ( --bảng lưu thời gian của các lớp mà học viên đó đã đăng ký
		MaLop CHAR(18),
		NamHoc INT,
		SoHocKy INT,
		Thu INT, 
		TietBD INT,
		TietKT INT
		);

	DECLARE @TimeTable2 TABLE ( --bảng lưu thời gian lớp học mà học viên đó sắp đăng ký
		MaLop CHAR(18),
		NamHoc INT,
		SoHocKy INT,
		Thu INT, 
		TietBD INT,
		TietKT INT
		);

	INSERT INTO @TimeTable1 (MaLop, NamHoc, SoHocKy, Thu, TietBD, TietKT) 
	SELECT	MaLop,
			CAST(SUBSTRING(MaLop, CHARINDEX('_', MaLop) + 1, 2) AS INT) AS NamHoc,
			CAST(SUBSTRING(MaLop, CHARINDEX('_', MaLop) + 4, 1) AS INT) AS SoHocKy,
			CAST(SUBSTRING(Thu, CHARINDEX(' ', Thu) + 1, LEN(Thu)) AS INT) AS Thu, --biến đổi thứ sang kiểu int để dễ xử lý
			CAST(SUBSTRING(Tiet, CHARINDEX('-', Tiet) - 2, 2) AS INT) AS TietBD, --biến đổi tiết sang kiểu int trở thành tiết bắt đầu
			CAST(SUBSTRING(Tiet, CHARINDEX('-', Tiet) + 1, LEN(Tiet)) AS INT) AS TietKT -- và tiết kết thúc để dễ xử lý
	FROM (
		SELECT MaLop, Thu, Tiet
		FROM dbo.v_DSDaDangKi ds
		WHERE ds.MaHocVien = @I_MaHocVien) A --A chứa thông tin thời gian học của Học viên
	
	INSERT INTO @TimeTable2 (MaLop, NamHoc, SoHocKy, Thu, TietBD, TietKT) 
	SELECT	MaLop,
			CAST(SUBSTRING(MaLop, CHARINDEX('_', MaLop) + 1, 2) AS INT) AS NamHoc,
			CAST(SUBSTRING(MaLop, CHARINDEX('_', MaLop) + 4, 1) AS INT) AS SoHocKy,
			CAST(SUBSTRING(Thu, CHARINDEX(' ', Thu) + 1, LEN(Thu)) AS INT) AS Thu, --biến đổi thứ sang kiểu int để dễ xử lý
			CAST(SUBSTRING(Tiet, CHARINDEX('-', Tiet) - 2, 2) AS INT) AS TietBD, --biến đổi tiết sang kiểu int trở thành tiết bắt đầu
			CAST(SUBSTRING(Tiet, CHARINDEX('-', Tiet) + 1, LEN(Tiet)) AS INT) AS TietKT -- và tiết kết thúc để dễ xử lý
	FROM (
		SELECT MaLop, Thu, Tiet
		FROM LOPHOC lh
		WHERE lh.MaLop = @I_MaLop ) A --A chứa thông tin thời gian học lớp sắp đăng kí
	

	IF EXISTS (SELECT 1 FROM DKMH WHERE MaLop = @I_MaLop and MaHocVien = @I_MaHocVien)
		BEGIN
			RAISERROR (N'Đã đăng kí môn đó', 16, 1)
		END
	ELSE IF (
			SELECT COUNT(ds.MaMon) --kiểm tra xem học viên đã đăng kí môn học đó ở lớp học khác chưa
			FROM v_DSDaDangKi ds
			WHERE ds.MaHocVien = @I_MaHocVien and ds.MaMon = (SELECT MaMon FROM LOPHOC WHERE MaLop = @I_MaLop)
		) >= 1
		BEGIN
			RAISERROR (N'Đã đăng kí môn đó', 16, 1)
		END
	ELSE IF ( --kiểm tra xem số tín chỉ có vượt quá cho phép chưa
		SELECT SUM(SoTinChi)
		FROM v_DSDaDangKi
		WHERE MaHocVien = @I_MaHocVien
		) > 35
		BEGIN
			RAISERROR (N'Số tín chỉ vượt quá giới hạn cho phép.', 16, 1)
		END
	ELSE IF EXISTS ( --kiểm tra xem có trùng lịch với môn nào hay không
		SELECT 1 
		FROM (SELECT * FROM @TimeTable1 ) AS tt1, (SELECT * FROM @TimeTable2 ) AS tt2
		WHERE (tt1.NamHoc = tt2.NamHoc AND tt1.SoHocKy = tt2.SoHocKy) AND 
		(tt1.Thu = tt2.Thu AND ((tt1.TietBD <= tt2.TietBD AND tt1.TietKT >= tt2.TietBD) OR (tt1.TietBD <= tt2.TietKT AND tt1.TietKT >= tt2.TietKT)))
		)
		BEGIN
			RAISERROR(N'Trùng lịch', 16, 1)
		END
	ELSE IF  ( --kiểm tra xem lướp đó đủ số lượng đăng kí chưa
		(SELECT SoHocVienDangKy
		FROM LOPHOC
		WHERE MaLop = @I_MaLop) = 75
		)
		BEGIN
			RAISERROR(N'Đã đủ số lượng đăng kí', 16, 1)
		END
	ELSE 
		BEGIN
			INSERT INTO DKMH (MaHocVien, MaLop)
			VALUES(@I_MaHocVien, @I_MaLop)
		END
END;
GO

--6 b
--DROP TRIGGER Trigger_TrungLichChuyenLop;
CREATE TRIGGER Trigger_TrungLichChuyenLop --Trigger ngăn trùng lịch học khi học viên chuyển lớp
ON DKMH
INSTEAD OF UPDATE
AS
BEGIN
	DECLARE @I_MaLop CHAR(18), @I_MaHocVien CHAR(10)
	SELECT  @I_MaLop = MaLop, @I_MaHocVien = MaHocVien FROM inserted
	
	DECLARE @D_MaLop CHAR(18)
	SELECT  @D_MaLop = MaLop FROM deleted
	DECLARE @TimeTable1 TABLE ( --bảng lưu thời gian của các môn mà học viên đó đã đăng ký
		MaLop CHAR(18),
		NamHoc INT,
		SoHocKy INT,
		Thu INT, 
		TietBD INT,
		TietKT INT
		);
		DECLARE @TimeTable2 TABLE ( --bảng lưu thời gian của các môn mà học viên đó đã đăng ký
		MaLop CHAR(18),
		NamHoc INT,
		SoHocKy INT,
		Thu INT, 
		TietBD INT,
		TietKT INT
		);
	INSERT INTO @TimeTable1 (MaLop, NamHoc, SoHocKy, Thu, TietBD, TietKT) 
	SELECT	MaLop,
			CAST(SUBSTRING(MaLop, CHARINDEX('_', MaLop) + 1, 2) AS INT) AS NamHoc,
			CAST(SUBSTRING(MaLop, CHARINDEX('_', MaLop) + 4, 1) AS INT) AS SoHocKy,
			CAST(SUBSTRING(Thu, CHARINDEX(' ', Thu) + 1, LEN(Thu)) AS INT) AS Thu, --biến đổi thứ sang kiểu int để dễ xử lý
			CAST(SUBSTRING(Tiet, CHARINDEX('-', Tiet) - 2, 2) AS INT) AS TietBD, --biến đổi tiết sang kiểu int trở thành tiết bắt đầu
			CAST(SUBSTRING(Tiet, CHARINDEX('-', Tiet) + 1, LEN(Tiet)) AS INT) AS TietKT -- và tiết kết thúc để dễ xử lý
	FROM (
		SELECT MaLop, Thu, Tiet
		FROM dbo.v_DSDaDangKi ds
		WHERE ds.MaHocVien = @I_MaHocVien and ds.MaLop != @D_MaLop) A --A chứa thông tin thời gian học của Học viên
	
	INSERT INTO @TimeTable2 (MaLop, NamHoc, SoHocKy, Thu, TietBD, TietKT) 
	SELECT	MaLop,
			CAST(SUBSTRING(MaLop, CHARINDEX('_', MaLop) + 1, 2) AS INT) AS NamHoc,
			CAST(SUBSTRING(MaLop, CHARINDEX('_', MaLop) + 4, 1) AS INT) AS SoHocKy,
			CAST(SUBSTRING(Thu, CHARINDEX(' ', Thu) + 1, LEN(Thu)) AS INT) AS Thu, --biến đổi thứ sang kiểu int để dễ xử lý
			CAST(SUBSTRING(Tiet, CHARINDEX('-', Tiet) - 2, 2) AS INT) AS TietBD, --biến đổi tiết sang kiểu int trở thành tiết bắt đầu
			CAST(SUBSTRING(Tiet, CHARINDEX('-', Tiet) + 1, LEN(Tiet)) AS INT) AS TietKT -- và tiết kết thúc để dễ xử lý
	FROM (
		SELECT MaLop, Thu, Tiet
		FROM LOPHOC lh
		WHERE lh.MaLop = @I_MaLop ) A --A chứa thông tin thời gian học lớp sắp đăng kí

	IF (@D_MaLop = @I_MaLop)
		BEGIN
			RAISERROR (N'Đã đăng kí lớp này', 16, 1)
			ROLLBACK;
		END
	ELSE IF EXISTS ( --kiểm tra xem có trùng lịch với môn nào hay không
		SELECT 1 
		FROM (SELECT * FROM @TimeTable1 ) AS tt1, (SELECT * FROM @TimeTable2 ) AS tt2
		WHERE (tt1.NamHoc = tt2.NamHoc AND tt1.SoHocKy = tt2.SoHocKy) AND 
		(tt1.Thu = tt2.Thu AND ((tt1.TietBD <= tt2.TietBD AND tt1.TietKT >= tt2.TietBD) OR (tt1.TietBD <= tt2.TietKT AND tt1.TietKT >= tt2.TietKT)))
		)
		BEGIN
			RAISERROR(N'Trùng lịch', 16, 1)
		END
	ELSE IF ( --kiểm tra xem lướp đó đủ số lượng đăng kí chưa
		(SELECT SoHocVienDangKy
		FROM LOPHOC
		WHERE MaLop = @I_MaLop) = 75
		)
		BEGIN
			RAISERROR(N'Đã đủ số lượng đăng kí', 16, 1)
			ROLLBACK;
		END
	ELSE
		BEGIN
			UPDATE DKMH 
			SET MaLop = @I_MaLop
			WHERE MaHocVien = @I_MaHocVien and MaLop = @D_MaLop;
		END
END;
GO

--6 c
--DROP TRIGGER Trigger_MoLop;
CREATE TRIGGER Trigger_MoLop --Trigger hỗ trợ người quản lý xem xét mở lớp học mới
ON LOPHOC
INSTEAD OF INSERT
AS
BEGIN
	DECLARE @TimeTable1 TABLE ( --lưu thời gian các lớp học phần đang mở
		MaLop CHAR(18),
		MaGiangVien CHAR(10),
		MaPhong CHAR(10),
		NamHoc INT,
		SoHocKy INT,
		Thu INT, 
		TietBD INT,
		TietKT INT);
	INSERT INTO @TimeTable1 (MaLop, MaGiangVien, MaPhong, NamHoc, SoHocKy, Thu, TietBD, TietKT) 
	SELECT	MaLop,
			MaGiangVien,
			MaPhong,
			CAST(SUBSTRING(MaLop, CHARINDEX('_', MaLop) + 1, 2) AS INT) AS NamHoc,
			CAST(SUBSTRING(MaLop, CHARINDEX('_', MaLop) + 4, 1) AS INT) AS SoHocKy,
			CAST(SUBSTRING(Thu, CHARINDEX(' ', Thu) + 1, LEN(Thu)) AS INT) AS Thu, 
			CAST(SUBSTRING(Tiet, CHARINDEX('-', Tiet) - 2, 2) AS INT) AS TietBD,
			CAST(SUBSTRING(Tiet, CHARINDEX('-', Tiet) + 1, LEN(Tiet)) AS INT) AS TietKT
	FROM dbo.LOPHOC

	DECLARE @TimeTable2 TABLE ( --lưu thời gian lớp học phần thêm vào (insert)
		MaLop CHAR(18),
		MaGiangVien CHAR(10),
		MaPhong CHAR(10),
		NamHoc INT,
		SoHocKy INT,
		Thu INT, 
		TietBD INT,
		TietKT INT);
	INSERT INTO @TimeTable2 (MaLop, MaGiangVien, MaPhong, NamHoc, SoHocKy, Thu, TietBD, TietKT) 
	SELECT	MaLop,
			MaGiangVien,
			MaPhong,
			CAST(SUBSTRING(MaLop, CHARINDEX('_', MaLop) + 1, 2) AS INT) AS NamHoc,
			CAST(SUBSTRING(MaLop, CHARINDEX('_', MaLop) + 4, 1) AS INT) AS SoHocKy,
			CAST(SUBSTRING(Thu, CHARINDEX(' ', Thu) + 1, LEN(Thu)) AS INT) AS Thu, 
			CAST(SUBSTRING(Tiet, CHARINDEX('-', Tiet) - 2, 2) AS INT) AS TietBD,
			CAST(SUBSTRING(Tiet, CHARINDEX('-', Tiet) + 1, LEN(Tiet)) AS INT) AS TietKT
		   FROM inserted

	DECLARE @I_MaLop CHAR(18)
    SELECT @I_MaLop = i.MaLop
	FROM inserted i
    IF EXISTS (
        SELECT 1
        FROM LOPHOC lh,inserted i
        WHERE lh.MaLop = i.MaLop
    )
    BEGIN
        RAISERROR (N'Lớp học đã tồn tại trong bảng lớp học.', 16, 1)
    END
    ELSE IF EXISTS ( --chú ý
			SELECT 1
			FROM @TimeTable1 tt1 ,@TimeTable2 AS tt2
			WHERE (tt1.NamHoc = tt2.NamHoc AND tt1.SoHocKy = tt2.SoHocKy) AND 
			(tt1.MaGiangVien = tt2.MaGiangVien AND tt1.Thu = tt2.Thu AND ((tt1.TietBD <= tt2.TietBD AND tt1.TietKT >= tt2.TietBD) OR (tt1.TietBD <= tt2.TietKT AND tt1.TietKT >= tt2.TietKT)))
		)
		BEGIN
			RAISERROR (N'Giảng viên đã dạy lớp học khác trong thời gian diễn ra lớp học.', 16, 1)
		END
    ELSE IF EXISTS ( --chú ý
			SELECT 1
			FROM @TimeTable1 tt1 ,@TimeTable2 AS tt2
			WHERE (tt1.NamHoc = tt2.NamHoc AND tt1.SoHocKy = tt2.SoHocKy) AND 
			(tt1.MaPhong = tt2.MaPhong AND tt1.Thu = tt2.Thu AND ((tt1.TietBD <= tt2.TietBD AND tt1.TietKT >= tt2.TietBD) OR (tt1.TietBD <= tt2.TietKT AND tt1.TietKT >= tt2.TietKT)))
		)
		BEGIN
			RAISERROR (N'Phòng học đã phục vụ lớp học khác trong thời gian diễn ra lớp học.', 16, 1)
		END
    ELSE
		BEGIN
			INSERT INTO LOPHOC (MaLop, MaGiangVien, TenLop, SoHocVienDangKy, MaMon, MaHocKy, MaPhong, Tiet, Thu)
			SELECT MaLop, MaGiangVien,TenLop, SoHocVienDangKy, MaMon, MaHocKy, MaPhong, Tiet,Thu
			FROM inserted i;
			PRINT N'Đã mở'
		END
END;
GO

--6 d
--DROP TRIGGER Trigger_XoaLopItHocVien
CREATE TRIGGER Trigger_XoaLopItHocVien --Trigger hỗ trợ người quản lý xóa lớp không đủ điều kiện
ON LOPHOC
INSTEAD OF DELETE
AS
BEGIN
	DECLARE @D_MaLop CHAR(18)
	SELECT @D_MaLop = d.MaLop 
	FROM deleted d

	IF (
		SELECT lh.SoHocVienDangKy
		FROM dbo.LOPHOC lh
		WHERE lh.MaLop = @D_MaLop
	) < 10
		BEGIN
			DELETE dbo.LOPHOC
			WHERE dbo.LOPHOC.MaLop = @D_MaLop;
		END
	ELSE 
		BEGIN
			RAISERROR (N'Lớp học không thể xoá', 16, 1)
		END
END;
GO

--2.2.3.
--6 e
--DROP TRIGGER Trigger_XoaGV
CREATE TRIGGER Trigger_XoaGV --Trigger hỗ trợ người quản lý xóa Giang vien (Chỉ xóa khi giảng viên đó ko dạy lớp nào)
ON GIANGVIEN
INSTEAD OF DELETE
AS
BEGIN
	DECLARE @D_MaGV CHAR(18)
	SELECT @D_MaGV = d.MaGiangVien 
	FROM deleted d

    IF NOT EXISTS (SELECT 1 FROM LOPHOC WHERE MaGiangVien = @D_MaGV)
	BEGIN
		DELETE FROM GIANGVIEN WHERE MaGiangVien = @D_MaGV
	END
	ELSE 
		BEGIN
			RAISERROR (N'Giảng viên đang dạy 1 lớp', 16, 1)
		END
END;
GO

--6 f
--DROP TRIGGER Trigger_CheckYeuCau
CREATE TRIGGER Trigger_CheckYeuCau -- Trigger kiểm tra yêu cầu của giáo viên
ON YEUCAU
INSTEAD OF INSERT 
AS
BEGIN
	DECLARE @I_MaGV CHAR(18), @I_MaMon CHAR(10)
	SELECT @I_MaGV = i.MaGiangVien, @I_MaMon = i.MaMon
	FROM inserted i

	IF NOT EXISTS (SELECT 1 FROM YEUCAU WHERE MaGiangVien = @I_MaGV and MaMon = @I_MaMon)
	BEGIN
		INSERT INTO YEUCAU (MaGiangVien, MaMon, SoHocVienDuocDangKy)
		SELECT i.MaGiangVien, i.MaMon, i.SoHocVienDuocDangKy
		FROM inserted i
	END
	ELSE 
		BEGIN
			RAISERROR (N'Giảng viên đã yêu cầu mở lớp cho môn này trước đó', 16, 1)
		END
END;
GO

--6 g
--DROP TRIGGER Trigger_TaoTaiKhoan
CREATE TRIGGER Trigger_TaoTaiKhoan 
ON TAIKHOAN
INSTEAD OF INSERT
AS
	DECLARE @userName NVARCHAR(30), @passWord NVARCHAR(10)
	SELECT @userName = nl.TaiKhoan, @passWord = nl.MatKhau
	FROM inserted nl
	IF EXISTS (SELECT 1 FROM TAIKHOAN WHERE TaiKhoan = @userName)
	BEGIN
		DECLARE @err NVARCHAR(MAX)
		SELECT @err = N'Lỗi: Tài khoản đã tồn tại' 
		RAISERROR(@err, 16, 1)
	END
	ELSE
	BEGIN
		INSERT INTO TaiKhoan (TaiKhoan, MatKhau) VALUES (@userName, @passWord)
		DECLARE @sqlString NVARCHAR(2000)

		SET @sqlString = 'CREATE LOGIN [' + @userName + '] WITH PASSWORD=''' + @passWord + ''', DEFAULT_DATABASE=[DANG_KY_MON_HOC], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF'
		EXEC (@sqlString)

		SET @sqlString = 'CREATE USER ' + @userName +' FOR LOGIN '+ @userName
		EXEC (@sqlString)

		IF (LEFT(@userName, 2) = 'HV')
			SET @sqlString = 'ALTER ROLE HV ADD MEMBER ' + @userName;
		ELSE IF (LEFT(@userName, 2) = 'GV')
			SET @sqlString = 'ALTER ROLE GV ADD MEMBER ' + @userName;
		ELSE
			SET @sqlString = 'ALTER SERVER ROLE sysadmin' + ' ADD MEMBER '+ @userName;
		EXEC (@sqlString)
	END;
GO

--6 h
--DROP TRIGGER Trigger_DoiMatKhau
CREATE TRIGGER Trigger_DoiMatKhau 
ON TAIKHOAN
INSTEAD OF UPDATE
AS
	DECLARE @userName NVARCHAR(30), @N_passWord NVARCHAR(20), @O_passWord NVARCHAR(10)
	SELECT @userName = nl.TaiKhoan, @N_passWord = nl.MatKhau
	FROM inserted nl
	SELECT @O_passWord = d.MatKhau
	FROM deleted d

	IF NOT EXISTS (SELECT 1 FROM TAIKHOAN WHERE TaiKhoan = @userName and MatKhau = @O_passWord)
	BEGIN
		DECLARE @err NVARCHAR(MAX)
		SELECT @err = N'Lỗi: Tên tài khoản hoặc mật khẩu không chính xác' 
		RAISERROR(@err, 16, 1)
	END
	ELSE
	BEGIN
		UPDATE TAIKHOAN
		SET TaiKhoan = @userName,MatKhau = @N_passWord
		WHERE TaiKhoan = @userName and MatKhau = @O_passWord

		DECLARE @sqlString NVARCHAR(2000)
		SET @sqlString = 'ALTER LOGIN [' + @userName + '] WITH PASSWORD = ''' + @N_passWord+ ''''
		EXEC (@sqlString)
	END;
GO
