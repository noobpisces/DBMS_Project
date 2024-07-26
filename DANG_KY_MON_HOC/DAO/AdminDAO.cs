using DANG_KY_MON_HOC.GUI.Admin;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DANG_KY_MON_HOC.DAO
{
    public class AdminDAO
    {
        public AdminDAO() { }

        // 2.1.
        public bool Admin_DangNhap(DatabaseConnection db, TextBox TaiKhoan, TextBox MatKhau)
        {
            string username = TaiKhoan.Text;
            string password = MatKhau.Text;
            db.OpenConnection();
            string query = "SELECT [dbo].[fu_Check_DangNhap_ADMIN](@user, @pass)";
            SqlCommand cmd = new SqlCommand(query, db.connection);
            cmd.Parameters.AddWithValue("@user", username);
            cmd.Parameters.AddWithValue("@pass", password);

            double check = 0;
            object result = cmd.ExecuteScalar(); // Sử dụng kiểu object để kiểm tra null
            if (result != DBNull.Value && result != null)
            {
                check = (double)result;
            }
            db.CloseConnection();

            if (check == 1)
            {
                FormLogIn fromAdmin = new FormLogIn();
                DatabaseConnection db_a = new DatabaseConnection(username, password);
                Admin nguoiquanly = new Admin(db_a);
                nguoiquanly.ShowDialog();
                nguoiquanly = null;
                return true;
            }
            else
            {
                MessageBox.Show("Lỗi: Không tìm thấy tài khoản mật khẩu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // 2.2.
        public void TaoTaiKhoan(DatabaseConnection db, string u, string p)
        {
            try
            {
                db.OpenConnection();
                string query = "proc_TaoTK";
                SqlCommand cmd = new SqlCommand(query, db.connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@TaiKhoan", u);
                cmd.Parameters.AddWithValue("@MatKhau", p);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Thông báo: Tạo tài khoản thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                db.CloseConnection();
            }
        }

        // 2.3.
        public void DoiMatKhau(DatabaseConnection db, string u, string O_p, string N_p)
        {
            try
            {
                db.OpenConnection();
                string query = "proc_DoiMK";
                SqlCommand cmd = new SqlCommand(query, db.connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@TaiKhoan", u);
                cmd.Parameters.AddWithValue("@MatKhauCu", O_p);
                cmd.Parameters.AddWithValue("@MatKhauMoi", N_p);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thông báo: Đổi mật khẩu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
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
