using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarehouseAdmin
{
    class PanelHover
    {
        bool _menu;
        public PanelHover(bool menu)
        {
            _menu = menu;
        }
        async public  void Hover(Panel MenuContainer,int step,int speed)
        {
            if (_menu == false)
            {
                while (step != 0)
                {
                    MenuContainer.Width -= speed;
                    await Task.Delay(1);
                    step--;
                }
                _menu = true;
            }
            else
            {
                while (step != 0)
                {
                    MenuContainer.Width += speed;
                    await Task.Delay(1);
                    step--;
                }
                _menu = false;
            }
        }
    }
}
