using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using hospital_management_system.classes;

namespace hospital_management_system.gui.forms
{

    public partial class FormMain : Form
    {
        private System.Drawing.Color blue = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(132)))), ((int)(((byte)(222)))));
        private EmployeeDetails employee;

        public void enableNavigationMenu()
        {
            navigationMenu.Enabled = true;
        }

        public void disableNavigationMenu()
        {
            navigationMenu.Enabled = false;
        }

        public FormMain()
        {
            InitializeComponent();
            navigationMenu.Enabled = false;

        }

        #region Draggable Window Function

        // Source: https://stackoverflow.com/questions/1592876/make-a-borderless-form-movable
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void draggable_window(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        #endregion

        #region Navigation Bar Icon Functions

        private void closeIcon_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void maximizeIcon_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }

        }

        private void minimizeIcon_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

        #region Display Forms Function

        private Form active_window = null;
        public void openChildWindow(Form childWindow)
        {
            if (active_window == childWindow)
            {
                return;
            }

            if (active_window != null)
            {
                active_window.Close();
            }

            active_window = childWindow;
            childWindow.TopLevel = false;
            childWindow.FormBorderStyle = FormBorderStyle.None;
            childWindow.Dock = DockStyle.Fill;
            displayPanel.Controls.Add(childWindow);
            displayPanel.Tag = childWindow;
            childWindow.BringToFront();
            childWindow.Show();
        }

        #endregion

        #region Display Sub Menu Functions

        private void hideSubMenu()
        {
            if (patientSubMenu.Visible)
            {
                patientSubMenu.Visible = false; 
            }
            if (doctorSubMenu.Visible)
            {
                doctorSubMenu.Visible = false; 
            }
            if (regSubMenu.Visible)
            {
                regSubMenu.Visible = false; 
            }
            if (billSubMenu.Visible)
            {
                billSubMenu.Visible = false; 
            }

        }

        private void showSubMenu(Panel submenu)
        {
            if (submenu == null)
            {
                hideSubMenu();
                return;
            }

            if (submenu.Visible == false)
            {
                hideSubMenu();
                submenu.Visible = true;
            }
            else
            {
                // Hides the menu panel if the user clicks the button again
                submenu.Visible = false;
            }
        }

        #endregion

        #region Button Effect Functions

        private void buttonEffect(Button btn, Panel submenu = null)
        {
            showActiveButton(btn);
            showSubMenu(submenu);
        }

        private void showInactiveButton(Button btn)
        {
            btn.BackColor = Color.White;
            btn.ForeColor = Color.Black;
        }

        private void showActiveButton(Button btn)
        {
            showInactiveButton(dashboardBtn);
            showInactiveButton(patientBtn);
            showInactiveButton(doctorBtn);
            showInactiveButton(regBtn);
            showInactiveButton(labBtn);
            showInactiveButton(roomBtn);
            showInactiveButton(billBtn);
            btn.BackColor = blue;
            btn.FlatAppearance.BorderColor = blue;
            btn.ForeColor = Color.White;
        }

        #endregion

        #region Navigation Menu Functions

        private void dashboardBtn_Click(object sender, EventArgs e)
        {
            openChildWindow(new PageDashboard(this.employee));
            buttonEffect(dashboardBtn);
        }

        private void patientBtn_Click(object sender, EventArgs e)
        {
            openChildWindow(new PageView("patient"));
            buttonEffect(patientBtn, patientSubMenu);
            
        }

        private void doctorBtn_Click(object sender, EventArgs e)
        {
            // openChildWindow(new employeeForm());
            buttonEffect(doctorBtn, doctorSubMenu);
        }

        private void regBtn_Click(object sender, EventArgs e)
        {
            // openChildWindow(new appointmentForm());
            buttonEffect(regBtn, regSubMenu);
        }

        private void labBtn_Click(object sender, EventArgs e)
        {
            buttonEffect(labBtn);
        }

        private void roomBtn_Click(object sender, EventArgs e)
        {
            buttonEffect(roomBtn);
        }

        private void billBtn_Click(object sender, EventArgs e)
        {
            // openChildWindow(new billingForm());
            buttonEffect(billBtn, billSubMenu);
        }

        #endregion

        #region Login Functions
        private void loginBtn_Click(object sender, EventArgs e)
        {
            dbAccess db = new dbAccess();

            var account = db.findAccount(emailTextbox.Text, passwordTextbox.Text);

            if (account == null)
            {
                emailText.ForeColor = Color.Red;
                passwordText.ForeColor = Color.Red;
                emailText.Text = "* Incorrect Email Address";
                passwordText.Text = "* Incorrect Password";
                emailTextbox.Text = "";
                passwordTextbox.Text = "";
                return;
            }

            this.employee = account[0];
            openChildWindow(new PageDashboard(this.employee));
            navigationMenu.Enabled = true;
            loginPanel.Hide();
        }

        private void emailTextbox_Click(object sender, EventArgs e)
        {
            emailText.ForeColor = Color.Black;
            emailText.Text = "Email Address";
        }

        private void passwordTextbox_Click(object sender, EventArgs e)
        {
            passwordText.ForeColor = Color.Black;
            passwordText.Text = "Password";
        }

        #endregion
    }
}
