using DANG_KY_MON_HOC.DAO;
using DANG_KY_MON_HOC.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DANG_KY_MON_HOC.GUI
{
    public partial class FormHVDangKyLopHoc : Form
    {
        private HocVienDAO hv_DAO = new HocVienDAO();
        private HocVienDTO hv = new HocVienDTO();
        private DatabaseConnection db = null;
        private string MaHK = null;

        public FormHVDangKyLopHoc(DatabaseConnection db)
        {
            InitializeComponent();
            this.db = db;
        }

        public void Update_Form(HocVienDTO hv)
        {
            this.hv = hv;
            lb_TenHV.Text = this.hv.Hoten;
            lb_MaHV.Text = this.hv.Mahv;
            lb_Khoa.Text = this.hv.Makhoa;
        }

        private void FormHVDangKyLopHoc_Load(object sender, EventArgs e)
        {
            MaHK = cb_MaHocKi.Text;
            dataGridView_DSMon.DataSource = hv_DAO.load_MonDK(db, hv);
            dataGridView_DSDaDK.DataSource = hv_DAO.load_MonDaDK(db, hv);
            tb_HocPhi.Text = hv_DAO.TinhHocPhi(db, hv);
            Utils.AutosizeOneColumn(dataGridView_DSDaDK, 2);
        }

        private void dataGridView_DSMon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string MaMon = dataGridView_DSMon.Rows[e.RowIndex].Cells["MaMon"].Value.ToString();
            FormDSLopHoc f_lop = new FormDSLopHoc();
            f_lop.Update_Form(hv, MaMon, "DangKy", MaHK, db);
            f_lop.ShowDialog();
        }

        private void dataGridView_DSDaDK_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string MaLop = dataGridView_DSDaDK.Rows[e.RowIndex].Cells["MaLop"].Value.ToString();
            if (dataGridView_DSDaDK.Columns[e.ColumnIndex].Name == "Xoa")
            {
                hv_DAO.Xoa_DK_LopHoc(db, hv, MaLop);
                dataGridView_DSDaDK.DataSource = hv_DAO.load_MonDaDK(db, hv);
                tb_HocPhi.Text = hv_DAO.TinhHocPhi(db, hv);
            }
            if (dataGridView_DSDaDK.Columns[e.ColumnIndex].Name == "ChuyenLop")
            {
                string MaMon = dataGridView_DSDaDK.Rows[e.RowIndex].Cells["MaMon"].Value.ToString();
                FormDSLopHoc f_lop = new FormDSLopHoc();
                f_lop.Update_Form(hv, MaMon, MaLop, "ChuyenLop", MaHK, db);
                f_lop.ShowDialog();
            }
            Utils.AutosizeOneColumn(dataGridView_DSDaDK, 2);
        }

        private void bt_Reload_Click(object sender, EventArgs e)
        {
            FormHVDangKyLopHoc_Load(sender, e);
        }

        private void bt_TKB_Click(object sender, EventArgs e)
        {
            hv_DAO.load_TKB(db, hv);
        }

        private void bt_Phieu_Click(object sender, EventArgs e)
        {
            DataTable dt = hv_DAO.load_MonDaDK(db, hv);
            hv_DAO.Phieu(db, hv, dataGridView_DSDaDK);
        }

        private void bt_ChiTiet_Click(object sender, EventArgs e)
        {
            FormHocPhi FormHocPhi = new FormHocPhi();
            FormHocPhi.Update_Form(hv, db);
            FormHocPhi.ShowDialog();
        }

        private void bt_TimKiem_Click(object sender, EventArgs e)
        {
            FormDSLopHoc f_lop = new FormDSLopHoc();
            f_lop.Update_Form(hv, tb_TimKiem.Text, "TimKiem", MaHK, db);
            f_lop.ShowDialog();
        }

        private void cb_MaHocKi_SelectedValueChanged(object sender, EventArgs e)
        {
            MaHK = cb_MaHocKi.Text;
        }

        private void bt_DangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
