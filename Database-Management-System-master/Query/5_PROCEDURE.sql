USE DANG_KY_MON_HOC;
GO

--2.2
--AdminDAO.cs
--DROP PROCEDURE proc_TaoTK
CREATE PROCEDURE proc_TaoTK(@TaiKhoan NVARCHAR(20), @MatKhau NVARCHAR(20))
AS
BEGIN
	INSERT INTO TaiKhoan(TaiKhoan, MatKhau) VALUES (@TaiKhoan, @MatKhau)
END;
GO

--2.3
--AdminDAO.cs
--DROP PROCEDURE proc_DoiMK
CREATE PROCEDURE proc_DoiMK(@TaiKhoan NVARCHAR(20), @MatKhauCu NVARCHAR(20), @MatKhauMoi NVARCHAR(20))
AS
BEGIN
	UPDATE TAIKHOAN
	SET TaiKhoan = @TaiKhoan, MatKhau = @MatKhauMoi
	WHERE TaiKhoan = @TaiKhoan AND MatKhau = @MatKhauCu
END;
GO

--2.4.3.
--Admin_GiangVien.cs
--GiangVienAdminDAO.cs
--DROP PROCEDURE DeleteGiangVien
CREATE PROCEDURE DeleteGiangVien
    @MaGiangVien CHAR(6)
AS
BEGIN
BEGIN TRANSACTION
	DECLARE @username VARCHAR(15);
	SELECT @username = MaGiangVien FROM GIANGVIEN WHERE MaGiangVien = @MaGiangVien
	DECLARE @sql VARCHAR(100)
	DECLARE @SessionID INT;
	SELECT @SessionID = session_id
	FROM sys.dm_exec_sessions
	WHERE login_name = @username;
	IF @SessionID IS NOT NULL
		BEGIN
			SET @sql = 'KILL ' + CONVERT(NVARCHAR(20), @SessionID)
			EXEC(@sql)
		END
	
	BEGIN TRY
		DELETE FROM GIANGVIEN
		WHERE MaGiangVien = @MaGiangVien;
		DELETE FROM TAIKHOAN 
		WHERE TaiKhoan = @MaGiangVien
		SET @sql = 'DROP USER '+ @username
		EXEC (@sql)

		SET @sql = 'DROP LOGIN '+ @username
		EXEC (@sql)
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		ROLLBACK
		DECLARE @err NVARCHAR(MAX)
		SELECT @err = N'Lỗi ' + ERROR_MESSAGE()
		RAISERROR(@err, 16, 1)
	END CATCH
END;
GO

--2.4.4.
--DROP PROCEDURE [dbo].[InsertGiangVien]
CREATE PROCEDURE [dbo].[InsertGiangVien]
	@MaGiangVien CHAR(6),
	@HoTen NVARCHAR(MAX),
	@HocVi NVARCHAR(10),
	@HocHam NVARCHAR(12),
	@DiaChi NVARCHAR(MAX),
	@Sdt CHAR(10),
	@MaKhoa VARCHAR(5)
AS
BEGIN
	IF EXISTS (SELECT 1 FROM GIANGVIEN WHERE MaGiangVien = @MaGiangVien)
	BEGIN
			DECLARE @err NVARCHAR(MAX)
			SELECT @err = N'Giảng viên đã có trong cơ sở dữ liệu'
			RAISERROR(@err, 16, 1)
	END
	ELSE
	BEGIN
		INSERT INTO GIANGVIEN (MaGiangVien, HoTen, HocVi, HocHam, DiaChi, Sdt, MaKhoa)
		VALUES (@MaGiangVien, @HoTen, @HocVi, @HocHam, @DiaChi, @Sdt, @MaKhoa);
	END
END;
GO

