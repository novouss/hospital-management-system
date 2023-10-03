using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using hospital_management_system.classes;
using hospital_management_system.gui.pages;

namespace hospital_management_system
{
    
    public partial class FormWindow : Form
    {
        private DisplayPage DISPLAYPAGE = null;
        private MoreColors COLORS = new MoreColors();
        private FormLogin form = new FormLogin();
        private Employees employee = null;
        public FormWindow(Employees employee, FormLogin form)
        {
            this.employee = employee;
            this.form = form;
            InitializeComponent();
            InitializeCustomComponent();
        }

        private void InitializeCustomComponent()
        {
            this.DISPLAYPAGE = new DisplayPage(this.displaypanel, new PageDashboard(this, employee));

            this.headerlabel.ForeColor = COLORS.RoyalBlue;
            this.sidepanel.BackColor = COLORS.RoyalBlue;

            this.dashboardbtn.BackColor = COLORS.RoyalBlue;
            this.patientbtn.BackColor = COLORS.RoyalBlue;
            this.employeebtn.BackColor = COLORS.RoyalBlue;
            this.appointmentbtn.BackColor = COLORS.RoyalBlue;
            this.billingbtn.BackColor = COLORS.RoyalBlue;
        }

        public void dashboardbtn_Click(object sender, EventArgs e)
        {
            this.DISPLAYPAGE.OpenChildWindow(new PageDashboard(this, this.employee));
        }

        public void patientbtn_Click(object sender, EventArgs e)
        {
            this.DISPLAYPAGE.OpenChildWindow(new PageView("patient"));
        }

        public void employeebtn_Click(object sender, EventArgs e)
        {
            this.DISPLAYPAGE.OpenChildWindow(new PageView("employee"));
        }

        public void appointmentbtn_Click(object sender, EventArgs e)
        {
            this.DISPLAYPAGE.OpenChildWindow(new PageView("appointment"));
        }

        public void billingbtn_Click(object sender, EventArgs e)
        {
            this.DISPLAYPAGE.OpenChildWindow(new PageView("billing"));
        }

        public void logoutbtn_Click(object sender, EventArgs e)
        {
            this.form.Show();
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
            this.form.Show();
        }

        private void maximizebtn_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void minimizebtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        #region Draggable Window

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void headerpanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #endregion

    }
}
