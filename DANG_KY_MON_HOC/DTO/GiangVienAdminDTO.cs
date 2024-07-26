using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DANG_KY_MON_HOC.DTO
{
    public class GiangVienAdminDTO
    {
        public string MaGiangVien { get; set; }
        public string HoTen { get; set; }
        public string HocVi { get; set; }
        public string HocHam { get; set; }
        public string DiaChi { get; set; }
        public string Sdt { get; set; }
        public string MaKhoa { get; set; }

        public GiangVienAdminDTO(string MaGiangVien, string HoTen, string HocVi, string HocHam, string DiaChi
            , string Sdt, string MaKhoa)
        {
            this.MaGiangVien = MaGiangVien;
            this.HoTen = HoTen;
            this.HocVi = HocVi;
            this.HocHam = HocHam;
            this.DiaChi = DiaChi;
            this.Sdt = Sdt;
            this.MaKhoa = MaKhoa;
        }

    }
}
