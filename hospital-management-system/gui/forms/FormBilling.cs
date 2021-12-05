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
        private Billings billing;
        public FormBilling(string function, Billings billing = null)
        {
            InitializeComponent();
            this.billing = billing;
            loadBilling(function);
        }

        #region Form Methods
        
        private void loadBilling(string function)
        {
            switch (function)
            {
                case "view":
                    billingForm.Text = "View Billing: " + billing.BillingID;
                    // viewPatient(this.patient);
                    break;
                case "modify":
                    billingForm.Text = "Modify Billing: " + billing.BillingID;
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

        #endregion
    }
}
