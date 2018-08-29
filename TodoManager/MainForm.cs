using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
                _todoListGrid.DataSource = _model.TodoLists;
                _model.TodoLists.ListChanged += TodoLists_ListChanged;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TodoLists_ListChanged(object sender, ListChangedEventArgs e)
        {
            AdjustGridSelection(_todoListGrid, e);
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
                _removeListButton.Enabled = true;
            }
            else if (e.ListChangedType == ListChangedType.ItemDeleted && _model.TodoLists.Count == 0)
            {
                _removeListButton.Enabled = false;
                _addTodoButton.Enabled = false;
            }
        }

        private void AdjustGridSelection(DataGridView grid, ListChangedEventArgs e)
        {
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
                grid.Rows[e.NewIndex].Selected = true;
            }
            else if (e.ListChangedType == ListChangedType.ItemDeleted)
            {
                if (grid.Rows.Count > 0)
                {
                    // select last in list if last item was removed
                    int index = e.NewIndex < grid.Rows.Count ? e.NewIndex : grid.Rows.Count - 1;
                    grid.Rows[index].Selected = true;
                }
            }
            else
            {
                throw new InvalidOperationException("Unrecognized list change type.");
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
                int index = GetSelectedRowIndex(_todoListGrid);
                _model.TodoLists[index].Todos.ListChanged -= Todos_ListChanged;

                // and remove todo list
                _model.TodoLists.RemoveAt(index);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private int GetSelectedRowIndex(DataGridView grid)
        {
            Debug.Assert(grid.SelectionMode == DataGridViewSelectionMode.FullRowSelect);
            if (grid.SelectedRows.Count == 0)
            {
                return -1;
            }
            else
            {
                return grid.SelectedRows[0].Index;
            }
        }

        private void _addTodoButton_Click(object sender, EventArgs e)
        {
            try
            {
                var dialog = new AddTodo();
                if (dialog.ShowDialog(this) == DialogResult.OK)
                {
                    _model.TodoLists[GetSelectedRowIndex(_todoListGrid)].Todos.Add(new Todo(dialog.Task));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Todos_ListChanged(object sender, ListChangedEventArgs e)
        {
            AdjustGridSelection(_todoGrid, e);
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
               _removeTodoButton.Enabled = true;
            }
            else if (e.ListChangedType == ListChangedType.ItemDeleted &&
                _model.TodoLists[GetSelectedRowIndex(_todoListGrid)].Todos.Count == 0)
            {
                _removeTodoButton.Enabled = false;
            }
        }

        private void _removeTodoButton_Click(object sender, EventArgs e)
        {
            try
            {
                _model.TodoLists[GetSelectedRowIndex(_todoListGrid)].Todos.RemoveAt(GetSelectedRowIndex(_todoGrid));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void _todoListGrid_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (_todoListGrid.Rows.Count == 0)
                {
                    _removeTodoButton.Enabled = false;
                }
                else
                {
                    int index = GetSelectedRowIndex(_todoListGrid);
                    if (index >= 0)
                    {
                        // bind new data source
                        var todos = _model.TodoLists[index].Todos;
                        _todoGrid.DataSource = todos;
                        todos.ListChanged += Todos_ListChanged;
                        _addTodoButton.Enabled = true;
                        _removeTodoButton.Enabled = todos.Count > 0;
                        _removeListButton.Enabled = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
