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
    public partial class FormWare : Form
    {
        public FormWare()
        {
            InitializeComponent();
        }

        private void FormWare_Load(object sender, EventArgs e)
        {
            ControlBox = false;
            this.MaximizeBox = false; // Запрет максимизации
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // Запрет изменения размеров
            MenuContainer.Width -= 195;
            Ware ware = new Ware();
            List<int> storageIds = ware.GetAllStorageIds(); // Получение всех номеров складов
            int[] storageIdsArray = storageIds.ToArray(); // Преобразование списка в массив
            decimal V;
            for (int i = 0; i < storageIdsArray.Length; i++)
            {
                V = ware.V(storageIdsArray[i]);
                if (V < 0)
                {
                    labelVcryt.Visible = true;
                   labelVcryt.Text = $"Необходимо освободить склад номер: {storageIdsArray[i]}\n" +
                        $"Необходимо распределить места{V}";
                }
            }
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
            toolTip1.SetToolTip(buttonWareAdd, "Добавление склада");
            toolTip2.SetToolTip(buttonChangeInfoWare, "Изменить данные склада");
            toolTip3.SetToolTip(buttonDeleteWare, "Удаление склада");
            toolTip4.SetToolTip(buttonBack, "Перейти обратно к главному меню");
            string result = null;
            for (int i = 0; i < storageIdsArray.Length; i++)
            {
               result += $"склад номер: {storageIdsArray[i]} " + ware.V(storageIdsArray[i]).ToString()+"\n";
            }
            labelV.Text = "Места свободно\n"+result;
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSetW.Склад". При необходимости она может быть перемещена или удалена.
            this.складTableAdapter.Fill(this.dataSetW.Склад);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Exit.Go(this);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void buttonBack_Click_1(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }

        private void buttonWareAdd_Click(object sender, EventArgs e)
        {
            FormWareAdd formWare = new FormWareAdd();
            formWare.ShowDialog();
        }

        private void buttonDeleteWare_Click(object sender, EventArgs e)
        {
            FormWareDelete formWareDelete = new FormWareDelete();
            formWareDelete.ShowDialog();
        }

        private void buttonChangeInfoWare_Click(object sender, EventArgs e)
        {
            FormWareUpdate formWareUpdate = new FormWareUpdate();
            formWareUpdate.ShowDialog();
        }
    }
}
