namespace WarehouseAdmin
{
    partial class FormWare
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.персоналDataGridView = new System.Windows.Forms.DataGridView();
            this.номерСкладаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.адрессDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.описаниеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.вместимостьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.складBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetW = new WarehouseAdmin.DataSetW();
            this.персоналBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.tableAdapterManager = new WarehouseAdmin.DataSetWTableAdapters.TableAdapterManager();
            this.персоналTableAdapter = new WarehouseAdmin.DataSetWTableAdapters.ПерсоналTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.labelClose = new System.Windows.Forms.Label();
            this.labelProgram = new System.Windows.Forms.Label();
            this.panelProgram = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBoxMenu = new System.Windows.Forms.PictureBox();
            this.MenuContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonWareAdd = new System.Windows.Forms.Button();
            this.buttonChangeInfoWare = new System.Windows.Forms.Button();
            this.buttonDeleteWare = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.накладнаяTableAdapter = new WarehouseAdmin.DataSetWTableAdapters.НакладнаяTableAdapter();
            this.складTableAdapter = new WarehouseAdmin.DataSetWTableAdapters.СкладTableAdapter();
            this.fKНакладнаяКодС440B1D61BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelV = new System.Windows.Forms.Label();
            this.labelVcryt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.персоналDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.складBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.персоналBindingSource)).BeginInit();
            this.panelProgram.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMenu)).BeginInit();
            this.MenuContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fKНакладнаяКодС440B1D61BindingSource)).BeginInit();
            this.SuspendLayout();
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
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.персоналDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.персоналDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.персоналDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.номерСкладаDataGridViewTextBoxColumn,
            this.названиеDataGridViewTextBoxColumn,
            this.адрессDataGridViewTextBoxColumn,
            this.описаниеDataGridViewTextBoxColumn,
            this.вместимостьDataGridViewTextBoxColumn});
            this.персоналDataGridView.DataSource = this.складBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.персоналDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.персоналDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.персоналDataGridView.GridColor = System.Drawing.Color.White;
            this.персоналDataGridView.Location = new System.Drawing.Point(122, 64);
            this.персоналDataGridView.Name = "персоналDataGridView";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.персоналDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.персоналDataGridView.RowHeadersVisible = false;
            this.персоналDataGridView.RowHeadersWidth = 51;
            this.персоналDataGridView.RowTemplate.Height = 24;
            this.персоналDataGridView.Size = new System.Drawing.Size(1126, 623);
            this.персоналDataGridView.TabIndex = 19;
            // 
            // номерСкладаDataGridViewTextBoxColumn
            // 
            this.номерСкладаDataGridViewTextBoxColumn.DataPropertyName = "Номер_Склада";
            this.номерСкладаDataGridViewTextBoxColumn.HeaderText = "    Номер_Склада";
            this.номерСкладаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.номерСкладаDataGridViewTextBoxColumn.Name = "номерСкладаDataGridViewTextBoxColumn";
            this.номерСкладаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // названиеDataGridViewTextBoxColumn
            // 
            this.названиеDataGridViewTextBoxColumn.DataPropertyName = "Название";
            this.названиеDataGridViewTextBoxColumn.HeaderText = "     Название";
            this.названиеDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.названиеDataGridViewTextBoxColumn.Name = "названиеDataGridViewTextBoxColumn";
            // 
            // адрессDataGridViewTextBoxColumn
            // 
            this.адрессDataGridViewTextBoxColumn.DataPropertyName = "Адресс";
            this.адрессDataGridViewTextBoxColumn.HeaderText = "   Адресс";
            this.адрессDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.адрессDataGridViewTextBoxColumn.Name = "адрессDataGridViewTextBoxColumn";
            // 
            // описаниеDataGridViewTextBoxColumn
            // 
            this.описаниеDataGridViewTextBoxColumn.DataPropertyName = "Описание";
            this.описаниеDataGridViewTextBoxColumn.HeaderText = "   Описание";
            this.описаниеDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.описаниеDataGridViewTextBoxColumn.Name = "описаниеDataGridViewTextBoxColumn";
            // 
            // вместимостьDataGridViewTextBoxColumn
            // 
            this.вместимостьDataGridViewTextBoxColumn.DataPropertyName = "Вместимость";
            dataGridViewCellStyle2.Format = ". м/кв";
            dataGridViewCellStyle2.NullValue = null;
            this.вместимостьDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.вместимостьDataGridViewTextBoxColumn.HeaderText = "     Вместимость";
            this.вместимостьDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.вместимостьDataGridViewTextBoxColumn.Name = "вместимостьDataGridViewTextBoxColumn";
            // 
            // складBindingSource
            // 
            this.складBindingSource.DataMember = "Склад";
            this.складBindingSource.DataSource = this.dataSetW;
            // 
            // dataSetW
            // 
            this.dataSetW.DataSetName = "DataSetW";
            this.dataSetW.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // персоналBindingSource
            // 
            this.персоналBindingSource.DataMember = "Персонал";
            this.персоналBindingSource.DataSource = this.dataSetW;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkCyan;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1274, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 41);
            this.label1.TabIndex = 15;
            this.label1.Text = "_";
            // 
            // labelClose
            // 
            this.labelClose.AutoSize = true;
            this.labelClose.BackColor = System.Drawing.Color.DarkCyan;
            this.labelClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelClose.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelClose.ForeColor = System.Drawing.Color.White;
            this.labelClose.Location = new System.Drawing.Point(1301, 9);
            this.labelClose.Name = "labelClose";
            this.labelClose.Size = new System.Drawing.Size(35, 41);
            this.labelClose.TabIndex = 14;
            this.labelClose.Text = "X";
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
            this.panelProgram.Controls.Add(this.label2);
            this.panelProgram.Controls.Add(this.label3);
            this.panelProgram.Controls.Add(this.label1);
            this.panelProgram.Controls.Add(this.labelClose);
            this.panelProgram.Controls.Add(this.labelProgram);
            this.panelProgram.Controls.Add(this.pictureBoxMenu);
            this.panelProgram.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelProgram.Location = new System.Drawing.Point(122, 0);
            this.panelProgram.Margin = new System.Windows.Forms.Padding(10);
            this.panelProgram.Name = "panelProgram";
            this.panelProgram.Size = new System.Drawing.Size(1126, 64);
            this.panelProgram.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkCyan;
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1061, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 41);
            this.label2.TabIndex = 17;
            this.label2.Text = "_";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkCyan;
            this.label3.Dock = System.Windows.Forms.DockStyle.Right;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1091, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 41);
            this.label3.TabIndex = 16;
            this.label3.Text = "X";
            this.label3.Click += new System.EventHandler(this.label3_Click);
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
            this.MenuContainer.Controls.Add(this.buttonWareAdd);
            this.MenuContainer.Controls.Add(this.buttonChangeInfoWare);
            this.MenuContainer.Controls.Add(this.buttonDeleteWare);
            this.MenuContainer.Controls.Add(this.buttonBack);
            this.MenuContainer.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuContainer.Location = new System.Drawing.Point(0, 0);
            this.MenuContainer.Margin = new System.Windows.Forms.Padding(10);
            this.MenuContainer.Name = "MenuContainer";
            this.MenuContainer.Size = new System.Drawing.Size(122, 687);
            this.MenuContainer.TabIndex = 18;
            // 
            // buttonWareAdd
            // 
            this.buttonWareAdd.BackColor = System.Drawing.Color.White;
            this.buttonWareAdd.FlatAppearance.BorderSize = 0;
            this.buttonWareAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWareAdd.Font = new System.Drawing.Font("Segoe UI Semilight", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonWareAdd.ForeColor = System.Drawing.Color.Black;
            this.buttonWareAdd.Image = global::WarehouseAdmin.Properties.Resources.icons8_добавить_30;
            this.buttonWareAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonWareAdd.Location = new System.Drawing.Point(3, 3);
            this.buttonWareAdd.Name = "buttonWareAdd";
            this.buttonWareAdd.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.buttonWareAdd.Size = new System.Drawing.Size(140, 81);
            this.buttonWareAdd.TabIndex = 13;
            this.buttonWareAdd.UseVisualStyleBackColor = false;
            this.buttonWareAdd.Click += new System.EventHandler(this.buttonWareAdd_Click);
            // 
            // buttonChangeInfoWare
            // 
            this.buttonChangeInfoWare.BackColor = System.Drawing.Color.White;
            this.buttonChangeInfoWare.FlatAppearance.BorderSize = 0;
            this.buttonChangeInfoWare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChangeInfoWare.Font = new System.Drawing.Font("Segoe UI Semilight", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonChangeInfoWare.ForeColor = System.Drawing.Color.Black;
            this.buttonChangeInfoWare.Image = global::WarehouseAdmin.Properties.Resources.icons8_заменить_30;
            this.buttonChangeInfoWare.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonChangeInfoWare.Location = new System.Drawing.Point(3, 90);
            this.buttonChangeInfoWare.Name = "buttonChangeInfoWare";
            this.buttonChangeInfoWare.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.buttonChangeInfoWare.Size = new System.Drawing.Size(140, 92);
            this.buttonChangeInfoWare.TabIndex = 14;
            this.buttonChangeInfoWare.UseVisualStyleBackColor = false;
            this.buttonChangeInfoWare.Click += new System.EventHandler(this.buttonChangeInfoWare_Click);
            // 
            // buttonDeleteWare
            // 
            this.buttonDeleteWare.BackColor = System.Drawing.Color.White;
            this.buttonDeleteWare.FlatAppearance.BorderSize = 0;
            this.buttonDeleteWare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteWare.Font = new System.Drawing.Font("Segoe UI Semilight", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDeleteWare.ForeColor = System.Drawing.Color.Black;
            this.buttonDeleteWare.Image = global::WarehouseAdmin.Properties.Resources.icons8_удалить_30;
            this.buttonDeleteWare.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDeleteWare.Location = new System.Drawing.Point(3, 188);
            this.buttonDeleteWare.Name = "buttonDeleteWare";
            this.buttonDeleteWare.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.buttonDeleteWare.Size = new System.Drawing.Size(140, 92);
            this.buttonDeleteWare.TabIndex = 15;
            this.buttonDeleteWare.UseVisualStyleBackColor = false;
            this.buttonDeleteWare.Click += new System.EventHandler(this.buttonDeleteWare_Click);
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
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click_1);
            // 
            // накладнаяTableAdapter
            // 
            this.накладнаяTableAdapter.ClearBeforeFill = true;
            // 
            // складTableAdapter
            // 
            this.складTableAdapter.ClearBeforeFill = true;
            // 
            // fKНакладнаяКодС440B1D61BindingSource
            // 
            this.fKНакладнаяКодС440B1D61BindingSource.DataMember = "FK__Накладная__Код_С__440B1D61";
            this.fKНакладнаяКодС440B1D61BindingSource.DataSource = this.персоналBindingSource;
            // 
            // labelV
            // 
            this.labelV.AutoSize = true;
            this.labelV.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelV.Location = new System.Drawing.Point(988, 591);
            this.labelV.Name = "labelV";
            this.labelV.Size = new System.Drawing.Size(67, 28);
            this.labelV.TabIndex = 20;
            this.labelV.Text = "label4";
            // 
            // labelVcryt
            // 
            this.labelVcryt.AutoSize = true;
            this.labelVcryt.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelVcryt.Location = new System.Drawing.Point(321, 591);
            this.labelVcryt.Name = "labelVcryt";
            this.labelVcryt.Size = new System.Drawing.Size(67, 28);
            this.labelVcryt.TabIndex = 21;
            this.labelVcryt.Text = "label4";
            this.labelVcryt.Visible = false;
            // 
            // FormWare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 687);
            this.Controls.Add(this.labelVcryt);
            this.Controls.Add(this.labelV);
            this.Controls.Add(this.персоналDataGridView);
            this.Controls.Add(this.panelProgram);
            this.Controls.Add(this.MenuContainer);
            this.Name = "FormWare";
            this.Load += new System.EventHandler(this.FormWare_Load);
            ((System.ComponentModel.ISupportInitialize)(this.персоналDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.складBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.персоналBindingSource)).EndInit();
            this.panelProgram.ResumeLayout(false);
            this.panelProgram.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMenu)).EndInit();
            this.MenuContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fKНакладнаяКодС440B1D61BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip4;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView персоналDataGridView;
        private System.Windows.Forms.BindingSource персоналBindingSource;
        private DataSetW dataSetW;
        private System.Windows.Forms.ToolTip toolTip3;
        private DataSetWTableAdapters.TableAdapterManager tableAdapterManager;
        private DataSetWTableAdapters.ПерсоналTableAdapter персоналTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelClose;
        private System.Windows.Forms.Label labelProgram;
        private System.Windows.Forms.PictureBox pictureBoxMenu;
        private System.Windows.Forms.Panel panelProgram;
        private System.Windows.Forms.Button buttonWareAdd;
        private System.Windows.Forms.Button buttonDeleteWare;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.FlowLayoutPanel MenuContainer;
        private System.Windows.Forms.BindingSource fKНакладнаяКодС440B1D61BindingSource;
        private DataSetWTableAdapters.НакладнаяTableAdapter накладнаяTableAdapter;
        private System.Windows.Forms.BindingSource складBindingSource;
        private DataSetWTableAdapters.СкладTableAdapter складTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonChangeInfoWare;
        private System.Windows.Forms.Label labelV;
        private System.Windows.Forms.Label labelVcryt;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерСкладаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn адрессDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn описаниеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn вместимостьDataGridViewTextBoxColumn;
    }
}