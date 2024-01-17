using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarehouseAdmin
{
    public static class Exit
    {
        public static void Go(Form form)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите выйти из программы?"
                , "Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                form.Close();
                Application.Exit();
            }
        }
        public static void Back(Form form)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите выйти из аккаунта?"
                , "Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Auth auth = new Auth();
                auth.Show();
                form.Close();
            }
        }
    }
}
