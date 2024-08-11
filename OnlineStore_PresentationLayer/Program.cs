using DVLD_PresentationLayer;
using OnlineStore_PresentationLayer.Login;
using OnlineStore_PresentationLayer.Manage_Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineStore_PresentationLayer
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
            clsGlobal.CreateNonExistedEventSource("OnlineStore_C#_ByMomenNasr", "Application");

            //Application.Run(new frmMainScreen());
            Application.Run(new frmLoginScreen());

        }
    }
}