--2.4.5.
--DROP PROCEDURE [dbo].[UpdateGiangVien]
CREATE PROCEDURE [dbo].[UpdateGiangVien]
	@MaGiangVien CHAR(6),
	@HoTen NVARCHAR(MAX),
	@HocVi NVARCHAR(10),
	@HocHam NVARCHAR(12),
	@DiaChi NVARCHAR(MAX),
	@Sdt CHAR(10),
	@MaKhoa VARCHAR(5)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION;

		IF EXISTS (SELECT 1 FROM GIANGVIEN WHERE MaGiangVien = @MaGiangVien)
		BEGIN
			UPDATE GIANGVIEN
			SET
				HoTen = @HoTen,
				HocVi = @HocVi,
				HocHam = @HocHam,
				DiaChi = @DiaChi,
				Sdt = @Sdt,
				MaKhoa = @MaKhoa
			WHERE MaGiangVien = @MaGiangVien;
		END
		ELSE
		BEGIN
			RAISERROR(N'Giảng viên với mã giảng viên không tồn tại.', 16, 1);
		END

		COMMIT TRANSACTION;
	END TRY
	BEGIN CATCH
		IF @@TRANCOUNT > 0
			ROLLBACK TRANSACTION;

		DECLARE @err NVARCHAR(MAX);
		SELECT @err = N'Lỗi ' + ERROR_MESSAGE();
		RAISERROR(@err, 16, 1);
	END CATCH
END;
GO

--2.5.3.
--DROP PROCEDURE DeleteHocVien
CREATE PROCEDURE DeleteHocVien
    @MaHocVien CHAR(10)
AS
BEGIN
		BEGIN TRANSACTION
			DECLARE @username VARCHAR(15);
			SELECT @username = MaHocVien FROM HOCVIEN WHERE MaHocVien = @MaHocVien
			DECLARE @sql VARCHAR(100)
			DECLARE @SessionID INT;
			SELECT @SessionID = session_id
			FROM sys.dm_exec_sessions
			WHERE login_name = @username;
			IF @SessionID IS NOT NULL
			BEGIN
				SET @sql = 'KILL ' + CONVERT(NVARCHAR(20), @SessionID)
				EXEC(@sql)
			END
    
		BEGIN TRY
			UPDATE LOPHOC
			SET LOPHOC.SoHocVienDangKy = LOPHOC.SoHocVienDangKy - 1
			WHERE MaLop IN (SELECT MaLop FROM DKMH WHERE MaHocVien = @MaHocVien);
        -- Xóa dòng dữ liệu có chứa @MaHocVien trong bảng DKMH
			DELETE FROM DKMH
			WHERE MaHocVien = @MaHocVien;
        -- Xóa học viên từ bảng HOCVIEN
			DELETE FROM HOCVIEN
			WHERE MaHocVien = @MaHocVien;
		----
			DELETE FROM TAIKHOAN
			WHERE taikhoan = @MaHocVien
			SET @sql = 'DROP USER ' + @username
			EXEC (@sql)

			SET @sql = 'DROP LOGIN ' + @username
			EXEC (@sql)

			COMMIT;
		END TRY
		BEGIN CATCH
		 -- Nếu có lỗi, hủy giao dịch và hiển thị thông báo lỗi
			ROLLBACK;
			DECLARE @err NVARCHAR(MAX)
			SELECT @err = N'Không thể xóa, kiểm tra lại mã học viên'
			RAISERROR(@err, 16, 1)
		END CATCH;
END;
GO

--2.5.4.
--PROCEDURE Thêm một học viên
--Drop procedure [dbo].[InsertHocVien]
CREATE PROCEDURE [dbo].[InsertHocVien]
    @MaHocVien CHAR(10),
    @HoTen NVARCHAR(40),
    @NgaySinh DATE,
    @DiaChi NVARCHAR(MAX),
    @QueQuan NVARCHAR(20),
    @MaKhoa VARCHAR(5)
AS
BEGIN
    IF EXISTS (SELECT 1 FROM HOCVIEN WHERE MaHocVien = @MaHocVien)
    BEGIN
        DECLARE @err NVARCHAR(MAX)
		SELECT @err = N'Học viên đã tồn tại trong cơ sở dữ liệu' 
		RAISERROR(@err, 16, 1)
    END
	ELSE
	BEGIN
		INSERT INTO HOCVIEN (MaHocVien, HoTen, NgaySinh, DiaChi, QueQuan, MaKhoa)
		VALUES (@MaHocVien, @HoTen, @NgaySinh, @DiaChi, @QueQuan, @MaKhoa);
	END
END;
GO

