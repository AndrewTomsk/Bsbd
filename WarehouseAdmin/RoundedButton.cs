using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarehouseAdmin
{
    public class RoundedButton : Button
    {
        public int CornerRadius { get; set; } = 10;

        public RoundedButton()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, CornerRadius * 2, CornerRadius * 2, 180, 90);
            path.AddArc(this.Width - CornerRadius * 2, 0, CornerRadius * 2, CornerRadius * 2, 270, 90);
            path.AddArc(this.Width - CornerRadius * 2, this.Height - CornerRadius * 2, CornerRadius * 2, CornerRadius * 2, 0, 90);
            path.AddArc(0, this.Height - CornerRadius * 2, CornerRadius * 2, CornerRadius * 2, 90, 90);
            this.Region = new Region(path);
        }
    }
}
