namespace WarehouseAdmin
{
    partial class FormStuffUpdate
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
            this.labelClose = new System.Windows.Forms.Label();
            this.КомбоДолжность = new System.Windows.Forms.ComboBox();
            this.Пароль = new System.Windows.Forms.TextBox();
            this.Зарплата = new System.Windows.Forms.TextBox();
            this.Фамилия = new System.Windows.Forms.TextBox();
            this.Имя = new System.Windows.Forms.TextBox();
            this.labelId = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Код_Сотрудника = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.roundedButtonUpdate = new WarehouseAdmin.RoundedButton();
            this.SuspendLayout();
            // 
            // labelClose
            // 
            this.labelClose.AutoSize = true;
            this.labelClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelClose.Location = new System.Drawing.Point(1060, 0);
            this.labelClose.Name = "labelClose";
            this.labelClose.Size = new System.Drawing.Size(51, 51);
            this.labelClose.TabIndex = 1;
            this.labelClose.Text = "X";
            this.labelClose.Click += new System.EventHandler(this.labelClose_Click);
            // 
            // КомбоДолжность
            // 
            this.КомбоДолжность.Font = new System.Drawing.Font("Segoe UI Semilight", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.КомбоДолжность.FormattingEnabled = true;
            this.КомбоДолжность.Items.AddRange(new object[] {
            "Администратор",
            "Кладовщик",
            "Бухгалтер"});
            this.КомбоДолжность.Location = new System.Drawing.Point(284, 384);
            this.КомбоДолжность.Name = "КомбоДолжность";
            this.КомбоДолжность.Size = new System.Drawing.Size(700, 39);
            this.КомбоДолжность.TabIndex = 43;
            this.КомбоДолжность.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxPosition_KeyPress);
            // 
            // Пароль
            // 
            this.Пароль.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Пароль.Location = new System.Drawing.Point(284, 533);
            this.Пароль.Multiline = true;
            this.Пароль.Name = "Пароль";
            this.Пароль.PasswordChar = '*';
            this.Пароль.Size = new System.Drawing.Size(700, 46);
            this.Пароль.TabIndex = 42;
            this.Пароль.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Зарплата
            // 
            this.Зарплата.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Зарплата.Location = new System.Drawing.Point(284, 456);
            this.Зарплата.Multiline = true;
            this.Зарплата.Name = "Зарплата";
            this.Зарплата.Size = new System.Drawing.Size(700, 46);
            this.Зарплата.TabIndex = 41;
            this.Зарплата.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Зарплата.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Зарплата_KeyPress);
            // 
            // Фамилия
            // 
            this.Фамилия.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Фамилия.Location = new System.Drawing.Point(284, 305);
            this.Фамилия.Multiline = true;
            this.Фамилия.Name = "Фамилия";
            this.Фамилия.Size = new System.Drawing.Size(700, 46);
            this.Фамилия.TabIndex = 40;
            this.Фамилия.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Фамилия.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Фамилия_KeyPress);
            // 
            // Имя
            // 
            this.Имя.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Имя.Location = new System.Drawing.Point(284, 234);
            this.Имя.Multiline = true;
            this.Имя.Name = "Имя";
            this.Имя.Size = new System.Drawing.Size(700, 46);
            this.Имя.TabIndex = 39;
            this.Имя.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Имя.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Имя_KeyPress);
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelId.Location = new System.Drawing.Point(41, 185);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(129, 28);
            this.labelId.TabIndex = 48;
            this.labelId.Text = "Выберите id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(41, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 28);
            this.label3.TabIndex = 49;
            this.label3.Text = "Введите имя";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(41, 323);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 28);
            this.label4.TabIndex = 50;
            this.label4.Text = "Введите фамилию";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(41, 395);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(216, 28);
            this.label5.TabIndex = 51;
            this.label5.Text = "Выберите должность";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(41, 474);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 28);
            this.label6.TabIndex = 52;
            this.label6.Text = "Укажите зарплату";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(41, 551);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(164, 28);
            this.label7.TabIndex = 53;
            this.label7.Text = "Введите пароль";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(39, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(872, 114);
            this.label2.TabIndex = 54;
            this.label2.Text = "Введите id сотрудника\r\nЗатем, заполните новые данные сотрудника\r\nПоля запрещено з" +
    "аполнять если их обновление не требуется \r\n";
            // 
            // Код_Сотрудника
            // 
            this.Код_Сотрудника.Font = new System.Drawing.Font("Segoe UI Semilight", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Код_Сотрудника.FormattingEnabled = true;
            this.Код_Сотрудника.Items.AddRange(new object[] {
            "Администратор",
            "Кладовщик",
            "Бухгалтер"});
            this.Код_Сотрудника.Location = new System.Drawing.Point(284, 180);
            this.Код_Сотрудника.Name = "Код_Сотрудника";
            this.Код_Сотрудника.Size = new System.Drawing.Size(700, 39);
            this.Код_Сотрудника.TabIndex = 55;
            this.Код_Сотрудника.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxId_KeyPress);
            // 
            // roundedButtonUpdate
            // 
            this.roundedButtonUpdate.BackColor = System.Drawing.Color.DarkCyan;
            this.roundedButtonUpdate.CornerRadius = 10;
            this.roundedButtonUpdate.FlatAppearance.BorderSize = 0;
            this.roundedButtonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButtonUpdate.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roundedButtonUpdate.ForeColor = System.Drawing.Color.White;
            this.roundedButtonUpdate.Location = new System.Drawing.Point(405, 622);
            this.roundedButtonUpdate.Name = "roundedButtonUpdate";
            this.roundedButtonUpdate.Size = new System.Drawing.Size(353, 82);
            this.roundedButtonUpdate.TabIndex = 47;
            this.roundedButtonUpdate.Text = "Обновить данные";
            this.roundedButtonUpdate.UseVisualStyleBackColor = false;
            this.roundedButtonUpdate.Visible = false;
            this.roundedButtonUpdate.Click += new System.EventHandler(this.roundedButtonUpdate_Click);
            // 
            // FormStuffUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1111, 716);
            this.Controls.Add(this.Код_Сотрудника);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.roundedButtonUpdate);
            this.Controls.Add(this.КомбоДолжность);
            this.Controls.Add(this.Пароль);
            this.Controls.Add(this.Зарплата);
            this.Controls.Add(this.Фамилия);
            this.Controls.Add(this.Имя);
            this.Controls.Add(this.labelClose);
            this.Name = "FormStuffUpdate";
            this.Text = "Обновление данных Сотрудников";
            this.Load += new System.EventHandler(this.FormStuffUpdate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelClose;
        private System.Windows.Forms.ComboBox КомбоДолжность;
        private System.Windows.Forms.TextBox Пароль;
        private System.Windows.Forms.TextBox Зарплата;
        private System.Windows.Forms.TextBox Фамилия;
        private System.Windows.Forms.TextBox Имя;
        private RoundedButton roundedButtonUpdate;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Код_Сотрудника;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}