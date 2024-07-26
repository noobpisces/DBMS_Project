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
    public class GiangVienAdminDAO
    {
        // 2.4.1.
        public DataTable load_DSGiangVien(DatabaseConnection db) // load danh sách lớp học cho học viên đăng ký (khoa nào đăng ký khoa đó)
        {
            db.OpenConnection();
            string query = "SELECT * FROM fu_load_GV()";
            SqlCommand cmd = new SqlCommand(query, db.connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            db.CloseConnection();
            return dt;
        }

        // 2.4.2.
        public DataTable get_GiangVien(DatabaseConnection db, TextBox MaGiangVien)
        {
            string maGiangVien = MaGiangVien.Text;
            DataTable dt = new DataTable();
            try
            {
                db.OpenConnection();

                string query = "SELECT MaGiangVien, HoTen, HocVi, HocHam, DiaChi, Sdt, MaKhoa, MatKhau\n" +
                               "FROM dbo.func_getGiangVienByMaGiangVien (@maGiangVien)";
                SqlCommand cmd = new SqlCommand(query, db.connection);
                cmd.Parameters.AddWithValue("@maGiangVien", maGiangVien);

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

        // 2.4.3.
        public void DeleteGiangVien(DatabaseConnection db, TextBox MaGiangVien)
        {
            string maGiangVien = MaGiangVien.Text;
            try
            {
                db.OpenConnection();
                string query = "DeleteGiangVien";
                SqlCommand cmd = new SqlCommand(query, db.connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaGiangVien", maGiangVien);
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa giảng viên này không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thành công: Xóa giảng viên thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        // 2.4.4.
        public bool InsertGiangVien(DatabaseConnection db, GiangVienAdminDTO gv)
        {
            try
            {
                db.OpenConnection();
                string query = "InsertGiangVien";
                SqlCommand cmd = new SqlCommand(query, db.connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaGiangVien", gv.MaGiangVien);
                cmd.Parameters.AddWithValue("@HoTen", gv.HoTen);
                cmd.Parameters.AddWithValue("@HocVi", gv.HocVi);
                cmd.Parameters.AddWithValue("@HocHam", gv.HocHam);
                cmd.Parameters.AddWithValue("@DiaChi", gv.DiaChi);
                cmd.Parameters.AddWithValue("@Sdt", gv.Sdt);
                cmd.Parameters.AddWithValue("@MaKhoa", gv.MaKhoa);

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

        // 2.4.5.
        public bool UpdateGiangVien(DatabaseConnection db, GiangVienAdminDTO gv)
        {
            try
            {
                db.OpenConnection();
                string query = "UpdateGiangVien";
                SqlCommand cmd = new SqlCommand(query, db.connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaGiangVien", gv.MaGiangVien);
                cmd.Parameters.AddWithValue("@HoTen", gv.HoTen);
                cmd.Parameters.AddWithValue("@HocVi", gv.HocVi);
                cmd.Parameters.AddWithValue("@HocHam", gv.HocHam);
                cmd.Parameters.AddWithValue("@DiaChi", gv.DiaChi);
                cmd.Parameters.AddWithValue("@Sdt", gv.Sdt);
                cmd.Parameters.AddWithValue("@MaKhoa", gv.MaKhoa);

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

    }
}
