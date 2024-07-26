using DANG_KY_MON_HOC.DAO;
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

namespace DANG_KY_MON_HOC.GUI.Admin
{
    public partial class Admin_LopHoc : Form
    {
        DatabaseConnection db = null;
        LopHocAdminDAO lophocDAO = new LopHocAdminDAO();

        public Admin_LopHoc(DatabaseConnection db)
        {
            InitializeComponent();
            this.db = db;
        }

        // 2.6.1. 
        private void QuanLyLopHoc_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = lophocDAO.load_lopHoc(db);
            dgvLopHoc.DataSource = dt;
            Utils.AutosizeColumns(dgvLopHoc);
        }

        // 2.6.2. 
        private void btnSearchLopHoc_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = lophocDAO.GetLopHoc(db, txtMaLopHoc);
            dgvLopHoc.DataSource = dt;
            Utils.AutosizeColumns(dgvLopHoc);
        }

        private void Reload_Lop_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = lophocDAO.load_lopHoc(db);
            dgvLopHoc.DataSource = dt;
            Utils.AutosizeColumns(dgvLopHoc);
        }

        private void btnUpdateLop_Click(object sender, EventArgs e)
        {
            this.Hide();
            Info_LopHoc inf = new Info_LopHoc(db);
            inf.ShowDialog();
            inf = null;
            this.Show();
        }

        // 2.6.3.
        private void btnDeleteLopHP_Click(object sender, EventArgs e)
        {
            lophocDAO.DeleteLopHoc(db, txtMaLopHoc);
        }

    }
}
