using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WarehouseAdmin.Properties;

namespace WarehouseAdmin
{
    public partial class Auth : Form
    {
        private int angle = 0; // Угол поворота изображения
        public Auth()
        {
            InitializeComponent();
        }
        private void Auth_Load(object sender, EventArgs e)
        {
            ControlBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false; // Запрет максимизации
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // Запрет изменения размеров
            Cloud cloud1 = new Cloud();
            cloud1.Right(pictureBoxCloud1,panelHeader);
            cloud1.Left(pictureBoxCloud2, panelHeader);
        }
        async private void RotatePictureBox(PictureBox pictureBox)
        {
            while (true)
            {
                angle += 5; // Увеличиваем угол поворота

                if (angle >= 360) // Если угол больше или равен 360 градусам, сбрасываем его
                {
                    angle = 0;
                }

                // Поворот изображения на заданный угол (в данном случае на 5 градусов)
                Image img = pictureBox.Image;
                img.RotateFlip(RotateFlipType.Rotate90FlipNone); // Например, вращение на 90 градусов

                // Задаем повернутое изображение обратно в PictureBox
                pictureBox.Image = img;

                // Обновляем PictureBox, чтобы отобразить изменения
                pictureBox.Invalidate();
                await Task.Delay(300);
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {
            Exit.Go(this);
        }

        async private void roundedButtonAuth_Click(object sender, EventArgs e)
        {
            int count = 0;
            panelLoading.Visible = true;
            while (count < 5) {
                RotatePictureBox(pictureBoxLoading);
                count++;
                await Task.Delay(300);
            }
            Database database = new Database();
            bool token = database.Auth(textBoxLogin.Text, textBoxPassword.Text);
            if (token)
            {

                Main main = new Main();
                main.Show();
                this.Hide();
            }
            else
            {
                panelLoading.Visible = false;
            }
        }
        
        private void textBoxLogin_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBoxLogin.Text == "login")
            {
                textBoxLogin.Text = String.Empty;
            }
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBoxPassword.Text == "password")
            {
                textBoxPassword.Text = String.Empty;
            }
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            textBoxPassword.PasswordChar = '●';
        }

        async private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBoxEye.Image = Resources.eyex;
            textBoxPassword.PasswordChar = '\0';
            await Task.Delay(1500);
            textBoxPassword.PasswordChar = '●';
            pictureBoxEye.Image = Resources.icons8_показать_30;
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxCloud1.Image = Resources.icons8_дождь_30;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxCloud1.Image = Resources.icons8_облако_30;
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxCloud2.Image = Resources.icons8_дождь_30;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxCloud2.Image = Resources.icons8_облако_30;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