--2.5.5.
--PROCEDURE cập nhật thông tin một học viên
--DROP PROCEDURE [dbo].[UpdateHocVien]
CREATE PROCEDURE [dbo].[UpdateHocVien]
    @MaHocVien CHAR(10),
    @HoTen NVARCHAR(MAX),
    @NgaySinh DATE,
    @DiaChi NVARCHAR(MAX),
    @QueQuan NVARCHAR(20),
    @MaKhoa VARCHAR(5)
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION;

        IF EXISTS (SELECT 1 FROM HOCVIEN WHERE MaHocVien = @MaHocVien)
        BEGIN
            UPDATE HOCVIEN
            SET
                HoTen = @HoTen,
                NgaySinh = @NgaySinh,
                DiaChi = @DiaChi,
                QueQuan = @QueQuan,
                MaKhoa = @MaKhoa
            WHERE MaHocVien = @MaHocVien;
        END
        ELSE
        BEGIN
            RAISERROR(N'!', 16, 1);
        END

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;

        DECLARE @err NVARCHAR(MAX);
        SELECT @err = N'Học viên với mã học viên đã tồn tại' + ERROR_MESSAGE();
        RAISERROR(@err, 16, 1);
    END CATCH
END;
GO

--2.6.3.
--DROP PROCEDURE [dbo].[XoaLopHoc]
CREATE PROCEDURE [dbo].[XoaLopHoc]
    @MaLop CHAR(18)
AS
BEGIN
	BEGIN TRANSACTION 
		BEGIN TRY
			DELETE FROM DKMH
			WHERE MaLop = @MaLop

			DELETE FROM LOPHOC
			WHERE MaLop = @MaLop;
		COMMIT TRAN
		END TRY
		BEGIN CATCH
			ROLLBACK
			DECLARE @err NVARCHAR(MAX)
			SELECT @err = N'Lỗi ' + ERROR_MESSAGE()
			RAISERROR(@err, 16, 1)
		END CATCH
END;
GO

--2.6.4.
--PROCEDURE thêm một lớp học phần 
--DROP PROCEDURE [dbo].[ThemLopHoc] 
CREATE PROCEDURE [dbo].[ThemLopHoc]
    @MaLop CHAR(18),
    @TenLop NVARCHAR(MAX),
    @MaGiangVien CHAR(6),
    @MaMon CHAR(10),
    @MaHocKy CHAR(9),
    @SoHocVienDangKy INT,
    @MaPhong VARCHAR(10),
    @Thu NVARCHAR(10),
    @Tiet NVARCHAR(10)
AS
BEGIN
    INSERT INTO LOPHOC (MaLop, TenLop, MaGiangVien, MaMon, MaHocKy, SoHocVienDangKy, MaPhong, Thu, Tiet)
    VALUES (@MaLop, @TenLop, @MaGiangVien, @MaMon, @MaHocKy, @SoHocVienDangKy, @MaPhong, @Thu, @Tiet);
