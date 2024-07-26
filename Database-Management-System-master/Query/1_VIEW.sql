USE DANG_KY_MON_HOC;
GO

--1. view xem danh sách các lớp học phần sinh viên có thể đăng kí
--3.4.
--5 a
/*
chức năng:+ để sinh viên khi đăng nhập vào thì hệ thống sẽ dùng mã khoa của sinh viên đó để 
(SELECT những gì cần hiển thị
FROM view 1
WHERE mã khoa của sinh viên đó)
+để sinh viên có thể xem các lớp dạy môn học mà mình cần chuyển lớp khi dùng tính năng chuyển môn
(SELECT những gì cần hiển thị
FROM view 1
WHERE mã môn học cần chuyển)
view 1*/
CREATE VIEW v_DSLopHoc AS
SELECT lh.MaLop, mh.TenMonHoc, mh.SoTinChi, lh.Tiet, lh.Thu, p.MaPhong Phong, 
gv.HoTen AS 'Giảng viên', mh.MaKhoa, mh.MaMon, lh.SoHocVienDangKy, lh.MaHocKy
FROM dbo.MONHOC mh
	JOIN dbo.LOPHOC lh ON lh.MaMon = mh.MaMon
	JOIN dbo.GIANGVIEN gv ON lh.MaGiangVien = gv.MaGiangVien
	JOIN dbo.PHONGHOC p ON  lh.MaPhong = p.MaPhong;
GO

--2. view xem danh sách các môn đã đăng kí
--3.3.
--5 b
/*
Chức năng: + xem danh sách các môn học sinh đã đăng kí
(SELECT những gì cần hiển thị
FROM view2
WHERE mã sinh viên đó)
+ Xem thời khóa biểu
(SELECT thu,tiet,phong
FROM view2
WHERE mã sinh viên đó)
+ Xem học phí
(SELECT 
FROM view2
WHERE mã sinh viên đó)
*/
-- view2 danh sach đã đk
CREATE VIEW v_DSDaDangKi AS
SELECT lh.MaLop, mh.TenMonHoc, mh.SoTinChi, lh.Tiet, lh.Thu, p.MaPhong Phong, 
gv.HoTen AS GiangVien, dk.MaHocVien, lh.MaMon
FROM dbo.MONHOC mh
	JOIN dbo.LOPHOC lh ON lh.MaMon = mh.MaMon
	JOIN dbo.GIANGVIEN gv ON lh.MaGiangVien = gv.MaGiangVien
	JOIN dbo.PHONGHOC p ON lh.MaPhong = p.MaPhong
	JOIN dbo.DKMH dk ON dk.MaLop = lh.MaLop;
GO

--3. view xem danh sách dạy lớp nào
--4.2.
--5 c
/*
chức năng + để gv coi mình dyaj lướp nào
(SELECT những gì cần hiển thị
FROM view3
WHERE mã gv )
*/---drop view v_DSLopDay
CREATE VIEW v_DSLopDay AS
SELECT lh.MaGiangVien, mh.TenMonHoc, lh.MaLop, mh.MaMon, lh.Tiet, lh.Thu, lh.MaPhong Phong, lh.MaHocKy
FROM dbo.LOPHOC lh 
	JOIN dbo.MONHOC mh ON mh.MaMon = lh.MaMon;
GO

--4. view xem sinh viên nào đăng kí lớp nào
--4.3.
--5 d
/*
để gv có thể xem lướp mình dạy có những sinh viên nào đăng kí
SELECT * FROM view 4 WHERE MÃ lớp học
*/
--View4 xem danh sách hv
CREATE VIEW v_DSHV AS
SELECT lh.MaLop, hv.MaHocVien, hv.HoTen
FROM dbo.DKMH dk
	JOIN dbo.LOPHOC lh ON dk.MaLop = lh.MaLop
	JOIN dbo.HOCVIEN hv ON dk.MaHocVien = hv.MaHocVien;
GO
