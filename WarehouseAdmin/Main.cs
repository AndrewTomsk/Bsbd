using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarehouseAdmin
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            if (User.Position == "Кладовщик")
            {
                buttonWar.Text = String.Empty;
                buttonWar.Image = null;
                buttonWar.Enabled = false;
                buttonStuff.Text = String.Empty;
                buttonStuff.Image = null;
                buttonStuff.Enabled = false;
                buttonPriem.Text = "Поступление";
            }
            ControlBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false; // Запрет максимизации
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // Запрет изменения размеров
            timer1.Start();
            labelName.Text = User.Name;
            labelSecondName.Text = User.Surname;
            labelSalary.Text = User.Salary.ToString() + "  ₽";
            labelPosition.Text = User.Position;
        }

        private void buttonStuff_Click(object sender, EventArgs e)
        {
            FormStuff formStuff = new FormStuff();
            formStuff.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Exit.Go(this);
        }
        bool menu = false;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (menu == false)
            {
                PanelHover panel = new PanelHover(false);
                panel.Hover(MenuContainer, 32,5);
                menu = true;
            }
            else
            {
                PanelHover panel = new PanelHover(true);
                panel.Hover(MenuContainer, 32,5);
                menu = false;
            }
        }

        private void MunuContainer_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Обновляем текст Label текущим временем
            labelTime.Text = DateTime.Now.ToString("HH:mm:ss") + "   " + DateTime.Now.ToShortDateString();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Exit.Back(this);
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            if (panelProfile.Visible)
            {
                panelProfile.Visible = false;
                roundedButtonProfile.Text = "скрыть данные";
            }
            else
            {
                panelProfile.Visible = true;
                roundedButtonProfile.Text = "показать профиль";
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonWar_Click(object sender, EventArgs e)
        {
            FormWare formWare = new FormWare();
            formWare.Show();
            this.Hide();
        }

        private void buttonProducts_Click(object sender, EventArgs e)
        {
            FormProducts formProducts = new FormProducts();
            formProducts.Show();
            this.Hide();
        }

        private void buttonVendor_Click(object sender, EventArgs e)
        {
            FormVenror formVenror = new FormVenror();
            formVenror.Show();
            this.Hide();
        }

        private void buttonNak_Click(object sender, EventArgs e)
        {
            FormInvoice formInvoice = new FormInvoice();
            formInvoice.Show();
            this.Hide();
        }

        private void buttonPriem_Click(object sender, EventArgs e)
        {
            if (User.Position == "Кладовщик")
            {
                Entrance entrance = new Entrance();
                entrance.Show();
                this.Hide();
            }
            else
            {
                FormAccGood formAccGoods = new FormAccGood();
                formAccGoods.Show();
                this.Hide();
            }
        }
    }
}
