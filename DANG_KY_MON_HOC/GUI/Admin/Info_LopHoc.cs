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
    public partial class Info_LopHoc : Form
    {
        DatabaseConnection db = null;
        LopHocAdminDAO lophocDao = new LopHocAdminDAO();

        public Info_LopHoc(DatabaseConnection db)
        {
            InitializeComponent();
            this.db = db;
        }

        // 2.6.4. 
        private void btnThemLopHoc_Click(object sender, EventArgs e)
        {
            LopHocAdminDTO lh = new LopHocAdminDTO(txtMaLop.Text, txtTenLop.Text, txtMaGiangVien.Text,
                txtMaMon.Text, txtMaHocKy.Text, ((int)numericSoHV.Value), txtMaPhong.Text, txtThu.Text, txtTietHoc.Text);
            bool temp = lophocDao.InsertLopHoc(db, lh);
            if (temp)
            {
                MessageBox.Show("Thêm thành công!");
            }
            else
            {
                MessageBox.Show("Không thể thêm!");
            }
        }

        // 2.6.5. 
        private void btnUpdateLH_Click(object sender, EventArgs e)
        {
            LopHocAdminDTO lh = new LopHocAdminDTO(txtMaLop.Text, txtTenLop.Text, txtMaGiangVien.Text,
                txtMaMon.Text, txtMaHocKy.Text, ((int)numericSoHV.Value), txtMaPhong.Text, txtThu.Text, txtTietHoc.Text);
            bool temp = lophocDao.UpdateLopHoc(db, lh);
            if (temp)
            {
                MessageBox.Show("Cập nhật thành công!");
            }
            else
            {
                MessageBox.Show("Không thể cập nhật!");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
