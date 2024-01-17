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
    public partial class FormWareDelete : Form
    {
        public FormWareDelete()
        {
            InitializeComponent();
        }
        Database _database = new Database();
        private void FormWareDelete_Load(object sender, EventArgs e)
        {
            ControlBox = false;
            this.MaximizeBox = false; // Запрет максимизации
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // Запрет изменения размеров
            MessageBox.Show("Проверьте имеются ли товары на складе!!!");
            _database.return_ID_ComboBox($"Номер_Склада", "Склад", comboBoxIds);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            CheckPassword checkPassword = new CheckPassword();
            checkPassword.ShowDialog();
            if (comboBoxIds.Text != String.Empty)
            {
                Database database = new Database();
                database.delete_ID("Номер_Склада", comboBoxIds.Text, "Склад");
                MessageBox.Show("Склад удален");
            }
            else
            {
                MessageBox.Show("Задайте значение id склада");
            }
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
