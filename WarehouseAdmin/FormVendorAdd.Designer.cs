namespace WarehouseAdmin
{
    partial class FormVendorAdd
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
            System.Windows.Forms.Label названиеLabel;
            System.Windows.Forms.Label адрессLabel;
            System.Windows.Forms.Label телефонLabel;
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelClose = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.dataSetW = new WarehouseAdmin.DataSetW();
            this.поставщикBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.поставщикTableAdapter = new WarehouseAdmin.DataSetWTableAdapters.ПоставщикTableAdapter();
            this.tableAdapterManager = new WarehouseAdmin.DataSetWTableAdapters.TableAdapterManager();
            this.названиеTextBox = new System.Windows.Forms.TextBox();
            this.адрессTextBox = new System.Windows.Forms.TextBox();
            this.телефонTextBox = new System.Windows.Forms.TextBox();
            названиеLabel = new System.Windows.Forms.Label();
            адрессLabel = new System.Windows.Forms.Label();
            телефонLabel = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // названиеLabel
            // 
            названиеLabel.AutoSize = true;
            названиеLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            названиеLabel.Location = new System.Drawing.Point(24, 98);
            названиеLabel.Name = "названиеLabel";
            названиеLabel.Size = new System.Drawing.Size(125, 31);
            названиеLabel.TabIndex = 46;
            названиеLabel.Text = "Название:";
            // 
            // адрессLabel
            // 
            адрессLabel.AutoSize = true;
            адрессLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            адрессLabel.Location = new System.Drawing.Point(24, 157);
            адрессLabel.Name = "адрессLabel";
            адрессLabel.Size = new System.Drawing.Size(97, 31);
            адрессLabel.TabIndex = 48;
            адрессLabel.Text = "Адресс:";
            // 
            // телефонLabel
            // 
            телефонLabel.AutoSize = true;
            телефонLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            телефонLabel.Location = new System.Drawing.Point(24, 217);
            телефонLabel.Name = "телефонLabel";
            телефонLabel.Size = new System.Drawing.Size(113, 31);
            телефонLabel.TabIndex = 50;
            телефонLabel.Text = "Телефон:";
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.buttonSave);
            this.panelMenu.Controls.Add(this.labelClose);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(833, 65);
            this.panelMenu.TabIndex = 43;
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.Image = global::WarehouseAdmin.Properties.Resources.icons8_сохранить_30;
            this.buttonSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSave.Location = new System.Drawing.Point(277, 11);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.buttonSave.Size = new System.Drawing.Size(299, 40);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelClose
            // 
            this.labelClose.AutoSize = true;
            this.labelClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelClose.Location = new System.Drawing.Point(782, 0);
            this.labelClose.Name = "labelClose";
            this.labelClose.Size = new System.Drawing.Size(51, 51);
            this.labelClose.TabIndex = 0;
            this.labelClose.Text = "X";
            this.labelClose.Click += new System.EventHandler(this.labelClose_Click);
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
            // названиеTextBox
            // 
            this.названиеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.поставщикBindingSource, "Название", true));
            this.названиеTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.названиеTextBox.Location = new System.Drawing.Point(210, 91);
            this.названиеTextBox.Name = "названиеTextBox";
            this.названиеTextBox.Size = new System.Drawing.Size(575, 38);
            this.названиеTextBox.TabIndex = 47;
            this.названиеTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // адрессTextBox
            // 
            this.адрессTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.поставщикBindingSource, "Адресс", true));
            this.адрессTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.адрессTextBox.Location = new System.Drawing.Point(210, 154);
            this.адрессTextBox.Name = "адрессTextBox";
            this.адрессTextBox.Size = new System.Drawing.Size(575, 38);
            this.адрессTextBox.TabIndex = 49;
            this.адрессTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // телефонTextBox
            // 
            this.телефонTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.поставщикBindingSource, "Телефон", true));
            this.телефонTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.телефонTextBox.Location = new System.Drawing.Point(210, 210);
            this.телефонTextBox.Name = "телефонTextBox";
            this.телефонTextBox.Size = new System.Drawing.Size(575, 38);
            this.телефонTextBox.TabIndex = 51;
            this.телефонTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.телефонTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.телефонTextBox_KeyPress);
            // 
            // FormVendorAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 295);
            this.Controls.Add(названиеLabel);
            this.Controls.Add(this.названиеTextBox);
            this.Controls.Add(адрессLabel);
            this.Controls.Add(this.адрессTextBox);
            this.Controls.Add(телефонLabel);
            this.Controls.Add(this.телефонTextBox);
            this.Controls.Add(this.panelMenu);
            this.Name = "FormVendorAdd";
            this.Text = "Добавление поставщика";
            this.Load += new System.EventHandler(this.FormVendorAdd_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelClose;
        private System.Windows.Forms.ToolTip toolTip1;
        private DataSetW dataSetW;
        private System.Windows.Forms.BindingSource поставщикBindingSource;
        private DataSetWTableAdapters.ПоставщикTableAdapter поставщикTableAdapter;
        private DataSetWTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox названиеTextBox;
        private System.Windows.Forms.TextBox адрессTextBox;
        private System.Windows.Forms.TextBox телефонTextBox;
    }
}