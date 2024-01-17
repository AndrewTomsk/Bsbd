namespace WarehouseAdmin
{
    partial class FormInvoice
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
            System.Windows.Forms.Label код_ПоставщикаLabel;
            System.Windows.Forms.Label код_СотрудникаLabel;
            System.Windows.Forms.Label номер_СкладаLabel;
            System.Windows.Forms.Label описаниеLabel;
            System.Windows.Forms.Label дата_НакладнойLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInvoice));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.товары_СкладаDataGridView = new System.Windows.Forms.DataGridView();
            this.dataSetW = new WarehouseAdmin.DataSetW();
            this.накладнаяBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.накладнаяTableAdapter = new WarehouseAdmin.DataSetWTableAdapters.НакладнаяTableAdapter();
            this.tableAdapterManager = new WarehouseAdmin.DataSetWTableAdapters.TableAdapterManager();
            this.накладнаяBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.накладнаяBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonExit = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.накладнаяDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.номер_НакладнойTextBox = new System.Windows.Forms.TextBox();
            this.код_ПоставщикаTextBox = new System.Windows.Forms.TextBox();
            this.код_СотрудникаTextBox = new System.Windows.Forms.TextBox();
            this.номер_СкладаTextBox = new System.Windows.Forms.TextBox();
            this.описаниеTextBox = new System.Windows.Forms.TextBox();
            this.дата_НакладнойDateTimePicker = new System.Windows.Forms.DateTimePicker();
            номер_НакладнойLabel = new System.Windows.Forms.Label();
            код_ПоставщикаLabel = new System.Windows.Forms.Label();
            код_СотрудникаLabel = new System.Windows.Forms.Label();
            номер_СкладаLabel = new System.Windows.Forms.Label();
            описаниеLabel = new System.Windows.Forms.Label();
            дата_НакладнойLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.товары_СкладаDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.накладнаяBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.накладнаяBindingNavigator)).BeginInit();
            this.накладнаяBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.накладнаяDataGridView)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // номер_НакладнойLabel
            // 
            номер_НакладнойLabel.AutoSize = true;
            номер_НакладнойLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            номер_НакладнойLabel.Location = new System.Drawing.Point(397, 27);
            номер_НакладнойLabel.Name = "номер_НакладнойLabel";
            номер_НакладнойLabel.Size = new System.Drawing.Size(193, 28);
            номер_НакладнойLabel.TabIndex = 15;
            номер_НакладнойLabel.Text = "Номер Накладной:";
            // 
            // код_ПоставщикаLabel
            // 
            код_ПоставщикаLabel.AutoSize = true;
            код_ПоставщикаLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            код_ПоставщикаLabel.Location = new System.Drawing.Point(38, 21);
            код_ПоставщикаLabel.Name = "код_ПоставщикаLabel";
            код_ПоставщикаLabel.Size = new System.Drawing.Size(175, 28);
            код_ПоставщикаLabel.TabIndex = 17;
            код_ПоставщикаLabel.Text = "Код Поставщика:";
            // 
            // код_СотрудникаLabel
            // 
            код_СотрудникаLabel.AutoSize = true;
            код_СотрудникаLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            код_СотрудникаLabel.Location = new System.Drawing.Point(38, 77);
            код_СотрудникаLabel.Name = "код_СотрудникаLabel";
            код_СотрудникаLabel.Size = new System.Drawing.Size(170, 28);
            код_СотрудникаLabel.TabIndex = 19;
            код_СотрудникаLabel.Text = "Код Сотрудника:";
            // 
            // номер_СкладаLabel
            // 
            номер_СкладаLabel.AutoSize = true;
            номер_СкладаLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            номер_СкладаLabel.Location = new System.Drawing.Point(38, 132);
            номер_СкладаLabel.Name = "номер_СкладаLabel";
            номер_СкладаLabel.Size = new System.Drawing.Size(154, 28);
            номер_СкладаLabel.TabIndex = 21;
            номер_СкладаLabel.Text = "Номер Склада:";
            // 
            // описаниеLabel
            // 
            описаниеLabel.AutoSize = true;
            описаниеLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            описаниеLabel.Location = new System.Drawing.Point(397, 80);
            описаниеLabel.Name = "описаниеLabel";
            описаниеLabel.Size = new System.Drawing.Size(110, 28);
            описаниеLabel.TabIndex = 23;
            описаниеLabel.Text = "Описание:";
            // 
            // дата_НакладнойLabel
            // 
            дата_НакладнойLabel.AutoSize = true;
            дата_НакладнойLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            дата_НакладнойLabel.Location = new System.Drawing.Point(397, 132);
            дата_НакладнойLabel.Name = "дата_НакладнойLabel";
            дата_НакладнойLabel.Size = new System.Drawing.Size(172, 28);
            дата_НакладнойLabel.TabIndex = 25;
            дата_НакладнойLabel.Text = "Дата Накладной:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.товары_СкладаDataGridView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 600);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1303, 318);
            this.panel1.TabIndex = 0;
            // 
            // товары_СкладаDataGridView
            // 
            this.товары_СкладаDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.товары_СкладаDataGridView.BackgroundColor = System.Drawing.Color.DarkCyan;
            this.товары_СкладаDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.товары_СкладаDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.товары_СкладаDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.товары_СкладаDataGridView.ColumnHeadersHeight = 29;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.товары_СкладаDataGridView.DefaultCellStyle = dataGridViewCellStyle20;
            this.товары_СкладаDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.товары_СкладаDataGridView.GridColor = System.Drawing.Color.White;
            this.товары_СкладаDataGridView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.товары_СкладаDataGridView.Location = new System.Drawing.Point(0, 0);
            this.товары_СкладаDataGridView.Margin = new System.Windows.Forms.Padding(7);
            this.товары_СкладаDataGridView.MultiSelect = false;
            this.товары_СкладаDataGridView.Name = "товары_СкладаDataGridView";
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.товары_СкладаDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.товары_СкладаDataGridView.RowHeadersVisible = false;
            this.товары_СкладаDataGridView.RowHeadersWidth = 51;
            this.товары_СкладаDataGridView.RowTemplate.Height = 24;
            this.товары_СкладаDataGridView.Size = new System.Drawing.Size(1303, 318);
            this.товары_СкладаDataGridView.TabIndex = 20;
            // 
            // dataSetW
            // 
            this.dataSetW.DataSetName = "DataSetW";
            this.dataSetW.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // накладнаяBindingSource
            // 
            this.накладнаяBindingSource.DataMember = "Накладная";
            this.накладнаяBindingSource.DataSource = this.dataSetW;
            // 
            // накладнаяTableAdapter
            // 
            this.накладнаяTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = WarehouseAdmin.DataSetWTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.НакладнаяTableAdapter = this.накладнаяTableAdapter;
            this.tableAdapterManager.ПерсоналTableAdapter = null;
            this.tableAdapterManager.ПоставщикTableAdapter = null;
            this.tableAdapterManager.Приемка_ТовараTableAdapter = null;
            this.tableAdapterManager.СкладTableAdapter = null;
            this.tableAdapterManager.Товары_СкладаTableAdapter = null;
            // 
            // накладнаяBindingNavigator
            // 
            this.накладнаяBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.накладнаяBindingNavigator.BindingSource = this.накладнаяBindingSource;
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
            this.накладнаяBindingNavigator.Size = new System.Drawing.Size(1303, 31);
            this.накладнаяBindingNavigator.TabIndex = 1;
            this.накладнаяBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(77, 28);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
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
            // накладнаяBindingNavigatorSaveItem
            // 
            this.накладнаяBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.накладнаяBindingNavigatorSaveItem.Image = global::WarehouseAdmin.Properties.Resources.icons8_сохранить_30;
            this.накладнаяBindingNavigatorSaveItem.Name = "накладнаяBindingNavigatorSaveItem";
            this.накладнаяBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.накладнаяBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.накладнаяBindingNavigatorSaveItem.Click += new System.EventHandler(this.накладнаяBindingNavigatorSaveItem_Click_1);
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
            this.toolStripButtonExit.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::WarehouseAdmin.Properties.Resources.icons8_назад_30;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 28);
            this.toolStripButton1.Text = "Назад";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click_1);
            // 
            // накладнаяDataGridView
            // 
            this.накладнаяDataGridView.AutoGenerateColumns = false;
            this.накладнаяDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.накладнаяDataGridView.BackgroundColor = System.Drawing.Color.DarkCyan;
            this.накладнаяDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.накладнаяDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.накладнаяDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.накладнаяDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.накладнаяDataGridView.ColumnHeadersHeight = 29;
            this.накладнаяDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.накладнаяDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.накладнаяDataGridView.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.накладнаяDataGridView.DataSource = this.накладнаяBindingSource;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.накладнаяDataGridView.DefaultCellStyle = dataGridViewCellStyle23;
            this.накладнаяDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.накладнаяDataGridView.GridColor = System.Drawing.Color.Black;
            this.накладнаяDataGridView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.накладнаяDataGridView.Location = new System.Drawing.Point(0, 31);
            this.накладнаяDataGridView.MultiSelect = false;
            this.накладнаяDataGridView.Name = "накладнаяDataGridView";
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.накладнаяDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.накладнаяDataGridView.RowHeadersVisible = false;
            this.накладнаяDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.накладнаяDataGridView.RowTemplate.Height = 24;
            this.накладнаяDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.накладнаяDataGridView.Size = new System.Drawing.Size(1303, 317);
            this.накладнаяDataGridView.TabIndex = 2;
            this.накладнаяDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.накладнаяDataGridView_CellFormatting);
            this.накладнаяDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.накладнаяDataGridView_DataError);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Номер_Накладной";
            this.dataGridViewTextBoxColumn1.HeaderText = "Номер_Накладной";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Код_Поставщика";
            this.dataGridViewTextBoxColumn2.HeaderText = "Код_Поставщика";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Код_Сотрудника";
            this.dataGridViewTextBoxColumn3.HeaderText = "Код_Сотрудника";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Номер_Склада";
            this.dataGridViewTextBoxColumn4.HeaderText = "Номер_Склада";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Описание";
            this.dataGridViewTextBoxColumn5.HeaderText = "Описание";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Дата_Накладной";
            this.dataGridViewTextBoxColumn6.HeaderText = "Дата_Накладной";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(номер_НакладнойLabel);
            this.panel2.Controls.Add(this.номер_НакладнойTextBox);
            this.panel2.Controls.Add(код_ПоставщикаLabel);
            this.panel2.Controls.Add(this.код_ПоставщикаTextBox);
            this.panel2.Controls.Add(код_СотрудникаLabel);
            this.panel2.Controls.Add(this.код_СотрудникаTextBox);
            this.panel2.Controls.Add(номер_СкладаLabel);
            this.panel2.Controls.Add(this.номер_СкладаTextBox);
            this.panel2.Controls.Add(описаниеLabel);
            this.panel2.Controls.Add(this.описаниеTextBox);
            this.panel2.Controls.Add(дата_НакладнойLabel);
            this.panel2.Controls.Add(this.дата_НакладнойDateTimePicker);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 348);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1303, 252);
            this.panel2.TabIndex = 3;
            // 
            // номер_НакладнойTextBox
            // 
            this.номер_НакладнойTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.накладнаяBindingSource, "Номер_Накладной", true));
            this.номер_НакладнойTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.номер_НакладнойTextBox.Location = new System.Drawing.Point(648, 21);
            this.номер_НакладнойTextBox.Name = "номер_НакладнойTextBox";
            this.номер_НакладнойTextBox.Size = new System.Drawing.Size(476, 34);
            this.номер_НакладнойTextBox.TabIndex = 16;
            // 
            // код_ПоставщикаTextBox
            // 
            this.код_ПоставщикаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.накладнаяBindingSource, "Код_Поставщика", true));
            this.код_ПоставщикаTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.код_ПоставщикаTextBox.Location = new System.Drawing.Point(289, 21);
            this.код_ПоставщикаTextBox.Name = "код_ПоставщикаTextBox";
            this.код_ПоставщикаTextBox.Size = new System.Drawing.Size(58, 34);
            this.код_ПоставщикаTextBox.TabIndex = 18;
            this.код_ПоставщикаTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.код_ПоставщикаTextBox_MouseClick);
            // 
            // код_СотрудникаTextBox
            // 
            this.код_СотрудникаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.накладнаяBindingSource, "Код_Сотрудника", true));
            this.код_СотрудникаTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.код_СотрудникаTextBox.Location = new System.Drawing.Point(289, 74);
            this.код_СотрудникаTextBox.Name = "код_СотрудникаTextBox";
            this.код_СотрудникаTextBox.Size = new System.Drawing.Size(58, 34);
            this.код_СотрудникаTextBox.TabIndex = 20;
            this.код_СотрудникаTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.код_СотрудникаTextBox_MouseClick);
            // 
            // номер_СкладаTextBox
            // 
            this.номер_СкладаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.накладнаяBindingSource, "Номер_Склада", true));
            this.номер_СкладаTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.номер_СкладаTextBox.Location = new System.Drawing.Point(289, 126);
            this.номер_СкладаTextBox.Name = "номер_СкладаTextBox";
            this.номер_СкладаTextBox.Size = new System.Drawing.Size(58, 34);
            this.номер_СкладаTextBox.TabIndex = 22;
            this.номер_СкладаTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.номер_СкладаTextBox_MouseClick);
            // 
            // описаниеTextBox
            // 
            this.описаниеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.накладнаяBindingSource, "Описание", true));
            this.описаниеTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.описаниеTextBox.Location = new System.Drawing.Point(648, 71);
            this.описаниеTextBox.Name = "описаниеTextBox";
            this.описаниеTextBox.Size = new System.Drawing.Size(476, 34);
            this.описаниеTextBox.TabIndex = 24;
            // 
            // дата_НакладнойDateTimePicker
            // 
            this.дата_НакладнойDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.накладнаяBindingSource, "Дата_Накладной", true));
            this.дата_НакладнойDateTimePicker.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.дата_НакладнойDateTimePicker.Location = new System.Drawing.Point(648, 124);
            this.дата_НакладнойDateTimePicker.Name = "дата_НакладнойDateTimePicker";
            this.дата_НакладнойDateTimePicker.Size = new System.Drawing.Size(476, 34);
            this.дата_НакладнойDateTimePicker.TabIndex = 26;
            // 
            // FormInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 918);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.накладнаяDataGridView);
            this.Controls.Add(this.накладнаяBindingNavigator);
            this.Controls.Add(this.panel1);
            this.Name = "FormInvoice";
            this.Text = "Накладные";
            this.Load += new System.EventHandler(this.FormInvoice_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.товары_СкладаDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.накладнаяBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.накладнаяBindingNavigator)).EndInit();
            this.накладнаяBindingNavigator.ResumeLayout(false);
            this.накладнаяBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.накладнаяDataGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView товары_СкладаDataGridView;
        private DataSetW dataSetW;
        private System.Windows.Forms.BindingSource накладнаяBindingSource;
        private DataSetWTableAdapters.НакладнаяTableAdapter накладнаяTableAdapter;
        private DataSetWTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator накладнаяBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton накладнаяBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridView накладнаяDataGridView;
        private System.Windows.Forms.ToolStripButton toolStripButtonExit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox номер_НакладнойTextBox;
        private System.Windows.Forms.TextBox код_ПоставщикаTextBox;
        private System.Windows.Forms.TextBox код_СотрудникаTextBox;
        private System.Windows.Forms.TextBox номер_СкладаTextBox;
        private System.Windows.Forms.TextBox описаниеTextBox;
        private System.Windows.Forms.DateTimePicker дата_НакладнойDateTimePicker;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}