using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace hospital_management_system
{
    public partial class patientForm : Form
    {
        public patientForm(string state, string id = null)
        {
            InitializeComponent();

            switch (state)
            {
                case "view":
                    viewPatientForm(id);
                    break;
                case "new":
                    newPatientForm();
                    break;
                case "modify":
                    modifyPatientForm(id);
                    break;
            }
        }

        #region Openning Patient Form Methods
        public void viewPatientForm(string id) 
        {
            overview_group.Text = "Patient " + id;
            personal_information.Enabled = false;
            address_information.Enabled = false;
            appointment_history.Enabled = false;
        }

        public void newPatientForm()
        {
            overview_group.Text = "Patient Form";
            personal_information.Enabled = true;
            address_information.Enabled = true;
            appointment_history.Enabled = false; 
            appointment_history.Visible = false; 
        }

        public void modifyPatientForm(string id)
        {
            overview_group.Text = "Patient " + id;
            personal_information.Enabled = true;
            address_information.Enabled = true;
            appointment_history.Enabled = true;
        }
        #endregion

    }
}
