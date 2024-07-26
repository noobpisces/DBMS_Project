using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DANG_KY_MON_HOC.DTO;
using DANG_KY_MON_HOC.GUI.GiangVien;

namespace DANG_KY_MON_HOC.DAO
{
    public class GiangVienDAO
    {
        public GiangVienDAO() { }

        // 4.1.
        public bool GV_DangNhap(DatabaseConnection db, TextBox U, TextBox P)
        {
            string username = U.Text;
            string password = P.Text;
            if (db.OpenConnection())
            {
                SqlCommand command = new SqlCommand("proc_GV_DN", db.connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@TaiKhoan", username);
                command.Parameters.AddWithValue("@MatKhau", password);
                try
                {
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        string HoTen = reader["HoTen"].ToString();
                        string MaKhoa = reader["MaKHoa"].ToString();
                        string SDT = reader["Sdt"].ToString();
                        string HocHam = reader["HocHam"].ToString();
                        string DiaChi = reader["DiaChi"].ToString();
                        reader.Close();
                        GiangVienDTO gv = new GiangVienDTO(HoTen, username, MaKhoa, SDT, HocHam, DiaChi);
                        ChucNangGiangVien f_GV = new ChucNangGiangVien();
                        DatabaseConnection db_G = new DatabaseConnection(username, password);
                        f_GV.Update_Form(gv, "HK1_22-23", db_G);
                        f_GV.ShowDialog();

                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    db.CloseConnection();
                }
                return true;
            }
            else
            {
                MessageBox.Show("Lỗi kết nối đến cơ sở dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // 4.2. 
        public DataTable load_DSLopDay(DatabaseConnection db, GiangVienDTO gv, string MaHocKy)
        {
            db.OpenConnection();
            string query = "SELECT * FROM v_DSLopDay WHERE MaGiangVien = @MaGiangVien AND MaHocKy = @MaHocKy";
            SqlCommand cmd = new SqlCommand(query, db.connection);
            cmd.Parameters.AddWithValue("@MaGiangVien", gv.Magiangvien);
            cmd.Parameters.AddWithValue("@MaHocKy", MaHocKy);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            db.CloseConnection();
            return dt;
        }

        // 4.3. 
        public DataTable load_DSHocVien(DatabaseConnection db, string LopHoc)
        {
            db.OpenConnection();
            string query = "SELECT * FROM v_DSHV WHERE MaLop = @MaLop";
            SqlCommand cmd = new SqlCommand(query, db.connection);
            cmd.Parameters.AddWithValue("@MaLop", LopHoc);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            db.CloseConnection();
            return dt;
        }

        // 4.4. 
        public void GV_GuiDeXuat(DatabaseConnection db, GiangVienDTO gv, string MaMon, int SoHV)
        {
            db.OpenConnection();
            SqlCommand cmd = new SqlCommand("proc_GuiYeuCau", db.connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaGiangVien", gv.Magiangvien);
            cmd.Parameters.AddWithValue("@MaMon", MaMon);
            cmd.Parameters.AddWithValue("@SoHocVienDuocDangKy", SoHV);
            try
            {
                cmd.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                db.CloseConnection();
            }
        }

    }
}
