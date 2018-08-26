using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            MainModel model = CreateModel();
            Application.Run(new MainForm(model));
            StoreModel(model);
        }

        private static MainModel CreateModel()
        {
            if (!Directory.Exists(_directory))
            {
                return new MainModel();
            }
            else
            {
                string json = File.ReadAllText(_file);
                return MainModel.Deserialize(json);
            }
        }

        private static void StoreModel(MainModel model)
        {
            string json = model.Serialize();
            if (!Directory.Exists(_directory))
            {
                Directory.CreateDirectory(_directory);
            }
            File.WriteAllText(_file, json);
        }
    }
}
