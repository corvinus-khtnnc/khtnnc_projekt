
namespace khtnnc_projekt
{
    partial class UserControl2
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl2));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tetelekSKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rendelesFKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.szindarabFKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.szindarabBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jegytipusFKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.jegytipusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mennyiségDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jegytipusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rendelesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.szindarabDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rendelesitetelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.rendelesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.szindarabBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jegytipusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rendelesitetelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rendelesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(27, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(213, 22);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBox1.DisplayMember = "Teljes_nev";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(27, 132);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(213, 452);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tetelekSKDataGridViewTextBoxColumn,
            this.rendelesFKDataGridViewTextBoxColumn,
            this.szindarabFKDataGridViewTextBoxColumn,
            this.jegytipusFKDataGridViewTextBoxColumn,
            this.mennyiségDataGridViewTextBoxColumn,
            this.jegytipusDataGridViewTextBoxColumn,
            this.rendelesDataGridViewTextBoxColumn,
            this.szindarabDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.rendelesitetelBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(279, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(920, 529);
            this.dataGridView1.TabIndex = 5;
            // 
            // tetelekSKDataGridViewTextBoxColumn
            // 
            this.tetelekSKDataGridViewTextBoxColumn.DataPropertyName = "TetelekSK";
            this.tetelekSKDataGridViewTextBoxColumn.HeaderText = "TetelekSK";
            this.tetelekSKDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tetelekSKDataGridViewTextBoxColumn.Name = "tetelekSKDataGridViewTextBoxColumn";
            this.tetelekSKDataGridViewTextBoxColumn.Width = 125;
            // 
            // rendelesFKDataGridViewTextBoxColumn
            // 
            this.rendelesFKDataGridViewTextBoxColumn.DataPropertyName = "RendelesFK";
            this.rendelesFKDataGridViewTextBoxColumn.HeaderText = "RendelesFK";
            this.rendelesFKDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rendelesFKDataGridViewTextBoxColumn.Name = "rendelesFKDataGridViewTextBoxColumn";
            this.rendelesFKDataGridViewTextBoxColumn.Width = 125;
            // 
            // szindarabFKDataGridViewTextBoxColumn
            // 
            this.szindarabFKDataGridViewTextBoxColumn.DataPropertyName = "SzindarabFK";
            this.szindarabFKDataGridViewTextBoxColumn.DataSource = this.szindarabBindingSource;
            this.szindarabFKDataGridViewTextBoxColumn.DisplayMember = "Cim";
            this.szindarabFKDataGridViewTextBoxColumn.HeaderText = "SzindarabFK";
            this.szindarabFKDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.szindarabFKDataGridViewTextBoxColumn.Name = "szindarabFKDataGridViewTextBoxColumn";
            this.szindarabFKDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.szindarabFKDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.szindarabFKDataGridViewTextBoxColumn.ValueMember = "SzindarabSK";
            this.szindarabFKDataGridViewTextBoxColumn.Width = 125;
            // 
            // szindarabBindingSource
            // 
            this.szindarabBindingSource.DataSource = typeof(khtnnc_projekt.Szindarab);
            // 
            // jegytipusFKDataGridViewTextBoxColumn
            // 
            this.jegytipusFKDataGridViewTextBoxColumn.DataPropertyName = "JegytipusFK";
            this.jegytipusFKDataGridViewTextBoxColumn.DataSource = this.jegytipusBindingSource;
            this.jegytipusFKDataGridViewTextBoxColumn.DisplayMember = "Megnevezes";
            this.jegytipusFKDataGridViewTextBoxColumn.HeaderText = "JegytipusFK";
            this.jegytipusFKDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.jegytipusFKDataGridViewTextBoxColumn.Name = "jegytipusFKDataGridViewTextBoxColumn";
            this.jegytipusFKDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.jegytipusFKDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.jegytipusFKDataGridViewTextBoxColumn.ValueMember = "JegytipusSK";
            this.jegytipusFKDataGridViewTextBoxColumn.Width = 125;
            // 
            // jegytipusBindingSource
            // 
            this.jegytipusBindingSource.DataSource = typeof(khtnnc_projekt.Jegytipus);
            // 
            // mennyiségDataGridViewTextBoxColumn
            // 
            this.mennyiségDataGridViewTextBoxColumn.DataPropertyName = "Mennyiség";
            this.mennyiségDataGridViewTextBoxColumn.HeaderText = "Mennyiség";
            this.mennyiségDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mennyiségDataGridViewTextBoxColumn.Name = "mennyiségDataGridViewTextBoxColumn";
            this.mennyiségDataGridViewTextBoxColumn.Width = 125;
            // 
            // jegytipusDataGridViewTextBoxColumn
            // 
            this.jegytipusDataGridViewTextBoxColumn.DataPropertyName = "Jegytipus";
            this.jegytipusDataGridViewTextBoxColumn.HeaderText = "Jegytipus";
            this.jegytipusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.jegytipusDataGridViewTextBoxColumn.Name = "jegytipusDataGridViewTextBoxColumn";
            this.jegytipusDataGridViewTextBoxColumn.Width = 125;
            // 
            // rendelesDataGridViewTextBoxColumn
            // 
            this.rendelesDataGridViewTextBoxColumn.DataPropertyName = "Rendeles";
            this.rendelesDataGridViewTextBoxColumn.HeaderText = "Rendeles";
            this.rendelesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rendelesDataGridViewTextBoxColumn.Name = "rendelesDataGridViewTextBoxColumn";
            this.rendelesDataGridViewTextBoxColumn.Width = 125;
            // 
            // szindarabDataGridViewTextBoxColumn
            // 
            this.szindarabDataGridViewTextBoxColumn.DataPropertyName = "Szindarab";
            this.szindarabDataGridViewTextBoxColumn.HeaderText = "Szindarab";
            this.szindarabDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.szindarabDataGridViewTextBoxColumn.Name = "szindarabDataGridViewTextBoxColumn";
            this.szindarabDataGridViewTextBoxColumn.Width = 125;
            // 
            // rendelesitetelBindingSource
            // 
            this.rendelesitetelBindingSource.DataSource = typeof(khtnnc_projekt.Rendelesi_tetel);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Szűrés vevőre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Vevő:";
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.rendelesitetelBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.toolStripButton1});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(1238, 27);
            this.bindingNavigator1.TabIndex = 10;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::khtnnc_projekt.Properties.Resources.Paomedia_Small_N_Flat_Floppy;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // rendelesBindingSource
            // 
            this.rendelesBindingSource.DataSource = typeof(khtnnc_projekt.Rendeles);
            // 
            // UserControl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Name = "UserControl2";
            this.Size = new System.Drawing.Size(1238, 621);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.szindarabBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jegytipusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rendelesitetelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rendelesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource rendelesitetelBindingSource;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.BindingSource rendelesBindingSource;
        private System.Windows.Forms.BindingSource szindarabBindingSource;
        private System.Windows.Forms.BindingSource jegytipusBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn tetelekSKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rendelesFKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn szindarabFKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn jegytipusFKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mennyiségDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jegytipusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rendelesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn szindarabDataGridViewTextBoxColumn;
    }
}
