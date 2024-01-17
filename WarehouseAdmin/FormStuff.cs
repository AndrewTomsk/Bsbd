using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WarehouseAdmin
{
    public partial class FormStuff : Form
    {
        public FormStuff()
        {
            InitializeComponent();
        }

        private void FormStuff_Load(object sender, EventArgs e)
        {
            ControlBox = false;
            this.MaximizeBox = false; // Запрет максимизации
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // Запрет изменения размеров
            MenuContainer.Width -= 195;
            timer1 = new Timer();
            timer1.Interval = 1000; // Установка интервала таймера на 1 секунду
            timer1.Tick += Timer_Tick; // Привязка обработчика события Tick таймера
            timer1.Start();
            // Запретить редактирование ячеек в DataGridView
            персоналDataGridView.ReadOnly = true;

            // Установить режим выделения строк
            персоналDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            toolTip1.InitialDelay = 100;
            toolTip1.AutoPopDelay = 2000;
            toolTip2.InitialDelay = 100;
            toolTip2.AutoPopDelay = 2000;
            toolTip3.InitialDelay = 100;
            toolTip3.AutoPopDelay = 2000;
            toolTip4.InitialDelay = 100;
            toolTip4.AutoPopDelay = 2000;
            toolTip1.SetToolTip(buttonStuffAdd, "Добавление пользователя");
            toolTip2.SetToolTip(buttonChangeInfoStuff,"Изменить данные пользователя");
            toolTip3.SetToolTip(buttonDeleteStuff, "Удаление пользователя");
            toolTip4.SetToolTip(buttonBack, "Перейти обратно к главному меню");
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSetW.Персонал". При необходимости она может быть перемещена или удалена.
            this.персоналTableAdapter.Fill(this.dataSetW.Персонал);
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            Exit.Go(this);
        }

        private void buttonDeleteStuff_Click(object sender, EventArgs e)
        {
            FormStuffDelete formStuffDelete = new FormStuffDelete();
            formStuffDelete.ShowDialog();
        }
        static bool menu = true;

        private void pictureBoxMenu_Click(object sender, EventArgs e)
        {
            if (menu == false)
            {
                PanelHover panel = new PanelHover(false);
                panel.Hover(MenuContainer, 1,100);
                menu = true;
            }
            else
            {
                PanelHover panel = new PanelHover(true);
                panel.Hover(MenuContainer, 1,100);
                menu = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }

        private void персоналBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.персоналBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSetW);

        }

        private void buttonStuffAdd_Click(object sender, EventArgs e)
        {
            FormStuffAdd formStuffAdd = new FormStuffAdd();
            formStuffAdd.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonChangeInfoStuff_Click(object sender, EventArgs e)
        {
            FormStuffUpdate formStuffUpdate = new FormStuffUpdate();
            formStuffUpdate.ShowDialog();
        }
    }
}

