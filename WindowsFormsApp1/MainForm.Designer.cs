namespace TodoList
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
            this._todoListList = new System.Windows.Forms.ListBox();
            this._listToolbar = new System.Windows.Forms.ToolStrip();
            this._addListButton = new System.Windows.Forms.ToolStripButton();
            this._removeListButton = new System.Windows.Forms.ToolStripButton();
            this._todoList = new System.Windows.Forms.CheckedListBox();
            this._todoToolbar = new System.Windows.Forms.ToolStrip();
            this._addTodoButton = new System.Windows.Forms.ToolStripButton();
            this._removeTodoButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this._splitContainer)).BeginInit();
            this._splitContainer.Panel1.SuspendLayout();
            this._splitContainer.Panel2.SuspendLayout();
            this._splitContainer.SuspendLayout();
            this._listToolbar.SuspendLayout();
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
            this._splitContainer.Panel1.Controls.Add(this._todoListList);
            this._splitContainer.Panel1.Controls.Add(this._listToolbar);
            // 
            // _splitContainer.Panel2
            // 
            this._splitContainer.Panel2.Controls.Add(this._todoList);
            this._splitContainer.Panel2.Controls.Add(this._todoToolbar);
            this._splitContainer.Size = new System.Drawing.Size(800, 450);
            this._splitContainer.SplitterDistance = 266;
            this._splitContainer.TabIndex = 0;
            // 
            // _todoListList
            // 
            this._todoListList.Dock = System.Windows.Forms.DockStyle.Fill;
            this._todoListList.FormattingEnabled = true;
            this._todoListList.IntegralHeight = false;
            this._todoListList.Location = new System.Drawing.Point(0, 0);
            this._todoListList.Name = "_todoListList";
            this._todoListList.Size = new System.Drawing.Size(266, 425);
            this._todoListList.TabIndex = 1;
            this._todoListList.SelectedIndexChanged += new System.EventHandler(this._todoListList_SelectedIndexChanged);
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
            this._listToolbar.Size = new System.Drawing.Size(266, 25);
            this._listToolbar.TabIndex = 0;
            this._listToolbar.Text = "toolStrip1";
            // 
            // _addListButton
            // 
            this._addListButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._addListButton.Image = global::TodoList.Properties.Resources.Add;
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
            this._removeListButton.Image = global::TodoList.Properties.Resources.Remove;
            this._removeListButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._removeListButton.Name = "_removeListButton";
            this._removeListButton.Size = new System.Drawing.Size(23, 22);
            this._removeListButton.Text = "toolStripButton1";
            this._removeListButton.Click += new System.EventHandler(this._removeListButton_Click);
            // 
            // _todoList
            // 
            this._todoList.Dock = System.Windows.Forms.DockStyle.Fill;
            this._todoList.FormattingEnabled = true;
            this._todoList.IntegralHeight = false;
            this._todoList.Location = new System.Drawing.Point(0, 0);
            this._todoList.Name = "_todoList";
            this._todoList.Size = new System.Drawing.Size(530, 425);
            this._todoList.TabIndex = 1;
            // 
            // _todoToolbar
            // 
            this._todoToolbar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._todoToolbar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this._todoToolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._addTodoButton,
            this._removeTodoButton});
            this._todoToolbar.Location = new System.Drawing.Point(0, 425);
            this._todoToolbar.Name = "_todoToolbar";
            this._todoToolbar.Size = new System.Drawing.Size(530, 25);
            this._todoToolbar.TabIndex = 0;
            this._todoToolbar.Text = "toolStrip2";
            // 
            // _addTodoButton
            // 
            this._addTodoButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._addTodoButton.Enabled = false;
            this._addTodoButton.Image = global::TodoList.Properties.Resources.Add;
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
            this._removeTodoButton.Image = global::TodoList.Properties.Resources.Remove;
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
            this._splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._splitContainer)).EndInit();
            this._splitContainer.ResumeLayout(false);
            this._listToolbar.ResumeLayout(false);
            this._listToolbar.PerformLayout();
            this._todoToolbar.ResumeLayout(false);
            this._todoToolbar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer _splitContainer;
        private System.Windows.Forms.ToolStrip _listToolbar;
        private System.Windows.Forms.ToolStrip _todoToolbar;
        private System.Windows.Forms.ListBox _todoListList;
        private System.Windows.Forms.CheckedListBox _todoList;
        private System.Windows.Forms.ToolStripButton _addListButton;
        private System.Windows.Forms.ToolStripButton _addTodoButton;
        private System.Windows.Forms.ToolStripButton _removeListButton;
        private System.Windows.Forms.ToolStripButton _removeTodoButton;
    }
}