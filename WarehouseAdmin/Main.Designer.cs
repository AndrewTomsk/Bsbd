namespace WarehouseAdmin
{
    partial class Main
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
            this.panelProgram = new System.Windows.Forms.Panel();
            this.label_ = new System.Windows.Forms.Label();
            this.labelClose = new System.Windows.Forms.Label();
            this.labelProgram = new System.Windows.Forms.Label();
            this.pictureBoxMenu = new System.Windows.Forms.PictureBox();
            this.MenuContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonStuff = new System.Windows.Forms.Button();
            this.buttonVendor = new System.Windows.Forms.Button();
            this.buttonNak = new System.Windows.Forms.Button();
            this.buttonProducts = new System.Windows.Forms.Button();
            this.buttonPriem = new System.Windows.Forms.Button();
            this.buttonWar = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelProfile = new System.Windows.Forms.Panel();
            this.labelPosition = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelSalary = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelSecondName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelProfile = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.roundedButtonProfile = new WarehouseAdmin.RoundedButton();
            this.panelProgram.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMenu)).BeginInit();
            this.MenuContainer.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelProgram
            // 
            this.panelProgram.Controls.Add(this.label_);
            this.panelProgram.Controls.Add(this.labelClose);
            this.panelProgram.Controls.Add(this.labelProgram);
            this.panelProgram.Controls.Add(this.pictureBoxMenu);
            this.panelProgram.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelProgram.Location = new System.Drawing.Point(0, 0);
            this.panelProgram.Name = "panelProgram";
            this.panelProgram.Size = new System.Drawing.Size(1030, 64);
            this.panelProgram.TabIndex = 11;
            // 
            // label_
            // 
            this.label_.AutoSize = true;
            this.label_.BackColor = System.Drawing.Color.Black;
            this.label_.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label_.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_.ForeColor = System.Drawing.Color.White;
            this.label_.Location = new System.Drawing.Point(942, 11);
            this.label_.Name = "label_";
            this.label_.Size = new System.Drawing.Size(30, 41);
            this.label_.TabIndex = 15;
            this.label_.Text = "_";
            this.label_.Click += new System.EventHandler(this.label5_Click);
            // 
            // labelClose
            // 
            this.labelClose.AutoSize = true;
            this.labelClose.BackColor = System.Drawing.Color.Black;
            this.labelClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labelClose.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelClose.ForeColor = System.Drawing.Color.White;
            this.labelClose.Location = new System.Drawing.Point(969, 11);
            this.labelClose.Name = "labelClose";
            this.labelClose.Size = new System.Drawing.Size(35, 41);
            this.labelClose.TabIndex = 14;
            this.labelClose.Text = "X";
            this.labelClose.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelProgram
            // 
            this.labelProgram.AutoSize = true;
            this.labelProgram.Font = new System.Drawing.Font("Segoe UI Semilight", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
            this.pictureBoxMenu.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // MenuContainer
            // 
            this.MenuContainer.BackColor = System.Drawing.Color.Black;
            this.MenuContainer.Controls.Add(this.buttonVendor);
            this.MenuContainer.Controls.Add(this.buttonNak);
            this.MenuContainer.Controls.Add(this.buttonProducts);
            this.MenuContainer.Controls.Add(this.buttonPriem);
            this.MenuContainer.Controls.Add(this.buttonWar);
            this.MenuContainer.Controls.Add(this.buttonStuff);
            this.MenuContainer.Controls.Add(this.buttonExit);
            this.MenuContainer.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuContainer.Location = new System.Drawing.Point(0, 64);
            this.MenuContainer.Name = "MenuContainer";
            this.MenuContainer.Size = new System.Drawing.Size(317, 429);
            this.MenuContainer.TabIndex = 12;
            this.MenuContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.MunuContainer_Paint);
            // 
            // buttonStuff
            // 
            this.buttonStuff.BackColor = System.Drawing.Color.Black;
            this.buttonStuff.FlatAppearance.BorderSize = 0;
            this.buttonStuff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStuff.Font = new System.Drawing.Font("Segoe UI Semilight", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStuff.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonStuff.Image = global::WarehouseAdmin.Properties.Resources.icons8_работник_26;
            this.buttonStuff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStuff.Location = new System.Drawing.Point(3, 302);
            this.buttonStuff.Name = "buttonStuff";
            this.buttonStuff.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.buttonStuff.Size = new System.Drawing.Size(368, 51);
            this.buttonStuff.TabIndex = 13;
            this.buttonStuff.Text = "Персонал";
            this.buttonStuff.UseVisualStyleBackColor = false;
            this.buttonStuff.Click += new System.EventHandler(this.buttonStuff_Click);
            // 
            // buttonVendor
            // 
            this.buttonVendor.BackColor = System.Drawing.Color.Black;
            this.buttonVendor.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonVendor.FlatAppearance.BorderSize = 0;
            this.buttonVendor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVendor.Font = new System.Drawing.Font("Segoe UI Semilight", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonVendor.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonVendor.Image = global::WarehouseAdmin.Properties.Resources.icons8_поставщик_30;
            this.buttonVendor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonVendor.Location = new System.Drawing.Point(3, 3);
            this.buttonVendor.Name = "buttonVendor";
            this.buttonVendor.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.buttonVendor.Size = new System.Drawing.Size(368, 52);
            this.buttonVendor.TabIndex = 14;
            this.buttonVendor.Text = "Поставщики";
            this.buttonVendor.UseVisualStyleBackColor = false;
            this.buttonVendor.Click += new System.EventHandler(this.buttonVendor_Click);
            // 
            // buttonNak
            // 
            this.buttonNak.BackColor = System.Drawing.Color.Black;
            this.buttonNak.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonNak.FlatAppearance.BorderSize = 0;
            this.buttonNak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNak.Font = new System.Drawing.Font("Segoe UI Semilight", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNak.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonNak.Image = global::WarehouseAdmin.Properties.Resources.icons8_statement_30;
            this.buttonNak.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNak.Location = new System.Drawing.Point(3, 61);
            this.buttonNak.Name = "buttonNak";
            this.buttonNak.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.buttonNak.Size = new System.Drawing.Size(368, 59);
            this.buttonNak.TabIndex = 18;
            this.buttonNak.Text = "Накладные";
            this.buttonNak.UseVisualStyleBackColor = false;
            this.buttonNak.Click += new System.EventHandler(this.buttonNak_Click);
            // 
            // buttonProducts
            // 
            this.buttonProducts.BackColor = System.Drawing.Color.Black;
            this.buttonProducts.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonProducts.FlatAppearance.BorderSize = 0;
            this.buttonProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProducts.Font = new System.Drawing.Font("Segoe UI Semilight", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonProducts.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonProducts.Image = global::WarehouseAdmin.Properties.Resources.icons8_коробка_30;
            this.buttonProducts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonProducts.Location = new System.Drawing.Point(3, 126);
            this.buttonProducts.Name = "buttonProducts";
            this.buttonProducts.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.buttonProducts.Size = new System.Drawing.Size(368, 55);
            this.buttonProducts.TabIndex = 15;
            this.buttonProducts.Text = "Товары";
            this.buttonProducts.UseVisualStyleBackColor = false;
            this.buttonProducts.Click += new System.EventHandler(this.buttonProducts_Click);
            // 
            // buttonPriem
            // 
            this.buttonPriem.BackColor = System.Drawing.Color.Black;
            this.buttonPriem.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPriem.FlatAppearance.BorderSize = 0;
            this.buttonPriem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPriem.Font = new System.Drawing.Font("Segoe UI Semilight", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPriem.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonPriem.Image = global::WarehouseAdmin.Properties.Resources.icons8_стойка_регистрации_30__1_;
            this.buttonPriem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPriem.Location = new System.Drawing.Point(3, 187);
            this.buttonPriem.Name = "buttonPriem";
            this.buttonPriem.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.buttonPriem.Size = new System.Drawing.Size(368, 53);
            this.buttonPriem.TabIndex = 16;
            this.buttonPriem.Text = "Приемка товара";
            this.buttonPriem.UseVisualStyleBackColor = false;
            this.buttonPriem.Click += new System.EventHandler(this.buttonPriem_Click);
            // 
            // buttonWar
            // 
            this.buttonWar.BackColor = System.Drawing.Color.Black;
            this.buttonWar.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonWar.FlatAppearance.BorderSize = 0;
            this.buttonWar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWar.Font = new System.Drawing.Font("Segoe UI Semilight", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonWar.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonWar.Image = global::WarehouseAdmin.Properties.Resources.icons8_склад_30;
            this.buttonWar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonWar.Location = new System.Drawing.Point(3, 246);
            this.buttonWar.Name = "buttonWar";
            this.buttonWar.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.buttonWar.Size = new System.Drawing.Size(368, 50);
            this.buttonWar.TabIndex = 17;
            this.buttonWar.Text = "Склады";
            this.buttonWar.UseVisualStyleBackColor = false;
            this.buttonWar.Click += new System.EventHandler(this.buttonWar_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonExit.BackColor = System.Drawing.Color.Red;
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonExit.Image = global::WarehouseAdmin.Properties.Resources.icons8_выход_30;
            this.buttonExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonExit.Location = new System.Drawing.Point(3, 359);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.buttonExit.Size = new System.Drawing.Size(368, 71);
            this.buttonExit.TabIndex = 19;
            this.buttonExit.Text = "Выйти из аккаунта";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.Controls.Add(this.roundedButtonProfile);
            this.panelMain.Controls.Add(this.panelProfile);
            this.panelMain.Controls.Add(this.labelPosition);
            this.panelMain.Controls.Add(this.label3);
            this.panelMain.Controls.Add(this.labelTime);
            this.panelMain.Controls.Add(this.labelSalary);
            this.panelMain.Controls.Add(this.label6);
            this.panelMain.Controls.Add(this.labelName);
            this.panelMain.Controls.Add(this.label4);
            this.panelMain.Controls.Add(this.labelSecondName);
            this.panelMain.Controls.Add(this.label2);
            this.panelMain.Controls.Add(this.labelProfile);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(317, 64);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(713, 429);
            this.panelMain.TabIndex = 13;
            // 
            // panelProfile
            // 
            this.panelProfile.Location = new System.Drawing.Point(22, 118);
            this.panelProfile.Name = "panelProfile";
            this.panelProfile.Size = new System.Drawing.Size(679, 248);
            this.panelProfile.TabIndex = 25;
            // 
            // labelPosition
            // 
            this.labelPosition.AutoSize = true;
            this.labelPosition.Font = new System.Drawing.Font("Segoe UI Semilight", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPosition.Location = new System.Drawing.Point(398, 266);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(127, 31);
            this.labelPosition.TabIndex = 24;
            this.labelPosition.Text = "Должность";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semilight", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(79, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 31);
            this.label3.TabIndex = 23;
            this.label3.Text = "Должность";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Segoe UI Semilight", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTime.Location = new System.Drawing.Point(471, 389);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(78, 31);
            this.labelTime.TabIndex = 22;
            this.labelTime.Text = "Время";
            // 
            // labelSalary
            // 
            this.labelSalary.AutoSize = true;
            this.labelSalary.Font = new System.Drawing.Font("Segoe UI Semilight", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSalary.Location = new System.Drawing.Point(398, 219);
            this.labelSalary.Name = "labelSalary";
            this.labelSalary.Size = new System.Drawing.Size(109, 31);
            this.labelSalary.TabIndex = 21;
            this.labelSalary.Text = "Зарплата";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semilight", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(79, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 31);
            this.label6.TabIndex = 20;
            this.label6.Text = "Зарплата";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Segoe UI Semilight", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(398, 174);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(57, 31);
            this.labelName.TabIndex = 19;
            this.labelName.Text = "Имя";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semilight", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(79, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 31);
            this.label4.TabIndex = 18;
            this.label4.Text = "Имя";
            // 
            // labelSecondName
            // 
            this.labelSecondName.AutoSize = true;
            this.labelSecondName.Font = new System.Drawing.Font("Segoe UI Semilight", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSecondName.Location = new System.Drawing.Point(398, 132);
            this.labelSecondName.Name = "labelSecondName";
            this.labelSecondName.Size = new System.Drawing.Size(106, 31);
            this.labelSecondName.TabIndex = 17;
            this.labelSecondName.Text = "Фамилия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(79, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 31);
            this.label2.TabIndex = 16;
            this.label2.Text = "Фамилия";
            // 
            // labelProfile
            // 
            this.labelProfile.AutoSize = true;
            this.labelProfile.Font = new System.Drawing.Font("Segoe UI Semilight", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelProfile.Location = new System.Drawing.Point(77, 23);
            this.labelProfile.Name = "labelProfile";
            this.labelProfile.Size = new System.Drawing.Size(268, 45);
            this.labelProfile.TabIndex = 15;
            this.labelProfile.Text = "Личный кабинет";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // roundedButtonProfile
            // 
            this.roundedButtonProfile.BackColor = System.Drawing.Color.Gray;
            this.roundedButtonProfile.CornerRadius = 10;
            this.roundedButtonProfile.FlatAppearance.BorderSize = 0;
            this.roundedButtonProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButtonProfile.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roundedButtonProfile.ForeColor = System.Drawing.Color.White;
            this.roundedButtonProfile.Location = new System.Drawing.Point(85, 77);
            this.roundedButtonProfile.Name = "roundedButtonProfile";
            this.roundedButtonProfile.Size = new System.Drawing.Size(177, 35);
            this.roundedButtonProfile.TabIndex = 26;
            this.roundedButtonProfile.Text = "показать профиль";
            this.roundedButtonProfile.UseVisualStyleBackColor = false;
            this.roundedButtonProfile.Click += new System.EventHandler(this.roundedButton1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1030, 493);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.MenuContainer);
            this.Controls.Add(this.panelProgram);
            this.Name = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panelProgram.ResumeLayout(false);
            this.panelProgram.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMenu)).EndInit();
            this.MenuContainer.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelProgram;
        private System.Windows.Forms.PictureBox pictureBoxMenu;
        private System.Windows.Forms.FlowLayoutPanel MenuContainer;
        private System.Windows.Forms.Button buttonStuff;
        private System.Windows.Forms.Button buttonVendor;
        private System.Windows.Forms.Button buttonProducts;
        private System.Windows.Forms.Button buttonPriem;
        private System.Windows.Forms.Button buttonWar;
        private System.Windows.Forms.Button buttonNak;
        private System.Windows.Forms.Label labelClose;
        private System.Windows.Forms.Label labelProgram;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label labelSalary;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelSecondName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelProfile;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelProfile;
        private RoundedButton roundedButtonProfile;
        private System.Windows.Forms.Label label_;
    }
}