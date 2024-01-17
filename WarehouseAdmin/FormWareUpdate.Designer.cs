namespace WarehouseAdmin
{
    partial class FormWareUpdate
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
            System.Windows.Forms.Label label9;
            System.Windows.Forms.Label label10;
            System.Windows.Forms.Label label11;
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ВместимостьСм = new System.Windows.Forms.TextBox();
            this.Описание = new System.Windows.Forms.TextBox();
            this.Номер_Склада = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.Вместимость = new System.Windows.Forms.TextBox();
            this.Название = new System.Windows.Forms.TextBox();
            this.roundedButtonUpdate = new WarehouseAdmin.RoundedButton();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxHouse = new System.Windows.Forms.TextBox();
            this.textBoxStreet = new System.Windows.Forms.TextBox();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            label9 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label9.Location = new System.Drawing.Point(933, 522);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(70, 26);
            label9.TabIndex = 79;
            label9.Text = "(дом)";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label10.Location = new System.Drawing.Point(650, 518);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(100, 26);
            label10.TabIndex = 78;
            label10.Text = "(ул/пр-т)";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label11.Location = new System.Drawing.Point(393, 522);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(88, 26);
            label11.TabIndex = 77;
            label11.Text = "(Город)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(974, 410);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 28);
            this.label4.TabIndex = 74;
            this.label4.Text = "см/кв";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(786, 410);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 28);
            this.label1.TabIndex = 73;
            this.label1.Text = "м/кв";
            // 
            // ВместимостьСм
            // 
            this.ВместимостьСм.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ВместимостьСм.Location = new System.Drawing.Point(873, 392);
            this.ВместимостьСм.Multiline = true;
            this.ВместимостьСм.Name = "ВместимостьСм";
            this.ВместимостьСм.Size = new System.Drawing.Size(81, 46);
            this.ВместимостьСм.TabIndex = 72;
            this.ВместимостьСм.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ВместимостьСм.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ВместимостьСм_KeyPress);
            // 
            // Описание
            // 
            this.Описание.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Описание.Location = new System.Drawing.Point(340, 313);
            this.Описание.Multiline = true;
            this.Описание.Name = "Описание";
            this.Описание.Size = new System.Drawing.Size(700, 46);
            this.Описание.TabIndex = 71;
            this.Описание.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Номер_Склада
            // 
            this.Номер_Склада.Font = new System.Drawing.Font("Segoe UI Semilight", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Номер_Склада.FormattingEnabled = true;
            this.Номер_Склада.Items.AddRange(new object[] {
            "Администратор",
            "Кладовщик",
            "Бухгалтер"});
            this.Номер_Склада.Location = new System.Drawing.Point(340, 197);
            this.Номер_Склада.Name = "Номер_Склада";
            this.Номер_Склада.Size = new System.Drawing.Size(700, 39);
            this.Номер_Склада.TabIndex = 70;
            this.Номер_Склада.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Номер_Склада_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(95, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(872, 114);
            this.label2.TabIndex = 69;
            this.label2.Text = "Введите id склада\r\nЗатем, заполните новые данные склада\r\nПоля запрещено заполнять" +
    " если их обновление не требуется \r\n";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(97, 487);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 28);
            this.label7.TabIndex = 68;
            this.label7.Text = "Введите адрес";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(97, 410);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(219, 28);
            this.label6.TabIndex = 67;
            this.label6.Text = "Введите вместимость";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(97, 331);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 28);
            this.label5.TabIndex = 66;
            this.label5.Text = "Введите описание";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(97, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 28);
            this.label3.TabIndex = 65;
            this.label3.Text = "Введите название";
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelId.Location = new System.Drawing.Point(97, 202);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(129, 28);
            this.labelId.TabIndex = 64;
            this.labelId.Text = "Выберите id";
            // 
            // Вместимость
            // 
            this.Вместимость.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Вместимость.Location = new System.Drawing.Point(340, 392);
            this.Вместимость.Multiline = true;
            this.Вместимость.Name = "Вместимость";
            this.Вместимость.Size = new System.Drawing.Size(426, 46);
            this.Вместимость.TabIndex = 61;
            this.Вместимость.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Вместимость.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Вместимость_KeyPress);
            // 
            // Название
            // 
            this.Название.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Название.Location = new System.Drawing.Point(340, 251);
            this.Название.Multiline = true;
            this.Название.Name = "Название";
            this.Название.Size = new System.Drawing.Size(700, 46);
            this.Название.TabIndex = 60;
            this.Название.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // roundedButtonUpdate
            // 
            this.roundedButtonUpdate.BackColor = System.Drawing.Color.DarkCyan;
            this.roundedButtonUpdate.CornerRadius = 10;
            this.roundedButtonUpdate.FlatAppearance.BorderSize = 0;
            this.roundedButtonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButtonUpdate.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roundedButtonUpdate.ForeColor = System.Drawing.Color.White;
            this.roundedButtonUpdate.Location = new System.Drawing.Point(413, 588);
            this.roundedButtonUpdate.Name = "roundedButtonUpdate";
            this.roundedButtonUpdate.Size = new System.Drawing.Size(353, 82);
            this.roundedButtonUpdate.TabIndex = 63;
            this.roundedButtonUpdate.Text = "Обновить данные";
            this.roundedButtonUpdate.UseVisualStyleBackColor = false;
            this.roundedButtonUpdate.Visible = false;
            this.roundedButtonUpdate.Click += new System.EventHandler(this.roundedButtonUpdate_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(1093, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 43);
            this.label8.TabIndex = 75;
            this.label8.Text = "Х";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // textBoxHouse
            // 
            this.textBoxHouse.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxHouse.Location = new System.Drawing.Point(873, 477);
            this.textBoxHouse.Name = "textBoxHouse";
            this.textBoxHouse.Size = new System.Drawing.Size(167, 38);
            this.textBoxHouse.TabIndex = 82;
            this.textBoxHouse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxStreet
            // 
            this.textBoxStreet.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxStreet.Location = new System.Drawing.Point(606, 477);
            this.textBoxStreet.Name = "textBoxStreet";
            this.textBoxStreet.Size = new System.Drawing.Size(188, 38);
            this.textBoxStreet.TabIndex = 81;
            this.textBoxStreet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxStreet.TextChanged += new System.EventHandler(this.textBoxStreet_TextChanged);
            // 
            // textBoxCity
            // 
            this.textBoxCity.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCity.Location = new System.Drawing.Point(340, 477);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(198, 38);
            this.textBoxCity.TabIndex = 80;
            this.textBoxCity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FormWareUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 682);
            this.Controls.Add(this.textBoxHouse);
            this.Controls.Add(this.textBoxStreet);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(label9);
            this.Controls.Add(label10);
            this.Controls.Add(label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ВместимостьСм);
            this.Controls.Add(this.Описание);
            this.Controls.Add(this.Номер_Склада);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.roundedButtonUpdate);
            this.Controls.Add(this.Вместимость);
            this.Controls.Add(this.Название);
            this.Name = "FormWareUpdate";
            this.Text = "Обновление данных склада";
            this.Load += new System.EventHandler(this.FormWareUpdate_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ВместимостьСм;
        private System.Windows.Forms.TextBox Описание;
        private System.Windows.Forms.ComboBox Номер_Склада;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelId;
        private RoundedButton roundedButtonUpdate;
        private System.Windows.Forms.TextBox Вместимость;
        private System.Windows.Forms.TextBox Название;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxHouse;
        private System.Windows.Forms.TextBox textBoxStreet;
        private System.Windows.Forms.TextBox textBoxCity;
    }
}