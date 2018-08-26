using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TodoManager
{
    public partial class AddTodo : Form
    {
        public string Task { get; private set; }

        public AddTodo()
        {
            InitializeComponent();
        }

        private void _okButton_Click(object sender, EventArgs e)
        {
            try
            {
                string task = _taskText.Text.Trim();
                if (task.Length == 0)
                {
                    MessageBox.Show("Please enter a task.");
                    _taskText.Focus();
                }
                else
                {
                    Task = task;
                    DialogResult = DialogResult.OK;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
