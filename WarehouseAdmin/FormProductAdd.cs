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
    public partial class FormProductAdd : Form
    {
        public FormProductAdd()
        {
            InitializeComponent();
        }

        private void FormProductAdd_Load(object sender, EventArgs e)
        {
            ControlBox = false;
            this.MaximizeBox = false; // Запрет максимизации
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // Запрет изменения размеров
            toolTip1.SetToolTip(textBoxDiscription, "Не обязательное поле");
            textBoxVfloat.Text = "00";
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxSecondName_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void comboBoxPosition_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
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

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string v = textBoxVINT.Text + "." + textBoxVfloat.Text;
            if (comboBoxCategory.Text != "Добавить категорию")
            {
                Database database = new Database();
                database.AddProduct(textBoxName.Text, comboBoxCategory.Text,
                    textBoxDiscription.Text, v, "Данные обновлены");
            }
            else
            {

            }
        }
    }
}
