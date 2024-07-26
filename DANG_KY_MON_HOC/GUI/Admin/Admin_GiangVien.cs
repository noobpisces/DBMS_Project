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
    public partial class Admin_GiangVien : Form
    {
        DatabaseConnection db = null;
        GiangVienAdminDAO giangvienDao = new GiangVienAdminDAO();

        public Admin_GiangVien(DatabaseConnection db)
        {
            InitializeComponent();
            this.db = db;
        }

        // 2.4.1.
        private void Admin_GiangVien_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = giangvienDao.load_DSGiangVien(db);
            dgvGiangVien.DataSource = dt;
            Utils.AutosizeColumns(dgvGiangVien);
        }

        // 2.4.2.
        private void Search_GiangVien_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = giangvienDao.get_GiangVien(db, txtMaGiangVien);
            dgvGiangVien.DataSource = dt;
            Utils.AutosizeColumns(dgvGiangVien);
        }

        // 2.4.3.
        private void Delete_GiangVien_Click(object sender, EventArgs e)
        {
            giangvienDao.DeleteGiangVien(db, txtMaGiangVien);
        }

        private void ReloadData_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = giangvienDao.load_DSGiangVien(db);
            dgvGiangVien.DataSource = dt;
            Utils.AutosizeColumns(dgvGiangVien);
        }

        private void Capnhat_GiangVien_Click(object sender, EventArgs e)
        {
            this.Hide();
            Info_GiangVien inf = new Info_GiangVien(db);
            inf.ShowDialog();
            inf = null;
            this.Show();
        }

        private void dgvGiangVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvGiangVien.Columns[e.ColumnIndex].Name == "ThemTaiKhoan")
            {
                string MaGV = dgvGiangVien.Rows[e.RowIndex].Cells["MaGiangVien"].Value.ToString();
                Admin_TaoTaiKhoan a_c = new Admin_TaoTaiKhoan(MaGV, db);
                a_c.ShowDialog();
            }
        }

    }
}
