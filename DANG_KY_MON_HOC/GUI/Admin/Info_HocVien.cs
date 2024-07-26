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
    public partial class Info_HocVien : Form
    {
        DatabaseConnection db = null;
        HocVienAdminDAO hocvienDAO = new HocVienAdminDAO();

        public Info_HocVien(DatabaseConnection db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // 2.5.4. 
        private void btnThemHocVien_Click(object sender, EventArgs e)
        {
            HocVienAdminDTO hv = new HocVienAdminDTO(txtMaHocVien.Text, txtTenHocVien.Text, 
                dtpNgaySinh.Value, txtDiaChi.Text, txtQueQuan.Text, txtMaKhoaHocVien.Text);
            bool temp = hocvienDAO.InsertHocVien(db, hv);
            if (temp)
            {
                MessageBox.Show("Thêm thành công!");
            }
            else
            {
                MessageBox.Show("Không thể thêm!");
            }
        }

        private void btnCapNhatHV_Click(object sender, EventArgs e)
        {
            HocVienAdminDTO hv = new HocVienAdminDTO(txtMaHocVien.Text, txtTenHocVien.Text, 
                dtpNgaySinh.Value, txtDiaChi.Text, txtQueQuan.Text, txtMaKhoaHocVien.Text);
            bool temp = hocvienDAO.UpdateHocVien(db, hv);
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
