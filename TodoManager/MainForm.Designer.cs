namespace TodoManager
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._splitContainer = new System.Windows.Forms.SplitContainer();
            this._todoListGrid = new System.Windows.Forms.DataGridView();
            this._listToolbar = new System.Windows.Forms.ToolStrip();
            this._addListButton = new System.Windows.Forms.ToolStripButton();
            this._removeListButton = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this._todoGrid = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this._todoToolbar = new System.Windows.Forms.ToolStrip();
            this._addTodoButton = new System.Windows.Forms.ToolStripButton();
            this._removeTodoButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this._splitContainer)).BeginInit();
            this._splitContainer.Panel1.SuspendLayout();
            this._splitContainer.Panel2.SuspendLayout();
            this._splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._todoListGrid)).BeginInit();
            this._listToolbar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._todoGrid)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this._todoToolbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // _splitContainer
            // 
            this._splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this._splitContainer.Location = new System.Drawing.Point(0, 0);
            this._splitContainer.Name = "_splitContainer";
            // 
            // _splitContainer.Panel1
            // 
            this._splitContainer.Panel1.Controls.Add(this._todoListGrid);
            this._splitContainer.Panel1.Controls.Add(this._listToolbar);
            // 
            // _splitContainer.Panel2
            // 
            this._splitContainer.Panel2.Controls.Add(this.panel1);
            this._splitContainer.Panel2.Controls.Add(this.tableLayoutPanel1);
            this._splitContainer.Size = new System.Drawing.Size(800, 450);
            this._splitContainer.SplitterDistance = 200;
            this._splitContainer.TabIndex = 0;
            // 
            // _todoListGrid
            // 
            this._todoListGrid.AllowUserToAddRows = false;
            this._todoListGrid.AllowUserToDeleteRows = false;
            this._todoListGrid.AllowUserToResizeRows = false;
            this._todoListGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._todoListGrid.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this._todoListGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._todoListGrid.ColumnHeadersVisible = false;
            this._todoListGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this._todoListGrid.Location = new System.Drawing.Point(0, 0);
            this._todoListGrid.MultiSelect = false;
            this._todoListGrid.Name = "_todoListGrid";
            this._todoListGrid.RowHeadersVisible = false;
            this._todoListGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._todoListGrid.Size = new System.Drawing.Size(200, 425);
            this._todoListGrid.TabIndex = 1;
            this._todoListGrid.SelectionChanged += new System.EventHandler(this._todoListGrid_SelectionChanged);
            // 
            // _listToolbar
            // 
            this._listToolbar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._listToolbar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this._listToolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._addListButton,
            this._removeListButton});
            this._listToolbar.Location = new System.Drawing.Point(0, 425);
            this._listToolbar.Name = "_listToolbar";
            this._listToolbar.Size = new System.Drawing.Size(200, 25);
            this._listToolbar.TabIndex = 0;
            this._listToolbar.Text = "toolStrip1";
            // 
            // _addListButton
            // 
            this._addListButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._addListButton.Image = global::TodoManager.Properties.Resources.Add;
            this._addListButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._addListButton.Name = "_addListButton";
            this._addListButton.Size = new System.Drawing.Size(23, 22);
            this._addListButton.Text = "toolStripButton1";
            this._addListButton.Click += new System.EventHandler(this._addListButton_Click);
            // 
            // _removeListButton
            // 
            this._removeListButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._removeListButton.Enabled = false;
            this._removeListButton.Image = global::TodoManager.Properties.Resources.Remove;
            this._removeListButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._removeListButton.Name = "_removeListButton";
            this._removeListButton.Size = new System.Drawing.Size(23, 22);
            this._removeListButton.Text = "toolStripButton1";
            this._removeListButton.Click += new System.EventHandler(this._removeListButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this._todoGrid);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(596, 390);
            this.panel1.TabIndex = 3;
            // 
            // _todoGrid
            // 
            this._todoGrid.AllowUserToAddRows = false;
            this._todoGrid.AllowUserToDeleteRows = false;
            this._todoGrid.AllowUserToResizeRows = false;
            this._todoGrid.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this._todoGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._todoGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this._todoGrid.Location = new System.Drawing.Point(0, 0);
            this._todoGrid.MultiSelect = false;
            this._todoGrid.Name = "_todoGrid";
            this._todoGrid.RowHeadersVisible = false;
            this._todoGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._todoGrid.Size = new System.Drawing.Size(596, 390);
            this._todoGrid.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this._todoToolbar, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(596, 60);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // _todoToolbar
            // 
            this._todoToolbar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._todoToolbar.Dock = System.Windows.Forms.DockStyle.None;
            this._todoToolbar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this._todoToolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._addTodoButton,
            this._removeTodoButton});
            this._todoToolbar.Location = new System.Drawing.Point(547, 35);
            this._todoToolbar.Name = "_todoToolbar";
            this._todoToolbar.Size = new System.Drawing.Size(49, 25);
            this._todoToolbar.TabIndex = 0;
            this._todoToolbar.Text = "toolStrip2";
            // 
            // _addTodoButton
            // 
            this._addTodoButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._addTodoButton.Enabled = false;
            this._addTodoButton.Image = global::TodoManager.Properties.Resources.Add;
            this._addTodoButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._addTodoButton.Name = "_addTodoButton";
            this._addTodoButton.Size = new System.Drawing.Size(23, 22);
            this._addTodoButton.Text = "toolStripButton1";
            this._addTodoButton.Click += new System.EventHandler(this._addTodoButton_Click);
            // 
            // _removeTodoButton
            // 
            this._removeTodoButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._removeTodoButton.Enabled = false;
            this._removeTodoButton.Image = global::TodoManager.Properties.Resources.Remove;
            this._removeTodoButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._removeTodoButton.Name = "_removeTodoButton";
            this._removeTodoButton.Size = new System.Drawing.Size(23, 22);
            this._removeTodoButton.Text = "toolStripButton1";
            this._removeTodoButton.Click += new System.EventHandler(this._removeTodoButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._splitContainer);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "To-Do Manager";
            this._splitContainer.Panel1.ResumeLayout(false);
            this._splitContainer.Panel1.PerformLayout();
            this._splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._splitContainer)).EndInit();
            this._splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._todoListGrid)).EndInit();
            this._listToolbar.ResumeLayout(false);
            this._listToolbar.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._todoGrid)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this._todoToolbar.ResumeLayout(false);
            this._todoToolbar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer _splitContainer;
        private System.Windows.Forms.ToolStrip _listToolbar;
        private System.Windows.Forms.ToolStrip _todoToolbar;
        private System.Windows.Forms.ToolStripButton _addListButton;
        private System.Windows.Forms.ToolStripButton _addTodoButton;
        private System.Windows.Forms.ToolStripButton _removeListButton;
        private System.Windows.Forms.ToolStripButton _removeTodoButton;
        private System.Windows.Forms.DataGridView _todoGrid;
        private System.Windows.Forms.DataGridView _todoListGrid;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
    }
}