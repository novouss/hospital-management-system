using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hospital_management_system
{
    public partial class window : Form
    {
        public window()
        {
            InitializeComponent();
            navigationMenu();
            openChildWindow(new overview());
        }

        #region DisplayChildMenu
        private Form active_window = null;
        public void openChildWindow(Form child_window)
        {
            if (active_window == child_window)
            {
                return;
            }

            if (active_window != null)
            {
                active_window.Close();
            }

            active_window = child_window;
            child_window.TopLevel = false;
            child_window.FormBorderStyle = FormBorderStyle.None;
            child_window.Dock = DockStyle.Fill;
            display_child_window.Controls.Add(child_window);
            display_child_window.Tag = child_window;
            child_window.BringToFront();
            child_window.Show();
        }
        #endregion

        #region NavigationPanel
        private void navigationMenu()
        {
            patient_panel.Visible = false;
            doctor_panel.Visible = false;
            appointment_panel.Visible = false;
            laboratory_panel.Visible = false;
            billing_panel.Visible = false;
        }

        private void hideSubMenu()
        {
            if (patient_panel.Visible == true)
            {
                patient_panel.Visible = false;
            }
            if (doctor_panel.Visible == true)
            {
                doctor_panel.Visible = false;
            }
            if (appointment_panel.Visible == true)
            {
                appointment_panel.Visible = false;
            }
            if(laboratory_panel.Visible == true)
            {
                laboratory_panel.Visible = false;
            }
            if (billing_panel.Visible == true)
            {
                billing_panel.Visible = false;
            }
        }

        private void showSubMenu(Panel menu_panel)
        {
            if (menu_panel.Visible == false)
            {
                hideSubMenu();
                menu_panel.Visible = true;
            } 
            else
            {
                // Hides the menu panel if the user clicks the button again
                menu_panel.Visible = false;
            }
        }
        #endregion

        #region PatientMenu
        private void patient_btn_Click(object sender, EventArgs e)
        {
            openChildWindow(new patient());
            showSubMenu(patient_panel);
        }

        private void addPatient_btn_Click(object sender, EventArgs e)
        {
            openChildWindow(new patientForm());
        }

        #endregion

        #region DoctorMenu
        private void doctor_btn_Click(object sender, EventArgs e)
        {
            showSubMenu(doctor_panel);
        }
        #endregion

        #region AppointmentMenu
        private void appointment_btn_Click(object sender, EventArgs e)
        {
            openChildWindow(new register());
            showSubMenu(appointment_panel);
        }
        #endregion

        #region LaboratoryMenu
        private void laboratory_btn_Click(object sender, EventArgs e)
        {
            showSubMenu(laboratory_panel);
        }
        #endregion

        #region BillingMenu
        private void billing_btn_Click(object sender, EventArgs e)
        {
            showSubMenu(billing_panel);
        }
        #endregion

        private void overview_btn_Click(object sender, EventArgs e)
        {
            openChildWindow(new overview());
            hideSubMenu();
        }
    }
}
