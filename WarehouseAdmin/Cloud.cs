using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarehouseAdmin
{
    interface ICloud
    {
        void Right(PictureBox pb, Panel panel);
        void Left(PictureBox pb, Panel panel);
    }
    /// <summary>
    /// Объект Облако
    /// </summary>
    public class Cloud : ICloud
    {
        /// <summary>
        /// Движение облака вправо
        /// </summary>
        /// <param name="pb"></param>
        /// <param name="panel"></param>
        async public void Right(PictureBox pb, Panel panel)
        {
            while (pb.Left < panel.Width - pb.Width)
            {
                pb.Left += 1;
                await Task.Delay(20);
            }
            Left(pb, panel);
        }
        /// <summary>
        /// Движение облака влево
        /// </summary>
        /// <param name="pb"></param>
        /// <param name="panel"></param>
        async public void Left(PictureBox pb, Panel panel)
        {
            while (pb.Left > panel.Left)
            {
                pb.Left -= 1;
                await Task.Delay(20);
            }
            Right(pb, panel);
        }
    }
}
