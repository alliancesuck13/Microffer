using System;
using System.Threading;
using System.Windows.Forms;

namespace Microffer
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Global exception
            Application.ThreadException += new ThreadExceptionEventHandler(Exception);
            Application.Run(new FormMain());
        }

        static void Exception(object sender, ThreadExceptionEventArgs e)
        {
            MessageBox.Show(e.Exception.ToString(), e.Exception.Message);
        }
    }
}
