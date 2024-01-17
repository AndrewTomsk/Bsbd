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
    public partial class CheckPassword : Form
    {
        public CheckPassword()
        {
            InitializeComponent();
        }

        private void CheckPassword_Load(object sender, EventArgs e)
        {
            ControlBox = false;
            this.MaximizeBox = false; // Запрет максимизации
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // Запрет изменения размеров
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Database database = new Database();
            if (database.Auth(User.Login, textBoxPassword.Text))
            {
                this.Hide();
            }
        }
    }
}
