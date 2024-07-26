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

namespace DANG_KY_MON_HOC.GUI.GiangVien
{
    public partial class DanhSachHocVien : Form
    {
        string MaLop = null;
        DatabaseConnection db = null;
        GiangVienDAO gv_DAO = new GiangVienDAO();
        public DanhSachHocVien()
        {
            InitializeComponent();
        }
        public void Update(string MaLop, DatabaseConnection db)
        {
            this.MaLop = MaLop;
            this.db = db;
        }

        private void Form_DSHocVien_Load(object sender, EventArgs e)
        {
            dataGridView_DSHocVien.DataSource = gv_DAO.load_DSHocVien(db, MaLop);
            label_Lop.Text = MaLop;
            Utils.AutosizeColumns(dataGridView_DSHocVien);
        }
    }
}
