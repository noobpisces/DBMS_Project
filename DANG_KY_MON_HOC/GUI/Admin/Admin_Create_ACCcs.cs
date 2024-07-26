using DANG_KY_MON_HOC.DAO;
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
    public partial class Admin_TaoTaiKhoancs : Form
    {
        private string Ma = null;
        DatabaseConnection db = null;
        AdminDAO hva_DAO = new AdminDAO();

        public Admin_TaoTaiKhoancs(string Ma,DatabaseConnection db)
        {
            InitializeComponent();
            this.Ma = Ma;
            this.db = db;
        }

        public Admin_TaoTaiKhoancs(DatabaseConnection db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void bt_TaoTaiKhoan_Click(object sender, EventArgs e)
        {
            string u = tb_TaiKhoan.Text;
            string p = tb_MatKhau.Text;
            hva_DAO.TaoTaiKhoan(db, u, p);   
        }

        private void Admin_TaoTaiKhoancs_Load(object sender, EventArgs e)
        {
            if (Ma != null)
            {
                tb_TaiKhoan.Text = Ma;
                tb_TaiKhoan.ReadOnly = true;
            }
        }

    }
}
