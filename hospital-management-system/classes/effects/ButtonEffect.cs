using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hospital_management_system.classes.effects
{
    class ButtonEffect
    {

        public void ShowInactiveButton(Button btn)
        {
            btn.BackColor = Color.White;
            btn.ForeColor = Color.Black;
        }

        public void ShowActiveButton(Button btn)
        {
            btn.BackColor = Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(132)))), ((int)(((byte)(222)))));
            btn.FlatAppearance.BorderColor = Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(132)))), ((int)(((byte)(222))))); ;
            btn.ForeColor = Color.White;
        }
    }
}
