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
        private Billings billing = null;
        public FormBilling(string function, Billings billing = null)
        {
            InitializeComponent();
            this.billing = billing;

            switch (function)
            {
                case "view":
                    LoadViewBilling();
                    break;
                case "edit":
                    LoadEditBilling();
                    break;
                case "add":
                    LoadAddBilling();
                    break;
            }

        }

        private void LoadAddBilling()
        {
            billingForm.Text = "Add Billing";

            // Configure buttons
            deleteBtn.Visible = false;
            cancelBtn.Visible = true;
            modifyBtn.Visible = false;
            saveBtn.Visible = true;

            saveBtn.Click += SaveNewBilling;
        }

        private void SaveNewBilling(object sender, EventArgs e)
        {
            this.billing = new Billings();
            // TODO: Create display patient screen
   
            db.addBilling(this.billing);
            this.Close();
        }

        private void LoadEditBilling()
        {
            // Configure buttons
            deleteBtn.Visible = true;
            cancelBtn.Visible = true;
            modifyBtn.Visible = false;
            saveBtn.Visible = true;
        }

        private void SaveEditBilling_Click(object sender, EventArgs e)
        {
            // HELP: Update billings not exist
            this.Close();
        }

        private void LoadViewBilling()
        {
            billingForm.Text = "Viewing Billing: " + this.billing.BillingID;
            // Configure buttons
            deleteBtn.Visible = false;
            cancelBtn.Visible = true;
            modifyBtn.Visible = true;
            saveBtn.Visible = false;


        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            // TODO: Create Messagebox warning
            db.RemoveBillings(this.billing);

            this.Close();
        }

        private void modifyBtn_Click(object sender, EventArgs e)
        {
            LoadEditBilling();
        }

    }
}
