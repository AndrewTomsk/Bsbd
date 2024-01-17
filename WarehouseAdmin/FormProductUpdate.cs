using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WarehouseAdmin
{
    public partial class FormProductUpdate : Form
    {
        public FormProductUpdate()
        {
            InitializeComponent();
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        async private void FormProductUpdate_Load(object sender, EventArgs e)
        {
            textBoxVfloat.Text = "00";
            ControlBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false; // Запрет максимизации
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // Запрет изменения размеров
            Database _database = new Database();
            _database.return_ID_ComboBox($"Код_Товара_На_Складе", "Товары_Склада", Код_Товара_На_Складе);
            await LoadDataAsync();
        }
        private async Task LoadDataAsync()
        {
            RGB rGB = new RGB(255, 0, 0);
            rGB.load(label3);
            await Task.Delay(3000);
            roundedButtonUpdate.Visible = true;
        }
        private void Update(System.Windows.Forms.TextBox textBoxFieldNameANDText)
        {
            Database _database = new Database();
            string table = "Товары_Склада";
            _database.update_table(table, Код_Товара_На_Складе.Name, Код_Товара_На_Складе.Text
                        , textBoxFieldNameANDText.Name, textBoxFieldNameANDText.Text);
        }

        private void roundedButtonUpdate_Click(object sender, EventArgs e)
        {
            CheckPassword checkPassword = new CheckPassword();
            checkPassword.ShowDialog();
            bool flag = false;
            if (Код_Товара_На_Складе.Text != String.Empty)
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
                if (textBoxVINT.Text != "" && textBoxVfloat.Text != "")
                {
                    string v = textBoxVINT.Text + "." + textBoxVfloat.Text;
                    Database _database = new Database();
                    string table = "Товары_Склада";
                    _database.update_table(table, Код_Товара_На_Складе.Name, Код_Товара_На_Складе.Text
                                , "Объем_Товара", v);
                    flag = true;
                }
                if (Категория_Товара.Text != "")
                {
                    Database _database = new Database();
                    string table = "Товары_Склада";
                    _database.update_table(table, Код_Товара_На_Складе.Name, Код_Товара_На_Складе.Text
                                , "Категория_Товара", Категория_Товара.Text);
                    flag = true;
                }
                if (flag)
                {
                    MessageBox.Show("Данные обновлены");
                }
            }
            else
            {
                MessageBox.Show("Введите id товара!");
            }
        }

        private void Код_Товара_На_Складе_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void Категория_Товара_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void textBoxVINT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) ||
                e.KeyChar == ' ' || textBoxVfloat.Text.Length == 7)
            {
                if (e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
            }
        }

        private void textBoxVfloat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) ||
                e.KeyChar == ' ' || textBoxVfloat.Text.Length == 2)
            {
                if (e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
            }
        }
    }
}
