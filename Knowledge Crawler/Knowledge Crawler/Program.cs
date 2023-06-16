using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Knowledge_Crawler
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new start());
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "AN ERROR HAS OCCURED", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
