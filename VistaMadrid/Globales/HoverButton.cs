using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VistaMadrid
{
    public class HoverButton 
    {

        public void MouseOn(Button btn)
        {
            
            btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(40)))));
            btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(40)))));
            btn.BackColor = Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(40)))));
            btn.ForeColor = Color.White;

        }

        public void MouseOff(Button btn) {
            btn.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn.BackColor = Color.FromArgb(249, 250, 252);
            btn.ForeColor = Color.Black;
            btn.Refresh();
        }

    }
}
