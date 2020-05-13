using QLDA.View.TaiKhoan;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDA
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            bool isLogout = true;
            while (isLogout) {
                var login = new Login();
                Application.Run(login);
                if (login.DialogResult == DialogResult.OK) {
                    var main = new MainForm(login.IdLogin);
                    Application.Run(main);
                    isLogout = main.IsLogOut;
                }
                else {
                    isLogout = false;
                }
            }
        }
    }
}