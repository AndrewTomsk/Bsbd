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
    public partial class FormWareUpdate : Form
    {
        public FormWareUpdate()
        {
            InitializeComponent();
        }
        private async Task LoadDataAsync()
        {
            RGB rGB = new RGB(255, 0, 0);
            rGB.load(label2);
            await Task.Delay(3000);
            roundedButtonUpdate.Visible = true;
        }
        async private void FormWareUpdate_Load_1(object sender, EventArgs e)
        {
            ВместимостьСм.Text = "00";
            ControlBox = false;
            this.MaximizeBox = false; // Запрет максимизации
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // Запрет изменения размеров
            Database _database = new Database();
            _database.return_ID_ComboBox($"Номер_Склада", "Склад", Номер_Склада);
            await LoadDataAsync();
        }
        private void Update(System.Windows.Forms.TextBox textBoxFieldNameANDText)
        {
            Database _database = new Database();
            string table = "Склад";
            _database.update_table(table, Номер_Склада.Name, Номер_Склада.Text
                        , textBoxFieldNameANDText.Name, textBoxFieldNameANDText.Text);
        }
        private void roundedButtonUpdate_Click(object sender, EventArgs e)
        {
            CheckPassword checkPassword = new CheckPassword();
            checkPassword.ShowDialog();
            bool flag = false;
            if (Номер_Склада.Text != String.Empty)
            {
                if (Название.Text != "")
                {
                    Update(Название);
                    flag = true;
                }
                if (Описание.Text != "")
                {
                    Update(Описание);
                    flag = true;
                }
                if (Вместимость.Text != "" && ВместимостьСм.Text != "")
                {
                    string v = Вместимость.Text + "." + ВместимостьСм.Text;
                    Database _database = new Database();
                    string table = "Склад";
                    _database.update_table(table, Номер_Склада.Name, Номер_Склада.Text
                                , "Вместимость", v);
                    flag = true;
                }
                if (textBoxCity.Text != "" && textBoxStreet.Text != "" && textBoxHouse.Text != "")
                {
                    string v = textBoxCity.Text + ", " + textBoxStreet.Text + ", " + textBoxHouse.Text;
                    Database _database = new Database();
                    string table = "Склад";
                    _database.update_table(table, Номер_Склада.Name, Номер_Склада.Text
                                , "Адресс", v);
                    flag = true;
                }
                if (flag)
                {
                    MessageBox.Show("Данные обновлены");
                }
            }
            else
            {
                MessageBox.Show("Введите id склада!");
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Вместимость_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) ||
                e.KeyChar == ' ' || Вместимость.Text.Length == 7)
            {
                if (e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
            }
        }

        private void ВместимостьСм_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) ||
                e.KeyChar == ' ' || ВместимостьСм.Text.Length == 2)
            {
                if (e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
            }
        }

        private void textBoxStreet_TextChanged(object sender, EventArgs e)
        {

        }

        private void Номер_Склада_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
