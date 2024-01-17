using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarehouseAdmin
{
    public partial class FormVendorAdd : Form
    {
        public FormVendorAdd()
        {
            InitializeComponent();
        }

        private void FormVendorAdd_Load(object sender, EventArgs e)
        {
            ControlBox = false;
            this.MaximizeBox = false; // Запрет максимизации
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // Запрет изменения размеров
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (названиеTextBox.Text!="" &&
                адрессTextBox.Text!="" &&
                телефонTextBox.Text!="")
            try
            {
                CheckPassword check = new CheckPassword();
                check.ShowDialog();
                Database database = new Database();
                database.AddVendor(названиеTextBox.Text,адрессTextBox.Text,телефонTextBox.Text, "Данные обновлены");
            }
            catch(Exception)
            {
                MessageBox.Show("Не удалось обновить данные");
            }
            else
            {
                MessageBox.Show("Заполните все поля");
            }
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void телефонTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) ||
                e.KeyChar == ' ' || телефонTextBox.Text.Length == 11)
            {
                if (e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
            }
        }
    }
}
