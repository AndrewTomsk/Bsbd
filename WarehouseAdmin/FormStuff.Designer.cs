namespace WarehouseAdmin
{
    partial class FormStuff
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
            this.MenuContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonStuffAdd = new System.Windows.Forms.Button();
            this.buttonChangeInfoStuff = new System.Windows.Forms.Button();
            this.buttonDeleteStuff = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.panelProgram = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelClose = new System.Windows.Forms.Label();
            this.labelProgram = new System.Windows.Forms.Label();
            this.pictureBoxMenu = new System.Windows.Forms.PictureBox();
            this.dataSetW = new WarehouseAdmin.DataSetW();
            this.персоналBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.персоналTableAdapter = new WarehouseAdmin.DataSetWTableAdapters.ПерсоналTableAdapter();
            this.tableAdapterManager = new WarehouseAdmin.DataSetWTableAdapters.TableAdapterManager();
            this.персоналDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.MenuContainer.SuspendLayout();
            this.panelProgram.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.персоналBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.персоналDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuContainer
            // 
            this.MenuContainer.BackColor = System.Drawing.Color.White;
            this.MenuContainer.Controls.Add(this.buttonStuffAdd);
            this.MenuContainer.Controls.Add(this.buttonChangeInfoStuff);
            this.MenuContainer.Controls.Add(this.buttonDeleteStuff);
            this.MenuContainer.Controls.Add(this.buttonBack);
            this.MenuContainer.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuContainer.Location = new System.Drawing.Point(0, 64);
            this.MenuContainer.Margin = new System.Windows.Forms.Padding(10);
            this.MenuContainer.Name = "MenuContainer";
            this.MenuContainer.Size = new System.Drawing.Size(122, 546);
            this.MenuContainer.TabIndex = 15;
            // 
            // buttonStuffAdd
            // 
            this.buttonStuffAdd.BackColor = System.Drawing.Color.White;
            this.buttonStuffAdd.FlatAppearance.BorderSize = 0;
            this.buttonStuffAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStuffAdd.Font = new System.Drawing.Font("Segoe UI Semilight", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStuffAdd.ForeColor = System.Drawing.Color.Black;
            this.buttonStuffAdd.Image = global::WarehouseAdmin.Properties.Resources.icons8_добавить_30;
            this.buttonStuffAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStuffAdd.Location = new System.Drawing.Point(3, 3);
            this.buttonStuffAdd.Name = "buttonStuffAdd";
            this.buttonStuffAdd.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.buttonStuffAdd.Size = new System.Drawing.Size(140, 81);
            this.buttonStuffAdd.TabIndex = 13;
            this.buttonStuffAdd.UseVisualStyleBackColor = false;
            this.buttonStuffAdd.Click += new System.EventHandler(this.buttonStuffAdd_Click);
            // 
            // buttonChangeInfoStuff
            // 
            this.buttonChangeInfoStuff.BackColor = System.Drawing.Color.White;
            this.buttonChangeInfoStuff.FlatAppearance.BorderSize = 0;
            this.buttonChangeInfoStuff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChangeInfoStuff.Font = new System.Drawing.Font("Segoe UI Semilight", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonChangeInfoStuff.ForeColor = System.Drawing.Color.Black;
            this.buttonChangeInfoStuff.Image = global::WarehouseAdmin.Properties.Resources.icons8_заменить_30;
            this.buttonChangeInfoStuff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonChangeInfoStuff.Location = new System.Drawing.Point(3, 90);
            this.buttonChangeInfoStuff.Name = "buttonChangeInfoStuff";
            this.buttonChangeInfoStuff.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.buttonChangeInfoStuff.Size = new System.Drawing.Size(140, 92);
            this.buttonChangeInfoStuff.TabIndex = 14;
            this.buttonChangeInfoStuff.UseVisualStyleBackColor = false;
            this.buttonChangeInfoStuff.Click += new System.EventHandler(this.buttonChangeInfoStuff_Click);
            // 
            // buttonDeleteStuff
            // 
            this.buttonDeleteStuff.BackColor = System.Drawing.Color.White;
            this.buttonDeleteStuff.FlatAppearance.BorderSize = 0;
            this.buttonDeleteStuff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteStuff.Font = new System.Drawing.Font("Segoe UI Semilight", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDeleteStuff.ForeColor = System.Drawing.Color.Black;
            this.buttonDeleteStuff.Image = global::WarehouseAdmin.Properties.Resources.icons8_удалить_30;
            this.buttonDeleteStuff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDeleteStuff.Location = new System.Drawing.Point(3, 188);
            this.buttonDeleteStuff.Name = "buttonDeleteStuff";
            this.buttonDeleteStuff.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.buttonDeleteStuff.Size = new System.Drawing.Size(140, 92);
            this.buttonDeleteStuff.TabIndex = 15;
            this.buttonDeleteStuff.UseVisualStyleBackColor = false;
            this.buttonDeleteStuff.Click += new System.EventHandler(this.buttonDeleteStuff_Click);
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
            this.buttonBack.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelProgram
            // 
            this.panelProgram.BackColor = System.Drawing.Color.White;
            this.panelProgram.Controls.Add(this.label1);
            this.panelProgram.Controls.Add(this.labelClose);
            this.panelProgram.Controls.Add(this.labelProgram);
            this.panelProgram.Controls.Add(this.pictureBoxMenu);
            this.panelProgram.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelProgram.Location = new System.Drawing.Point(0, 0);
            this.panelProgram.Margin = new System.Windows.Forms.Padding(10);
            this.panelProgram.Name = "panelProgram";
            this.panelProgram.Size = new System.Drawing.Size(1374, 64);
            this.panelProgram.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkCyan;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1309, 0);
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
            this.labelClose.Location = new System.Drawing.Point(1339, 0);
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
            // персоналTableAdapter
            // 
            this.персоналTableAdapter.ClearBeforeFill = true;
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
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.персоналDataGridView.DataSource = this.персоналBindingSource;
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
            this.персоналDataGridView.Size = new System.Drawing.Size(1252, 546);
            this.персоналDataGridView.TabIndex = 16;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Код_Сотрудника";
            this.dataGridViewTextBoxColumn1.HeaderText = "    Код_Сотрудника";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Имя";
            this.dataGridViewTextBoxColumn2.HeaderText = "     Имя";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Фамилия";
            this.dataGridViewTextBoxColumn3.HeaderText = "     Фамилия";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Должность";
            this.dataGridViewTextBoxColumn4.HeaderText = "     Должность";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Зарплата";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn5.HeaderText = "     Зарплата";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Соль";
            this.dataGridViewTextBoxColumn6.HeaderText = "     Соль";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Хеш_Пароля";
            this.dataGridViewTextBoxColumn7.HeaderText = "     Хеш_Пароля";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // FormStuff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1374, 610);
            this.Controls.Add(this.персоналDataGridView);
            this.Controls.Add(this.MenuContainer);
            this.Controls.Add(this.panelProgram);
            this.Name = "FormStuff";
            this.Load += new System.EventHandler(this.FormStuff_Load);
            this.MenuContainer.ResumeLayout(false);
            this.panelProgram.ResumeLayout(false);
            this.panelProgram.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.персоналBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.персоналDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel MenuContainer;
        private System.Windows.Forms.Button buttonStuffAdd;
        private System.Windows.Forms.Panel panelProgram;
        private System.Windows.Forms.Label labelClose;
        private System.Windows.Forms.Label labelProgram;
        private System.Windows.Forms.PictureBox pictureBoxMenu;
        private System.Windows.Forms.Button buttonChangeInfoStuff;
        private System.Windows.Forms.Button buttonDeleteStuff;
        private System.Windows.Forms.Button buttonBack;
        private DataSetW dataSetW;
        private System.Windows.Forms.BindingSource персоналBindingSource;
        private DataSetWTableAdapters.ПерсоналTableAdapter персоналTableAdapter;
        private DataSetWTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView персоналDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ToolTip toolTip4;
        private System.Windows.Forms.Label label1;
    }
}