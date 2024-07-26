# Hệ thống đăng kí môn học - DBMS Project
### (Project thực hành về SQL, hệ quản trị cở sở dữ liệu SQL server, Dùng WinForms ([code ở đây](https://github.com/noobpisces/DBMS_Project/tree/master/DANG_KY_MON_HOC))để cung cấp giao diện người dùng )
### (Tất cả code SQL đều có trong link [DBMS Project - Query Directory](https://github.com/noobpisces/DBMS_Project/tree/master/Database-Management-System-master/Query))
# Mục Lục

1. [Các chức năng có trong project](#1-c%C3%A1c-ch%E1%BB%A9c-n%C4%83ng-c%C3%B3-trong-project)
   - [Chức năng của người quản lý](#11-ch%E1%BB%A9c-n%C4%83ng-c%E1%BB%A7a-ng%C6%B0%E1%BB%9Di-qu%E1%BA%A3n-l%C3%BD)
     	- [Kiểm tra tài khoản mật khẩu của người quản lý](#111-kiểm-tra-tài-khoản-mật-khẩu-của-người-quản-lý)
     	- [Tạo tài khoản](#112-tạo-tài-khoản)
      	- [Đổi mật khẩu](#113-đổi-mật-khẩu)
      - [Quản lý giảng viên](#114-quản-lý-giảng-viên)
         - [Hiển thị danh sách thông tin giảng viên](#a-hiển-thị-danh-sách-thông-tin-giảng-viên)
         - [Tìm kiếm thông tin một giảng viên](#b-tìm-kiếm-thông-tin-một-giảng-viên)
         - [Xoá thông tin một giảng viên](#c-xoá-thông-tin-một-giảng-viên)
         - [Thêm một giảng viên](#d-thêm-một-giảng-viên)
         - [Cập nhật thông tin một giảng viên](#e-cập-nhật-thông-tin-một-giảng-viên)
      - [Quản lý học viên](#115-quản-lý-học-viên)
         - [Hiển thị danh sách thông tin học viên](#a-hiển-thị-danh-sách-thông-tin-học-viên)
         - [Tìm kiếm thông tin một học viên](#b-tìm-kiếm-thông-tin-một-học-viên)
         - [Xoá thông tin một học viên](#c-xoá-thông-tin-một-học-viên)
         - [Thêm một học viên](#d-thêm-một-học-viên)
         - [Cập nhật thông tin một học viên](#e-cập-nhật-thông-tin-một-học-viên)
      - [Quản lý lớp học](#116-quản-lý-lớp-học)
         - [Hiển thị danh sách thông tin lớp học](#a-hiển-thị-danh-sách-thông-tin-lớp-học)
         - [Tìm kiếm thông tin một lớp học](#b-tìm-kiếm-thông-tin-một-lớp-học)
         - [Xoá thông tin một lớp học](#c-xoá-thông-tin-một-lớp-học)
         - [Thêm một lớp học](#d-thêm-một-lớp-học)
         - [Cập nhật thông tin một lớp học](#e-cập-nhật-thông-tin-một-lớp-học)
   - [Chức năng của học viên](#12-chức-năng-của-học-viên)
      - [Đăng nhập vào hệ thống](#121-đăng-nhập-vào-hệ-thống)
      - [Xem các môn có thể đăng kí](#122-xem-các-môn-có-thể-đăng-kí)
      - [Xem các môn đã đăng kí](#123-xem-các-môn-đã-đăng-kí)
      - [Xem danh sách lớp của một môn](#124-xem-danh-sách-lớp-của-một-môn)
      - [Học viên đăng ký lớp học](#125-học-viên-đăng-ký-lớp-học)
      - [Học viên xóa đăng ký lớp học](#126-học-viên-xóa-đăng-ký-lớp-học)
      - [Học viên chuyển lớp](#127-học-viên-chuyển-lớp)
      - [Học viên xem danh sách học phí](#128-học-viên-xem-danh-sách-học-phí)
      - [Học viên xem tổng học phí](#129-học-viên-xem-tổng-học-phí)
      - [Tìm kiếm các lớp đang mở của một môn](#1210-tìm-kiếm-các-lớp-đang-mở-của-một-môn)
   - [Chức năng của giảng viên](#13-chức-năng-của-giảng-viên)
      - [Đăng nhập vào hệ thống](#131-đăng-nhập-vào-hệ-thống)
      - [Xem danh sách lớp dạy](#132-xem-danh-sách-lớp-dạy)
      - [Xem danh sách học viên của lớp đang dạy](#133-xem-danh-sách-học-viên-của-lớp-đang-dạy)
      - [Gửi đề xuất mở lớp](#134-gửi-để-xuất-mở-lớp)
2. [Entity-Relationship Diagram (ERD)](#2-entity-relationship-diagram-erd)
3. [Relational Schemas](#3-relational-schemas)
4. [Các ràng buộc cần có](#4-các-ràng-buộc-cần-có)
5. [Cài đặt các CSDL và các ràng buộc](#5-cài-đặt-các-csdl-và-các-ràng-buộc)
   - [Tạo các bảng](#51-t%E1%BA%A1o-c%C3%A1c-b%E1%BA%A3ng)
   - [Tạo các view](#52-t%E1%BA%A1o-c%C3%A1c-view)
   - [Các trigger](#53-c%C3%A1c-trigger)
     	- [Trigger ngăn chặn học viên đăng kí lớp học trùng lịch, môn, quá 35 tín chỉ hoặc lớp đã đủ số lượng sinh viên (mặc định là 75)](#531-trigger-ngăn-chặn-học-viên-đăng-kí-lớp-học-trùng-lịch-môn-quá-35-tín-chỉ-hoặc-lớp-đã-đủ-số-lượng-sinh-viên-mặc-định-là-75)
     	- [Trigger ngăn trùng lịch học khi học viên chuyển lớp](#532-trigger-ngăn-trùng-lịch-học-khi-học-viên-chuyển-lớp)
    	- [Trigger hỗ trợ người quản lý xem xét mở lớp học mới](#533-trigger-hỗ-trợ-người-quản-lý-xem-xét-mở-lớp-học-mới)
     	- [Trigger hỗ trợ người quản lý xóa lớp không đủ điều kiện (có ít hơn 10 học viên đăng ký)](#534-trigger-hỗ-trợ-người-quản-lý-xóa-lớp-không-đủ-điều-kiện-có-ít-hơn-10-học-viên-đăng-ký)
     	- [Trigger hỗ trợ người quản lý xóa giảng viên](#535-trigger-hỗ-trợ-người-quản-lý-xóa-giảng-viên)
     	- [Trigger kiểm tra yêu cầu mở lớp của giảng viên](#536-trigger-kiểm-tra-yêu-cầu-mở-lớp-của-giảng-viên)
     	- [Trigger hỗ trợ admin tạo tài khoản](#537-trigger-hỗ-trợ-admin-tạo-tài-khoản)
     	- [Trigger hỗ trợ admin đổi mật khẩu](#538-trigger-hỗ-trợ-admin-đổi-mật-khẩu)
   - [Tạo user và phân quyền](#54-t%E1%BA%A0o-user-v%C3%A0-ph%C3%A2n-quy%E1%BB%81n)


## 1. Các chức năng có trong project
### (Đa số code SQL các chức năng này đều trong [DBMS Project - Query Directory/Procedure](https://github.com/noobpisces/DBMS_Project/blob/master/Database-Management-System-master/Query/5_PROCEDURE.sql))
### 1.1. Chức năng của người quản lý
#### 1.1.1. Kiểm tra tài khoản mật khẩu của người quản lý
```sql
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
```
#### 1.1.2. Tạo tài khoản
```sql
CREATE PROCEDURE proc_TaoTK(@TaiKhoan NVARCHAR(20), @MatKhau NVARCHAR(20))
AS
BEGIN
	INSERT INTO TaiKhoan(TaiKhoan, MatKhau) VALUES (@TaiKhoan, @MatKhau)
END;
```
#### 1.1.3. Đổi mật khẩu
```sql
CREATE PROCEDURE proc_DoiMK(@TaiKhoan NVARCHAR(20), @MatKhauCu NVARCHAR(20), @MatKhauMoi NVARCHAR(20))
AS
BEGIN
	UPDATE TAIKHOAN
	SET TaiKhoan = @TaiKhoan, MatKhau = @MatKhauMoi
	WHERE TaiKhoan = @TaiKhoan AND MatKhau = @MatKhauCu
END;
```
#### 1.1.4. Quản lý giảng viên
##### a. Hiển thị danh sách thông tin giảng viên
```sql
CREATE FUNCTION fu_load_GV( ) 
RETURNS TABLE 
AS RETURN (
	SELECT MaGiangVien, HoTen, HocVi, HocHam, Diachi, Sdt, MaKhoa, MatKhau 
	FROM GIANGVIEN LEFT JOIN TAIKHOAN ON TaiKhoan = MaGiangVien
);
```
##### b. Tìm kiếm thông tin một giảng viên
```sql
CREATE FUNCTION [dbo].[func_getGiangVienByMaGiangVien] (@maGiangVien CHAR(6))
RETURNS TABLE
AS
RETURN
(
    SELECT MaGiangVien, HoTen, HocVi, HocHam, Diachi, Sdt, MaKhoa, MatKhau  
	FROM GIANGVIEN LEFT JOIN TAIKHOAN ON TaiKhoan = MaGiangVien
    WHERE MaGiangVien = @maGiangVien
);
```
##### c. Xoá thông tin một giảng viên
```sql
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
```
##### d. Thêm một giảng viên
```sql
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
```
##### e. Cập nhật thông tin một giảng viên
```sql
CREATE PROCEDURE [dbo].[UpdateGiangVien]
	@MaGiangVien CHAR(6),
	@HoTen NVARCHAR(MAX),
	@HocVi NVARCHAR(10),
	@HocHam NVARCHAR(12),
	@DiaChi NVARCHAR(MAX),
	@Sdt CHAR(10),
	@MaKhoa VARCHAR(5),
	@MatKhau VARCHAR(20)
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
				MaKhoa = @MaKhoa,
				MatKhau = @MatKhau
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
```
#### 1.1.5. Quản lý học viên
##### a. Hiển thị danh sách thông tin học viên
```sql
CREATE FUNCTION fu_load_HocVien ( )
RETURNS TABLE 
AS RETURN (
	SELECT MaHocVien, HoTen, NgaySinh, DiaChi, QueQuan, MaKhoa, MatKhau
	FROM HOCVIEN LEFT JOIN TAIKHOAN ON MaHocVien = TaiKhoan
);
```
##### b. Tìm kiếm thông tin một học viên
```sql
CREATE FUNCTION [dbo].[func_getHocVienByMaHocVien] (@maHocVien CHAR(10))
RETURNS TABLE
AS
RETURN
(
    SELECT MaHocVien, HoTen, NgaySinh, DiaChi, QueQuan, MaKhoa, MatKhau
	FROM HOCVIEN LEFT JOIN TAIKHOAN ON MaHocVien = TaiKhoan
    WHERE MaHocVien = @maHocVien
);
```
##### c. Xoá thông tin một học viên
```sql
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
```
##### d. Thêm một học viên
```sql
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
```
##### e. Cập nhật thông tin một học viên
```sql
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
```
#### 1.1.6. Quản lý lớp học
##### a. Hiển thị danh sách thông tin lớp học
```sql
CREATE FUNCTION [dbo].[DanhSachLopHoc] ( )
RETURNS TABLE
AS
RETURN
(
    SELECT MaLop, TenLop, MaGiangVien, MaMon, MaHocKy, SoHocVienDangKy, MaPhong, Thu, Tiet
    FROM LOPHOC
);
```
##### b. Tìm kiếm thông tin một lớp học
```sql
CREATE FUNCTION [dbo].[DanhSachLopHoc] ( )
RETURNS TABLE
AS
RETURN
(
    SELECT MaLop, TenLop, MaGiangVien, MaMon, MaHocKy, SoHocVienDangKy, MaPhong, Thu, Tiet
    FROM LOPHOC
);
```
##### c. Xoá thông tin một lớp học
```sql
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
```
##### d. Thêm một lớp học
```sql
CREATE PROCEDURE [dbo].[ThemLopHoc]
    @MaLop CHAR(18),
    @TenLop NVARCHAR(MAX),
    @MaGiangVien CHAR(6),
    @MaMon CHAR(10),
    @MaHocKy CHAR(9),
    @SoHocVienDangKy INT,
    @MaPhong VARCHAR(10),
    @Thu NVARCHAR(10),
    @Tiet VARCHAR(10)
AS
BEGIN
    INSERT INTO LOPHOC (MaLop, TenLop, MaGiangVien, MaMon, MaHocKy, SoHocVienDangKy, MaPhong, Thu, Tiet)
    VALUES (@MaLop, @TenLop, @MaGiangVien, @MaMon, @MaHocKy, @SoHocVienDangKy, @MaPhong, @Thu, @Tiet);
END;
```
##### e. Cập nhật thông tin một lớp học
```sql
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
```
### 1.2. Chức năng của học viên
#### 1.2.1. Đăng nhập vào hệ thống
```sql
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
```
#### 1.2.2. Xem các môn có thể đăng kí
```sql
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
```
#### 1.2.3. Xem các môn đã đăng kí
```sql
CREATE VIEW v_DSDaDangKi AS
SELECT lh.MaLop, mh.TenMonHoc, mh.SoTinChi, lh.Tiet, lh.Thu, p.MaPhong Phong, gv.HoTen AS GiangVien, dk.MaHocVien, lh.MaMon
FROM dbo.MONHOC mh
	JOIN dbo.LOPHOC lh ON lh.MaMon = mh.MaMon
	JOIN dbo.GIANGVIEN gv ON lh.MaGiangVien = gv.MaGiangVien
	JOIN dbo.PHONGHOC p ON  lh.MaPhong = p.MaPhong
	JOIN dbo.DKMH dk ON dk.MaLop = lh.MaLop;
```
#### 1.2.4. Xem danh sách lớp của một môn
```sql
CREATE VIEW v_DSLopHoc AS
SELECT lh.MaLop, mh.TenMonHoc, mh.SoTinChi, lh.Tiet, lh.Thu, p.MaPhong Phong, lh.MaHocKy, gv.HoTen AS 'Giảng viên', mh.MaKhoa, mh.MaMon, lh.SoHocVienDangKy
FROM dbo.MONHOC mh
	JOIN dbo.LOPHOC lh ON lh.MaMon = mh.MaMon
	JOIN dbo.GIANGVIEN gv ON lh.MaGiangVien = gv.MaGiangVien
	JOIN dbo.PHONGHOC p ON  lh.MaPhong = p.MaPhong;
```
#### 1.2.5. Học viên đăng ký lớp học
```sql
CREATE PROCEDURE proc_DKLopHoc --Học viên đăng ký lớp học
	@MaHV CHAR(10),
	@MaLH CHAR(18)
AS
BEGIN
	BEGIN TRANSACTION 
		BEGIN TRY
			INSERT INTO DKMH (MaHocVien, MaLop)
			VALUES(@MaHV,@MaLH)

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
```
#### 1.2.6. Học viên xóa đăng ký lớp học
```sql
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
```
#### 1.2.7. Học viên chuyển lớp
```sql
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

```
#### 1.2.8. Học viên xem danh sách học phí
```sql
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
```
#### 1.2.9. Học viên xem tổng học phí
```sql
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
```
#### 1.2.10. Tìm kiếm các lớp đang mở của một môn
```sql
CREATE FUNCTION fu_load_DSTimKiem (@string NVARCHAR(50), @MaHocKy CHAR(9)) --Hàm load các lớp học cho học viên đăng ký
RETURNS TABLE 
AS RETURN (
	SELECT * 
	FROM v_DSLopHoc 
	WHERE MaMon LIKE '%' + @string + '%' and MaHocKy = @MaHocKy
);
```
### 1.3. Chức năng của giảng viên
#### 1.3.1. Đăng nhập vào hệ thống
```sql
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
```
#### 1.3.2. Xem danh sách lớp dạy
```sql
CREATE VIEW v_DSLopDay AS
SELECT lh.MaGiangVien, mh.TenMonHoc, lh.MaLop, mh.MaMon, lh.Tiet, lh.Thu, lh.MaPhong Phong,lh.MahocKy
FROM dbo.LOPHOC lh 
	JOIN dbo.MONHOC mh ON mh.MaMon = lh.MaMon;
GO
```
#### 1.3.3. Xem danh sách học viên của lớp đang dạy
```sql
CREATE VIEW v_DSHV AS
SELECT lh.MaLop, hv.MaHocVien, hv.HoTen
FROM dbo.DKMH dk
	JOIN dbo.LOPHOC lh ON dk.MaLop = lh.MaLop
	JOIN dbo.HOCVIEN hv ON dk.MaHocVien = hv.MaHocVien;
```
#### 1.3.4. Gửi để xuất mở lớp
```sql
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
```
## 2. Entity-Relationship Diagram (ERD)
![ERD Diagram](https://github.com/noobpisces/DBMS_Project/blob/master/Database-Management-System-master/ERD_DoAn-v0.4.2.png)
## 3. Relational Schemas

- **HOCKI**(MaHocKy, NgayKhaiGiang, NgayBeGiang)
- **KHOA**(MaKhoa, TenKhoa)
- **GIANGVIEN**(MaGiangVien, HoTen, HocVi, HocHam, DiaChi, Sdt, MaKhoa)
- **MONHOC**(MaMon, TenMonHoc, SoTinChi, MaKhoa)
- **HOCVIEN**(MaHocVien, HoTen, NgaySinh, DiaChi, QueQuan, MaKhoa)
- **PHONGHOC**(MaPhong, LoaiPhong)
- **LOPHOC**(MaLop, TenLop, MaGiangVien, MaMon, MaHocKy, SoHocVienDangKy, MaPhong, Thu, Tiet)
- **DKMH**(MaHocVien, MaLop)
- **YEUCAU**(MaGiangVien, MaMon, SoHocVienDuocDangKy)
- **TAIKHOAN**(TaiKhoan, MatKhau)

## 4. Các ràng buộc cần có

| STT | BẢNG       | RÀNG BUỘC                                                                                       |
|-----|------------|-------------------------------------------------------------------------------------------------|
| 1   | HOCKY      | Khoá chính MaHocKy, NOT NULL NgayKhaiGiang, NOT NULL NgayBeGiang                                |
| 2   | KHOA       | Khoá chính MaKhoa, NOT NULL TenKhoa                                                             |
| 3   | GIANGVIEN  | Khoá chính MaGiangVien, NOT NULL HoTen, NOT NULL HocVi, NOT NULL Sdt, Khoá ngoại MaKhoa đến bảng KHOA, CHECK Sdt (= 10) |
| 4   | MONHOC     | Khoá chính MaMon, NOT NULL TenMonHoc, NOT NULL SoTinChi, Khoá ngoại MaKhoa đến bảng KHOA        |
| 5   | HOCVIEN    | Khoá chính MaHocVien, NOT NULL HoTen, NOT NULL NgaySinh, NOT NULL DiaChi, NOT NULL QueQuan, Khoá ngoại MaKhoa đến bảng KHOA |
| 6   | PHONGHOC   | Khoá chính MaPhong, NOT NULL LoaiPhong                                                          |
| 7   | LOPHOC     | Khoá chính MaLop, NOT NULL TenLop, NOT NULL SoHocVienDangKy, NOT NULL Thu, NOT NULL Tiet, Khoá ngoại MaGiangVien đến bảng GIANGVIEN, Khoá ngoại MaMon đến bảng MONHOC, Khoá ngoại MaHocKy đến bảng HOCKY, Khoá ngoại MaPhong đến bảng PHONGHOC, CHECK SoHocVienDangKy (<= 75) |
| 8   | DKMH       | Khoá chính (MaHocVien, MaLop), Khoá ngoại MaHocVien đến bảng HOCVIEN, Khoá ngoại MaLop đến bảng LOPHOC |
| 9   | YEUCAU     | Khoá chính (MaMon, MaGiangVien), NOT NULL SoHocVienDuocDangKy, Khoá ngoại MaGiangVien đến bảng GIANGVIEN, Khoá ngoại MaMon đến bảng MONHOC |
| 10  | TAIKHOAN   | Khoá chính TaiKhoan                                                                             |

## 5. Cài đặt các CSDL và các ràng buộc
### 5.1. Tạo các bảng
```sql
CREATE TABLE HOCKY (
    MaHocKy CHAR(9) NOT NULL, --HK1_22-23, HK2_22-23,..
    NgayKhaiGiang DATE NOT NULL,
    NgayBeGiang DATE NOT NULL,
    CONSTRAINT PK_HOCKY PRIMARY KEY (MaHocKy)
);
CREATE TABLE KHOA (
    MaKhoa VARCHAR(5) NOT NULL, --FIT, FCFT, FCEAM, ITE,...
    TenKhoa NVARCHAR(MAX) NOT NULL,
    CONSTRAINT PK_KHOA PRIMARY KEY (MaKhoa)
);
CREATE TABLE GIANGVIEN (
    MaGiangVien CHAR(6) NOT NULL, --GV0001, GV0002,...
    HoTen NVARCHAR(MAX) NOT NULL,
    HocVi NVARCHAR(10) NOT NULL, --Thạc sĩ, Tiến sĩ, Cử nhân,...
    HocHam NVARCHAR(12), --Phó Giáo sư, Giáo sư
    DiaChi NVARCHAR(MAX),
    Sdt CHAR(10) CHECK(len(Sdt) = 10) NOT NULL,
    MaKhoa VARCHAR(5) NOT NULL,
    CONSTRAINT PK_GIANGVIEN PRIMARY KEY (MaGiangVien),
    CONSTRAINT FK_GIANGVIEN_KHOA FOREIGN KEY (MaKhoa) REFERENCES KHOA(MaKhoa)
);
CREATE TABLE MONHOC (
    MaMon CHAR(10) NOT NULL, --WEPR330479, DBMS330284,...
    TenMonHoc NVARCHAR(30) NOT NULL,
    SoTinChi INT NOT NULL, --(từ 1 đến 4)
    MaKhoa VARCHAR(5) NOT NULL, --FIT, FCFT, FCEAM, ITE,...
    CONSTRAINT PK_MONHOC PRIMARY KEY (MaMon),
    CONSTRAINT FK_MONHOC_KHOA FOREIGN KEY (MaKhoa) REFERENCES KHOA(MaKhoa)
);
CREATE TABLE HOCVIEN (
    MaHocVien CHAR(10)  NOT NULL, --HV00000001, HV00000011,...
    HoTen NVARCHAR(40) NOT NULL, --Lê Hoàng Hiếu Nghĩa Đệ Nhất Thương Tâm Nhân (tên dài nhất VN),...
    NgaySinh DATE NOT NULL,
    DiaChi NVARCHAR(MAX) NOT NULL,
    QueQuan NVARCHAR(20) NOT NULL, --Bà Rịa - Vũng Tàu, Thừa Thiên - Huế,...
    MaKhoa VARCHAR(5) NOT NULL, --FIT, FCFT, FCEAM, ITE,...
    CONSTRAINT PK_HOCVIEN PRIMARY KEY (MaHocVien),
    CONSTRAINT FK_HOCVIEN_KHOA FOREIGN KEY (MaKhoa) REFERENCES KHOA(MaKhoa)
);
CREATE TABLE PHONGHOC (
    MaPhong VARCHAR(10) NOT NULL, --A5-203, A121, B108
    LoaiPhong NVARCHAR(40) NOT NULL, --Phòng lý thuyết, Phòng máy tính, Phòng thực hành, Phòng thí nghiệm,...
    CONSTRAINT PK_PHONGHOC PRIMARY KEY (MaPhong)
);
CREATE TABLE LOPHOC (
    MaLop CHAR(18) NOT NULL, --DBMS330284_23_1_05, WEPR330479_23_1_11
    TenLop NVARCHAR(MAX) NOT NULL,
    MaGiangVien CHAR(6) NOT NULL, --GV0001, GV0002,...
    MaMon CHAR(10) NOT NULL, --WEPR330479, DBMS330284,...
    MaHocKy CHAR(9) NOT NULL, --HK1_22-23, HK2_22-23,..
    SoHocVienDangKy INT NOT NULL CHECK (SoHocVienDangKy <= 75),
    MaPhong VARCHAR(10) NOT NULL, --A5-203, A121, B108
    Thu NVARCHAR(10) NOT NULL,
    Tiet VARCHAR(10) NOT NULL,
    CONSTRAINT PK_LOPHOC PRIMARY KEY (MaLop),
    CONSTRAINT FK_LOPHOC_GIANGVIEN FOREIGN KEY (MaGiangVien) REFERENCES GIANGVIEN(MaGiangVien),
    CONSTRAINT FK_LOPHOC_MONHOC FOREIGN KEY (MaMon) REFERENCES MONHOC(MaMon),
    CONSTRAINT FK_LOPHOC_HOCKY FOREIGN KEY (MaHocKy) REFERENCES HOCKY(MaHocKy),
    CONSTRAINT FK_LOPHOC_PHONGHOC FOREIGN KEY (MaPhong) REFERENCES PHONGHOC(MaPhong)
);
CREATE TABLE DKMH (
    MaHocVien CHAR(10) NOT NULL,
    MaLop CHAR(18) NOT NULL,
    CONSTRAINT PK_DKMH PRIMARY KEY (MaHocVien, MaLop),
    CONSTRAINT FK_DKMH_LOPHOC FOREIGN KEY (MaLop) REFERENCES LOPHOC(MaLop),
    CONSTRAINT FK_DKMH_HOCVIEN FOREIGN KEY (MaHocVien) REFERENCES HOCVIEN(MaHocVien)
);
CREATE TABLE YEUCAU (
    MaGiangVien CHAR(6) NOT NULL,
    MaMon CHAR(10) NOT NULL,
    SoHocVienDuocDangKy INT NOT NULL,
    CONSTRAINT PK_YEUCAU PRIMARY KEY (MaGiangVien, MaMon),
    CONSTRAINT FK_YEUCAU_GIANGVIEN FOREIGN KEY (MaGiangVien) REFERENCES GIANGVIEN(MaGiangVien),
    CONSTRAINT FK_YEUCAU_MONHOC FOREIGN KEY (MaMon) REFERENCES MONHOC(MaMon)
);
CREATE TABLE TAIKHOAN (
    TaiKhoan NVARCHAR(10) NOT NULL,
    MatKhau NVARCHAR(20) NOT NULL,
    CONSTRAINT PK_TAIKHOAN PRIMARY KEY (TaiKhoan)
);

```
### 5.2. Tạo các view
#### 5.2.1. Xem danh sách các lớp học phần sinh viên có thể đăng kí
```sql
CREATE VIEW v_DSLopHoc AS
SELECT lh.MaLop, mh.TenMonHoc, mh.SoTinChi, lh.Tiet, lh.Thu, p.MaPhong AS Phong, gv.HoTen AS 'Giảng viên', mh.MaKhoa, mh.MaMon, lh.SoHocVienDangKy, lh.MaHocKy
FROM dbo.MONHOC mh
JOIN dbo.LOPHOC lh ON lh.MaMon = mh.MaMon
JOIN dbo.GIANGVIEN gv ON lh.MaGiangVien = gv.MaGiangVien
JOIN dbo.PHONGHOC p ON lh.MaPhong = p.MaPhong;
```
#### 5.2.2. Xem danh sách các môn đã đăng kí
```sql
CREATE VIEW v_DSDaDangKi AS
SELECT lh.MaLop, mh.TenMonHoc, mh.SoTinChi, lh.Tiet, lh.Thu, p.MaPhong AS Phong, gv.HoTen AS GiangVien, dk.MaHocVien, lh.MaMon
FROM dbo.MONHOC mh
JOIN dbo.LOPHOC lh ON lh.MaMon = mh.MaMon
JOIN dbo.GIANGVIEN gv ON lh.MaGiangVien = gv.MaGiangVien
JOIN dbo.PHONGHOC p ON lh.MaPhong = p.MaPhong
JOIN dbo.DKMH dk ON dk.MaLop = lh.MaLop;
```
#### 5.2.3. Xem danh sách giảng viên nào dạy lớp nào
```sql
CREATE VIEW v_DSLopDay AS
SELECT lh.MaGiangVien, mh.TenMonHoc, lh.MaLop, mh.MaMon, lh.Tiet, lh.Thu, lh.MaPhong AS Phong, lh.MaHocKy
FROM dbo.LOPHOC lh 
JOIN dbo.MONHOC mh ON mh.MaMon = lh.MaMon;

```
#### 5.2.4. Xem sinh viên nào đăng kí lớp nào
```sql
CREATE VIEW v_DSHV AS
SELECT lh.MaLop, hv.MaHocVien, hv.HoTen
FROM dbo.DKMH dk
JOIN dbo.LOPHOC lh ON dk.MaLop = lh.MaLop
JOIN dbo.HOCVIEN hv ON dk.MaHocVien = hv.MaHocVien;

```
### 5.3. Các trigger 
#### 5.3.1. Trigger ngăn chặn học viên đăng kí lớp học trùng lịch, môn, quá 35 tín chỉ hoặc lớp đã đủ số lượng sinh viên (mặc định là 75)
```sql
CREATE TRIGGER Trigger_TrungLichDangKyLop --Trigger ngăn chặn học viên đăng kí lớp học trùng lịch, môn, hoặc quá 35 tín chỉ
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
	ELSE IF ( --kiểm tra xem lớp đó đủ số lượng đăng kí chưa
		SELECT SoHocVienDangKy
		FROM LOPHOC
		WHERE MaLop = @I_MaLop ) = 75
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

```
#### 5.3.2. Trigger ngăn trùng lịch học khi học viên chuyển lớp
```sql
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
```

#### 5.3.3. Trigger hỗ trợ người quản lý xem xét mở lớp học mới
```sql
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

```
#### 5.3.4. Trigger hỗ trợ người quản lý xóa lớp không đủ điều kiện (có ít hơn 10 học viên đăng ký)
```sql
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

```
#### 5.3.5. Trigger hỗ trợ người quản lý xóa giảng viên
```sql
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
```
#### 5.3.6. Trigger kiểm tra yêu cầu mở lớp của giảng viên
```sql
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
```
#### 5.3.7. Trigger hỗ trợ admin tạo tài khoản
```sql
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

```
#### 5.3.8. Trigger hỗ trợ admin đổi mật khẩu
```sql
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

```
### 5.4. TẠO USER VÀ PHÂN QUYỀN
Ứng với ba nhóm người dùng (người quản lý, giảng viên, học viên) là role riêng
#### 5.4.1. Đối với role người quản lý (admin) ta sử dụng server role sysadmin:
-	Trigger tạo tài khoản
```sql
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

```
-	Procedure xoá giảng viên
```sql
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

```
-	Procedure xoá học viên:
```sql
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

```
#### 5.4.2. Đối với role giảng viên
```sql
CREATE ROLE GV

GRANT SELECT ON GIANGVIEN TO GV
GRANT SELECT ON HOCKY TO GV
GRANT SELECT ON HOCVIEN TO GV
GRANT SELECT ON KHOA TO GV
GRANT SELECT ON LOPHOC TO GV
GRANT SELECT ON LOPHOC TO GV
GRANT SELECT ON DKMH TO GV
GRANT SELECT ON PHONGHOC TO GV
GRANT SELECT, INSERT ON YEUCAU TO GV

GRANT EXECUTE TO GV
GRANT SELECT TO GV;

DENY EXECUTE ON DeleteGiangVien TO GV;
DENY EXECUTE ON InsertGiangVien TO GV;
DENY EXECUTE ON UpdateGiangVien TO GV;
DENY EXECUTE ON DeleteHocVien TO GV;
DENY EXECUTE ON InsertHocVien TO GV;
DENY EXECUTE ON UpdateHocVien TO GV;
DENY EXECUTE ON XoaLopHoc TO GV;
DENY EXECUTE ON ThemLopHoc TO GV;
DENY EXECUTE ON UpdateLopHoc TO GV;
DENY EXECUTE ON proc_HV_DN TO GV;
DENY EXECUTE ON proc_GV_DN TO GV;
DENY EXECUTE ON proc_TaoTK TO GV;
DENY EXECUTE ON proc_DKLopHoc TO GV;
DENY EXECUTE ON proc_Xoa_DKLopHoc TO GV;
DENY EXECUTE ON proc_ChuyenLopHoc TO GV;
DENY EXECUTE ON proc_TaoTK TO GV;
```
#### 5.4.3. Đối với role học viên
```sql
CREATE ROLE HV
GRANT SELECT, INSERT, DELETE, UPDATE, REFERENCES ON DKMH TO HV
GRANT SELECT ON HOCKY TO HV
GRANT SELECT ON HOCVIEN TO HV
GRANT SELECT ON MONHOC TO HV
GRANT SELECT ON LOPHOC TO HV
GRANT SELECT ON KHOA TO HV
GRANT SELECT ON LOPHOC TO HV

GRANT EXECUTE TO HV
GRANT SELECT TO HV;

DENY EXECUTE ON DeleteGiangVien TO HV;
DENY EXECUTE ON InsertGiangVien TO HV;
DENY EXECUTE ON UpdateGiangVien TO HV;
DENY EXECUTE ON DeleteHocVien TO HV;
DENY EXECUTE ON InsertHocVien TO HV;
DENY EXECUTE ON UpdateHocVien TO HV;
DENY EXECUTE ON XoaLopHoc TO HV
DENY EXECUTE ON ThemLopHoc TO HV;
DENY EXECUTE ON UpdateLopHoc TO HV;
DENY EXECUTE ON proc_HV_DN TO HV;
DENY EXECUTE ON proc_GV_DN TO HV;
DENY EXECUTE ON proc_GuiYeuCau TO HV;
DENY EXECUTE ON proc_TaoTK TO HV;
```





