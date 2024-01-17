namespace WarehouseAdmin
{
    partial class FormVenror
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableAdapterManager = new WarehouseAdmin.DataSetWTableAdapters.TableAdapterManager();
            this.персоналTableAdapter = new WarehouseAdmin.DataSetWTableAdapters.ПерсоналTableAdapter();
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.dataSetW = new WarehouseAdmin.DataSetW();
            this.label1 = new System.Windows.Forms.Label();
            this.labelClose = new System.Windows.Forms.Label();
            this.labelProgram = new System.Windows.Forms.Label();
            this.panelProgram = new System.Windows.Forms.Panel();
            this.pictureBoxMenu = new System.Windows.Forms.PictureBox();
            this.MenuContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonVendorAdd = new System.Windows.Forms.Button();
            this.buttonChangeInfoVendor = new System.Windows.Forms.Button();
            this.buttonDeleteVendor = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.персоналBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.персоналDataGridView = new System.Windows.Forms.DataGridView();
            this.кодПоставщикаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.адрессDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.телефонDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.поставщикBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.поставщикTableAdapter = new WarehouseAdmin.DataSetWTableAdapters.ПоставщикTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetW)).BeginInit();
            this.panelProgram.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMenu)).BeginInit();
            this.MenuContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.персоналBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.персоналDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = WarehouseAdmin.DataSetWTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.НакладнаяTableAdapter = null;
            this.tableAdapterManager.ПерсоналTableAdapter = this.персоналTableAdapter;
            this.tableAdapterManager.ПоставщикTableAdapter = null;
            this.tableAdapterManager.Приемка_ТовараTableAdapter = null;
            this.tableAdapterManager.СкладTableAdapter = null;
            this.tableAdapterManager.Товары_СкладаTableAdapter = null;
            // 
            // персоналTableAdapter
            // 
            this.персоналTableAdapter.ClearBeforeFill = true;
            // 
            // dataSetW
            // 
            this.dataSetW.DataSetName = "DataSetW";
            this.dataSetW.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkCyan;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1074, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 41);
            this.label1.TabIndex = 15;
            this.label1.Text = "_";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelClose
            // 
            this.labelClose.AutoSize = true;
            this.labelClose.BackColor = System.Drawing.Color.DarkCyan;
            this.labelClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelClose.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelClose.ForeColor = System.Drawing.Color.White;
            this.labelClose.Location = new System.Drawing.Point(1104, 0);
            this.labelClose.Name = "labelClose";
            this.labelClose.Size = new System.Drawing.Size(35, 41);
            this.labelClose.TabIndex = 14;
            this.labelClose.Text = "X";
            this.labelClose.Click += new System.EventHandler(this.labelClose_Click);
            // 
            // labelProgram
            // 
            this.labelProgram.AutoSize = true;
            this.labelProgram.BackColor = System.Drawing.Color.White;
            this.labelProgram.Font = new System.Drawing.Font("Segoe UI Semilight", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelProgram.ForeColor = System.Drawing.Color.Black;
            this.labelProgram.Location = new System.Drawing.Point(207, 17);
            this.labelProgram.Name = "labelProgram";
            this.labelProgram.Size = new System.Drawing.Size(640, 31);
            this.labelProgram.TabIndex = 13;
            this.labelProgram.Text = "Company Warehouse | (c) Andronov Andrew TUSUR 721-1 2023";
            // 
            // panelProgram
            // 
            this.panelProgram.BackColor = System.Drawing.Color.White;
            this.panelProgram.Controls.Add(this.label1);
            this.panelProgram.Controls.Add(this.labelClose);
            this.panelProgram.Controls.Add(this.labelProgram);
            this.panelProgram.Controls.Add(this.pictureBoxMenu);
            this.panelProgram.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelProgram.Location = new System.Drawing.Point(122, 0);
            this.panelProgram.Margin = new System.Windows.Forms.Padding(10);
            this.panelProgram.Name = "panelProgram";
            this.panelProgram.Size = new System.Drawing.Size(1139, 64);
            this.panelProgram.TabIndex = 17;
            // 
            // pictureBoxMenu
            // 
            this.pictureBoxMenu.Image = global::WarehouseAdmin.Properties.Resources.menuthreelinesbuttoninterfacesymbol_79952;
            this.pictureBoxMenu.Location = new System.Drawing.Point(27, 2);
            this.pictureBoxMenu.Name = "pictureBoxMenu";
            this.pictureBoxMenu.Size = new System.Drawing.Size(65, 59);
            this.pictureBoxMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxMenu.TabIndex = 12;
            this.pictureBoxMenu.TabStop = false;
            this.pictureBoxMenu.Click += new System.EventHandler(this.pictureBoxMenu_Click);
            // 
            // MenuContainer
            // 
            this.MenuContainer.BackColor = System.Drawing.Color.White;
            this.MenuContainer.Controls.Add(this.buttonVendorAdd);
            this.MenuContainer.Controls.Add(this.buttonChangeInfoVendor);
            this.MenuContainer.Controls.Add(this.buttonDeleteVendor);
            this.MenuContainer.Controls.Add(this.buttonBack);
            this.MenuContainer.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuContainer.Location = new System.Drawing.Point(0, 0);
            this.MenuContainer.Margin = new System.Windows.Forms.Padding(10);
            this.MenuContainer.Name = "MenuContainer";
            this.MenuContainer.Size = new System.Drawing.Size(122, 674);
            this.MenuContainer.TabIndex = 18;
            // 
            // buttonVendorAdd
            // 
            this.buttonVendorAdd.BackColor = System.Drawing.Color.White;
            this.buttonVendorAdd.FlatAppearance.BorderSize = 0;
            this.buttonVendorAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVendorAdd.Font = new System.Drawing.Font("Segoe UI Semilight", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonVendorAdd.ForeColor = System.Drawing.Color.Black;
            this.buttonVendorAdd.Image = global::WarehouseAdmin.Properties.Resources.icons8_добавить_30;
            this.buttonVendorAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonVendorAdd.Location = new System.Drawing.Point(3, 3);
            this.buttonVendorAdd.Name = "buttonVendorAdd";
            this.buttonVendorAdd.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.buttonVendorAdd.Size = new System.Drawing.Size(140, 81);
            this.buttonVendorAdd.TabIndex = 13;
            this.buttonVendorAdd.UseVisualStyleBackColor = false;
            this.buttonVendorAdd.Click += new System.EventHandler(this.buttonVendorAdd_Click);
            // 
            // buttonChangeInfoVendor
            // 
            this.buttonChangeInfoVendor.BackColor = System.Drawing.Color.White;
            this.buttonChangeInfoVendor.FlatAppearance.BorderSize = 0;
            this.buttonChangeInfoVendor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChangeInfoVendor.Font = new System.Drawing.Font("Segoe UI Semilight", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonChangeInfoVendor.ForeColor = System.Drawing.Color.Black;
            this.buttonChangeInfoVendor.Image = global::WarehouseAdmin.Properties.Resources.icons8_заменить_30;
            this.buttonChangeInfoVendor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonChangeInfoVendor.Location = new System.Drawing.Point(3, 90);
            this.buttonChangeInfoVendor.Name = "buttonChangeInfoVendor";
            this.buttonChangeInfoVendor.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.buttonChangeInfoVendor.Size = new System.Drawing.Size(140, 92);
            this.buttonChangeInfoVendor.TabIndex = 14;
            this.buttonChangeInfoVendor.UseVisualStyleBackColor = false;
            this.buttonChangeInfoVendor.Click += new System.EventHandler(this.buttonChangeInfoVendor_Click);
            // 
            // buttonDeleteVendor
            // 
            this.buttonDeleteVendor.BackColor = System.Drawing.Color.White;
            this.buttonDeleteVendor.FlatAppearance.BorderSize = 0;
            this.buttonDeleteVendor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteVendor.Font = new System.Drawing.Font("Segoe UI Semilight", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDeleteVendor.ForeColor = System.Drawing.Color.Black;
            this.buttonDeleteVendor.Image = global::WarehouseAdmin.Properties.Resources.icons8_удалить_30;
            this.buttonDeleteVendor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDeleteVendor.Location = new System.Drawing.Point(3, 188);
            this.buttonDeleteVendor.Name = "buttonDeleteVendor";
            this.buttonDeleteVendor.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.buttonDeleteVendor.Size = new System.Drawing.Size(140, 92);
            this.buttonDeleteVendor.TabIndex = 15;
            this.buttonDeleteVendor.UseVisualStyleBackColor = false;
            this.buttonDeleteVendor.Click += new System.EventHandler(this.buttonDeleteVendor_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.White;
            this.buttonBack.FlatAppearance.BorderSize = 0;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Font = new System.Drawing.Font("Segoe UI Semilight", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.ForeColor = System.Drawing.Color.Black;
            this.buttonBack.Image = global::WarehouseAdmin.Properties.Resources.icons8_назад_30;
            this.buttonBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBack.Location = new System.Drawing.Point(3, 286);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.buttonBack.Size = new System.Drawing.Size(126, 92);
            this.buttonBack.TabIndex = 16;
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // персоналBindingSource
            // 
            this.персоналBindingSource.DataMember = "Персонал";
            this.персоналBindingSource.DataSource = this.dataSetW;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.персоналDataGridView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(122, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1139, 610);
            this.panel1.TabIndex = 19;
            // 
            // персоналDataGridView
            // 
            this.персоналDataGridView.AutoGenerateColumns = false;
            this.персоналDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.персоналDataGridView.BackgroundColor = System.Drawing.Color.DarkCyan;
            this.персоналDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.персоналDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.персоналDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.персоналDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.персоналDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодПоставщикаDataGridViewTextBoxColumn,
            this.названиеDataGridViewTextBoxColumn,
            this.адрессDataGridViewTextBoxColumn,
            this.телефонDataGridViewTextBoxColumn});
            this.персоналDataGridView.DataSource = this.поставщикBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.персоналDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.персоналDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.персоналDataGridView.GridColor = System.Drawing.Color.White;
            this.персоналDataGridView.Location = new System.Drawing.Point(0, 0);
            this.персоналDataGridView.Name = "персоналDataGridView";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.персоналDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.персоналDataGridView.RowHeadersVisible = false;
            this.персоналDataGridView.RowHeadersWidth = 51;
            this.персоналDataGridView.RowTemplate.Height = 24;
            this.персоналDataGridView.Size = new System.Drawing.Size(1139, 610);
            this.персоналDataGridView.TabIndex = 17;
            this.персоналDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.персоналDataGridView_CellContentClick);
            // 
            // кодПоставщикаDataGridViewTextBoxColumn
            // 
            this.кодПоставщикаDataGridViewTextBoxColumn.DataPropertyName = "Код_Поставщика";
            this.кодПоставщикаDataGridViewTextBoxColumn.HeaderText = "  Код_Поставщика";
            this.кодПоставщикаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодПоставщикаDataGridViewTextBoxColumn.Name = "кодПоставщикаDataGridViewTextBoxColumn";
            this.кодПоставщикаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // названиеDataGridViewTextBoxColumn
            // 
            this.названиеDataGridViewTextBoxColumn.DataPropertyName = "Название";
            this.названиеDataGridViewTextBoxColumn.HeaderText = "Название";
            this.названиеDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.названиеDataGridViewTextBoxColumn.Name = "названиеDataGridViewTextBoxColumn";
            // 
            // адрессDataGridViewTextBoxColumn
            // 
            this.адрессDataGridViewTextBoxColumn.DataPropertyName = "Адресс";
            this.адрессDataGridViewTextBoxColumn.HeaderText = "Адресс";
            this.адрессDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.адрессDataGridViewTextBoxColumn.Name = "адрессDataGridViewTextBoxColumn";
            // 
            // телефонDataGridViewTextBoxColumn
            // 
            this.телефонDataGridViewTextBoxColumn.DataPropertyName = "Телефон";
            this.телефонDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.телефонDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.телефонDataGridViewTextBoxColumn.Name = "телефонDataGridViewTextBoxColumn";
            // 
            // поставщикBindingSource
            // 
            this.поставщикBindingSource.DataMember = "Поставщик";
            this.поставщикBindingSource.DataSource = this.dataSetW;
            // 
            // поставщикTableAdapter
            // 
            this.поставщикTableAdapter.ClearBeforeFill = true;
            // 
            // FormVenror
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 674);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelProgram);
            this.Controls.Add(this.MenuContainer);
            this.Name = "FormVenror";
            this.Load += new System.EventHandler(this.FormVenror_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetW)).EndInit();
            this.panelProgram.ResumeLayout(false);
            this.panelProgram.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMenu)).EndInit();
            this.MenuContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.персоналBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.персоналDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip4;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Timer timer1;
        private DataSetWTableAdapters.TableAdapterManager tableAdapterManager;
        private DataSetWTableAdapters.ПерсоналTableAdapter персоналTableAdapter;
        private System.Windows.Forms.ToolTip toolTip3;
        private DataSetW dataSetW;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelClose;
        private System.Windows.Forms.Label labelProgram;
        private System.Windows.Forms.PictureBox pictureBoxMenu;
        private System.Windows.Forms.Panel panelProgram;
        private System.Windows.Forms.Button buttonVendorAdd;
        private System.Windows.Forms.Button buttonChangeInfoVendor;
        private System.Windows.Forms.Button buttonDeleteVendor;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.FlowLayoutPanel MenuContainer;
        private System.Windows.Forms.BindingSource персоналBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView персоналDataGridView;
        private System.Windows.Forms.BindingSource поставщикBindingSource;
        private DataSetWTableAdapters.ПоставщикTableAdapter поставщикTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодПоставщикаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn адрессDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn телефонDataGridViewTextBoxColumn;
    }
}