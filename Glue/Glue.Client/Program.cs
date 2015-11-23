using System;
using System.Windows.Forms;
using NFX.WinForms;

namespace Glue.Client
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            using (var application = new BaseApplication(args, null))
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Shell());
            }
        }
    }
}
