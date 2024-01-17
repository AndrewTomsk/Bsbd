using System;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WarehouseAdmin
{
    public partial class FormStuffAdd : Form
    {
        public FormStuffAdd()
        {
            InitializeComponent();
        }

        private void FormStuffAdd_Load(object sender, EventArgs e)
        {
            ControlBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false; // Запрет максимизации
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // Запрет изменения размеров
            toolTip1.InitialDelay = 100;
            toolTip1.SetToolTip(textBoxPassword, "Пароль должен сотсоять из 5 или более символов");
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            textBoxPassword.PasswordChar = '●';
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.Text.Length >= 5)
            {
                    Database database = new Database();
                database.AddStuff(textBoxName.Text, textBoxSecondName.Text, comboBoxPosition.Text,
                    textBoxSalary.Text, textBoxPassword.Text, "Сотрудник добавлен");
                MessageBox.Show($"Логин: {comboBoxPosition.Text}{database.Show_User_ID(comboBoxPosition.Text)}" +
                        $"\nПароль: {textBoxPassword.Text}");
                this.Close();
            }
            else
            {
                MessageBox.Show("Пароль должен состоять из пяти или более символов");
            }
        }

        private void textBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) || e.KeyChar == ' ')
            {
                e.Handled = true; 
            }
        }

        private void textBoxSecondName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) || e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }

        private void textBoxSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) || e.KeyChar == ' ')
            {
                e.Handled = true; 
            }
        }

        private void comboBoxPosition_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
