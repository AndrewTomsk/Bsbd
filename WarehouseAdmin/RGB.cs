using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarehouseAdmin
{
    class RGB
    {
        private byte _r;
        private byte _g;
        private byte _b;
        public RGB( byte r, byte g, byte b)
        {
            _r = r;
            _g = g;
            _b = b;
        }
        async public void load(Label label)
        {
            for (byte r = this._r, g = this._g, b = this._b; r <=255;
                r += 5, await Task.Delay(60))
            {
                label.ForeColor = Color.FromArgb(r, g, b);
            }
        }
    }
}
