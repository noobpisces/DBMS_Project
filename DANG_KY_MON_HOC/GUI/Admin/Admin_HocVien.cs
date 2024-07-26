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
    public partial class Admin_HocVien : Form
    {
        DatabaseConnection db = null;
        HocVienAdminDAO hocvienDAO = new HocVienAdminDAO();

        public Admin_HocVien(DatabaseConnection db)
        {
            InitializeComponent();
            this.db = db;
        }

        // 2.5.1. 
        private void Admin_HocVien_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = hocvienDAO.load_DSHocVien(db);
            dgvHocVien.DataSource = dt;
            Utils.AutosizeColumns(dgvHocVien);
        }

        // 2.5.2. 
        private void btnSearchHocVien_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = hocvienDAO.get_HocVien(db, txtMaHocVien);
            dgvHocVien.DataSource = dt;
            Utils.AutosizeColumns(dgvHocVien);
        }

        private void Reload_HocVien_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = hocvienDAO.load_DSHocVien(db);
            dgvHocVien.DataSource = dt;
            Utils.AutosizeColumns(dgvHocVien);
        }

        // 2.5.3. 
        private void btnDeleteHocVien_Click(object sender, EventArgs e)
        {
            hocvienDAO.DeleteHocVien(db, txtMaHocVien);
        }

        // 2.5.5. 
        private void btnUpdateHocVien_Click(object sender, EventArgs e)
        {
            this.Hide();
            Info_HocVien inf = new Info_HocVien(db);
            inf.ShowDialog();
            inf = null;
            this.Show();
        }

        private void dgvHocVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvHocVien.Columns[e.ColumnIndex].Name == "ThemTaiKhoan")
            {
                string MaHV = dgvHocVien.Rows[e.RowIndex].Cells["MaHocVien"].Value.ToString();
                Admin_TaoTaiKhoan a_c = new Admin_TaoTaiKhoan(MaHV,db);
                a_c.ShowDialog();
            }    
        }
    }
}
