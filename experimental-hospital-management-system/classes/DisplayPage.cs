using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace experimental_hospital_management_system.classes
{
    public class DisplayPage
    {
        private Panel displayPanel = null;
        private Form activeWindow = null;

        public DisplayPage(Panel displaypanel, Form activewindow)
        {
            this.displayPanel = displaypanel;
            OpenChildWindow(activewindow);
        }
        public void OpenChildWindow(Form childWindow)
        {
            if (this.activeWindow == childWindow)
            {
                return;
            }

            if (this.activeWindow != null)
            {
                this.activeWindow.Close();
            }

            this.activeWindow = childWindow;
            childWindow.TopLevel = false;
            childWindow.FormBorderStyle = FormBorderStyle.None;
            childWindow.Dock = DockStyle.Fill;
            this.displayPanel.Controls.Add(childWindow);
            this.displayPanel.Tag = childWindow;
            childWindow.BringToFront();
            childWindow.Show();
        }
    }
}
