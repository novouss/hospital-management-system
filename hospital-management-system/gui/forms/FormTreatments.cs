using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hospital_management_system.gui.forms
{
    public partial class FormTreatments : Form
    {
        public FormTreatments(string function, string id = null)
        {
            InitializeComponent();
            loadAppointment(function, id);
        }

        private void loadAppointment(string function, string id = null)
        {
            switch (function)
            {
                case "view":
                    appointmentForm.Text = "View Appointment ID: " + id;
                    viewAppointment(id);
                    break;
                case "modify":
                    appointmentForm.Text = "Modify Appointment ID: " + id;
                    modifyAppointment(id);
                    break;
                case "add":
                    appointmentForm.Text = "Add Appointment";
                    addAppointment();
                    break;
                default:
                    break;

            }
        }

        private void addAppointment()
        {
            // Visualize information
            appointmentGroup.Visible = true;
            resultGroup.Visible = true;

            // Allow for user input
            appointmentGroup.Enabled = true;
            resultGroup.Enabled = true;

            // Add Functions
        }

        private void viewAppointment(string id)
        {
            // Visualize information
            appointmentGroup.Visible = true;
            resultGroup.Visible = true;

            // Do not allow for user input
            appointmentGroup.Enabled = false;
            resultGroup.Enabled = false;

            // View Functions
        }

        private void modifyAppointment(string id)
        {
            // Visualize information
            appointmentGroup.Visible = true;
            resultGroup.Visible = true;

            // Allow for user input
            appointmentGroup.Enabled = true;
            resultGroup.Enabled = true;

            // Modify Functions
        }
    }
}
