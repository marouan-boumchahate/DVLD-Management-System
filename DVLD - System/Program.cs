using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD___System
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
            //Settings.CreatedByUserID = 16;
            Application.Run(new Login_Form());
            //Application.Run(new DVLD_Form());
            //Application.Run(new Testing_Form());
        }
    }
}
