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
    public partial class FormHocPhi : Form
    {
        private HocVienDTO hv = new HocVienDTO();
        private HocVienDAO hv_DAO = new HocVienDAO();
        private DatabaseConnection db = null;

        public void Update_Form(HocVienDTO hv, DatabaseConnection db)
        {
            this.hv = hv;
            this.db = db;
        }

        public FormHocPhi()
        {
            InitializeComponent();
        }

        private void FormHocPhi_Load(object sender, EventArgs e)
        {
            dataGridView_DSHP.DataSource = hv_DAO.load_DSHP(db, hv);
            tb_HP.Text = hv_DAO.TinhHocPhi(db, hv);
        }
    }
}
