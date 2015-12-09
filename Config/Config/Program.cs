using System;
using System.Windows.Forms;
using NFX.WinForms;

namespace NFXDemos.Config
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            using (var app = new BaseApplication(args, null))
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Shell());
            }
        }
    }
}
