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
    public partial class FormInvoice : Form
    {
        public FormInvoice()
        {
            InitializeComponent();
        }

        private void FormInvoice_Load(object sender, EventArgs e)
        {
            if (User.Position == "Кладовщик")
            {
                bindingNavigatorDeleteItem.Visible = false;
            }
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSetW.Накладная". При необходимости она может быть перемещена или удалена.
            this.накладнаяTableAdapter.Fill(this.dataSetW.Накладная);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSetW.Накладная". При необходимости она может быть перемещена или удалена.
            this.накладнаяTableAdapter.Fill(this.dataSetW.Накладная);
            ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // Запрет изменения размеров
            накладнаяDataGridView.ReadOnly = true;
        }

        private void накладнаяBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.накладнаяBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dataSetW);
            }
            catch (Exception)
            {
                MessageBox.Show("Неверный ввод данных","Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Exit.Go(this);
        }

        private void накладнаяDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            накладнаяDataGridView.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }

        private void накладнаяDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Неверный ввод данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void код_ПоставщикаTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            Database database = new Database();        
            товары_СкладаDataGridView.DataSource = database.FillDataGridView("SELECT *FROM Поставщик"); 
        }

        private void код_СотрудникаTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            Database database = new Database();
            товары_СкладаDataGridView.DataSource = database.FillDataGridView("SELECT *FROM Персонал");
        }

        private void номер_СкладаTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            Database database = new Database();
            товары_СкладаDataGridView.DataSource = database.FillDataGridView("SELECT *FROM Склад");
        }
    }
}
