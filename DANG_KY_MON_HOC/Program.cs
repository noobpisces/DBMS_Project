using DANG_KY_MON_HOC.GUI.Admin;
using DANG_KY_MON_HOC.GUI.GiangVien;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DANG_KY_MON_HOC
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormLogIn());
        }
    }
}
