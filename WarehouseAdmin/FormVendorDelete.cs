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
    public partial class FormVendorDelete : Form
    {
        public FormVendorDelete()
        {
            InitializeComponent();
        }
        Database _database = new Database();
        private void FormVendorDelete_Load(object sender, EventArgs e)
        {
            ControlBox = false;
            this.MaximizeBox = false; // Запрет максимизации
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // Запрет изменения размеров
            MessageBox.Show("Проверьте, есть ли данные связанные с поставщиком");
            _database.return_ID_ComboBox($"Код_Поставщика", "Поставщик", comboBoxIds);
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            CheckPassword checkPassword = new CheckPassword();
            checkPassword.ShowDialog();
            if (comboBoxIds.Text != String.Empty)
            {
                Database database = new Database();
                database.delete_ID("Код_Поставщика", comboBoxIds.Text, "Поставщик");
                MessageBox.Show("Поставщик удален");
            }
            else
            {
                MessageBox.Show("Задайте значение id склада");
            }
        }
    }
}
