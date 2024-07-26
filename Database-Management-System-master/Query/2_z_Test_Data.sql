USE DANG_KY_MON_HOC;
GO

INSERT INTO HOCKY (MaHocKy, NgayKhaiGiang, NgayBeGiang)
VALUES ('HK1_22-23', '2022-08-20', '2022-12-30'),
	   ('HK2_22-23', '2023-01-20', '2023-05-30'),
       ('HK3_22-23', '2023-06-20', '2023-07-30'),
	   ('HK1_23-24', '2023-08-20', '2024-01-10'),
	   ('HK2_23-24', '2024-01-20', '2024-05-30'), 
	   ('HK3_23-24', '2024-06-20', '2024-07-30');
GO

INSERT INTO KHOA (MaKhoa, TenKhoa)
VALUES ('FPI', N'Khoa Chính trị và Luật'),
	   ('FME', N'Khoa Cơ khí Chế tạo máy'),
	   ('FAE', N'Khoa Cơ khí động lực'),
	   ('FCFT', N'Khoa Công nghệ hoá học và thực phẩm'),
	   ('FIT', N'Khoa Công nghệ thông tin'),
	   ('FIE', N'Khoa Đào tạo Quốc tế'),
	   ('FEEE', N'Khoa Điện - Điện tử'),
	   ('FGAM', N'Khoa In và Truyền thông'),
	   ('FAS', N'Khoa Khoa học ứng dụng'),
	   ('FE', N'Khoa Kinh tế'),
	   ('FFL', N'Khoa Ngoại ngữ'),
	   ('FGTFD', N'Khoa Thời trang và Du lịch'),
	   ('FCEAM', N'Khoa Xây dựng'),
	   ('FHQ',N'Khoa Đào tạo Chất lượng cao'),
	   ('ITE', N'Viện Sư phạm');
GO

INSERT INTO GIANGVIEN (MaGiangVien, HoTen, HocVi, HocHam, DiaChi, Sdt, MaKhoa)
VALUES ('GV0001', N'Nguyễn Văn A', N'Tiến sĩ', N'Giáo sư', N'123 Trần Hưng Đạo, Quận 1', '0987654321', 'FIT'),
	   ('GV0002', N'Trần Thị B', N'Thạc sĩ', NULL, N'456 Lê Lợi, Quận 3', '0123456789', 'FIT'),
	   ('GV0003', N'Lê Văn C', N'Cử nhân', NULL, N'789 Nguyễn Trãi, Quận 5', '0912345678', 'FIT'),
	   ('GV0004', N'Phạm Thị D', N'Tiến sĩ', NULL, N'321 Lý Thường Kiệt, Quận 10', '0901234567', 'FPI'),
	   ('GV0005', N'Đỗ Văn E', N'Thạc sĩ', NULL, N'654 Nguyễn Thị Minh Khai, Quận 1', '0998765432', 'FFL'),
	   ('GV0006', N'Nguyễn Thị F', N'Tiến sĩ', NULL, N'147 Phan Đình Phùng, Quận 3', '0965432109', 'FE'),
	   ('GV0007', N'Trần Văn G', N'Thạc sĩ', NULL, N'258 Nguyễn Văn Cừ, Quận 5', '0943210987', 'FE'),
	   ('GV0008', N'Lê Thị H', N'Cử nhân', NULL, N'369 Điện Biên Phủ, Quận 10', '0921098765', 'FAS'),
	   ('GV0009', N'Phạm Văn I', N'Tiến sĩ', N'Phó Giáo sư', N'480 Cách Mạng Tháng Tám, Quận 3','0921098765','FGTFD'),
	   ('GV0010', N'Đỗ Thị J', N'Thạc sĩ', N'Phó Giáo sư', N'591 Lê Đại Hành, Quận 11','0954321098','FCEAM');
GO

