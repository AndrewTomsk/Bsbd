namespace WarehouseAdmin
{
    partial class Auth
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
            this.labelExit = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.pictureBoxLuna = new System.Windows.Forms.PictureBox();
            this.labelMain = new System.Windows.Forms.Label();
            this.pictureBoxCloud1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCloud2 = new System.Windows.Forms.PictureBox();
            this.roundedButtonAuth = new WarehouseAdmin.RoundedButton();
            this.panelLoading = new System.Windows.Forms.Panel();
            this.pictureBoxLoading = new System.Windows.Forms.PictureBox();
            this.pictureBoxEye = new System.Windows.Forms.PictureBox();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLuna)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCloud1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCloud2)).BeginInit();
            this.panelLoading.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEye)).BeginInit();
            this.SuspendLayout();
            // 
            // labelExit
            // 
            this.labelExit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelExit.AutoSize = true;
            this.labelExit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelExit.ForeColor = System.Drawing.Color.White;
            this.labelExit.Location = new System.Drawing.Point(675, 9);
            this.labelExit.Name = "labelExit";
            this.labelExit.Size = new System.Drawing.Size(35, 34);
            this.labelExit.TabIndex = 0;
            this.labelExit.Text = "X";
            this.labelExit.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLogin.Location = new System.Drawing.Point(188, 200);
            this.textBoxLogin.Multiline = true;
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(370, 48);
            this.textBoxLogin.TabIndex = 4;
            this.textBoxLogin.Text = "login";
            this.textBoxLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxLogin.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxLogin_MouseClick);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPassword.Location = new System.Drawing.Point(188, 274);
            this.textBoxPassword.Multiline = true;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(370, 48);
            this.textBoxPassword.TabIndex = 5;
            this.textBoxPassword.Text = "password";
            this.textBoxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxPassword.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseClick);
            this.textBoxPassword.TextChanged += new System.EventHandler(this.textBoxPassword_TextChanged);
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.pictureBoxLuna);
            this.panelHeader.Controls.Add(this.labelMain);
            this.panelHeader.Controls.Add(this.labelExit);
            this.panelHeader.Controls.Add(this.pictureBoxCloud1);
            this.panelHeader.Controls.Add(this.pictureBoxCloud2);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(722, 175);
            this.panelHeader.TabIndex = 9;
            // 
            // pictureBoxLuna
            // 
            this.pictureBoxLuna.Image = global::WarehouseAdmin.Properties.Resources._42645crescentmoon_99074;
            this.pictureBoxLuna.Location = new System.Drawing.Point(496, 9);
            this.pictureBoxLuna.Name = "pictureBoxLuna";
            this.pictureBoxLuna.Size = new System.Drawing.Size(62, 51);
            this.pictureBoxLuna.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxLuna.TabIndex = 10;
            this.pictureBoxLuna.TabStop = false;
            // 
            // labelMain
            // 
            this.labelMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMain.AutoSize = true;
            this.labelMain.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMain.ForeColor = System.Drawing.Color.White;
            this.labelMain.Location = new System.Drawing.Point(52, 9);
            this.labelMain.Name = "labelMain";
            this.labelMain.Size = new System.Drawing.Size(383, 41);
            this.labelMain.TabIndex = 9;
            this.labelMain.Text = "Admin profile | Warehouse";
            this.labelMain.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // pictureBoxCloud1
            // 
            this.pictureBoxCloud1.Image = global::WarehouseAdmin.Properties.Resources.icons8_облако_30;
            this.pictureBoxCloud1.Location = new System.Drawing.Point(153, 59);
            this.pictureBoxCloud1.Name = "pictureBoxCloud1";
            this.pictureBoxCloud1.Size = new System.Drawing.Size(59, 46);
            this.pictureBoxCloud1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxCloud1.TabIndex = 8;
            this.pictureBoxCloud1.TabStop = false;
            this.pictureBoxCloud1.MouseEnter += new System.EventHandler(this.pictureBox3_MouseEnter);
            this.pictureBoxCloud1.MouseLeave += new System.EventHandler(this.pictureBox3_MouseLeave);
            // 
            // pictureBoxCloud2
            // 
            this.pictureBoxCloud2.Image = global::WarehouseAdmin.Properties.Resources.icons8_облако_30;
            this.pictureBoxCloud2.Location = new System.Drawing.Point(574, 112);
            this.pictureBoxCloud2.Name = "pictureBoxCloud2";
            this.pictureBoxCloud2.Size = new System.Drawing.Size(59, 46);
            this.pictureBoxCloud2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxCloud2.TabIndex = 7;
            this.pictureBoxCloud2.TabStop = false;
            this.pictureBoxCloud2.MouseEnter += new System.EventHandler(this.pictureBox2_MouseEnter);
            this.pictureBoxCloud2.MouseLeave += new System.EventHandler(this.pictureBox2_MouseLeave);
            // 
            // roundedButtonAuth
            // 
            this.roundedButtonAuth.BackColor = System.Drawing.Color.Indigo;
            this.roundedButtonAuth.CornerRadius = 10;
            this.roundedButtonAuth.FlatAppearance.BorderSize = 0;
            this.roundedButtonAuth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButtonAuth.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roundedButtonAuth.ForeColor = System.Drawing.Color.White;
            this.roundedButtonAuth.Location = new System.Drawing.Point(278, 348);
            this.roundedButtonAuth.Name = "roundedButtonAuth";
            this.roundedButtonAuth.Size = new System.Drawing.Size(189, 56);
            this.roundedButtonAuth.TabIndex = 3;
            this.roundedButtonAuth.Text = "LOGIN";
            this.roundedButtonAuth.UseVisualStyleBackColor = false;
            this.roundedButtonAuth.Click += new System.EventHandler(this.roundedButtonAuth_Click);
            // 
            // panelLoading
            // 
            this.panelLoading.Controls.Add(this.pictureBoxLoading);
            this.panelLoading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLoading.Location = new System.Drawing.Point(0, 175);
            this.panelLoading.Name = "panelLoading";
            this.panelLoading.Size = new System.Drawing.Size(722, 275);
            this.panelLoading.TabIndex = 10;
            this.panelLoading.Visible = false;
            this.panelLoading.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBoxLoading
            // 
            this.pictureBoxLoading.Image = global::WarehouseAdmin.Properties.Resources.icons8_спиннер__кадр_3_48;
            this.pictureBoxLoading.Location = new System.Drawing.Point(333, 47);
            this.pictureBoxLoading.Name = "pictureBoxLoading";
            this.pictureBoxLoading.Size = new System.Drawing.Size(59, 46);
            this.pictureBoxLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxLoading.TabIndex = 11;
            this.pictureBoxLoading.TabStop = false;
            // 
            // pictureBoxEye
            // 
            this.pictureBoxEye.Image = global::WarehouseAdmin.Properties.Resources.icons8_показать_30;
            this.pictureBoxEye.Location = new System.Drawing.Point(110, 274);
            this.pictureBoxEye.Name = "pictureBoxEye";
            this.pictureBoxEye.Size = new System.Drawing.Size(53, 51);
            this.pictureBoxEye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxEye.TabIndex = 6;
            this.pictureBoxEye.TabStop = false;
            this.pictureBoxEye.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Auth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(722, 450);
            this.Controls.Add(this.panelLoading);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.pictureBoxEye);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.roundedButtonAuth);
            this.Name = "Auth";
            this.Load += new System.EventHandler(this.Auth_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLuna)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCloud1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCloud2)).EndInit();
            this.panelLoading.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEye)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelExit;
        private RoundedButton roundedButtonAuth;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.PictureBox pictureBoxEye;
        private System.Windows.Forms.PictureBox pictureBoxCloud2;
        private System.Windows.Forms.PictureBox pictureBoxCloud1;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelMain;
        private System.Windows.Forms.PictureBox pictureBoxLuna;
        private System.Windows.Forms.Panel panelLoading;
        private System.Windows.Forms.PictureBox pictureBoxLoading;
    }
}