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
    public partial class FormProductDelete : Form
    {
        public FormProductDelete()
        {
            InitializeComponent();
        }
        Database _database = new Database();
        private void FormProductDelete_Load(object sender, EventArgs e)
        {
            ControlBox = false;
            this.MaximizeBox = false; // Запрет максимизации
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // Запрет изменения размеров
            _database.return_ID_ComboBox($"Код_Товара_На_Складе", "Товары_Склада", comboBoxIds);
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxIds_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Удаление товара невозможно, если он занесен в другие таблицы с данными");
            CheckPassword checkPassword = new CheckPassword();
            checkPassword.ShowDialog();
            if (comboBoxIds.Text != String.Empty)
            {
                Database database = new Database();
                database.delete_ID("Код_Товара_На_Складе", comboBoxIds.Text, "Товары_Склада");
                MessageBox.Show("Товар удален");
            }
            else
            {
                MessageBox.Show("Задайте значение id товара");
            }
        }
    }
}
