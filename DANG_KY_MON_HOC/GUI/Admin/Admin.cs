using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DANG_KY_MON_HOC.GUI.Admin
{
    public partial class Admin : Form
    {
        DatabaseConnection db = null;

        public Admin(DatabaseConnection db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void QuanLy_GV_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_GiangVien quanlygiangvien = new Admin_GiangVien(db);
            quanlygiangvien.ShowDialog();
            quanlygiangvien = null;
            this.Show();
        }

        private void Thoat_admin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Quanly_HocVien_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_HocVien quanlysinhvien = new Admin_HocVien(db);
            quanlysinhvien.ShowDialog();
            quanlysinhvien = null;
            this.Show();
        }

        private void Quanly_MH_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_LopHoc quanlylophoc = new Admin_LopHoc(db);
            quanlylophoc.ShowDialog();
            quanlylophoc = null;
            this.Show();
        }

        private void bt_Create_ACCADMIN_Click(object sender, EventArgs e)
        {
            Admin_TaoTaiKhoan ad = new Admin_TaoTaiKhoan(db);
            ad.ShowDialog();
        }
    }
}
