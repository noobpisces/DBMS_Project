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

namespace DANG_KY_MON_HOC.GUI.GiangVien
{
    public partial class ChucNangGiangVien : Form
    {
        GiangVienDTO gv = new GiangVienDTO();
        string MaHocKy = null;
        GiangVienDAO gv_DAO = new GiangVienDAO();
        DatabaseConnection db = null;
        public ChucNangGiangVien()
        {
            InitializeComponent();
        }
        public void Update_Form(GiangVienDTO gv, string MaHocKy, DatabaseConnection db)
        {
            this.gv = gv;
            txtMagiangvien.Text = gv.Magiangvien;
            txtHoten.Text = gv.Hoten;
            txtDiachi.Text = gv.Diachi;
            txtSodienthoai.Text = gv.Sdt;
            txtMaKhoa.Text = gv.Makhoa;
            txtHocvi.Text = gv.Hocham;
            this.MaHocKy = MaHocKy;
            this.db = db;
        }

        private void ChucNangGiangVien_Load(object sender, EventArgs e)
        {
            dataGridView_DSLopDay.DataSource = gv_DAO.load_DSLopDay(db, gv, MaHocKy);
            Utils.AutosizeColumns(dataGridView_DSLopDay);
        }

        private void cb_HK_SelectedValueChanged(object sender, EventArgs e)
        {
            MaHocKy = cb_HK.Text;
            ChucNangGiangVien_Load(sender, e);
        }

        private void dataGridView_DSLopDay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string MaLop = dataGridView_DSLopDay.Rows[e.RowIndex].Cells["MaLop"].Value.ToString();
            DanhSachHocVien form_DSHocVien = new DanhSachHocVien();
            form_DSHocVien.Update(MaLop,db);
            form_DSHocVien.ShowDialog();
        }

        private void bt_DeXuat_Click(object sender, EventArgs e)
        {
            DeXuat dx = new DeXuat();
            dx.Update_Form(gv,db);
            dx.ShowDialog();
        }
    }
}
