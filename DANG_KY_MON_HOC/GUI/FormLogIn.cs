using DANG_KY_MON_HOC.DAO;
using DANG_KY_MON_HOC.DTO;
using DANG_KY_MON_HOC.GUI;
using DANG_KY_MON_HOC.GUI.Admin;
using Microsoft.Office.Interop.Access.Dao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DANG_KY_MON_HOC
{
    public partial class FormLogIn : Form
    {
        AdminDAO admin_DAO = new AdminDAO();
        GiangVienDAO gv_DAO = new GiangVienDAO();
        HocVienDAO hv_DAO = new HocVienDAO();
        DatabaseConnection db = new DatabaseConnection();

        public FormLogIn()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (radioButton1.Checked)
            {
                admin_DAO.Admin_DangNhap(db, txtTenDangNhap, txtMatKhau);
            }
            else if (radioButton2.Checked)
            {
                gv_DAO.GV_DangNhap(db, txtTenDangNhap, txtMatKhau);
            }
            else if (radioButton3.Checked)
            {
                hv_DAO.HocVien_DangNhap(db, txtTenDangNhap, txtMatKhau);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một vai trò trước khi đăng nhập.");
            }
            this.Show();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_Doi_MK_Click(object sender, EventArgs e)
        {
            DoiMatKhau dmk = new DoiMatKhau();
            dmk.ShowDialog();
        }
    }
}
