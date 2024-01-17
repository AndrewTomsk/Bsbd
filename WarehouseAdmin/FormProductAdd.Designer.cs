namespace WarehouseAdmin
{
    partial class FormProductAdd
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
            System.Windows.Forms.Label фамилияLabel;
            System.Windows.Forms.Label должностьLabel;
            System.Windows.Forms.Label зарплатаLabel;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label вместимостьLabel;
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelClose = new System.Windows.Forms.Label();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.textBoxDiscription = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxVfloat = new System.Windows.Forms.TextBox();
            this.textBoxVINT = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            фамилияLabel = new System.Windows.Forms.Label();
            должностьLabel = new System.Windows.Forms.Label();
            зарплатаLabel = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            вместимостьLabel = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // фамилияLabel
            // 
            фамилияLabel.AutoSize = true;
            фамилияLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            фамилияLabel.Location = new System.Drawing.Point(21, 109);
            фамилияLabel.Name = "фамилияLabel";
            фамилияLabel.Size = new System.Drawing.Size(179, 31);
            фамилияLabel.TabIndex = 35;
            фамилияLabel.Text = "Наименование";
            // 
            // должностьLabel
            // 
            должностьLabel.AutoSize = true;
            должностьLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            должностьLabel.Location = new System.Drawing.Point(21, 181);
            должностьLabel.Name = "должностьLabel";
            должностьLabel.Size = new System.Drawing.Size(206, 31);
            должностьLabel.TabIndex = 36;
            должностьLabel.Text = "Категория товара";
            // 
            // зарплатаLabel
            // 
            зарплатаLabel.AutoSize = true;
            зарплатаLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            зарплатаLabel.Location = new System.Drawing.Point(21, 260);
            зарплатаLabel.Name = "зарплатаLabel";
            зарплатаLabel.Size = new System.Drawing.Size(122, 31);
            зарплатаLabel.TabIndex = 37;
            зарплатаLabel.Text = "Описание";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label3.Location = new System.Drawing.Point(420, 294);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(255, 26);
            label3.TabIndex = 74;
            label3.Text = "(необязательное поле)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label2.Location = new System.Drawing.Point(754, 342);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(85, 31);
            label2.TabIndex = 73;
            label2.Text = "кв. см.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label1.Location = new System.Drawing.Point(587, 342);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(74, 31);
            label1.TabIndex = 72;
            label1.Text = "кв. м.";
            // 
            // вместимостьLabel
            // 
            вместимостьLabel.AutoSize = true;
            вместимостьLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            вместимостьLabel.Location = new System.Drawing.Point(21, 346);
            вместимостьLabel.Name = "вместимостьLabel";
            вместимостьLabel.Size = new System.Drawing.Size(162, 31);
            вместимостьLabel.TabIndex = 71;
            вместимостьLabel.Text = "Вместимость:";
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.buttonSave);
            this.panelMenu.Controls.Add(this.labelClose);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(915, 65);
            this.panelMenu.TabIndex = 33;
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.Image = global::WarehouseAdmin.Properties.Resources.icons8_сохранить_30;
            this.buttonSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSave.Location = new System.Drawing.Point(322, 11);
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
            this.labelClose.Location = new System.Drawing.Point(864, 0);
            this.labelClose.Name = "labelClose";
            this.labelClose.Size = new System.Drawing.Size(51, 51);
            this.labelClose.TabIndex = 0;
            this.labelClose.Text = "X";
            this.labelClose.Click += new System.EventHandler(this.labelClose_Click);
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.Font = new System.Drawing.Font("Segoe UI Semilight", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Items.AddRange(new object[] {
            "А-Крупногабаритное",
            "А-Среднегабаритное",
            "А-Мелкогабаритное",
            "Б-Крупногабаритное",
            "Б-Среднегабаритное",
            "Б-Мелкогабаритное"});
            this.comboBoxCategory.Location = new System.Drawing.Point(258, 173);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(581, 39);
            this.comboBoxCategory.TabIndex = 43;
            this.comboBoxCategory.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxPosition_KeyPress);
            // 
            // textBoxDiscription
            // 
            this.textBoxDiscription.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDiscription.Location = new System.Drawing.Point(258, 245);
            this.textBoxDiscription.Multiline = true;
            this.textBoxDiscription.Name = "textBoxDiscription";
            this.textBoxDiscription.Size = new System.Drawing.Size(581, 46);
            this.textBoxDiscription.TabIndex = 41;
            this.textBoxDiscription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxName.Location = new System.Drawing.Point(258, 94);
            this.textBoxName.Multiline = true;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(581, 46);
            this.textBoxName.TabIndex = 40;
            this.textBoxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSecondName_KeyPress);
            // 
            // textBoxVfloat
            // 
            this.textBoxVfloat.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxVfloat.Location = new System.Drawing.Point(665, 335);
            this.textBoxVfloat.Name = "textBoxVfloat";
            this.textBoxVfloat.Size = new System.Drawing.Size(83, 38);
            this.textBoxVfloat.TabIndex = 76;
            this.textBoxVfloat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxVfloat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxVfloat_KeyPress);
            // 
            // textBoxVINT
            // 
            this.textBoxVINT.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxVINT.Location = new System.Drawing.Point(258, 339);
            this.textBoxVINT.Name = "textBoxVINT";
            this.textBoxVINT.Size = new System.Drawing.Size(307, 38);
            this.textBoxVINT.TabIndex = 75;
            this.textBoxVINT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxVINT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxVINT_KeyPress);
            // 
            // FormProductAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 427);
            this.Controls.Add(this.textBoxVfloat);
            this.Controls.Add(this.textBoxVINT);
            this.Controls.Add(label3);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(вместимостьLabel);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.textBoxDiscription);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(фамилияLabel);
            this.Controls.Add(должностьLabel);
            this.Controls.Add(зарплатаLabel);
            this.Controls.Add(this.panelMenu);
            this.Name = "FormProductAdd";
            this.Text = "Добавление товара";
            this.Load += new System.EventHandler(this.FormProductAdd_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelClose;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.TextBox textBoxDiscription;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxVfloat;
        private System.Windows.Forms.TextBox textBoxVINT;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}