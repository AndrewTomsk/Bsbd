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
    public partial class FormAccGood : Form
    {
        public FormAccGood()
        {
            InitializeComponent();
        }

        private void FormAccGood_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSetW.Приемка_Товара". При необходимости она может быть перемещена или удалена.
            this.приемка_ТовараTableAdapter.Fill(this.dataSetW.Приемка_Товара);
            ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // Запрет изменения размеров
            накладнаяDataGridView.ReadOnly = true;
        }

        private void toolStripButtonExit_Click(object sender, EventArgs e)
        {
            Exit.Go(this);
        }

        private void накладнаяBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                {
                    this.Validate();
                    this.приемкаТовараBindingSource.EndEdit();
                    this.приемка_ТовараTableAdapter.Update(this.dataSetW.Приемка_Товара);
                    MessageBox.Show("Данные успешно сохранены.");
                }
                //else
                //{
                //    MessageBox.Show("Места на складе не достаточно!!!","Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении данных: {ex.Message}");
            }
        }
        
            private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }

        private void номер_НакладнойTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) ||
                e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }

        private void количествоTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) ||
                e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }

        private void код_ТовараTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) ||
                e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }

        private void номер_НакладнойTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            Database database = new Database();
            товары_СкладаDataGridView.DataSource = database.FillDataGridView("SELECT *FROM Накладная");
        }

        private void код_ТовараTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            Database database = new Database();
            товары_СкладаDataGridView.DataSource = database.FillDataGridView("SELECT *FROM Товары_Склада");
        }

        private void цена_За_ЕдTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            // Разрешить только цифры, точку и разрешить только одну точку
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // Разрешить только одну точку в текстовом поле
            if ((e.KeyChar == '.') && textBox.Text.Contains("."))
            {
                e.Handled = true;
            }

            // Разрешить только две цифры после точки
            if (textBox.Text.Contains("."))
            {
                string[] splitText = textBox.Text.Split('.');
                if (splitText.Length > 1 && splitText[1].Length >= 2 && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }

            // Передача фокуса на другой текстовый блок при нажатии Enter
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.SelectNextControl(textBox, true, true, true, true);
            }
        }
    }
}
