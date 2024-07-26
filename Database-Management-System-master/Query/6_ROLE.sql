USE DANG_KY_MON_HOC;
GO

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

--INSERT INTO TAIKHOAN(TaiKhoan,MatKhau) VALUES ('admin1', '123');

--DROP ROLE HV;
--DROP ROLE GV;