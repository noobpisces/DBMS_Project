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
    public partial class DeXuat : Form
    {
        GiangVienDTO gv = new GiangVienDTO();
        GiangVienDAO gv_DAO = new GiangVienDAO();
        DatabaseConnection db = null;
        public DeXuat()
        {
            InitializeComponent();
        }
        public void Update_Form(GiangVienDTO gv, DatabaseConnection db)
        {
            this.gv = gv;
            this.db = db;

        }
        private void bt_GuiDeXuat_Click(object sender, EventArgs e)
        {
            string MaMon = tb_MaMon.Text;
            int SoHV = (int)numericUpDown_HocVien.Value;
            gv_DAO.GV_GuiDeXuat(db, gv, tb_MaMon.Text, SoHV);
        }
    }
}
