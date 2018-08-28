using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TodoManager
{
    public partial class MainForm : Form
    {
        private MainModel _model;
        private int _previousTodoListIndex = -1;

        public MainForm(MainModel model)
        {
            _model = model;
            InitializeComponent();
            InitializeTodoGrid();
        }

        private void InitializeTodoGrid()
        {
            _todoGrid.AutoGenerateColumns = false;
            var column1 = new DataGridViewCheckBoxColumn();
            column1.DataPropertyName = "Done";
            column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            _todoGrid.Columns.Add(column1);
            var column2 = new DataGridViewTextBoxColumn();
            column2.HeaderText = "Task";
            column2.DataPropertyName = "Task";
            column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            _todoGrid.Columns.Add(column2);
        }

        protected override void OnLoad(EventArgs e)
        {
            try
            {
                base.OnLoad(e);
                _todoListList.DataSource = _model.TodoLists;
                _todoListList.DisplayMember = "Name";
                _model.TodoLists.ListChanged += TodoLists_ListChanged;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TodoLists_ListChanged(object sender, ListChangedEventArgs e)
        {
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
                _todoListList.SelectedIndex = -1;
                _todoListList.SelectedIndex = e.NewIndex;
                _removeListButton.Enabled = true;
            }
            else if (e.ListChangedType == ListChangedType.ItemDeleted && _model.TodoLists.Count == 0)
            {
                _removeListButton.Enabled = false;
                _addTodoButton.Enabled = false;
            }
        }

        private void _addListButton_Click(object sender, EventArgs e)
        {
            try
            {
                var dialog = new AddTodoList();
                if (dialog.ShowDialog(this) == DialogResult.OK)
                {
                    _model.TodoLists.Add(new TodoList(dialog.NewName));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void _removeListButton_Click(object sender, EventArgs e)
        {
            try
            {
                // disconnect current todo list handler
                _model.TodoLists[_todoListList.SelectedIndex].Todos.ListChanged -= Todos_ListChanged;

                // and remove todo list
                _model.TodoLists.RemoveAt(_todoListList.SelectedIndex);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void _addTodoButton_Click(object sender, EventArgs e)
        {
            try
            {
                var dialog = new AddTodo();
                if (dialog.ShowDialog(this) == DialogResult.OK)
                {
                    _model.TodoLists[_todoListList.SelectedIndex].Todos.Add(new Todo(dialog.Task));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void _todoListList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (_todoListList.SelectedIndex >= 0 &&
                    _todoListList.SelectedIndex != _previousTodoListIndex)
                {
                    if (_todoListList.Items.Count == 0)
                    {
                        _removeTodoButton.Enabled = false;
                    }
                    else
                    {
                        // bind new data source
                        var todos = _model.TodoLists[_todoListList.SelectedIndex].Todos;
                        _todoGrid.DataSource = todos;
                        todos.ListChanged += Todos_ListChanged;
                        _addTodoButton.Enabled = true;
                        _removeTodoButton.Enabled = todos.Count > 0;
                        _removeListButton.Enabled = true;
                    }
                    _previousTodoListIndex = _todoListList.SelectedIndex;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Todos_ListChanged(object sender, ListChangedEventArgs e)
        {
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
                _todoGrid.Rows[e.NewIndex].Selected = true;
               _removeTodoButton.Enabled = true;
            }
            else if (e.ListChangedType == ListChangedType.ItemDeleted &&
                _model.TodoLists[_todoListList.SelectedIndex].Todos.Count == 0)
            {
                _removeTodoButton.Enabled = false;
            }
        }

        private void _removeTodoButton_Click(object sender, EventArgs e)
        {
            try
            {
                _model.TodoLists[_todoListList.SelectedIndex].Todos.RemoveAt(_todoGrid.CurrentRow.Index);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
