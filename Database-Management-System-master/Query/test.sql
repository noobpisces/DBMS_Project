USE DANG_KY_MON_HOC;
GO

--đăng nhập bằng học viên để test
--DENY EXECUTE ON DeleteGiangVien TO HV;
--DENY EXECUTE ON DeleteGiangVien TO GV;
EXEC DeleteGiangVien @MaGiangVien = 'GV0011';



--DENY EXECUTE ON InsertGiangVien TO GV;
--DENY EXECUTE ON InsertGiangVien TO HV
DECLARE @MaGiangVien CHAR(6) = 'GV10011';
DECLARE @HoTen NVARCHAR(MAX) = 'Nguyen Van A';
DECLARE @HocVi NVARCHAR(10) = 'Thac si';
DECLARE @HocHam NVARCHAR(12) = 'Giao su';
DECLARE @DiaChi NVARCHAR(MAX) = '123 Main Street, City';
DECLARE @Sdt CHAR(10) = '1234567890';
DECLARE @MaKhoa VARCHAR(5) = 'K001';

EXEC [dbo].[InsertGiangVien]
    @MaGiangVien,
    @HoTen,
    @HocVi,
    @HocHam,
    @DiaChi,
    @Sdt,
    @MaKhoa;


--DENY EXECUTE ON UpdateGiangVien TO HV
--DENY EXECUTE ON UpdateGiangVien TO GV
DECLARE @MaGiangVien CHAR(6) = 'GV1234';
DECLARE @HoTen NVARCHAR(MAX) = 'Nguyen Van B';
DECLARE @HocVi NVARCHAR(10) = 'Tiến sĩ';
DECLARE @HocHam NVARCHAR(12) = 'Phó giáo sư';
DECLARE @DiaChi NVARCHAR(MAX) = '456 Second Street, City';
DECLARE @Sdt CHAR(10) = '9876543210';
DECLARE @MaKhoa VARCHAR(5) = 'K002';

EXEC [dbo].[UpdateGiangVien]
    @MaGiangVien,
    @HoTen,
    @HocVi,
    @HocHam,
    @DiaChi,
    @Sdt,
    @MaKhoa;


--DENY EXECUTE ON DeleteHocVien TO HV
--DENY EXECUTE ON DeleteHocVien TO GV
EXEC DeleteHocVien @MaHocVien = 'HV00000001';

--DENY EXECUTE ON InsertHocVien TO HV
--DENY EXECUTE ON InsertHocVien TO GV
-- Example values for parameters
DECLARE @MaHocVien CHAR(10) = 'HV0001';
DECLARE @HoTen NVARCHAR(40) = 'Nguyen Thi B';
DECLARE @NgaySinh DATE = '1990-01-15';
DECLARE @DiaChi NVARCHAR(MAX) = '456 Third Street, City';
DECLARE @QueQuan NVARCHAR(20) = 'Ha Noi';
DECLARE @MaKhoa VARCHAR(5) = 'K002';

-- Execute the stored procedure
EXEC [dbo].[InsertHocVien]
    @MaHocVien,
    @HoTen,
    @NgaySinh,
    @DiaChi,
    @QueQuan,
    @MaKhoa;


--DENY EXECUTE ON UpdateHocVien TO HV;
--DENY EXECUTE ON UpdateHocVien TO GV;
DECLARE @MaHocVien CHAR(10) = 'HV0001';
DECLARE @HoTen NVARCHAR(MAX) = 'Nguyen Thi C';
DECLARE @NgaySinh DATE = '1992-05-20';
DECLARE @DiaChi NVARCHAR(MAX) = '789 Fourth Street, City';
DECLARE @QueQuan NVARCHAR(20) = 'Da Nang';
DECLARE @MaKhoa VARCHAR(5) = 'K003';

-- Execute the stored procedure
EXEC [dbo].[UpdateHocVien]
    @MaHocVien,
    @HoTen,
    @NgaySinh,
    @DiaChi,
    @QueQuan,
    @MaKhoa;

--DENY EXECUTE ON XoaLopHoc TO HV
--DENY EXECUTE ON XoaLopHoc TO GV
-- Example value for parameter
DECLARE @MaLop CHAR(18) = 'LH001';

-- Execute the stored procedure
EXEC [dbo].[XoaLopHoc] @MaLop;

--DENY EXECUTE ON ThemLopHoc TO HV;
--DENY EXECUTE ON ThemLopHoc TO GV;
-- Example values for parameters
DECLARE @MaLop CHAR(18) = 'LH0001';
DECLARE @TenLop NVARCHAR(MAX) = 'Lop A';
DECLARE @MaGiangVien CHAR(6) = 'GV1234';
DECLARE @MaMon CHAR(10) = 'M001';
DECLARE @MaHocKy CHAR(9) = 'HK2023';
DECLARE @SoHocVienDangKy INT = 30;
DECLARE @MaPhong VARCHAR(10) = 'P001';
DECLARE @Thu NVARCHAR(10) = 'Monday';
DECLARE @Tiet NVARCHAR(10) = 'Tiet 1-2';

EXEC [dbo].[ThemLopHoc]
    @MaLop,
    @TenLop,
    @MaGiangVien,
    @MaMon,
    @MaHocKy,
    @SoHocVienDangKy,
    @MaPhong,
    @Thu,
    @Tiet;

