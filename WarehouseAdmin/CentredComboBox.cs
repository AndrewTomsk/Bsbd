using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseAdmin
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    namespace CenteredComboBox
    {
        public class CenteredComboBox : ComboBox
        {
            public CenteredComboBox() : base()
            {
                DrawMode = DrawMode.OwnerDrawFixed;
            }

            protected override void OnDrawItem(DrawItemEventArgs e)
            {
                base.OnDrawItem(e);

                if (e.Index < 0)
                    return;

                e.DrawBackground();

                if (Items[e.Index] != null)
                {
                    StringFormat stringFormat = new StringFormat();
                    stringFormat.Alignment = StringAlignment.Center;
                    stringFormat.LineAlignment = StringAlignment.Center;

                    using (Brush brush = new SolidBrush(e.ForeColor))
                    {
                        e.Graphics.DrawString(Items[e.Index].ToString(), e.Font, brush, e.Bounds, stringFormat);
                    }
                }

                e.DrawFocusRectangle();
            }
            private const int WM_SETFOCUS = 0x0007;

            protected override void WndProc(ref Message m)
            {
                base.WndProc(ref m);

                if (m.Msg == WM_SETFOCUS)
                {
                    using (Graphics g = CreateGraphics())
                    {
                        Rectangle borderRect = new Rectangle(0, 0, Width - 1, Height - 1);
                        ControlPaint.DrawFocusRectangle(g, borderRect, Color.Red, BackColor);
                    }
                }
            }
        }
    }

}
