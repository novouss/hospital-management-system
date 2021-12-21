using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using experimental_hospital_management_system.classes;

namespace experimental_hospital_management_system
{
    public partial class FormBilling : Form
    {
        private MoreColors COLORS = new MoreColors();
        private dbAccess db = new dbAccess();
        private Billings billing = null;
        public FormBilling(string function, Billings billing = null)
        {
            InitializeComponent();
            InitializeCustomComponent();
            this.billing = billing;

            switch (function)
            {
                case "view":
                    LoadViewBilling();
                    break;
                case "add":
                    LoadAddBilling();
                    break;
            }
        }

        private void InitializeCustomComponent()
        {
            statusInfobox.BackColorActiveState = COLORS.MediumSeaGreen;
            statusInfobox.BackColorInactiveState = COLORS.Crimson;
            statusInfobox.ButtonState("active");

            regButtonbox.MainButtonbox_Click += RegButtonbox_MainButtonbox_Click;
            regButtonbox.SubButtonbox_Click -= RegButtonbox_SubButtonbox_Click;
            statusInfobox.CheckedButton_Click += StatusInfobox_CheckedButton_Click;
        }

        private void StatusInfobox_CheckedButton_Click(object sender, EventArgs e)
        {
            if (statusInfobox.Status == 1)
            {
                statusInfobox.LabelButton = "Unpaid";
                statusInfobox.ButtonState("inactive");
                statusInfobox.Status = 0;
            }
            else
            {
                statusInfobox.LabelButton = "Paid";
                statusInfobox.ButtonState("active");
                statusInfobox.Status = 1;
            }
        }

        private void RegButtonbox_SubButtonbox_Click(object sender, EventArgs e)
        {
            FormAppointment form = new FormAppointment("view", (regButtonbox.Value as Registrations));
            form.Show();
        }

        private void RegButtonbox_MainButtonbox_Click(object sender, EventArgs e)
        {
            using (var form = new FormSelection("registration"))
            {
                var result = form.ShowDialog();

                if (result == DialogResult.OK)
                {
                    regButtonbox.Value = form.registration;
                    regButtonbox.VisibleSubButton = true;
                }
            }
        }

        #region Form Methods

        private void LoadAddBilling()
        {
            billingForm.Text = "Add Billing";

            // Visualizes Information and record
            regButtonbox.VisibleSubButton = false;
            statusInfobox.Visible = false;

            // Configure user input
            billingDetails.Enabled = true;

            // Configure buttons
            deleteBtn.Visible = false;
            cancelBtn.Visible = true;
            saveBtn.Visible = true;

            saveBtn.Click += SaveNewBilling;
        }

        private void SaveNewBilling(object sender, EventArgs e)
        {
            this.billing = new Billings();

            this.billing.RegistrationID = (regButtonbox.Value as Registrations).RegistrationID;
            this.billing.Status = statusInfobox.Status;
            
            db.AddBilling(this.billing);
            this.Close();
        }

        private void LoadEditBilling()
        {
            this.billing.RegistrationID = (regButtonbox.Value as Registrations).RegistrationID;
            this.billing.Status = statusInfobox.Status;

            // Configure user input
            billingDetails.Enabled = true;

            // Configure buttons
            deleteBtn.Visible = true;
            cancelBtn.Visible = true;
            modifyBtn.Visible = false;
            saveBtn.Visible = true;

            saveBtn.Click += SaveEditBilling_Click;
        }

        private void SaveEditBilling_Click(object sender, EventArgs e)
        {
            db.UpdateBilling(this.billing);
            this.Close();
        }

        private void LoadViewBilling()
        {
            billingForm.Text = "Viewing Billing: " + this.billing.BillingID;

            if (this.billing.Status == 1)
            {
                statusInfobox.LabelButton = "Paid";
                statusInfobox.ButtonState("active");
            }
            else
            {
                statusInfobox.LabelButton = "Unpaid";
                statusInfobox.ButtonState("inactive");
            }

            roomInfobox.TextboxText = this.billing.RoomFee + "";
            labInfobox.TextboxText = this.billing.LaboratoryFee + "";
            depInfobox.TextboxText = this.billing.DepartmentFee + "";
            totalInfobox.TextboxText = this.billing.Total + "";        

            // Configure user input
            billingDetails.Enabled = false;
            
            // Configure buttons
            deleteBtn.Visible = false;
            cancelBtn.Visible = true;
            modifyBtn.Visible = true;
            saveBtn.Visible = false;
        }

        #endregion

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            db.RemoveBillings(this.billing);
            this.Close();
        }

        private void modifyBtn_Click(object sender, EventArgs e)
        {
            LoadEditBilling();
        }
    }
}
