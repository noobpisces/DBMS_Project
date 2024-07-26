using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DANG_KY_MON_HOC.DTO;
using COMExcel = Microsoft.Office.Interop.Excel;
using DANG_KY_MON_HOC.GUI;

namespace DANG_KY_MON_HOC.DAO
{
    public class HocVienDAO
    {
        public HocVienDAO() { }

        // 3.1.
        public bool HocVien_DangNhap(DatabaseConnection db, TextBox U, TextBox P)
        {
            string username = U.Text;
            string password = P.Text;
            if (db.OpenConnection())
            {
                SqlCommand command = new SqlCommand("proc_HV_DN", db.connection);
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
                        reader.Close();
                        HocVienDTO hv = new HocVienDTO(HoTen, username, MaKhoa);
                        DatabaseConnection db_H = new DatabaseConnection(username, password);
                        FormHVDangKyLopHoc f_sv = new FormHVDangKyLopHoc(db_H);
                        f_sv.Update_Form(hv);
                        f_sv.ShowDialog();
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

        // 3.2.
        public DataTable load_MonDK(DatabaseConnection db, HocVienDTO hv)
        {
            db.OpenConnection();
            string query = "SELECT * FROM fu_load_MonDK(@MaKhoa)";
            SqlCommand cmd = new SqlCommand(query, db.connection);
            cmd.Parameters.AddWithValue("@MaKhoa", hv.Makhoa);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            db.CloseConnection();
            return dt;
        }

        // 3.3. 
        public DataTable load_MonDaDK(DatabaseConnection db, HocVienDTO hv)
        {
            db.OpenConnection();
            string query = "SELECT * FROM v_DSDaDangKi WHERE MaHocVien = @MaHocVien";
            SqlCommand cmd = new SqlCommand(query, db.connection);
            cmd.Parameters.AddWithValue("@MaHocVien", hv.Mahv);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            db.CloseConnection();
            return dt;
        }

        // 3.4. 
        public DataTable load_DSLop(DatabaseConnection db, string MaMon, string MaHK)
        {
            db.OpenConnection();
            string query = "SELECT * FROM v_DSLopHoc WHERE MaMon = @MaMon AND MaHocKy = @MaHocKy";
            SqlCommand cmd = new SqlCommand(query, db.connection);
            cmd.Parameters.AddWithValue("@MaMon", MaMon);
            cmd.Parameters.AddWithValue("@MaHocKy", MaHK);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            db.CloseConnection();
            return dt;
        }

        // 3.5.
        public void DK_LopHoc(DatabaseConnection db, HocVienDTO hv, string LopHoc)
        {
            db.OpenConnection();
            SqlCommand cmd = new SqlCommand("proc_DKLopHoc", db.connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MaLH", LopHoc);
            cmd.Parameters.AddWithValue("@MaHV", hv.Mahv);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thành công: Đăng ký lớp học thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        // 3.6.
        public void Xoa_DK_LopHoc(DatabaseConnection db, HocVienDTO hv, string LopHoc)
        {
            db.OpenConnection();
            SqlCommand cmd = new SqlCommand("proc_Xoa_DKLopHoc", db.connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaLH", LopHoc);
            cmd.Parameters.AddWithValue("@MaHV", hv.Mahv);
            try
            {
                DialogResult result = MessageBox.Show("Bạn có chắc xóa môn này không", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thành công: Xóa lớp thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        }

        // 3.7. 
        public bool Chuyen_LopHoc(DatabaseConnection db, HocVienDTO hv, string LopHoc, string MaLopDK)
        {
            db.OpenConnection();
            SqlCommand cmd = new SqlCommand("proc_ChuyenLopHoc", db.connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MaLH", LopHoc);
            cmd.Parameters.AddWithValue("@MaHV", hv.Mahv);
            cmd.Parameters.AddWithValue("@MaLHDK", MaLopDK);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thành công: Chuyển lớp học thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                db.CloseConnection();
            }
        }

        
        public void load_TKB(DatabaseConnection db, HocVienDTO hv)
        {
            COMExcel.Application exApp = new COMExcel.Application();
            COMExcel.Workbook exBook; //Trong 1 chương trình Excel có nhiều Workbook
            COMExcel.Worksheet exSheet; //Trong 1 Workbook có nhiều Worksheet
            COMExcel.Range exRange;
            //string sql;
            int hang = 0, cot = 0;
            exBook = exApp.Workbooks.Add(COMExcel.XlWBATemplate.xlWBATWorksheet);
            exSheet = exBook.Worksheets[1];
            // Định dạng chung
            exRange = exSheet.Cells[1, 1];
            exRange.Range["A1:Z300"].Font.Name = "Times new roman"; //Font chữ
            exRange.Range["A1:B3"].Font.Size = 10;
            exRange.Range["A1:B3"].Font.Bold = true;
            exRange.Range["A1:B3"].Font.ColorIndex = 5; //Màu xanh da trời
            exRange.Range["A1:A1"].ColumnWidth = 7;
            exRange.Range["B1:B1"].ColumnWidth = 15;
            exRange.Range["A1:B1"].MergeCells = true;
            exRange.Range["A1:B1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A1:B1"].Value = hv.Hoten;
            exRange.Range["A2:B2"].MergeCells = true;
            exRange.Range["A2:B2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:B2"].Value = hv.Mahv;
            exRange.Range["A3:B3"].MergeCells = true;
            exRange.Range["A3:B3"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A3:B3"].Value = hv.Makhoa;
            exRange.Range["C2:E2"].Font.Size = 16;
            exRange.Range["C2:E2"].Font.Bold = true;
            exRange.Range["C2:E2"].Font.ColorIndex = 3; //Màu đỏ
            exRange.Range["C2:E2"].MergeCells = true;
            exRange.Range["C2:E2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C2:E2"].Value = "Thoi Khoa Bieu";

            db.OpenConnection();
            string query = "Select TenMonHoc,GiangVien,Thu,Tiet,Phong from v_DSDaDangKi where MaHocVien = @MaHocVien ";
            SqlCommand cmd = new SqlCommand(query, db.connection);
            cmd.Parameters.AddWithValue("@MaHocVien", hv.Mahv);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            db.CloseConnection();

            //Tạo dòng tiêu đề bảng
            exRange.Range["A7:F7"].Font.Bold = true;
            exRange.Range["A7:F7"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C7:F7"].ColumnWidth = 12;
            exRange.Range["A7:A7"].Value = "Ten mon";
            exRange.Range["B7:B7"].Value = "Giang Vien";
            exRange.Range["C7:C7"].Value = "Thu ";
            exRange.Range["D7:D7"].Value = "Tiet";
            exRange.Range["E7:E7"].Value = "Phong";

            for (hang = 0; hang < dt.Rows.Count; hang++)
            {
                for (cot = 0; cot < dt.Columns.Count; cot++)
                {
                    exSheet.Cells[cot + 1][hang + 8] = dt.Rows[hang][cot].ToString();

                }
            }

            exApp.Visible = true;
        }

        // 3.8.
        public string TinhHocPhi(DatabaseConnection db, HocVienDTO hv)
        {
            db.OpenConnection();
            string query = "SELECT [dbo].[fu_TongHocPhi](@MaHocVien, @MaKhoa)";
            SqlCommand cmd = new SqlCommand(query, db.connection);
            cmd.Parameters.AddWithValue("@MaHocVien", hv.Mahv);
            cmd.Parameters.AddWithValue("@MaKhoa", hv.Makhoa);

            double hocPhi = 0;
            object result = cmd.ExecuteScalar(); // Sử dụng kiểu object để kiểm tra null
            if (result != DBNull.Value && result != null)
            {
                hocPhi = (double)result;
            }

            db.CloseConnection();
            return hocPhi.ToString();
        }

        // 3.9.
        public DataTable load_DSHP(DatabaseConnection db, HocVienDTO hv)
        {
            db.OpenConnection();
            string query = "SELECT * FROM fu_load_DSHocPhi(@MaHocVien, @MaKhoa)";
            SqlCommand cmd = new SqlCommand(query, db.connection);
            cmd.Parameters.AddWithValue("@MaHocVien", hv.Mahv);
            cmd.Parameters.AddWithValue("@MaKhoa", hv.Makhoa);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            db.CloseConnection();
            return dt;
        }

        // 3.10.
        public DataTable TimKiem(DatabaseConnection db, string s, string MaHK)
        {
            db.OpenConnection();
            string query = "SELECT * FROM fu_load_DSTimKiem (@string, @MaHocKy)";
            SqlCommand cmd = new SqlCommand(query, db.connection);
            cmd.Parameters.AddWithValue("@string", s);
            cmd.Parameters.AddWithValue("@MaHocKy", MaHK);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            db.CloseConnection();
            return dt;
        }

        public void Phieu(DatabaseConnection db, HocVienDTO hv, DataGridView dtgv)
        {
            COMExcel.Application exApp = new COMExcel.Application();
            COMExcel.Workbook exBook; //Trong 1 chương trình Excel có nhiều Workbook
            COMExcel.Worksheet exSheet; //Trong 1 Workbook có nhiều Worksheet
            COMExcel.Range exRange;
            //string sql;
            int hang = 0, cot = 0;
            exBook = exApp.Workbooks.Add(COMExcel.XlWBATemplate.xlWBATWorksheet);
            exSheet = exBook.Worksheets[1];
            // Định dạng chung
            exRange = exSheet.Cells[1, 1];
            exRange.Range["A1:Z300"].Font.Name = "Times new roman"; //Font chữ
            exRange.Range["A1:B3"].Font.Size = 10;
            exRange.Range["A1:B3"].Font.Bold = true;
            exRange.Range["A1:B3"].Font.ColorIndex = 5; //Màu xanh da trời
            exRange.Range["A1:A1"].ColumnWidth = 7;
            exRange.Range["B1:B1"].ColumnWidth = 15;
            exRange.Range["A1:B1"].MergeCells = true;
            exRange.Range["A1:B1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A1:B1"].Value = hv.Hoten;
            exRange.Range["A2:B2"].MergeCells = true;
            exRange.Range["A2:B2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:B2"].Value = hv.Mahv;
            exRange.Range["A3:B3"].MergeCells = true;
            exRange.Range["A3:B3"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A3:B3"].Value = hv.Makhoa;
            exRange.Range["C2:E2"].Font.Size = 16;
            exRange.Range["C2:E2"].Font.Bold = true;
            exRange.Range["C2:E2"].Font.ColorIndex = 3; //Màu đỏ
            exRange.Range["C2:E2"].MergeCells = true;
            exRange.Range["C2:E2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C2:E2"].Value = "Phieu Dang Ki";

            db.OpenConnection();
            string query = "Select * from v_DSDaDangKi where MaHocVien = @MaHocVien ";
            SqlCommand cmd = new SqlCommand(query, db.connection);
            cmd.Parameters.AddWithValue("@MaHocVien", hv.Mahv);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            db.CloseConnection();

            //Tạo dòng tiêu đề bảng
            exRange.Range["A7:F7"].Font.Bold = true;
            exRange.Range["A7:F7"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C7:F7"].ColumnWidth = 12;
            exRange.Range["A7:A7"].Value = "MaLop";
            exRange.Range["B7:B7"].Value = "Ten Mon hoc";
            exRange.Range["C7:C7"].Value = "Số tin chi ";
            exRange.Range["D7:D7"].Value = "Tiet";
            exRange.Range["E7:E7"].Value = "Thu";
            exRange.Range["F7:F7"].Value = "Phong";
            exRange.Range["G7:G7"].Value = "GiangVien";
            exRange.Range["H7:H7"].Value = "Ma Hoc Vien";
            exRange.Range["I7:I7"].Value = "Ma Mon";

            for (hang = 0; hang < dt.Rows.Count; hang++)
            {
                for (cot = 0; cot < dt.Columns.Count; cot++)
                {
                    exSheet.Cells[cot + 1][hang + 8] = dt.Rows[hang][cot].ToString();

                }
            }

            exApp.Visible = true;
        }

    }
}