END;
GO
/*
DROP PROCEDURE InsertLopHocFromYeuCau;
CREATE PROCEDURE InsertLopHocFromYeuCau
(
	@MaGiangVien CHAR(6),
    @MaMon CHAR(10),
    @MaPhong VARCHAR(10),
    @Thu NVARCHAR(10),
    @Tiet VARCHAR(10),
    @MaHocKy CHAR(9)
)
AS
BEGIN
    BEGIN TRANSACTION;
    BEGIN TRY
        DECLARE @SoHocKy INT;
        DECLARE @SoHocKyKep INT;
		DECLARE @TenLop NVARCHAR(MAX);

        -- Lấy số kỳ học dựa trên @HocKy
        SET @SoHocKy = SUBSTRING(@MaHocKy, 3, 1);

        -- Tìm số kế tiếp của lớp học dạy môn giống nhau
        SELECT @SoHocKyKep = MAX(CAST(RIGHT(MaLop, 2) AS INT))
        FROM LOPHOC
        WHERE MaMon = @MaMon
        AND MaHocKy = @MaHocKy;

        -- Nếu không tìm thấy số kế tiếp, sử dụng 1
        IF @SoHocKyKep IS NULL
            BEGIN
                SET @SoHocKyKep = 1;
            END
        ELSE
            BEGIN
                SET @SoHocKyKep = @SoHocKyKep + 1;
            END;

        -- Tạo MaLop theo định dạng
        DECLARE @MaLop CHAR(18);
        SET @MaLop = @MaMon + '_' + RIGHT(@MaHocKy, 2) + '_' + CAST(@SoHocKy AS CHAR(1)) + '_' + RIGHT('0' + CAST(@SoHocKyKep AS VARCHAR(2)), 2);

		SET @TenLop = (SELECT TenMonHoc FROM MONHOC WHERE MaMon = @MaMon) + '_Nhóm ' + RIGHT('0' + CAST(@SoHocKyKep AS VARCHAR(2)), 2);

        -- Chèn bản ghi vào bảng LOPHOC
        INSERT INTO LOPHOC (MaLop, TenLop, MaGiangVien, MaMon, MaHocKy, SoHocVienDangKy, MaPhong, Thu, Tiet)
        VALUES (@MaLop, @TenLop, @MaGiangVien, @MaMon, @MaHocKy, 0, @MaPhong, @Thu, @Tiet);
        
		-- Xoá bản ghi tương ứng trong bảng YEUCAU
        DELETE FROM YEUCAU
        WHERE MaGiangVien = @MaGiangVien
        AND MaMon = @MaMon;
        COMMIT;
    END TRY
    BEGIN CATCH
        ROLLBACK;
        DECLARE @err NVARCHAR(MAX);
        SELECT @err = N'Lỗi ' + ERROR_MESSAGE();
        RAISERROR(@err, 16, 1);
    END CATCH;
END;
GO

EXEC InsertLopHocFromYeuCau @MaPhong = 'B108', @Thu = N'Thu 2', @Tiet = 'Tiet 1-3', @MaHocKy = 'HK2_22-23', @MaGiangVien = 'GV0001', @MaMon = 'MATH330123';
*/
PRINT '';
GO

--2.6.5.
--DROP PROCEDURE [dbo].[UpdateLopHoc]
CREATE PROCEDURE [dbo].[UpdateLopHoc]
    @MaLop CHAR(18),
    @TenLop NVARCHAR(50),
    @MaGiangVien CHAR(10),
    @MaMon CHAR(10),
    @MaHocKy CHAR(10),
    @SoHocVienDangKy INT,
    @MaPhong CHAR(10),
    @Thu NVARCHAR(10),
    @Tiet NVARCHAR(50)
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION;

        IF EXISTS (SELECT 1 FROM LOPHOC WHERE MaLop = @MaLop)
        BEGIN
            UPDATE LOPHOC
            SET
                TenLop = @TenLop,
                MaGiangVien = @MaGiangVien,
                MaMon = @MaMon,
                MaHocKy = @MaHocKy,
                SoHocVienDangKy = @SoHocVienDangKy,
                MaPhong = @MaPhong,
                Thu = @Thu,
                Tiet = @Tiet
            WHERE MaLop = @MaLop;
        END
        ELSE
        BEGIN
            RAISERROR(N'Lớp học với mã lớp = %s không tồn tại.', 16, 1, @MaLop);
        END

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;

        DECLARE @err NVARCHAR(MAX);
        SELECT @err = N'Lỗi ' + ERROR_MESSAGE();
        RAISERROR(@err, 16, 1);
    END CATCH
END;
GO

--3.1.
--DROP PROCEDURE proc_HV_DN 
CREATE PROCEDURE proc_HV_DN
	@TaiKhoan CHAR(10),
	@MatKhau CHAR(18)
AS
BEGIN
	IF EXISTS (SELECT 1 FROM TAIKHOAN, HOCVIEN WHERE TaiKhoan = @TaiKhoan and MatKhau = @MatKhau and MaHocVien = @TaiKhoan)
	BEGIN
		SELECT HoTen, MaKhoa 
		FROM HOCVIEN 
		WHERE MaHocVien = @TaiKHoan
	END
	ELSE 
	BEGIN
		DECLARE @err NVARCHAR(MAX)
		SELECT @err = N'Sai Tài khoản hoặc Mật khẩu'
		RAISERROR(@err, 16, 1)
	END
END;
GO

--3.5.
--DROP PROCEDURE proc_DKLopHoc
CREATE PROCEDURE proc_DKLopHoc --Học viên đăng ký lớp học
	@MaHV CHAR(10),
	@MaLH CHAR(18)
