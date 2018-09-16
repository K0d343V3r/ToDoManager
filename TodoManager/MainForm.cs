using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;
using TodoManager.Extensions;
using TodoManager.Models;
using TodoManager.Proxies;

namespace TodoManager
{
    public partial class MainForm : Form
    {
        private MainModel _model;

        public MainForm(MainModel model)
        {
            _model = model;
            InitializeComponent();
            InitializeTodoGrids();
            _todoToolbar.MakeTransparent();
            _listToolbar.MakeTransparent();
            _todoBanner.Title = Properties.Resources.TXT_No_Todo_Lists;
        }

        private void InitializeTodoGrids()
        {
            // initialize todo list grid
            _todoListGrid.AutoGenerateColumns = false;
            var column1 = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Name",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            };
            _todoListGrid.Columns.Add(column1);

            // initialize todo list item grid
            _todoGrid.AutoGenerateColumns = false;
            var column2 = new DataGridViewCheckBoxColumn
            {
                DataPropertyName = "Done",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            };
            _todoGrid.Columns.Add(column2);
            var column3 = new DataGridViewTextBoxColumn
            {
                HeaderText = "Task",
                DataPropertyName = "Task",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            };
            _todoGrid.Columns.Add(column3);
        }

        protected override void OnLoad(EventArgs e)
        {
            try
            {
                base.OnLoad(e);
                _todoListGrid.DataSource = _model.BindableLists;
                _model.BindableLists.ListChanged += TodoLists_ListChanged;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TodoLists_ListChanged(object sender, ListChangedEventArgs e)
        {
            AdjustGridSelection(_todoListGrid, e);
            switch (e.ListChangedType)
            { 
                case ListChangedType.ItemAdded:
                    _removeListButton.Enabled = true;
                    break;

                case ListChangedType.ItemDeleted:
                    if (_model.BindableLists.Count == 0)
                    {
                        _removeListButton.Enabled = false;
                        _addTodoButton.Enabled = false;
                    }
                    break;

                case ListChangedType.ItemChanged:
                    break;
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
        }

        private void _addListButton_Click(object sender, EventArgs e)
        {
            try
            {
                var dialog = new AddTodoList();
                if (dialog.ShowDialog(this) == DialogResult.OK)
                {
                    _model.BindableLists.Add(new TodoList(dialog.NewName));
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
                _model.BindableLists[index].BindableItems.ListChanged -= Todos_ListChanged;

                // and remove todo list
                _model.BindableLists.RemoveAt(index);
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
                    _model.BindableLists[GetSelectedRowIndex(_todoListGrid)].BindableItems.Add(new TodoListItem(dialog.Task));
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
                _model.BindableLists[GetSelectedRowIndex(_todoListGrid)].BindableItems.Count == 0)
            {
                _removeTodoButton.Enabled = false;
            }
        }

        private void _removeTodoButton_Click(object sender, EventArgs e)
        {
            try
            {
                _model.BindableLists[GetSelectedRowIndex(_todoListGrid)].BindableItems.RemoveAt(GetSelectedRowIndex(_todoGrid));
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
                int index = GetSelectedRowIndex(_todoListGrid);
                if (_todoListGrid.Rows.Count == 0 || index < 0)
                {
                    _removeTodoButton.Enabled = false;
                    _todoBanner.Title = Properties.Resources.TXT_No_Todo_Lists;
                }
                else
                {
                    // rebind new data source
                    var todos = _model.BindableLists[index].BindableItems;
                    _todoGrid.DataSource = todos;
                    todos.ListChanged += Todos_ListChanged;

                    // adjust toolbar buttons
                    _addTodoButton.Enabled = true;
                    _removeTodoButton.Enabled = todos.Count > 0;
                    _removeListButton.Enabled = true;
                    
                    // and update title
                    _todoBanner.Title = _model.BindableLists[index].Name;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
