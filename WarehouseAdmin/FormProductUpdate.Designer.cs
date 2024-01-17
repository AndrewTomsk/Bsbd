namespace WarehouseAdmin
{
    partial class FormProductUpdate
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
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label вместимостьLabel;
            System.Windows.Forms.Label фамилияLabel;
            System.Windows.Forms.Label должностьLabel;
            System.Windows.Forms.Label зарплатаLabel;
            System.Windows.Forms.Label label4;
            this.textBoxVfloat = new System.Windows.Forms.TextBox();
            this.textBoxVINT = new System.Windows.Forms.TextBox();
            this.Категория_Товара = new System.Windows.Forms.ComboBox();
            this.Описание = new System.Windows.Forms.TextBox();
            this.Название = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelClose = new System.Windows.Forms.Label();
            this.Код_Товара_На_Складе = new System.Windows.Forms.ComboBox();
            this.roundedButtonUpdate = new WarehouseAdmin.RoundedButton();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            вместимостьLabel = new System.Windows.Forms.Label();
            фамилияLabel = new System.Windows.Forms.Label();
            должностьLabel = new System.Windows.Forms.Label();
            зарплатаLabel = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label2.Location = new System.Drawing.Point(843, 506);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(85, 31);
            label2.TabIndex = 85;
            label2.Text = "кв. см.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label1.Location = new System.Drawing.Point(676, 506);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(74, 31);
            label1.TabIndex = 84;
            label1.Text = "кв. м.";
            // 
            // вместимостьLabel
            // 
            вместимостьLabel.AutoSize = true;
            вместимостьLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            вместимостьLabel.Location = new System.Drawing.Point(110, 510);
            вместимостьLabel.Name = "вместимостьLabel";
            вместимостьLabel.Size = new System.Drawing.Size(162, 31);
            вместимостьLabel.TabIndex = 83;
            вместимостьLabel.Text = "Вместимость:";
            // 
            // фамилияLabel
            // 
            фамилияLabel.AutoSize = true;
            фамилияLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            фамилияLabel.Location = new System.Drawing.Point(110, 273);
            фамилияLabel.Name = "фамилияLabel";
            фамилияLabel.Size = new System.Drawing.Size(179, 31);
            фамилияLabel.TabIndex = 77;
            фамилияLabel.Text = "Наименование";
            // 
            // должностьLabel
            // 
            должностьLabel.AutoSize = true;
            должностьLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            должностьLabel.Location = new System.Drawing.Point(110, 345);
            должностьLabel.Name = "должностьLabel";
            должностьLabel.Size = new System.Drawing.Size(206, 31);
            должностьLabel.TabIndex = 78;
            должностьLabel.Text = "Категория товара";
            // 
            // зарплатаLabel
            // 
            зарплатаLabel.AutoSize = true;
            зарплатаLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            зарплатаLabel.Location = new System.Drawing.Point(110, 424);
            зарплатаLabel.Name = "зарплатаLabel";
            зарплатаLabel.Size = new System.Drawing.Size(122, 31);
            зарплатаLabel.TabIndex = 79;
            зарплатаLabel.Text = "Описание";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label4.Location = new System.Drawing.Point(110, 204);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(116, 31);
            label4.TabIndex = 92;
            label4.Text = "Id товара";
            // 
            // textBoxVfloat
            // 
            this.textBoxVfloat.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxVfloat.Location = new System.Drawing.Point(754, 499);
            this.textBoxVfloat.Name = "textBoxVfloat";
            this.textBoxVfloat.Size = new System.Drawing.Size(83, 38);
            this.textBoxVfloat.TabIndex = 88;
            this.textBoxVfloat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxVfloat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxVfloat_KeyPress);
            // 
            // textBoxVINT
            // 
            this.textBoxVINT.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxVINT.Location = new System.Drawing.Point(347, 503);
            this.textBoxVINT.Name = "textBoxVINT";
            this.textBoxVINT.Size = new System.Drawing.Size(307, 38);
            this.textBoxVINT.TabIndex = 87;
            this.textBoxVINT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxVINT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxVINT_KeyPress);
            // 
            // Категория_Товара
            // 
            this.Категория_Товара.Font = new System.Drawing.Font("Segoe UI Semilight", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Категория_Товара.FormattingEnabled = true;
            this.Категория_Товара.Items.AddRange(new object[] {
            "А-Крупногабаритное",
            "А-Среднегабаритное",
            "А-Мелкогабаритное",
            "Б-Крупногабаритное",
            "Б-Среднегабаритное",
            "Б-Мелкогабаритное",
            "Добавить категорию"});
            this.Категория_Товара.Location = new System.Drawing.Point(347, 337);
            this.Категория_Товара.Name = "Категория_Товара";
            this.Категория_Товара.Size = new System.Drawing.Size(581, 39);
            this.Категория_Товара.TabIndex = 82;
            this.Категория_Товара.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Категория_Товара_KeyPress);
            // 
            // Описание
            // 
            this.Описание.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Описание.Location = new System.Drawing.Point(347, 409);
            this.Описание.Multiline = true;
            this.Описание.Name = "Описание";
            this.Описание.Size = new System.Drawing.Size(581, 46);
            this.Описание.TabIndex = 81;
            this.Описание.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Название
            // 
            this.Название.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Название.Location = new System.Drawing.Point(347, 258);
            this.Название.Multiline = true;
            this.Название.Name = "Название";
            this.Название.Size = new System.Drawing.Size(581, 46);
            this.Название.TabIndex = 80;
            this.Название.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(40, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(872, 114);
            this.label3.TabIndex = 89;
            this.label3.Text = "Введите id товара\r\nЗатем, заполните новые данные товара\r\nПоля запрещено заполнять" +
    " если их обновление не требуется \r\n";
            // 
            // labelClose
            // 
            this.labelClose.AutoSize = true;
            this.labelClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelClose.Location = new System.Drawing.Point(998, 0);
            this.labelClose.Name = "labelClose";
            this.labelClose.Size = new System.Drawing.Size(51, 51);
            this.labelClose.TabIndex = 90;
            this.labelClose.Text = "X";
            this.labelClose.Click += new System.EventHandler(this.labelClose_Click);
            // 
            // Код_Товара_На_Складе
            // 
            this.Код_Товара_На_Складе.Font = new System.Drawing.Font("Segoe UI Semilight", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Код_Товара_На_Складе.FormattingEnabled = true;
            this.Код_Товара_На_Складе.Items.AddRange(new object[] {
            "А-Крупногабаритное",
            "А-Среднегабаритное",
            "А-Мелкогабаритное",
            "Б-Крупногабаритное",
            "Б-Среднегабаритное",
            "Б-Мелкогабаритное",
            "Добавить категорию"});
            this.Код_Товара_На_Складе.Location = new System.Drawing.Point(347, 196);
            this.Код_Товара_На_Складе.Name = "Код_Товара_На_Складе";
            this.Код_Товара_На_Складе.Size = new System.Drawing.Size(581, 39);
            this.Код_Товара_На_Складе.TabIndex = 93;
            this.Код_Товара_На_Складе.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Код_Товара_На_Складе_KeyPress);
            // 
            // roundedButtonUpdate
            // 
            this.roundedButtonUpdate.BackColor = System.Drawing.Color.DarkCyan;
            this.roundedButtonUpdate.CornerRadius = 10;
            this.roundedButtonUpdate.FlatAppearance.BorderSize = 0;
            this.roundedButtonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButtonUpdate.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roundedButtonUpdate.ForeColor = System.Drawing.Color.White;
            this.roundedButtonUpdate.Location = new System.Drawing.Point(362, 574);
            this.roundedButtonUpdate.Name = "roundedButtonUpdate";
            this.roundedButtonUpdate.Size = new System.Drawing.Size(353, 82);
            this.roundedButtonUpdate.TabIndex = 91;
            this.roundedButtonUpdate.Text = "Обновить данные";
            this.roundedButtonUpdate.UseVisualStyleBackColor = false;
            this.roundedButtonUpdate.Visible = false;
            this.roundedButtonUpdate.Click += new System.EventHandler(this.roundedButtonUpdate_Click);
            // 
            // FormProductUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 678);
            this.Controls.Add(this.Код_Товара_На_Складе);
            this.Controls.Add(label4);
            this.Controls.Add(this.roundedButtonUpdate);
            this.Controls.Add(this.labelClose);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxVfloat);
            this.Controls.Add(this.textBoxVINT);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(вместимостьLabel);
            this.Controls.Add(this.Категория_Товара);
            this.Controls.Add(this.Описание);
            this.Controls.Add(this.Название);
            this.Controls.Add(фамилияLabel);
            this.Controls.Add(должностьLabel);
            this.Controls.Add(зарплатаLabel);
            this.Name = "FormProductUpdate";
            this.Text = "Обновление данных о товаре";
            this.Load += new System.EventHandler(this.FormProductUpdate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxVfloat;
        private System.Windows.Forms.TextBox textBoxVINT;
        private System.Windows.Forms.ComboBox Категория_Товара;
        private System.Windows.Forms.TextBox Описание;
        private System.Windows.Forms.TextBox Название;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelClose;
        private RoundedButton roundedButtonUpdate;
        private System.Windows.Forms.ComboBox Код_Товара_На_Складе;
    }
}