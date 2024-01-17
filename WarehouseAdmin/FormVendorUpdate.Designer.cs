namespace WarehouseAdmin
{
    partial class FormVendorUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVendorUpdate));
            System.Windows.Forms.Label названиеLabel;
            System.Windows.Forms.Label адрессLabel;
            System.Windows.Forms.Label телефонLabel;
            this.dataSetW = new WarehouseAdmin.DataSetW();
            this.поставщикBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.поставщикTableAdapter = new WarehouseAdmin.DataSetWTableAdapters.ПоставщикTableAdapter();
            this.tableAdapterManager = new WarehouseAdmin.DataSetWTableAdapters.TableAdapterManager();
            this.поставщикBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.поставщикBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.названиеTextBox = new System.Windows.Forms.TextBox();
            this.адрессTextBox = new System.Windows.Forms.TextBox();
            this.телефонTextBox = new System.Windows.Forms.TextBox();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            названиеLabel = new System.Windows.Forms.Label();
            адрессLabel = new System.Windows.Forms.Label();
            телефонLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикBindingNavigator)).BeginInit();
            this.поставщикBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataSetW
            // 
            this.dataSetW.DataSetName = "DataSetW";
            this.dataSetW.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = WarehouseAdmin.DataSetWTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.НакладнаяTableAdapter = null;
            this.tableAdapterManager.ПерсоналTableAdapter = null;
            this.tableAdapterManager.ПоставщикTableAdapter = this.поставщикTableAdapter;
            this.tableAdapterManager.Приемка_ТовараTableAdapter = null;
            this.tableAdapterManager.СкладTableAdapter = null;
            this.tableAdapterManager.Товары_СкладаTableAdapter = null;
            // 
            // поставщикBindingNavigator
            // 
            this.поставщикBindingNavigator.AddNewItem = null;
            this.поставщикBindingNavigator.BackColor = System.Drawing.Color.DarkGray;
            this.поставщикBindingNavigator.BindingSource = this.поставщикBindingSource;
            this.поставщикBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.поставщикBindingNavigator.DeleteItem = null;
            this.поставщикBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.поставщикBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.поставщикBindingNavigatorSaveItem,
            this.toolStripButton1});
            this.поставщикBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.поставщикBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.поставщикBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.поставщикBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.поставщикBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.поставщикBindingNavigator.Name = "поставщикBindingNavigator";
            this.поставщикBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.поставщикBindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.поставщикBindingNavigator.TabIndex = 0;
            this.поставщикBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
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
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(61, 24);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // поставщикBindingNavigatorSaveItem
            // 
            this.поставщикBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.поставщикBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("поставщикBindingNavigatorSaveItem.Image")));
            this.поставщикBindingNavigatorSaveItem.Name = "поставщикBindingNavigatorSaveItem";
            this.поставщикBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.поставщикBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.поставщикBindingNavigatorSaveItem.Click += new System.EventHandler(this.поставщикBindingNavigatorSaveItem_Click);
            // 
            // названиеLabel
            // 
            названиеLabel.AutoSize = true;
            названиеLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            названиеLabel.Location = new System.Drawing.Point(16, 57);
            названиеLabel.Name = "названиеLabel";
            названиеLabel.Size = new System.Drawing.Size(125, 31);
            названиеLabel.TabIndex = 3;
            названиеLabel.Text = "Название:";
            // 
            // названиеTextBox
            // 
            this.названиеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.поставщикBindingSource, "Название", true));
            this.названиеTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.названиеTextBox.Location = new System.Drawing.Point(244, 54);
            this.названиеTextBox.Name = "названиеTextBox";
            this.названиеTextBox.Size = new System.Drawing.Size(544, 38);
            this.названиеTextBox.TabIndex = 4;
            // 
            // адрессLabel
            // 
            адрессLabel.AutoSize = true;
            адрессLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            адрессLabel.Location = new System.Drawing.Point(20, 130);
            адрессLabel.Name = "адрессLabel";
            адрессLabel.Size = new System.Drawing.Size(97, 31);
            адрессLabel.TabIndex = 5;
            адрессLabel.Text = "Адресс:";
            // 
            // адрессTextBox
            // 
            this.адрессTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.поставщикBindingSource, "Адресс", true));
            this.адрессTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.адрессTextBox.Location = new System.Drawing.Point(244, 130);
            this.адрессTextBox.Name = "адрессTextBox";
            this.адрессTextBox.Size = new System.Drawing.Size(544, 38);
            this.адрессTextBox.TabIndex = 6;
            // 
            // телефонLabel
            // 
            телефонLabel.AutoSize = true;
            телефонLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            телефонLabel.Location = new System.Drawing.Point(20, 215);
            телефонLabel.Name = "телефонLabel";
            телефонLabel.Size = new System.Drawing.Size(113, 31);
            телефонLabel.TabIndex = 7;
            телефонLabel.Text = "Телефон:";
            // 
            // телефонTextBox
            // 
            this.телефонTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.поставщикBindingSource, "Телефон", true));
            this.телефонTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.телефонTextBox.Location = new System.Drawing.Point(244, 212);
            this.телефонTextBox.Name = "телефонTextBox";
            this.телефонTextBox.Size = new System.Drawing.Size(544, 38);
            this.телефонTextBox.TabIndex = 8;
            this.телефонTextBox.TextChanged += new System.EventHandler(this.телефонTextBox_TextChanged);
            this.телефонTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.телефонTextBox_KeyPress);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::WarehouseAdmin.Properties.Resources.icons8_удалить_30;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton1.Text = "Закрыть форму";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // FormVendorUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 289);
            this.Controls.Add(названиеLabel);
            this.Controls.Add(this.названиеTextBox);
            this.Controls.Add(адрессLabel);
            this.Controls.Add(this.адрессTextBox);
            this.Controls.Add(телефонLabel);
            this.Controls.Add(this.телефонTextBox);
            this.Controls.Add(this.поставщикBindingNavigator);
            this.Name = "FormVendorUpdate";
            this.Text = "Обновление данных поставщика";
            this.Load += new System.EventHandler(this.FormVendorUpdate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикBindingNavigator)).EndInit();
            this.поставщикBindingNavigator.ResumeLayout(false);
            this.поставщикBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSetW dataSetW;
        private System.Windows.Forms.BindingSource поставщикBindingSource;
        private DataSetWTableAdapters.ПоставщикTableAdapter поставщикTableAdapter;
        private DataSetWTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator поставщикBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton поставщикBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox названиеTextBox;
        private System.Windows.Forms.TextBox адрессTextBox;
        private System.Windows.Forms.TextBox телефонTextBox;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}