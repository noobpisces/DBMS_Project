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
    public class HocVienAdminDAO
    {
        // 2.5.1. 
        public DataTable load_DSHocVien(DatabaseConnection db)//load danh sach lop học cho học viên đk(khoa nào đăng kí khao đó)
        {
            db.OpenConnection();
            string query = "SELECT * FROM fu_load_HocVien()";
            SqlCommand cmd = new SqlCommand(query, db.connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            db.CloseConnection();
            return dt;
        }

        // 2.5.2. 
        public DataTable get_HocVien(DatabaseConnection db, TextBox MaHocVien)
        {
            string maHocVien = MaHocVien.Text;
            DataTable dt = new DataTable();
            try
            {
                db.OpenConnection();

                string query = "SELECT MaHocVien, HoTen, NgaySinh, DiaChi, QueQuan, MaKhoa, MatKhau\n" +
                            "FROM dbo.func_getHocVienByMaHocVien(@maHocVien)";
                SqlCommand cmd = new SqlCommand(query, db.connection);
                cmd.Parameters.AddWithValue("@maHocVien", maHocVien);

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

        // 2.5.3. 
        public void DeleteHocVien(DatabaseConnection db, TextBox MaHocVien)
        {
            string maHocVien = MaHocVien.Text;
            try
            {
                db.OpenConnection();
                string query = "DeleteHocVien";
                SqlCommand cmd = new SqlCommand(query, db.connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaHocVien", maHocVien);
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa học viên này không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thành công: Xóa học viên thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        // 2.5.4. 
        public bool InsertHocVien(DatabaseConnection db, HocVienAdminDTO hv)
        {
            try
            {
                db.OpenConnection();
                string query = "InsertHocVien";
                SqlCommand cmd = new SqlCommand(query, db.connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaHocVien", hv.MaHocVien);
                cmd.Parameters.AddWithValue("@HoTen", hv.HoTen);
                cmd.Parameters.AddWithValue("@NgaySinh", hv.NgaySinh);
                cmd.Parameters.AddWithValue("@DiaChi", hv.DiaChi);
                cmd.Parameters.AddWithValue("@QueQuan", hv.QueQuan);
                cmd.Parameters.AddWithValue("@MaKhoa", hv.MaKhoa);

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

        // 2.5.5. 
        public bool UpdateHocVien(DatabaseConnection db, HocVienAdminDTO hv)
        {
            try
            {
                db.OpenConnection();
                string query = "UpdateHocVien";
                SqlCommand cmd = new SqlCommand(query, db.connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaHocVien", hv.MaHocVien);
                cmd.Parameters.AddWithValue("@HoTen", hv.HoTen);
                cmd.Parameters.AddWithValue("@NgaySinh", hv.NgaySinh);
                cmd.Parameters.AddWithValue("@DiaChi", hv.DiaChi);
                cmd.Parameters.AddWithValue("@QueQuan", hv.QueQuan);
                cmd.Parameters.AddWithValue("@MaKhoa", hv.MaKhoa);

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
                MessageBox.Show("Lỗi:" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                db.CloseConnection();
            }
        }

    }
}
