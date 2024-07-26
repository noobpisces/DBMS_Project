using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DANG_KY_MON_HOC.DTO
{
    public class HocVienDTO
    {
        private string hoten;
        private string mahv;
        private string makhoa;

        public HocVienDTO() { }
        public HocVienDTO(string hoten, string mahv, string makhoa)
        {
            this.Hoten = hoten;
            this.Mahv = mahv;
            this.Makhoa = makhoa;
        }

        public string Hoten { get => hoten; set => hoten = value; }
        public string Mahv { get => mahv; set => mahv = value; }
        public string Makhoa { get => makhoa; set => makhoa = value; }


        //public DataTable load_MonDK(DB_Connect db)
        //{
        //    string query = "Select MaMon, TenMonHoc, SoTinChi from MonHoc where MaKhoa = @MaKhoa";
        //    SqlCommand cmd = new SqlCommand(query,db.connection);
        //    cmd.Parameters.AddWithValue("@MaKhoa", this.Makhoa);
        //    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        //    DataTable dt = new DataTable();
        //    adapter.Fill(dt);
        //    return dt;
        //}
        //public DataTable load_MonDaDK(DB_Connect db)
        //{
        //    string query = "Select * from v_DSDaDangKi where MaHocVien = @MaHocVien";
        //    SqlCommand cmd = new SqlCommand(query, db.connection);
        //    cmd.Parameters.AddWithValue("@MaHocVien", this.Mahv);
        //    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        //    DataTable dt = new DataTable();
        //    adapter.Fill(dt);
        //    return dt;
        //}
        //public DataTable load_DSLop(DB_Connect db)
        //{
        //    string query = "Select * from v_DSDaDangKi where MaHocVien = @MaHocVien";
        //    SqlCommand cmd = new SqlCommand(query, db.connection);
        //    cmd.Parameters.AddWithValue("@MaHocVien", this.Mahv);
        //    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        //    DataTable dt = new DataTable();
        //    adapter.Fill(dt);
        //    return dt;
        //}

    }
}
