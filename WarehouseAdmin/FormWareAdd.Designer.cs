namespace WarehouseAdmin
{
    partial class FormWareAdd
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
            System.Windows.Forms.Label описаниеLabel;
            System.Windows.Forms.Label вместимостьLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelClose = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.dataSetW = new WarehouseAdmin.DataSetW();
            this.складBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.складTableAdapter = new WarehouseAdmin.DataSetWTableAdapters.СкладTableAdapter();
            this.tableAdapterManager = new WarehouseAdmin.DataSetWTableAdapters.TableAdapterManager();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.textBoxStreet = new System.Windows.Forms.TextBox();
            this.textBoxHouse = new System.Windows.Forms.TextBox();
            this.textBoxDiscription = new System.Windows.Forms.TextBox();
            this.textBoxVINT = new System.Windows.Forms.TextBox();
            this.textBoxVfloat = new System.Windows.Forms.TextBox();
            названиеLabel = new System.Windows.Forms.Label();
            адрессLabel = new System.Windows.Forms.Label();
            описаниеLabel = new System.Windows.Forms.Label();
            вместимостьLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.складBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // названиеLabel
            // 
            названиеLabel.AutoSize = true;
            названиеLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            названиеLabel.Location = new System.Drawing.Point(52, 107);
            названиеLabel.Name = "названиеLabel";
            названиеLabel.Size = new System.Drawing.Size(125, 31);
            названиеLabel.TabIndex = 46;
            названиеLabel.Text = "Название:";
            // 
            // адрессLabel
            // 
            адрессLabel.AutoSize = true;
            адрессLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            адрессLabel.Location = new System.Drawing.Point(52, 187);
            адрессLabel.Name = "адрессLabel";
            адрессLabel.Size = new System.Drawing.Size(97, 31);
            адрессLabel.TabIndex = 48;
            адрессLabel.Text = "Адресс:";
            // 
            // описаниеLabel
            // 
            описаниеLabel.AutoSize = true;
            описаниеLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            описаниеLabel.Location = new System.Drawing.Point(52, 265);
            описаниеLabel.Name = "описаниеLabel";
            описаниеLabel.Size = new System.Drawing.Size(128, 31);
            описаниеLabel.TabIndex = 50;
            описаниеLabel.Text = "Описание:";
            // 
            // вместимостьLabel
            // 
            вместимостьLabel.AutoSize = true;
            вместимостьLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            вместимостьLabel.Location = new System.Drawing.Point(52, 343);
            вместимостьLabel.Name = "вместимостьLabel";
            вместимостьLabel.Size = new System.Drawing.Size(162, 31);
            вместимостьLabel.TabIndex = 52;
            вместимостьLabel.Text = "Вместимость:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label1.Location = new System.Drawing.Point(557, 343);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(74, 31);
            label1.TabIndex = 54;
            label1.Text = "кв. м.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label2.Location = new System.Drawing.Point(724, 343);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(85, 31);
            label2.TabIndex = 56;
            label2.Text = "кв. см.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label3.Location = new System.Drawing.Point(376, 303);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(255, 26);
            label3.TabIndex = 57;
            label3.Text = "(необязательное поле)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label4.Location = new System.Drawing.Point(264, 225);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(88, 26);
            label4.TabIndex = 61;
            label4.Text = "(Город)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label5.Location = new System.Drawing.Point(454, 225);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(100, 26);
            label5.TabIndex = 62;
            label5.Text = "(ул\\пр-т)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label6.Location = new System.Drawing.Point(648, 225);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(70, 26);
            label6.TabIndex = 63;
            label6.Text = "(дом)";
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.buttonSave);
            this.panelMenu.Controls.Add(this.labelClose);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(855, 65);
            this.panelMenu.TabIndex = 43;
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.Image = global::WarehouseAdmin.Properties.Resources.icons8_сохранить_30;
            this.buttonSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSave.Location = new System.Drawing.Point(294, 12);
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
            this.labelClose.Location = new System.Drawing.Point(804, 0);
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
            // складBindingSource
            // 
            this.складBindingSource.DataMember = "Склад";
            this.складBindingSource.DataSource = this.dataSetW;
            // 
            // складTableAdapter
            // 
            this.складTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = WarehouseAdmin.DataSetWTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.НакладнаяTableAdapter = null;
            this.tableAdapterManager.ПерсоналTableAdapter = null;
            this.tableAdapterManager.ПоставщикTableAdapter = null;
            this.tableAdapterManager.Приемка_ТовараTableAdapter = null;
            this.tableAdapterManager.СкладTableAdapter = this.складTableAdapter;
            this.tableAdapterManager.Товары_СкладаTableAdapter = null;
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxName.Location = new System.Drawing.Point(228, 100);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(531, 38);
            this.textBoxName.TabIndex = 64;
            this.textBoxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxCity
            // 
            this.textBoxCity.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCity.Location = new System.Drawing.Point(228, 180);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(165, 38);
            this.textBoxCity.TabIndex = 65;
            this.textBoxCity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxCity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCity_KeyPress);
            // 
            // textBoxStreet
            // 
            this.textBoxStreet.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxStreet.Location = new System.Drawing.Point(419, 180);
            this.textBoxStreet.Name = "textBoxStreet";
            this.textBoxStreet.Size = new System.Drawing.Size(165, 38);
            this.textBoxStreet.TabIndex = 66;
            this.textBoxStreet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxStreet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxStreet_KeyPress);
            // 
            // textBoxHouse
            // 
            this.textBoxHouse.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxHouse.Location = new System.Drawing.Point(616, 180);
            this.textBoxHouse.Name = "textBoxHouse";
            this.textBoxHouse.Size = new System.Drawing.Size(143, 38);
            this.textBoxHouse.TabIndex = 67;
            this.textBoxHouse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxHouse.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxHouse_KeyPress);
            // 
            // textBoxDiscription
            // 
            this.textBoxDiscription.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDiscription.Location = new System.Drawing.Point(228, 262);
            this.textBoxDiscription.Name = "textBoxDiscription";
            this.textBoxDiscription.Size = new System.Drawing.Size(531, 38);
            this.textBoxDiscription.TabIndex = 68;
            this.textBoxDiscription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxVINT
            // 
            this.textBoxVINT.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxVINT.Location = new System.Drawing.Point(228, 340);
            this.textBoxVINT.Name = "textBoxVINT";
            this.textBoxVINT.Size = new System.Drawing.Size(307, 38);
            this.textBoxVINT.TabIndex = 69;
            this.textBoxVINT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxVINT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxVINT_KeyPress);
            // 
            // textBoxVfloat
            // 
            this.textBoxVfloat.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxVfloat.Location = new System.Drawing.Point(635, 336);
            this.textBoxVfloat.Name = "textBoxVfloat";
            this.textBoxVfloat.Size = new System.Drawing.Size(83, 38);
            this.textBoxVfloat.TabIndex = 70;
            this.textBoxVfloat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxVfloat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxVfloat_KeyPress);
            // 
            // FormWareAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 418);
            this.Controls.Add(this.textBoxVfloat);
            this.Controls.Add(this.textBoxVINT);
            this.Controls.Add(this.textBoxDiscription);
            this.Controls.Add(this.textBoxHouse);
            this.Controls.Add(this.textBoxStreet);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(label6);
            this.Controls.Add(label5);
            this.Controls.Add(label4);
            this.Controls.Add(label3);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(названиеLabel);
            this.Controls.Add(адрессLabel);
            this.Controls.Add(описаниеLabel);
            this.Controls.Add(вместимостьLabel);
            this.Controls.Add(this.panelMenu);
            this.Name = "FormWareAdd";
            this.Text = "Добавление склада";
            this.Load += new System.EventHandler(this.FormWareAdd_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.складBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelClose;
        private System.Windows.Forms.ToolTip toolTip1;
        private DataSetW dataSetW;
        private System.Windows.Forms.BindingSource складBindingSource;
        private DataSetWTableAdapters.СкладTableAdapter складTableAdapter;
        private DataSetWTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.TextBox textBoxStreet;
        private System.Windows.Forms.TextBox textBoxHouse;
        private System.Windows.Forms.TextBox textBoxDiscription;
        private System.Windows.Forms.TextBox textBoxVINT;
        private System.Windows.Forms.TextBox textBoxVfloat;
    }
}