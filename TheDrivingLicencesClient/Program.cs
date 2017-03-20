using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TheDrivingLicencesClient
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
            Application.Run(new LoginForm());
            //Application.Run(new TestForm());
           // Application.Run(new ResultForm());
            //Application.Run(new WaitForm());
        }
    }
}
