using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DANG_KY_MON_HOC.DTO
{
    public class LopHocAdminDTO
    {
        public string MaLop { get; set; }
        public string TenLop { get; set; }
        public string MaGiangVien { get; set; }
        public string MaMon { get; set; }
        public string MaHocKy { get; set; }
        public int SoHocVienDangKy { get; set; }
        public string MaPhong { get; set; }
        public string Thu { get; set; }
        public string Tiet { get; set; }

        public LopHocAdminDTO(string MaLop, string TenLop, string MaGiangVien, string MaMon, string MaHocKy
            , int SoHocVienDangKy, string MaPhong, string Thu, string Tiet)
        {
            this.MaLop = MaLop;
            this.TenLop = TenLop;
            this.MaGiangVien = MaGiangVien;
            this.MaMon = MaMon;
            this.MaHocKy = MaHocKy;
            this.SoHocVienDangKy = SoHocVienDangKy;
            this.MaPhong = MaPhong;
            this.Thu = Thu;
            this.Tiet = Tiet;

        }
    }
}