AS
BEGIN
	BEGIN TRANSACTION 
		BEGIN TRY
			INSERT INTO DKMH (MaHocVien, MaLop)
			VALUES(@MaHV, @MaLH)

			UPDATE LOPHOC
			SET LOPHOC.SoHocVienDangKy = LOPHOC.SoHocVienDangKy + 1
			WHERE MaLop = @MaLH

		COMMIT TRAN
		END TRY
		BEGIN CATCH
			ROLLBACK
			DECLARE @err NVARCHAR(MAX)
			SELECT @err = N'Lỗi ' + ERROR_MESSAGE()
			RAISERROR(@err, 16, 1)
		END CATCH
END;
GO

--3.6.
--DROP PROCEDURE proc_Xoa_DKLopHoc 
CREATE PROCEDURE proc_Xoa_DKLopHoc --Học viên xoá đăng ký lớp học
	@MaHV CHAR(10),
	@MaLH CHAR(18)
AS
BEGIN
	BEGIN TRANSACTION 
		BEGIN TRY
			DELETE FROM DKMH WHERE MaHocVien = @MaHV AND MaLop = @MaLH

			UPDATE LOPHOC
			SET LOPHOC.SoHocVienDangKy = LOPHOC.SoHocVienDangKy - 1
			WHERE MaLop = @MaLH
		COMMIT TRAN
		END TRY
		BEGIN CATCH
			ROLLBACK
			DECLARE @err NVARCHAR(MAX)
			SELECT @err = N'Lỗi ' + ERROR_MESSAGE()
			RAISERROR(@err, 16, 1)
		END CATCH
END;
GO

--3.7.
--DROP PROCEDURE proc_ChuyenLopHoc 
CREATE PROCEDURE proc_ChuyenLopHoc --Học viên chuyển lớp học
	@MaHV CHAR(10),
	@MaLH CHAR(18), --lớp học hiện tại
	@MaLHDK CHAR(18) --lớp học đăng ký mới
AS
BEGIN
	BEGIN TRANSACTION 
		BEGIN TRY
			UPDATE DKMH 
			SET MaLop = @MaLHDK
			WHERE MaHocVien = @MaHV and MaLop = @MaLH;

			UPDATE LOPHOC
			SET LOPHOC.SoHocVienDangKy = LOPHOC.SoHocVienDangKy - 1
			WHERE MaLop = @MaLH
			UPDATE LOPHOC
			SET LOPHOC.SoHocVienDangKy = LOPHOC.SoHocVienDangKy + 1
			WHERE MaLop = @MaLHDK

		COMMIT TRAN
		END TRY
		BEGIN CATCH
			ROLLBACK
			DECLARE @err NVARCHAR(MAX)
			SELECT @err = N'Lỗi ' + ERROR_MESSAGE()
			RAISERROR(@err, 16, 1)
		END CATCH
END;
GO

--4.1.
--DROP PROCEDURE proc_GV_DN
CREATE PROCEDURE proc_GV_DN --Giảng viên đăng nhập
	@TaiKhoan CHAR(10),
	@MatKhau CHAR(18)
AS
BEGIN
	IF EXISTS (SELECT 1 FROM TAIKHOAN, GIANGVIEN WHERE MaGiangVien = @TaiKhoan AND TaiKhoan = @TaiKhoan AND MatKhau = @MatKhau)
	BEGIN
		SELECT *
		FROM GIANGVIEN 
		WHERE MaGiangVien = @TaiKhoan
	END
	ELSE 
	BEGIN
		DECLARE @err NVARCHAR(MAX)
		SELECT @err = N'Sai Tài khoản hoặc Mật khẩu'
		RAISERROR(@err, 16, 1)
	END
END;
GO

--4.4.
--drop PROCEDURE proc_GuiYeuCau
CREATE PROCEDURE proc_GuiYeuCau
	@MaGiangVien CHAR(6),
	@MaMon CHAR(10),
	@SoHocVienDuocDangKy INT
AS
BEGIN
BEGIN TRY
	INSERT INTO YEUCAU (MaGiangVien, MaMon, SoHocVienDuocDangKy)
	VALUES (@MaGiangVien, @MaMon, @SoHocVienDuocDangKy)
END TRY
BEGIN CATCH
	DECLARE @err NVARCHAR(MAX)
	SELECT @err = N'Lỗi ' + ERROR_MESSAGE()
	RAISERROR(@err, 16, 1)
END CATCH
END;
GO