INSERT INTO MONHOC (MaMon, TenMonHoc, SoTinChi, MaKhoa) 
VALUES ('WEPR330479', N'Lập trình web', 3, 'FIT'), 
	   ('DBMS330284', N'Cơ sở dữ liệu', 4, 'FIT'), 
	   ('MATH330123', N'Toán rời rạc', 3, 'FIT'), 
	   ('CHEM330567', N'Hóa học vô cơ', 4, 'FCFT'), 
	   ('PHYS330678', N'Vật lý đại cương', 3, 'FCFT'), 
	   ('BIO330789', N'Sinh học phân tử', 4, 'FCFT'), 
	   ('ECON330901', N'Kinh tế vi mô', 3, 'FCEAM'), 
	   ('ACCT330012', N'Kế toán quản trị', 4, 'FCEAM'), 
	   ('FINA330345', N'Tài chính doanh nghiệp', 3, 'FCEAM'), 
	   ('ENGL330456', N'Tiếng Anh giao tiếp', 2, 'ITE'), 
	   ('JAPN330567', N'Tiếng Nhật cơ bản', 2, 'ITE'), 
	   ('CHIN330678', N'Tiếng Trung giao tiếp', 2, 'ITE'), 
	   ('STAT330789', N'Thống kê và xác suất', 3, 'ITE'), 
	   ('COMP330901', N'Tin học đại cương', 3, 'ITE'), 
	   ('SOFT330012', N'Kỹ thuật phần mềm', 4, 'ITE');
GO

INSERT INTO HOCVIEN (MaHocVien, HoTen, NgaySinh, DiaChi, QueQuan, MaKhoa)
VALUES
    ('HV00000001', N'Lê Hoàng Hiếu Nghĩa', '1990-01-01', N'123 Đường ABC, Quận XYZ, TP.HCM', N'Bà Rịa - Vũng Tàu', 'FIT'),
    ('HV00000002', N'Nguyễn Thị Mai', '1995-02-15', N'456 Đường XYZ, Quận ABC, Hà Nội', N'Hà Nội', 'FCFT'),
    ('HV00000003', N'Trần Văn An', '1992-03-20', N'789 Đường DEF, Quận PQR, Đà Nẵng', N'Đà Nẵng', 'FIT'),
    ('HV00000004', N'Phạm Thị Thu', '1993-04-10', N'101 Đường GHI, Quận JKL, Hồ Chí Minh', N'Hồ Chí Minh', 'FCFT'),
    ('HV00000005', N'Huỳnh Văn Long', '1998-05-05', N'202 Đường MNO, Quận STU, Hà Nội', N'Hà Nội', 'FCEAM'),
    ('HV00000006', N'Võ Thị Lan', '1997-06-30', N'303 Đường UVW, Quận XYZ, Đà Lạt', N'Đà Lạt', 'FIT'),
    ('HV00000007', N'Lê Thanh Tùng', '1994-07-22', N'404 Đường DEF, Quận PQR, Hồ Chí Minh', N'Hồ Chí Minh', 'FCFT'),
    ('HV00000008', N'Nguyễn Đức Hải', '1991-08-12', N'505 Đường GHI, Quận JKL, Hà Nội', N'Hà Nội', 'FCEAM'),
    ('HV00000009', N'Phạm Thị Lan', '1996-09-03', N'606 Đường ABC, Quận STU, Hà Nội', N'Hà Nội', 'FIT'),
    ('HV00000010', N'Trần Văn Tâm', '1999-10-18', N'707 Đường XYZ, Quận PQR, Đà Nẵng', N'Đà Nẵng', 'FCFT'),
	('HV00000011', N'Nguyễn Văn A', '1998-11-11', N'1111 Đường DEF, Quận XYZ, TP.HCM', N'TP.HCM', 'FIT'),
    ('HV00000012', N'Lê Thị B', '1997-10-12', N'1212 Đường XYZ, Quận ABC, Hà Nội', N'Hà Nội', 'FCFT'),
    ('HV00000013', N'Trần Văn C', '1996-09-13', N'1313 Đường DEF, Quận PQR, Đà Nẵng', N'Đà Nẵng', 'FIT'),
    ('HV00000014', N'Phạm Thị D', '1995-08-14', N'1414 Đường GHI, Quận JKL, Hồ Chí Minh', N'Hồ Chí Minh', 'FCFT'),
    ('HV00000015', N'Huỳnh Văn E', '1994-07-15', N'1515 Đường MNO, Quận STU, Hà Nội', N'Hà Nội', 'FCEAM'),
    ('HV00000016', N'Võ Thị F', '1993-06-16', N'1616 Đường UVW, Quận XYZ, Đà Lạt', N'Đà Lạt', 'FIT'),
    ('HV00000017', N'Lê Thị G', '1992-05-17', N'1717 Đường DEF, Quận PQR, Hồ Chí Minh', N'Hồ Chí Minh', 'FCFT'),
    ('HV00000018', N'Nguyễn Văn H', '1991-04-18', N'1818 Đường GHI, Quận JKL, Hà Nội', N'Hà Nội', 'FCEAM'),
    ('HV00000019', N'Phạm Đình I', '1990-03-19', N'1919 Đường ABC, Quận STU, Hà Nội', N'Hà Nội', 'FIT'),
    ('HV00000020', N'Trần Văn J', '1989-02-20', N'2020 Đường XYZ, Quận PQR, Đà Nẵng', N'Đà Nẵng', 'FCFT');
