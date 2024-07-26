using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DANG_KY_MON_HOC.DTO
{
    public class HocVienAdminDTO
    {
        public string MaHocVien { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string QueQuan { get; set; }
        public string MaKhoa { get; set; }

        public HocVienAdminDTO(string MaHocVien, string HoTen, DateTime NgaySinh, string DiaChi,
            string QueQuan, string MaKhoa)
        {
            this.MaHocVien = MaHocVien;
            this.HoTen = HoTen;
            this.NgaySinh = NgaySinh;
            this.DiaChi = DiaChi;
            this.QueQuan = QueQuan;
            this.MaKhoa = MaKhoa;
        }

    }
}
