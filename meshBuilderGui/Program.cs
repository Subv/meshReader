using System;
using System.Windows.Forms;
using meshDatabase;

namespace meshBuilderGui
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            MpqManager.Initialize(@"L:\World of Warcraft 3.3.5a");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Interface());
        }
    }
}
