using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using experimental_hospital_management_system.gui.components;

namespace experimental_hospital_management_system.classes
{
    public class PreviewboxEffects
    {
        private MoreColors COLORS = new MoreColors();
        private PreviewBox ActiveButton;
        public void ButtonEffect(PreviewBox previewbox)
        {

            if (ActiveButton != null)
            {
                this.ActiveButton.TableLayout.BackColor = Color.White;
                this.ActiveButton.TextForeColor0 = Color.Black;
                this.ActiveButton.TextForeColor1 = Color.Black;
                // this.ActiveButton.TextForeColor2 = Color.Black; // Text2 is a conditional State
                this.ActiveButton.TextForeColor3 = Color.Black;
            }

            this.ActiveButton = previewbox;

            this.ActiveButton.TextForeColor0 = Color.White;
            this.ActiveButton.TextForeColor1 = Color.White;
            this.ActiveButton.TextForeColor2 = Color.White;
            this.ActiveButton.TextForeColor3 = Color.White;
            this.ActiveButton.TableLayout.BackColor = COLORS.SteelBlue;
        }
    }
}
