using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DANG_KY_MON_HOC.DTO
{
    public class GiangVienDTO
    {
        private string hoten;
        private string magiangvien;
        private string makhoa;
        private string sdt;
        private string hocham;
        private string diachi;

        public GiangVienDTO() { }

        public GiangVienDTO(string hoten, string magiangvien, string makhoa, string sdt, string hocham, string diachi)
        {
            this.Hoten = hoten;
            this.Magiangvien = magiangvien;
            this.Makhoa = makhoa;
            this.Sdt = sdt;
            this.hocham = hocham;
            this.Diachi = diachi;

        }

        public string Hoten { get => hoten; set => hoten = value; }
        public string Magiangvien { get => magiangvien; set => magiangvien = value; }
        public string Makhoa { get => makhoa; set => makhoa = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Hocham { get => hocham; set => hocham = value; }
        public string Diachi { get => diachi; set => diachi = value; }
    }
}