GO

INSERT INTO PHONGHOC (MaPhong, LoaiPhong) 
VALUES ('A5-203', N'Phòng lý thuyết'), 
	   ('A121', N'Phòng máy tính'), 
	   ('B108', N'Phòng thực hành'), 
	   ('C201', N'Phòng thí nghiệm'), 
	   ('D301', N'Phòng hội thảo'), 
	   ('E401', N'Phòng đa năng'), 
	   ('F501', N'Phòng âm nhạc'), 
	   ('G601', N'Phòng mỹ thuật'), 
	   ('H701', N'Phòng thể dục'), 
	   ('I801', N'Phòng ngoại ngữ');
GO

INSERT INTO LOPHOC (MaLop, TenLop, MaGiangVien, MaMon, MaHocKy, SoHocVienDangKy, MaPhong, Thu, Tiet)
VALUES
    ('DBMS330284_23_1_25', N'Lớp Cơ sở dữ liệu HK1 22-23', 'GV0005', 'DBMS330284', 'HK1_22-23', 30, 'B108', N'Thứ 2', N'Tiết 10-11'),
    ('WEPR330479_23_1_22', N'Lớp Lập trình web HK1 22-23', 'GV0005', 'WEPR330479', 'HK1_22-23', 40, 'A121', N'Thứ 6', N'Tiết 8-9'),
    ('WEPR330479_23_1_54', N'Lớp Lập trình web HK1 22-23', 'GV0007', 'WEPR330479', 'HK1_22-23', 35, 'B108', N'Thứ 2', N'Tiết 1-3'),
    ('DBMS330284_23_1_23', N'Lớp Cơ sở dữ liệu HK1 22-23', 'GV0006', 'DBMS330284', 'HK1_22-23', 30, 'A5-203', N'Thứ 2', N'Tiết 4-6'),
    ('MATH330123_23_1_52', N'Lớp Toán rời rạc HK2 22-23', 'GV0004', 'MATH330123', 'HK1_22-23', 25, 'A121', N'Thứ 6', N'Tiết 1-3'),
    ('CHEM330567_23_1_23', N'Lớp Hóa học vô cơ HK2 22-23', 'GV0001', 'CHEM330567', 'HK1_22-23', 20, 'B108', N'Thứ 7', N'Tiết 4-6'),
    ('PHYS330678_23_1_91', N'Lớp Vật lý đại cương HK2 22-23', 'GV0004', 'PHYS330678', 'HK1_22-23', 25, 'A5-203', N'Thứ 5', N'Tiết 1-3'),
    ('BIO330789_23_1_99', N'Lớp Sinh học phân tử HK2 22-23', 'GV0005', 'BIO330789', 'HK1_22-23', 30, 'A121', N'Thứ 4', N'Tiết 4-6'),
    ('ECON330901_23_1_34', N'Lớp Kinh tế vi mô HK3 22-23', 'GV0006', 'ECON330901', 'HK1_22-23', 35, 'A121', N'Thứ 5', N'Tiết 1-3'),
    ('ACCT330012_23_1_64', N'Lớp Kế toán quản trị HK3 22-23', 'GV0006', 'ACCT330012', 'HK1_22-23', 40, 'A5-203', N'Thứ 7', N'Tiết 1-2'),
	('DBMS330284_23_1_05', N'Lớp Cơ sở dữ liệu HK1 22-23', 'GV0001', 'DBMS330284', 'HK1_22-23', 30, 'A5-203', N'Thứ 2', N'Tiết 1-3'),
    ('WEPR330479_23_1_11', N'Lớp Lập trình web HK1 22-23', 'GV0002', 'WEPR330479', 'HK1_22-23', 40, 'A121', N'Thứ 3', N'Tiết 4-6'),
    ('WEPR330479_23_1_12', N'Lớp Lập trình web HK1 22-23', 'GV0003', 'WEPR330479', 'HK1_22-23', 35, 'B108', N'Thứ 4', N'Tiết 1-3'),
    ('DBMS330284_23_1_13', N'Lớp Cơ sở dữ liệu HK1 22-23', 'GV0004', 'DBMS330284', 'HK1_22-23', 30, 'A5-203', N'Thứ 5', N'Tiết 4-6'),
    ('MATH330123_23_2_05', N'Lớp Toán rời rạc HK2 22-23', 'GV0005', 'MATH330123', 'HK2_22-23', 25, 'A121', N'Thứ 2', N'Tiết 1-3'),
    ('CHEM330567_23_2_11', N'Lớp Hóa học vô cơ HK2 22-23', 'GV0006', 'CHEM330567', 'HK2_22-23', 20, 'B108', N'Thứ 3', N'Tiết 4-6'),
    ('PHYS330678_23_2_12', N'Lớp Vật lý đại cương HK2 22-23', 'GV0007', 'PHYS330678', 'HK2_22-23', 25, 'A5-203', N'Thứ 4', N'Tiết 1-3'),
    ('BIO330789_23_2_13', N'Lớp Sinh học phân tử HK2 22-23', 'GV0008', 'BIO330789', 'HK2_22-23', 30, 'A121', N'Thứ 5', N'Tiết 4-6'),
    ('ECON330901_23_3_05', N'Lớp Kinh tế vi mô HK3 22-23', 'GV0009', 'ECON330901', 'HK3_22-23', 35, 'B108', N'Thứ 2', N'Tiết 1-3'),
    ('ACCT330012_23_3_11', N'Lớp Kế toán quản trị HK3 22-23', 'GV0010', 'ACCT330012', 'HK3_22-23', 40, 'A5-203', N'Thứ 3', N'Tiết 4-6');
