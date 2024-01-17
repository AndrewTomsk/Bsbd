namespace WarehouseAdmin
{
    partial class FormAccGood
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
            System.Windows.Forms.Label номер_НакладнойLabel;
            System.Windows.Forms.Label код_ТовараLabel;
            System.Windows.Forms.Label количествоLabel;
            System.Windows.Forms.Label цена_За_ЕдLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAccGood));
            this.dataSetW = new WarehouseAdmin.DataSetW();
            this.panel2 = new System.Windows.Forms.Panel();
            this.номер_НакладнойTextBox = new System.Windows.Forms.TextBox();
            this.приемкаТовараBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.код_ТовараTextBox = new System.Windows.Forms.TextBox();
            this.количествоTextBox = new System.Windows.Forms.TextBox();
            this.цена_За_ЕдTextBox = new System.Windows.Forms.TextBox();
            this.накладнаяDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Код_Товара = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Количество = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Цена_За_Ед = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.товары_СкладаDataGridView = new System.Windows.Forms.DataGridView();
            this.tableAdapterManager = new WarehouseAdmin.DataSetWTableAdapters.TableAdapterManager();
            this.приемка_ТовараTableAdapter = new WarehouseAdmin.DataSetWTableAdapters.Приемка_ТовараTableAdapter();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.накладнаяBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonExit = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.накладнаяBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            номер_НакладнойLabel = new System.Windows.Forms.Label();
            код_ТовараLabel = new System.Windows.Forms.Label();
            количествоLabel = new System.Windows.Forms.Label();
            цена_За_ЕдLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetW)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.приемкаТовараBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.накладнаяDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.товары_СкладаDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.накладнаяBindingNavigator)).BeginInit();
            this.накладнаяBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // номер_НакладнойLabel
            // 
            номер_НакладнойLabel.AutoSize = true;
            номер_НакладнойLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            номер_НакладнойLabel.Location = new System.Drawing.Point(35, 22);
            номер_НакладнойLabel.Name = "номер_НакладнойLabel";
            номер_НакладнойLabel.Size = new System.Drawing.Size(193, 28);
            номер_НакладнойLabel.TabIndex = 0;
            номер_НакладнойLabel.Text = "Номер Накладной:";
            // 
            // код_ТовараLabel
            // 
            код_ТовараLabel.AutoSize = true;
            код_ТовараLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            код_ТовараLabel.Location = new System.Drawing.Point(633, 75);
            код_ТовараLabel.Name = "код_ТовараLabel";
            код_ТовараLabel.Size = new System.Drawing.Size(123, 28);
            код_ТовараLabel.TabIndex = 2;
            код_ТовараLabel.Text = "Код Товара:";
            // 
            // количествоLabel
            // 
            количествоLabel.AutoSize = true;
            количествоLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            количествоLabel.Location = new System.Drawing.Point(35, 75);
            количествоLabel.Name = "количествоLabel";
            количествоLabel.Size = new System.Drawing.Size(128, 28);
            количествоLabel.TabIndex = 4;
            количествоLabel.Text = "Количество:";
            // 
            // цена_За_ЕдLabel
            // 
            цена_За_ЕдLabel.AutoSize = true;
            цена_За_ЕдLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            цена_За_ЕдLabel.Location = new System.Drawing.Point(633, 22);
            цена_За_ЕдLabel.Name = "цена_За_ЕдLabel";
            цена_За_ЕдLabel.Size = new System.Drawing.Size(121, 28);
            цена_За_ЕдLabel.TabIndex = 6;
            цена_За_ЕдLabel.Text = "Цена За Ед:";
            // 
            // dataSetW
            // 
            this.dataSetW.DataSetName = "DataSetW";
            this.dataSetW.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(номер_НакладнойLabel);
            this.panel2.Controls.Add(this.номер_НакладнойTextBox);
            this.panel2.Controls.Add(код_ТовараLabel);
            this.panel2.Controls.Add(this.код_ТовараTextBox);
            this.panel2.Controls.Add(количествоLabel);
            this.panel2.Controls.Add(this.количествоTextBox);
            this.panel2.Controls.Add(цена_За_ЕдLabel);
            this.panel2.Controls.Add(this.цена_За_ЕдTextBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 302);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1164, 211);
            this.panel2.TabIndex = 7;
            // 
            // номер_НакладнойTextBox
            // 
            this.номер_НакладнойTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.приемкаТовараBindingSource, "Номер_Накладной", true));
            this.номер_НакладнойTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.номер_НакладнойTextBox.Location = new System.Drawing.Point(279, 16);
            this.номер_НакладнойTextBox.Name = "номер_НакладнойTextBox";
            this.номер_НакладнойTextBox.Size = new System.Drawing.Size(258, 34);
            this.номер_НакладнойTextBox.TabIndex = 1;
            this.номер_НакладнойTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.номер_НакладнойTextBox_MouseClick);
            this.номер_НакладнойTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.номер_НакладнойTextBox_KeyPress);
            // 
            // приемкаТовараBindingSource
            // 
            this.приемкаТовараBindingSource.DataMember = "Приемка_Товара";
            this.приемкаТовараBindingSource.DataSource = this.dataSetW;
            // 
            // код_ТовараTextBox
            // 
            this.код_ТовараTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.приемкаТовараBindingSource, "Код_Товара", true));
            this.код_ТовараTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.код_ТовараTextBox.Location = new System.Drawing.Point(823, 72);
            this.код_ТовараTextBox.Name = "код_ТовараTextBox";
            this.код_ТовараTextBox.Size = new System.Drawing.Size(258, 34);
            this.код_ТовараTextBox.TabIndex = 3;
            this.код_ТовараTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.код_ТовараTextBox_MouseClick);
            this.код_ТовараTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.код_ТовараTextBox_KeyPress);
            // 
            // количествоTextBox
            // 
            this.количествоTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.приемкаТовараBindingSource, "Количество", true));
            this.количествоTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.количествоTextBox.Location = new System.Drawing.Point(279, 75);
            this.количествоTextBox.Name = "количествоTextBox";
            this.количествоTextBox.Size = new System.Drawing.Size(258, 34);
            this.количествоTextBox.TabIndex = 5;
            this.количествоTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.количествоTextBox_KeyPress);
            // 
            // цена_За_ЕдTextBox
            // 
            this.цена_За_ЕдTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.приемкаТовараBindingSource, "Цена_За_Ед", true));
            this.цена_За_ЕдTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.цена_За_ЕдTextBox.Location = new System.Drawing.Point(823, 16);
            this.цена_За_ЕдTextBox.Name = "цена_За_ЕдTextBox";
            this.цена_За_ЕдTextBox.Size = new System.Drawing.Size(258, 34);
            this.цена_За_ЕдTextBox.TabIndex = 7;
            this.цена_За_ЕдTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.цена_За_ЕдTextBox_KeyPress);
            // 
            // накладнаяDataGridView
            // 
            this.накладнаяDataGridView.AutoGenerateColumns = false;
            this.накладнаяDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.накладнаяDataGridView.BackgroundColor = System.Drawing.Color.DarkCyan;
            this.накладнаяDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.накладнаяDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.накладнаяDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.накладнаяDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.накладнаяDataGridView.ColumnHeadersHeight = 29;
            this.накладнаяDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.накладнаяDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Код_Товара,
            this.Количество,
            this.Цена_За_Ед});
            this.накладнаяDataGridView.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.накладнаяDataGridView.DataSource = this.приемкаТовараBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.накладнаяDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.накладнаяDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.накладнаяDataGridView.GridColor = System.Drawing.Color.Black;
            this.накладнаяDataGridView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.накладнаяDataGridView.Location = new System.Drawing.Point(0, 31);
            this.накладнаяDataGridView.MultiSelect = false;
            this.накладнаяDataGridView.Name = "накладнаяDataGridView";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.накладнаяDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.накладнаяDataGridView.RowHeadersVisible = false;
            this.накладнаяDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.накладнаяDataGridView.RowTemplate.Height = 24;
            this.накладнаяDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.накладнаяDataGridView.Size = new System.Drawing.Size(1164, 271);
            this.накладнаяDataGridView.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Номер_Накладной";
            this.dataGridViewTextBoxColumn1.HeaderText = "Номер_Накладной";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // Код_Товара
            // 
            this.Код_Товара.DataPropertyName = "Код_Товара";
            this.Код_Товара.HeaderText = "Код_Товара";
            this.Код_Товара.MinimumWidth = 6;
            this.Код_Товара.Name = "Код_Товара";
            // 
            // Количество
            // 
            this.Количество.DataPropertyName = "Количество";
            this.Количество.HeaderText = "Количество";
            this.Количество.MinimumWidth = 6;
            this.Количество.Name = "Количество";
            // 
            // Цена_За_Ед
            // 
            this.Цена_За_Ед.DataPropertyName = "Цена_За_Ед";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.Цена_За_Ед.DefaultCellStyle = dataGridViewCellStyle2;
            this.Цена_За_Ед.HeaderText = "Цена_За_Ед";
            this.Цена_За_Ед.MinimumWidth = 6;
            this.Цена_За_Ед.Name = "Цена_За_Ед";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.товары_СкладаDataGridView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 513);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1164, 231);
            this.panel1.TabIndex = 4;
            // 
            // товары_СкладаDataGridView
            // 
            this.товары_СкладаDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.товары_СкладаDataGridView.BackgroundColor = System.Drawing.Color.DarkCyan;
            this.товары_СкладаDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.товары_СкладаDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.товары_СкладаDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.товары_СкладаDataGridView.ColumnHeadersHeight = 29;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.товары_СкладаDataGridView.DefaultCellStyle = dataGridViewCellStyle6;
            this.товары_СкладаDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.товары_СкладаDataGridView.GridColor = System.Drawing.Color.White;
            this.товары_СкладаDataGridView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.товары_СкладаDataGridView.Location = new System.Drawing.Point(0, 0);
            this.товары_СкладаDataGridView.Margin = new System.Windows.Forms.Padding(7);
            this.товары_СкладаDataGridView.MultiSelect = false;
            this.товары_СкладаDataGridView.Name = "товары_СкладаDataGridView";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.товары_СкладаDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.товары_СкладаDataGridView.RowHeadersVisible = false;
            this.товары_СкладаDataGridView.RowHeadersWidth = 51;
            this.товары_СкладаDataGridView.RowTemplate.Height = 24;
            this.товары_СкладаDataGridView.Size = new System.Drawing.Size(1164, 231);
            this.товары_СкладаDataGridView.TabIndex = 20;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = WarehouseAdmin.DataSetWTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.НакладнаяTableAdapter = null;
            this.tableAdapterManager.ПерсоналTableAdapter = null;
            this.tableAdapterManager.ПоставщикTableAdapter = null;
            this.tableAdapterManager.Приемка_ТовараTableAdapter = this.приемка_ТовараTableAdapter;
            this.tableAdapterManager.СкладTableAdapter = null;
            this.tableAdapterManager.Товары_СкладаTableAdapter = null;
            // 
            // приемка_ТовараTableAdapter
            // 
            this.приемка_ТовараTableAdapter.ClearBeforeFill = true;
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(77, 28);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = global::WarehouseAdmin.Properties.Resources.icons8_добавить_30;
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = global::WarehouseAdmin.Properties.Resources.icons8_удалить_30;
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // накладнаяBindingNavigatorSaveItem
            // 
            this.накладнаяBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.накладнаяBindingNavigatorSaveItem.Image = global::WarehouseAdmin.Properties.Resources.icons8_сохранить_30;
            this.накладнаяBindingNavigatorSaveItem.Name = "накладнаяBindingNavigatorSaveItem";
            this.накладнаяBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.накладнаяBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.накладнаяBindingNavigatorSaveItem.Click += new System.EventHandler(this.накладнаяBindingNavigatorSaveItem_Click);
            // 
            // toolStripButtonExit
            // 
            this.toolStripButtonExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButtonExit.BackColor = System.Drawing.Color.Black;
            this.toolStripButtonExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonExit.Image = global::WarehouseAdmin.Properties.Resources.icons8_выход_30;
            this.toolStripButtonExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonExit.Name = "toolStripButtonExit";
            this.toolStripButtonExit.Size = new System.Drawing.Size(29, 28);
            this.toolStripButtonExit.ToolTipText = "Выход";
            this.toolStripButtonExit.Click += new System.EventHandler(this.toolStripButtonExit_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::WarehouseAdmin.Properties.Resources.icons8_назад_30;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 28);
            this.toolStripButton1.Text = "Назад";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // накладнаяBindingNavigator
            // 
            this.накладнаяBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.накладнаяBindingNavigator.BindingSource = this.приемкаТовараBindingSource;
            this.накладнаяBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.накладнаяBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.накладнаяBindingNavigator.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.накладнаяBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.накладнаяBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.накладнаяBindingNavigatorSaveItem,
            this.toolStripButtonExit,
            this.toolStripButton1});
            this.накладнаяBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.накладнаяBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.накладнаяBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.накладнаяBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.накладнаяBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.накладнаяBindingNavigator.Name = "накладнаяBindingNavigator";
            this.накладнаяBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.накладнаяBindingNavigator.Size = new System.Drawing.Size(1164, 31);
            this.накладнаяBindingNavigator.TabIndex = 5;
            this.накладнаяBindingNavigator.Text = "bindingNavigator1";
            // 
            // FormAccGood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 744);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.накладнаяDataGridView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.накладнаяBindingNavigator);
            this.Name = "FormAccGood";
            this.Text = "Прием товара";
            this.Load += new System.EventHandler(this.FormAccGood_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetW)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.приемкаТовараBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.накладнаяDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.товары_СкладаDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.накладнаяBindingNavigator)).EndInit();
            this.накладнаяBindingNavigator.ResumeLayout(false);
            this.накладнаяBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataSetW dataSetW;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView накладнаяDataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView товары_СкладаDataGridView;
        private DataSetWTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource приемкаТовараBindingSource;
        private DataSetWTableAdapters.Приемка_ТовараTableAdapter приемка_ТовараTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Код_Товара;
        private System.Windows.Forms.DataGridViewTextBoxColumn Количество;
        private System.Windows.Forms.DataGridViewTextBoxColumn Цена_За_Ед;
        private System.Windows.Forms.TextBox номер_НакладнойTextBox;
        private System.Windows.Forms.TextBox код_ТовараTextBox;
        private System.Windows.Forms.TextBox количествоTextBox;
        private System.Windows.Forms.TextBox цена_За_ЕдTextBox;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton накладнаяBindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStripButton toolStripButtonExit;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.BindingNavigator накладнаяBindingNavigator;
    }
}