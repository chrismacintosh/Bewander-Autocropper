using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bewandercropper
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //First run check. If firstrun = true (the default flag in the config file), run a one-time setup form.
            if (Properties.Settings.Default.firstrun)
            {
                //Fire off the configuration cannon!
                Application.Run(new firstrun());
            }
            //Proceed to app since it's not the first run.
            else { Application.Run(new main()); }
        }
    }
}
