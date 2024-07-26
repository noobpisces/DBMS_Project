using DANG_KY_MON_HOC.DAO;
using DANG_KY_MON_HOC.DTO;
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
    public partial class Info_GiangVien : Form
    {
        DatabaseConnection db = null;
        GiangVienAdminDAO giangvienDao = new GiangVienAdminDAO();

        public Info_GiangVien(DatabaseConnection db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // 2.4.4.
        private void btnThemGiangVien_Click(object sender, EventArgs e)
        {
            GiangVienAdminDTO gv = new GiangVienAdminDTO(txtMaGiangVien.Text, txtTenGiangVien.Text, txtHocVi.Text
                , txtHocHam.Text, txtDiaChi.Text, txtSdt.Text, txtMaKhoa.Text);
            bool temp = giangvienDao.InsertGiangVien(db, gv);
            if (temp)
            {
                MessageBox.Show("Thêm thành công!");
            }
            else
            {
                MessageBox.Show("Không thể thêm!");
            }
        }

        // 2.4.5.
        private void btnCapNhatGV_Click(object sender, EventArgs e)
        {
            GiangVienAdminDTO gv = new GiangVienAdminDTO(txtMaGiangVien.Text, txtTenGiangVien.Text, txtHocVi.Text, 
                txtHocHam.Text, txtDiaChi.Text, txtSdt.Text, txtMaKhoa.Text);
            bool temp = giangvienDao.UpdateGiangVien(db, gv);
            if (temp)
            {
                MessageBox.Show("Cập nhật thành công!");
            }
            else
            {
                MessageBox.Show("Không thể cập nhật!");
            }
        }

    }
}
