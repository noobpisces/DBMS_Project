USE DANG_KY_MON_HOC;
GO

--2.1.
--AdminDAO.cs
--DROP FUNCTION [dbo].[fu_Check_DangNhap_ADMIN] --bỏ proceduce 2.1 proc_login thay thành cái này để tạo ra hàm tar về gái trị nhưu ý thầy
CREATE FUNCTION [dbo].[fu_Check_DangNhap_ADMIN](@user NVARCHAR(50), @pass NVARCHAR(50))
RETURNS FLOAT
AS 
BEGIN
    DECLARE @result FLOAT;
	IF EXISTS (SELECT (1) FROM TAIKHOAN WHERE TaiKhoan = @user
											AND MatKhau = @pass  
											AND @user NOT IN (SELECT MaHocVien FROM HOCVIEN)
											AND @user NOT IN (SELECT MaGiangVien FROM GIANGVIEN))
	BEGIN
		SET @result = 1
	END
	ELSE SET @result = 0
	RETURN @result
END;
GO

--2.4.1.
--FUNCTION lấy dữ liệu từ table GiangVien
--DROP FUNCTION fu_load_GV
CREATE FUNCTION fu_load_GV( ) 
RETURNS TABLE 
AS RETURN (
	SELECT MaGiangVien, HoTen, HocVi, HocHam, Diachi, Sdt, MaKhoa, MatKhau 
	FROM GIANGVIEN LEFT JOIN TAIKHOAN ON TaiKhoan = MaGiangVien
);
GO

--2.4.2.
--DROP FUNCTION [dbo].[func_getGiangVienByMaGiangVien]
CREATE FUNCTION [dbo].[func_getGiangVienByMaGiangVien] (@maGiangVien CHAR(6))
RETURNS TABLE
AS
RETURN
(
    SELECT MaGiangVien, HoTen, HocVi, HocHam, Diachi, Sdt, MaKhoa, MatKhau  
	FROM GIANGVIEN LEFT JOIN TAIKHOAN ON TaiKhoan = MaGiangVien
    WHERE MaGiangVien = @maGiangVien
);
GO

--2.5.1.
--FUNCTION lấy dữ liệu từ table SinhViên --
--DROP FUNCTION fu_load_HocVien
CREATE FUNCTION fu_load_HocVien ( )
RETURNS TABLE 
AS RETURN (
	SELECT MaHocVien, HoTen, NgaySinh, DiaChi, QueQuan, MaKhoa, MatKhau
	FROM HOCVIEN LEFT JOIN TAIKHOAN ON MaHocVien = TaiKhoan
);
GO

--2.5.2.
--FUNCTION tìm thông tin của một sinh viên bằng Mã Sinh viên
--DROP FUNCTION [dbo].[func_getHocVienByMaHocVien]
CREATE FUNCTION [dbo].[func_getHocVienByMaHocVien] (@maHocVien CHAR(10))
RETURNS TABLE
AS
RETURN
(
    SELECT MaHocVien, HoTen, NgaySinh, DiaChi, QueQuan, MaKhoa, MatKhau
	FROM HOCVIEN LEFT JOIN TAIKHOAN ON MaHocVien = TaiKhoan
    WHERE MaHocVien = @maHocVien
);
GO

--2.6.1.
--FUNCTION hiển thị danh sách lớp học
CREATE FUNCTION [dbo].[DanhSachLopHoc] ( )
RETURNS TABLE
AS
RETURN
(
    SELECT MaLop, TenLop, MaGiangVien, MaMon, MaHocKy, SoHocVienDangKy, MaPhong, Thu, Tiet
    FROM LOPHOC
);
GO

--2.6.2.
--FUNCTION Tìm kiếm một lớp học phần
CREATE FUNCTION [dbo].[LayThongTinLopHocPhan] (@MaLop CHAR(18))
RETURNS TABLE
AS
RETURN
(
    SELECT MaLop, TenLop, MaGiangVien, MaMon, MaHocKy, SoHocVienDangKy, MaPhong, Thu, Tiet
    FROM LOPHOC
    WHERE MaLop = @MaLop
);
GO

--3.2.
--DROP FUNCTION fu_load_MonDK
CREATE FUNCTION fu_load_MonDK (@MaKhoa VARCHAR(5)) --Hàm load các môn học cho học viên đăng ký
RETURNS TABLE 
AS RETURN (
	SELECT MaMon, TenMonHoc, SoTinChi 
	FROM MonHoc 
	WHERE MaKhoa = @MaKhoa
);
GO

--3.8.
--DROP FUNCTION fu_load_DSHocPhi
CREATE FUNCTION fu_load_DSHocPhi (@MaHocVien CHAR(10), @MaKhoa VARCHAR(5)) --Hàm danh sách học phí
RETURNS TABLE 
AS 
RETURN 
(
    SELECT lh.MaLop, mh.TenMonHoc, lh.Tiet, lh.Thu, p.MaPhong Phong, 
           gv.HoTen AS GiangVien, dk.MaHocVien, lh.MaMon, mh.SoTinChi, 
           CASE 
               WHEN @MaKhoa = 'FHQ' THEN mh.SoTinChi * 800000
               ELSE mh.SoTinChi * 600000
           END AS HocPhi
    FROM dbo.MONHOC mh
    JOIN dbo.LOPHOC lh ON lh.MaMon = mh.MaMon
    JOIN dbo.GIANGVIEN gv ON lh.MaGiangVien = gv.MaGiangVien
    JOIN dbo.PHONGHOC p ON  lh.MaPhong = p.MaPhong
    JOIN dbo.DKMH dk ON dk.MaLop = lh.MaLop
    WHERE dk.MaHocVien = @MaHocVien
);
GO

--3.10.
--DROP FUNCTION fu_load_DSTimKiem
CREATE FUNCTION fu_load_DSTimKiem(@string NVARCHAR(50), @MaHocKy CHAR(9)) --Hàm load các lớp học cho học viên đăng ký
RETURNS TABLE 
AS RETURN (
	SELECT * 
	FROM v_DSLopHoc 
	WHERE MaMon LIKE '%' + @string + '%' and MaHocKy = @MaHocKy
);
GO

--3.9.
--DROP FUNCTION fu_TongHocPhi
CREATE FUNCTION [dbo].[fu_TongHocPhi](@MaHocVien NVARCHAR(10), @MaKhoa VARCHAR(5))
RETURNS FLOAT
AS 
BEGIN
    DECLARE @tinchi FLOAT;
	DECLARE @HocPhi FLOAT;

    -- Sử dụng SELECT để gán giá trị cho biến result
    SELECT @tinchi = SUM(SoTinChi) FROM v_DSDaDangKi WHERE MaHocVien = @MaHocVien;

    -- Nếu không có dữ liệu, gán giá trị mặc định cho biến result
    IF (@tinchi IS NULL)
        SET @tinchi = 0;

    -- Trả về giá trị
	IF ( @MaKhoa = 'FHQ')
	BEGIN
		SET @HocPhi = @tinchi * 800000
	END
	ELSE 
		BEGIN
			SET @HocPhi = @tinchi * 600000		
		END
    RETURN @HocPhi;
END;
GO