GO

INSERT INTO DKMH (MaHocVien, MaLop)
VALUES
    ('HV00000001', 'DBMS330284_23_1_05'),
    ('HV00000002', 'WEPR330479_23_1_11'),
    ('HV00000003', 'WEPR330479_23_1_12'),
    ('HV00000004', 'DBMS330284_23_1_13'),
    ('HV00000005', 'MATH330123_23_2_05'),
    ('HV00000006', 'CHEM330567_23_2_11'),
    ('HV00000007', 'PHYS330678_23_2_12'),
    ('HV00000008', 'BIO330789_23_2_13'),
    ('HV00000009', 'ECON330901_23_3_05'),
    ('HV00000010', 'ACCT330012_23_3_11'),
    ('HV00000011', 'DBMS330284_23_1_05'),
    ('HV00000012', 'WEPR330479_23_1_11'),
    ('HV00000013', 'WEPR330479_23_1_12'),
    ('HV00000014', 'DBMS330284_23_1_13'),
    ('HV00000015', 'MATH330123_23_2_05'),
    ('HV00000016', 'CHEM330567_23_2_11'),
    ('HV00000017', 'PHYS330678_23_2_12'),
    ('HV00000018', 'BIO330789_23_2_13'),
    ('HV00000019', 'ECON330901_23_3_05'),
    ('HV00000020', 'ACCT330012_23_3_11');
GO

INSERT INTO YEUCAU (MaGiangVien, MaMon, SoHocVienDuocDangKy)
VALUES
    ( 'GV0001', 'WEPR330479', 20),
    ( 'GV0002', 'DBMS330284', 15),
    ( 'GV0003', 'MATH330123', 25),
    ('GV0004', 'CHEM330567', 10),
    ( 'GV0005', 'PHYS330678', 30),
    ( 'GV0006', 'BIO330789', 25),
    ( 'GV0007', 'ECON330901', 20),
    ( 'GV0008', 'ACCT330012', 35),
    ( 'GV0009', 'FINA330345', 30),
    ( 'GV0010', 'ENGL330456', 40);
GO

INSERT INTO TAIKHOAN (TaiKhoan, MatKhau) VALUES ('admin1', '123');
GO