using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using TodoManager.Models;

namespace TodoManager
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static async Task Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm(await MainModel.CreateAsync()));
        }
    }
}
