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
using hospital_management_system.classes.effects;

namespace hospital_management_system.gui.forms
{

    public partial class FormMain : Form
    {
        private System.Drawing.Color blue = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(132)))), ((int)(((byte)(222)))));
        private EmployeeDetails employee;

        public FormMain()
        {
            InitializeComponent();
            navigationMenu.Enabled = false;

        }

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

        #region Display Pages Function

        private Form active_window = null;
        public void OpenChildWindow(Form childWindow)
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

        private void HideSubMenu()
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

        private void ShowSubMenu(Panel submenu)
        {
            if (submenu == null)
            {
                HideSubMenu();
                return;
            }

            if (submenu.Visible == false)
            {
                HideSubMenu();
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

        private ButtonEffect btn_effects = new ButtonEffect();

        private void ButtonEffect(Button btn, Panel submenu = null)
        {
            ResetButtonEffects();
            this.btn_effects.ShowActiveButton(btn);
            ShowSubMenu(submenu);
        }

        private void ResetButtonEffects()
        {
            this.btn_effects.ShowInactiveButton(dashboardBtn);
            this.btn_effects.ShowInactiveButton(patientBtn);
            this.btn_effects.ShowInactiveButton(doctorBtn);
            this.btn_effects.ShowInactiveButton(regBtn);
            this.btn_effects.ShowInactiveButton(labBtn);
            this.btn_effects.ShowInactiveButton(roomBtn);
            this.btn_effects.ShowInactiveButton(billBtn);
        }

        #endregion

        #region Navigation Menu Functions

        public void dashboardBtn_Click(object sender, EventArgs e)
        {
            OpenChildWindow(new PageDashboard(this, this.employee));
            ButtonEffect(dashboardBtn);
        }

        public void patientBtn_Click(object sender, EventArgs e)
        {
            OpenChildWindow(new PageView("patient"));
            ButtonEffect(patientBtn, patientSubMenu);
            
        }

        public void doctorBtn_Click(object sender, EventArgs e)
        {
            OpenChildWindow(new PageView("employee"));
            ButtonEffect(doctorBtn, doctorSubMenu);
        }

        public void regBtn_Click(object sender, EventArgs e)
        {
            OpenChildWindow(new PageView("appointment"));
            
            ButtonEffect(regBtn, regSubMenu);
        }

        public void labBtn_Click(object sender, EventArgs e)
        {
            OpenChildWindow(new PageView("laboratory"));
            ButtonEffect(labBtn);
        }

        public void roomBtn_Click(object sender, EventArgs e)
        {
            OpenChildWindow(new PageView("room"));
            ButtonEffect(roomBtn);
        }

        public void billBtn_Click(object sender, EventArgs e)
        {
            OpenChildWindow(new PageView("billing"));
            ButtonEffect(billBtn, billSubMenu);
        }

        #endregion

        #region Login and Logout Functions
        private void loginBtn_Click(object sender, EventArgs e)
        {
            dbAccess db = new dbAccess();

            var account = db.findAccount(emailTextbox.Text, passwordTextbox.Text);

            if (account == null || account.Count > 1)
            {
                AccountDoesNotExist();
                return;
            }

            AccountExists(account[0]);
        }

        private void AccountDoesNotExist()
        {
            emailText.ForeColor = Color.Red;
            passwordText.ForeColor = Color.Red;
            emailText.Text = "* Incorrect Email Address";
            passwordText.Text = "* Incorrect Password";
            emailTextbox.Text = "";
            passwordTextbox.Text = "";
        }

        private void AccountExists(EmployeeDetails employee)
        {
            this.employee = employee;
            OpenChildWindow(new PageDashboard(this, this.employee));
            navigationMenu.Enabled = true;
            this.btn_effects.ShowActiveButton(dashboardBtn);
            loginPanel.Hide();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            active_window.Close();
            active_window = null;
            
            HideSubMenu();
            ResetButtonEffects();
            navigationMenu.Enabled = false;
            
            loginPanel.Show();
            emailTextbox.Text = "";
            passwordTextbox.Text = "";
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

        private void addPatientBtn_Click(object sender, EventArgs e)
        {
            FormPatient form = new FormPatient("add");
            form.Show();
        }
    }
}
