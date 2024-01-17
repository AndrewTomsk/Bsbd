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
    public partial class FormProducts : Form
    {
        public FormProducts()
        {
            InitializeComponent();
        }

        private void FormProducts_Load(object sender, EventArgs e)
        {
            if (User.Position == "Кладовщик")
            {
                buttonDeleteStuff.Visible = false;
            }
            ControlBox = false;
            this.MaximizeBox = false; // Запрет максимизации
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // Запрет изменения размеров
            MenuContainer.Width -= 195;
            timer1 = new Timer();
            timer1.Interval = 1000; // Установка интервала таймера на 1 секунду
            timer1.Tick += Timer_Tick; // Привязка обработчика события Tick таймера
            timer1.Start();
            // Запретить редактирование ячеек в DataGridView
            товары_СкладаDataGridView.ReadOnly = true;

            // Установить режим выделения строк
            товары_СкладаDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            toolTip1.InitialDelay = 100;
            toolTip1.AutoPopDelay = 2000;
            toolTip2.InitialDelay = 100;
            toolTip2.AutoPopDelay = 2000;
            toolTip3.InitialDelay = 100;
            toolTip3.AutoPopDelay = 2000;
            toolTip4.InitialDelay = 100;
            toolTip4.AutoPopDelay = 2000;
            toolTip1.SetToolTip(buttonStuffAdd, "Добавление товара");
            toolTip2.SetToolTip(buttonChangeInfoStuff, "Изменить данные о товаре");
            toolTip3.SetToolTip(buttonDeleteStuff, "Удаление товара");
            toolTip4.SetToolTip(buttonBack, "Перейти обратно к главному меню");
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSetW.Товары_Склада". При необходимости она может быть перемещена или удалена.
            this.товары_СкладаTableAdapter.Fill(this.dataSetW.Товары_Склада);
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            Exit.Go(this);
        }
        static bool menu = true;
        private void pictureBoxMenu_Click(object sender, EventArgs e)
        {
            if (menu == false)
            {
                PanelHover panel = new PanelHover(false);
                panel.Hover(MenuContainer, 1, 100);
                menu = true;
            }
            else
            {
                PanelHover panel = new PanelHover(true);
                panel.Hover(MenuContainer, 1, 100);
                menu = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }

        private void buttonStuffAdd_Click(object sender, EventArgs e)
        {
            FormProductAdd formProductAdd = new FormProductAdd();
            formProductAdd.ShowDialog();
        }

        private void buttonChangeInfoStuff_Click(object sender, EventArgs e)
        {
            FormProductUpdate formProductUpdate = new FormProductUpdate();
            formProductUpdate.ShowDialog();
        }

        private void buttonDeleteStuff_Click(object sender, EventArgs e)
        {
            FormProductDelete formProductDelete = new FormProductDelete();
            formProductDelete.ShowDialog();
        }
    }
}
