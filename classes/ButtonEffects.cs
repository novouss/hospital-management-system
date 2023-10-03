using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using hospital_management_system.gui.components;

namespace hospital_management_system
{
    public class ButtonEffects
    {
        private MoreColors COLORS = new MoreColors();
        private Button ACTIVE = null;
        public ButtonEffects(Button button)
        {
            this.ACTIVE = button;
            SetActiveButton(button);
        }
        public void SetActiveButton(Button button)
        {
            if (this.ACTIVE != null)
            {
                SetInactiveButton(this.ACTIVE);
            }

            button.ForeColor = COLORS.White;
            button.BackColor = COLORS.SteelBlue;
            this.ACTIVE = button;
        }
        public void SetInactiveButton(Button button)
        {
            button.BackColor = COLORS.RoyalBlue;
        }
    }
}
