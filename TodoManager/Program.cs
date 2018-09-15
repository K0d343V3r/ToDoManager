using System;
using System.IO;
using System.Windows.Forms;
using TodoManager.Models;

namespace TodoManager
{
    static class Program
    {
        private static readonly string _directory = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), Application.ProductName);
        private static readonly string _file = Path.Combine(_directory, "Data.txt");

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm(new MainModel()));
        }
    }
}
