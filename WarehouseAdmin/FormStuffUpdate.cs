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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WarehouseAdmin
{
    public partial class FormStuffUpdate : Form
    {
        public FormStuffUpdate()
        {
            InitializeComponent();
        }

        private async void FormStuffUpdate_Load(object sender, EventArgs e)
        {
            ControlBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false; // Запрет максимизации
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // Запрет изменения размеров
            Database _database = new Database();
            _database.return_ID_ComboBox($"Код_Сотрудника", "Персонал", Код_Сотрудника);
            toolTip1.InitialDelay = 100;
            toolTip1.SetToolTip(Пароль, "Пароль должен состоять из пяти или более символов");
            await LoadDataAsync();
        }
        private async Task LoadDataAsync()
        {
            RGB rGB = new RGB(255, 0, 0);
            rGB.load(label2);
            await Task.Delay(3000);
            roundedButtonUpdate.Visible = true;
        }
        private void Update(System.Windows.Forms.TextBox textBoxFieldNameANDText)
        {
            Database _database = new Database();
            string table = "Персонал";
            _database.update_table(table, Код_Сотрудника.Name, Код_Сотрудника.Text
                        , textBoxFieldNameANDText.Name, textBoxFieldNameANDText.Text);
        }
        private void roundedButtonUpdate_Click(object sender, EventArgs e)
        {
            CheckPassword checkPassword = new CheckPassword();
            checkPassword.ShowDialog();
            bool flag = false;
            if (Код_Сотрудника.Text != String.Empty)
            {
                if (Имя.Text != "")
                {
                    Update(Имя);
                    flag = true;
                }
                if (Фамилия.Text != "")
                {
                    Update(Фамилия);
                    flag = true;
                }
                if (КомбоДолжность.Text != "")
                {
                    Database _database = new Database();
                    string table = "Персонал";
                    _database.update_table(table, Код_Сотрудника.Name, Код_Сотрудника.Text
                                ,"Должность", КомбоДолжность.Text);
                    flag = true;
                }
                if (Зарплата.Text != "")
                {
                    Update(Зарплата);
                    flag = true;
                }
                if (Пароль.Text != "" && Пароль.Text.Length>=5)
                {
                    Security security = new Security(Пароль.Text);
                    Database _database = new Database();
                    string table = "Персонал";
                    _database.update_table(table, Код_Сотрудника.Name, Код_Сотрудника.Text
                                , "Соль", security.Salt);
                    _database.update_table(table, Код_Сотрудника.Name, Код_Сотрудника.Text
                                , "Хеш_Пароля", security.Password);
                    flag = true;
                }
                if (flag)
                {
                    MessageBox.Show("Данные обновлены");
                }
            }
            else
            {
                MessageBox.Show("Введите id сотрудника!");
            }
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxId_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboBoxPosition_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void Имя_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) || e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }

        private void Фамилия_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) || e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }

        private void Зарплата_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) || e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }
    }
}
