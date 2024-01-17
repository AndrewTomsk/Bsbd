using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WarehouseAdmin
{
    public partial class FormWareAdd : Form
    {
        public FormWareAdd()
        {
            InitializeComponent();
        }

        private void FormWareAdd_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSetW.Склад". При необходимости она может быть перемещена или удалена.
            this.складTableAdapter.Fill(this.dataSetW.Склад);
            ControlBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false; // Запрет максимизации
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // Запрет изменения размеров
            toolTip1.InitialDelay = 100;
            toolTip1.SetToolTip(textBoxDiscription, "Не обязательное поле");
            textBoxVfloat.Text = "00";
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string adress = textBoxCity.Text + ", " + textBoxStreet.Text + ", " + textBoxHouse.Text;
            string v = textBoxVINT.Text + "." + textBoxVfloat.Text;
            Database database = new Database();
            database.AddWare(textBoxName.Text, adress, textBoxDiscription.Text, v, "Данные обновлены");
        }

        private void textBoxVINT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) ||
                e.KeyChar == ' ' || textBoxVINT.Text.Length == 7)
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

        private void textBoxCity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) ||
                e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }

        private void textBoxStreet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) ||
                e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }

        private void textBoxHouse_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) ||
                e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }
    }
}
