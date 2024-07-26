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

namespace DANG_KY_MON_HOC.GUI
{
    public partial class DoiMatKhau : Form
    {
        public DoiMatKhau()
        {
            InitializeComponent();
        }

        private void bt_Doi_Click(object sender, EventArgs e)
        {
            string u = tb_TK.Text;
            string O_p = tb_MK_Cu.Text;
            string N_p = tb_MK_Moi.Text;
            DatabaseConnection db = new DatabaseConnection();
            AdminDAO a = new AdminDAO();
            a.DoiMatKhau(db, u, O_p, N_p);
        }

    }
}
