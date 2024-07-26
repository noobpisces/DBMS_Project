using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DANG_KY_MON_HOC
{
    public class Utils
    {
        public static void AutosizeColumns(DataGridView dataGridView)
        {
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }

        public static void AutosizeOneColumn(DataGridView dataGridView, int columnIndex)
        {
            dataGridView.AutoResizeColumn(columnIndex, DataGridViewAutoSizeColumnMode.AllCells);
        }

    }
}
