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
    public partial class FormDSLopHoc : Form
    {
        private HocVienDAO hv_DAO = new HocVienDAO();
        private HocVienDTO hv = new HocVienDTO();
        private DatabaseConnection db = null;
        private string MaMon;
        private string MaLop = null;//ma lop ng hoc dang hoc(dung de chuyenlop)
        private string YeuCau;
        private string MaLopDK = null; // malop ng hocj muon chuyen hoac DK
        private string MaHK = null;

        public FormDSLopHoc()
        {
            InitializeComponent();
        }

        private void FormDSLopHoc_Load(object sender, EventArgs e)
        {
            if (YeuCau == "ChuyenLop")
            {
                dataGridView_DSLop.DataSource = hv_DAO.load_DSLop(db, MaMon, MaHK);
                Utils.AutosizeOneColumn(dataGridView_DSLop, 1);
                foreach (DataGridViewRow row in dataGridView_DSLop.Rows)
                {
                    if (row.Cells[1].Value != null && row.Cells[1].Value.Equals(MaLop))
                    {
                        row.Cells[0].Value = true;
                    }
                }
            }
            else if (YeuCau == "TimKiem")
            {
                dataGridView_DSLop.DataSource = hv_DAO.TimKiem(db, MaMon, MaHK);
                Utils.AutosizeOneColumn(dataGridView_DSLop, 1);
            }
            else
            {
                dataGridView_DSLop.DataSource = hv_DAO.load_DSLop(db, MaMon, MaHK);
                Utils.AutosizeOneColumn(dataGridView_DSLop, 1);
            }
        }

        public void Update_Form(HocVienDTO hv, string MaMon, string MaLop, string YeuCau, string MaHK, DatabaseConnection db)
        {
            this.hv = hv;
            this.MaMon = MaMon;
            this.MaLop = MaLop;
            this.YeuCau = YeuCau;
            this.MaHK = MaHK;
            this.db = db;
        }

        public void Update_Form(HocVienDTO hv, string MaMon, string YeuCau, string MaHK, DatabaseConnection db)
        {
            this.hv = hv;
            this.MaMon = MaMon;
            this.YeuCau = YeuCau;
            this.MaHK = MaHK;
            this.db = db;
        }

        private void dataGridView_DSLop_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView_DSLop.Rows)
            {
                if (row.Index != e.RowIndex)
                {
                    // Checkbox không được chọn, đặt giá trị thành null
                    row.Cells[0].Value = false;
                }
            }
            Utils.AutosizeOneColumn(dataGridView_DSLop, 1);
        }

        private void bt_DangKy_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView_DSLop.Rows)
            {
                DataGridViewCheckBoxCell checkbox = row.Cells[0] as DataGridViewCheckBoxCell;
                if (checkbox.Value != null && (bool)checkbox.Value == true)
                {
                    MaLopDK = row.Cells[1].Value.ToString();
                }
            }
            if (YeuCau == "ChuyenLop")
            {
                if (hv_DAO.Chuyen_LopHoc(db, hv, MaLop, MaLopDK))
                {
                    MaLop = MaLopDK;
                }    
                FormDSLopHoc_Load(sender, e);
            }
            else
            {
                hv_DAO.DK_LopHoc(db, hv, MaLopDK);
                FormDSLopHoc_Load(sender, e);
            }
            Utils.AutosizeOneColumn(dataGridView_DSLop, 1);
        }

    }
}
