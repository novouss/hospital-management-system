using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using hospital_management_system.classes;

namespace hospital_management_system
{
    public partial class FormBilling : Form
    {

        private dbAccess db = new dbAccess();
        private Patients patient = null;
        public FormBilling(string function)
        {
            InitializeComponent();
            // loadBilling(function);
        }

        private void loadBilling(string function)
        {
            switch (function)
            {
                case "view":
                    billingForm.Text = "View Billing: " + patient.PatientID;
                    // viewPatient(this.patient);
                    break;
                case "modify":
                    billingForm.Text = "Modify Billing: " + patient.PatientID;
                    // modifyPatient();
                    break;
                case "add":
                    billingForm.Text = "Add Billing";
                    // addPatient();
                    break;
                default:
                    break;

            }
        }
    }
}
