using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Reflection.Emit;
using System.Windows.Forms;
using WarehouseAdmin.CenteredComboBox;

namespace WarehouseAdmin
{
    public partial class Entrance : Form
    {
        public Entrance()
        {
            InitializeComponent();
        }

        private void Entrance_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSetW.Приемка_Товара". При необходимости она может быть перемещена или удалена.
            this.приемка_ТовараTableAdapter.Fill(this.dataSetW.Приемка_Товара);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSetW.Накладная". При необходимости она может быть перемещена или удалена.
            this.накладнаяTableAdapter.Fill(this.dataSetW.Накладная);
            ControlBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false; // Запрет максимизации
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // Запрет изменения размеров
            Database database = new Database();
            database.return_ID_ComboBox("Номер_Накладной", "Накладная", comboBoxId);
            comboBoxId.TabStop = false;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Exit.Go(this);
        }


        string GetSelectedFieldName()
        {
            return
           приемка_ТовараDataGridView.Columns[приемка_ТовараDataGridView.FirstDisplayedCell.ColumnIndex
           ].DataPropertyName;
        }

        private void comboBoxId_TextChanged(object sender, EventArgs e)
        {
            try
            {
                приемка_ТовараBindingSource.Filter =
               GetSelectedFieldName() + "='" + comboBoxId.Text + "'";
            }
            catch
            {

            }
        }

        private void comboBoxId_MouseClick(object sender, MouseEventArgs e)
        {
            comboBoxId.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormProductAdd formProductAdd = new FormProductAdd();
            formProductAdd.ShowDialog();
        }

        private void накладнаяBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.накладнаяBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dataSetW);
                MessageBox.Show("Данные сохранены");
                Database database = new Database();
                database.return_ID_ComboBox("Номер_Накладной", "Накладная", comboBoxId);
                this.накладнаяTableAdapter.Fill(this.dataSetW.Накладная);
            }
            catch
            {
                MessageBox.Show("Введите корректные данные");
            }

        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.приемка_ТовараBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dataSetW);
                MessageBox.Show("Данные сохранены");
            }
            catch
            {
                MessageBox.Show("Введите корректные данные");
            }
        }

        private void приемка_ТовараDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Введите корректные данные");
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            panelNak.Visible = true;
            lid.Text = String.Empty;
        }

        private void номер_НакладнойTextBox_TextChanged(object sender, EventArgs e)
        {
            lid.Text = номер_НакладнойTextBox.Text;
        }

        private void код_ПоставщикаTextBox_TextChanged(object sender, EventArgs e)
        {
            Database database = new Database();
            lVn.Text = database.getNameVendor(код_ПоставщикаTextBox.Text);
        }

        private void код_СотрудникаTextBox_TextChanged(object sender, EventArgs e)
        {
            Database database = new Database();
            lSt.Text = database.getNameStuff(код_СотрудникаTextBox.Text);
        }

        private void номер_СкладаTextBox_TextChanged(object sender, EventArgs e)
        {
            Database database = new Database();
            lWr.Text = database.getNameWrs(номер_СкладаTextBox.Text);
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception)
            {

            }
        }
    }
}
