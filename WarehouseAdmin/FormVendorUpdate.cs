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
    public partial class FormVendorUpdate : Form
    {
        public FormVendorUpdate()
        {
            InitializeComponent();
        }

        private void FormVendorUpdate_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSetW.Поставщик". При необходимости она может быть перемещена или удалена.
            this.поставщикTableAdapter.Fill(this.dataSetW.Поставщик);
            ControlBox = false;
            this.MaximizeBox = false; // Запрет максимизации
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // Запрет изменения размеров
        }

        private void поставщикBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.поставщикBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dataSetW);
                MessageBox.Show("Данные обновлены");
            }
            catch (Exception) { 
                MessageBox.Show("Неверный ввод данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
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

        private void телефонTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
