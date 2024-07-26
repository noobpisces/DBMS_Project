using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DANG_KY_MON_HOC.DTO;

namespace DANG_KY_MON_HOC.DAO
{
    public class LopHocAdminDAO
    {
        // 2.6.1. 
        public DataTable load_lopHoc(DatabaseConnection db)
        {
            db.OpenConnection();
            string query = "SELECT * FROM DanhSachLopHoc()";
            SqlCommand cmd = new SqlCommand(query, db.connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            db.CloseConnection();
            return dt;
        }

        // 2.6.2. 
        public DataTable GetLopHoc(DatabaseConnection db, TextBox MaLop)
        {
            string maLop = MaLop.Text;
            DataTable dt = new DataTable();
            try
            {
                db.OpenConnection();

                string query = "SELECT MaLop, TenLop, MaGiangVien, MaMon, MaHocKy, SoHocVienDangKy, MaPhong, Thu, Tiet\n" +
                               "FROM dbo.LOPHOC\n" +
                               "WHERE MaLop = @maLop";
                SqlCommand cmd = new SqlCommand(query, db.connection);
                cmd.Parameters.AddWithValue("@maLop", maLop);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                db.CloseConnection();
            }

            return dt;
        }


        // 2.6.4. 
        public bool InsertLopHoc(DatabaseConnection db, LopHocAdminDTO lopHoc)
        {
            try
            {
                db.OpenConnection();
                string query = "ThemLopHoc";
                SqlCommand cmd = new SqlCommand(query, db.connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaLop", lopHoc.MaLop);
                cmd.Parameters.AddWithValue("@TenLop", lopHoc.TenLop);
                cmd.Parameters.AddWithValue("@MaGiangVien", lopHoc.MaGiangVien);
                cmd.Parameters.AddWithValue("@MaMon", lopHoc.MaMon);
                cmd.Parameters.AddWithValue("@MaHocKy", lopHoc.MaHocKy);
                cmd.Parameters.AddWithValue("@SoHocVienDangKy", lopHoc.SoHocVienDangKy);
                cmd.Parameters.AddWithValue("@MaPhong", lopHoc.MaPhong);
                cmd.Parameters.AddWithValue("@Thu", lopHoc.Thu);
                cmd.Parameters.AddWithValue("@Tiet", lopHoc.Tiet);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                db.CloseConnection();
            }
        }

        // 2.6.5. 
        public bool UpdateLopHoc(DatabaseConnection db, LopHocAdminDTO lopHoc)
        {
            try
            {
                db.OpenConnection();
                string query = "UpdateLopHoc";
                SqlCommand cmd = new SqlCommand(query, db.connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaLop", lopHoc.MaLop);
                cmd.Parameters.AddWithValue("@TenLop", lopHoc.TenLop);
                cmd.Parameters.AddWithValue("@MaGiangVien", lopHoc.MaGiangVien);
                cmd.Parameters.AddWithValue("@MaMon", lopHoc.MaMon);
                cmd.Parameters.AddWithValue("@MaHocKy", lopHoc.MaHocKy);
                cmd.Parameters.AddWithValue("@SoHocVienDangKy", lopHoc.SoHocVienDangKy);
                cmd.Parameters.AddWithValue("@MaPhong", lopHoc.MaPhong);
                cmd.Parameters.AddWithValue("@Thu", lopHoc.Thu);
                cmd.Parameters.AddWithValue("@Tiet", lopHoc.Tiet);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                db.CloseConnection();
            }
        }

        // 2.6.3. 
        public void DeleteLopHoc(DatabaseConnection db, TextBox MaLopHoc)
        {
            string maLopHoc = MaLopHoc.Text;
            try
            {
                db.OpenConnection();
                string query = "XoaLopHoc";
                SqlCommand cmd = new SqlCommand(query, db.connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaLop", maLopHoc);
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa lớp học này không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thành công: Xóa lớp học thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                db.CloseConnection();
            }
        }

    }
}
