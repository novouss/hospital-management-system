using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace hospital_management_system
{
    public partial class FormPatient : Form
    {
        public FormPatient(string function, string id = null)
        {
            InitializeComponent();
            loadPatient(function, id);
        }

        private void loadPatient(string function, string id)
        {
            switch (function)
            {
                case "view":
                    viewForm.Text = "View Patient ID: " + id;
                    viewPatient(id);
                    break;
                case "modify":
                    viewForm.Text = "Modify Patient ID: " + id;
                    modifyPatient(id);
                    break;
                case "add":
                    viewForm.Text = "Add Patient";
                    addPatient();
                    break;
                default:
                    break;

            }
        }

        private void addPatient()
        {
            // Visualize information
            infoGroup.Visible = true;
            addressGroup.Visible = true;

            // Allow for user input
            infoGroup.Enabled = true;
            addressGroup.Enabled = true;

            // Add Functions
        }

        private void viewPatient(string id)
        {
            // Visualize information
            infoGroup.Visible = true;
            addressGroup.Visible = true;
            appGroup.Visible = true;

            // Do not allow for user input
            infoGroup.Enabled = false;
            addressGroup.Enabled = false;
            appGroup.Enabled = false;

            // View Functions
        }

        private void modifyPatient(string id)
        {
            // Visualize information
            infoGroup.Visible = true;
            addressGroup.Visible = true;
            appGroup.Visible = true;

            // Allow for user input
            infoGroup.Enabled = true;
            addressGroup.Enabled = true;
            appGroup.Enabled = true;

        }

    }
}
