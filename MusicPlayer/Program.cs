using System;
using System.Windows.Forms;

namespace MusicPlayer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// Added a test comment
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MusicPlayerMain());
        }
    }
}
