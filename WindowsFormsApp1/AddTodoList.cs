using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TodoList
{
    public partial class AddTodoList : Form
    {
        public string NewName { get; private set; }

        public AddTodoList()
        {
            InitializeComponent();
        }

        private void _okButton_Click(object sender, EventArgs e)
        {
            try
            {
                string newName = _newNameText.Text.Trim();
                if (newName.Length == 0)
                {
                    MessageBox.Show("Please enter a name.");
                    _newNameText.Focus();
                }
                else
                {
                    NewName = newName;
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
