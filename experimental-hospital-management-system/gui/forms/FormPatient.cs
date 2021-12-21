using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using experimental_hospital_management_system.classes;
using experimental_hospital_management_system.gui.components;

namespace experimental_hospital_management_system
{
    public partial class FormPatient : Form
    {
        private MoreColors COLORS = new MoreColors();
        private dbAccess db = new dbAccess();
        private Patients patient = null;
        public FormPatient(string function, Patients patient = null)
        {
            InitializeComponent();
            this.patient = patient;

            switch (function)
            {
                case "view":
                    LoadViewPatient();
                    break;
                case "edit":
                    LoadEditPatient();
                    break;
                case "add":
                    LoadAddPatient();
                    break;
            }
        }

        #region FormMethods

        private void LoadAddPatient()
        {
            patientForm.Text = "Add Patient";
            // Visualizes Information and record
            personalGroupbox.Visible = true;
            addressGroupbox.Visible = true;
            appointmentGroupbox.Visible = false;
            // Configure user input
            personalGroupbox.Enabled = true;
            addressGroupbox.Enabled = true;
            appointmentGroupbox.Enabled = false;
            // Configure buttons
            deleteBtn.Visible = false;
            cancelBtn.Visible = true;
            modifyBtn.Visible = false;
            saveBtn.Visible = true;

            saveBtn.Click += SaveNewPatient_Click;
        }

        private void SaveNewPatient_Click(object sender, EventArgs e)
        {
            this.patient = new Patients();
            this.patient.FirstName = firstnameInfobox.TextboxText;
            this.patient.MiddleName = middlenameInfobox.TextboxText;
            this.patient.LastName = lastnameInfobox.TextboxText;
            this.patient.Birthdate = birthdateInfobox.GetDate();
            this.patient.Gender = genderInfobox.GetCheckedRadio();
            this.patient.Religion = religionInfobox.TextboxText;
            this.patient.Email = emailInfobox.TextboxText;
            this.patient.PhoneNumber = numberInfobox.TextboxText;

            Addresses address = new Addresses();
            address.Address1 = address1Infobox.TextboxText;
            address.Address2 = address2Infobox.TextboxText;
            address.City = cityInfobox.TextboxText;
            address.Province = provinceInfobox.TextboxText;
            address.Zipcode = zipcodeInfobox.TextboxText;
            address.Country = countryInfobox.TextboxText;

            db.AddPatient(this.patient, address);
            
            this.Close();
        }

        private void LoadEditPatient()
        {
            patientForm.Text = "Edit Patient: " + this.patient.PatientID;

            // Visualizes Information and record
            personalGroupbox.Visible = true;
            addressGroupbox.Visible = true;
            appointmentGroupbox.Visible = true;

            // Configure user input
            personalGroupbox.Enabled = true;
            addressGroupbox.Enabled = true;
            appointmentGroupbox.Enabled = true;

            // Configure buttons
            deleteBtn.Visible = true;
            cancelBtn.Visible = true;
            modifyBtn.Visible = false;
            saveBtn.Visible = true;

            saveBtn.Click += SaveEditPatient_Click;
        }

        private void SaveEditPatient_Click(object sender, EventArgs e)
        { 
            this.patient.FirstName = firstnameInfobox.TextboxText;
            this.patient.MiddleName = middlenameInfobox.TextboxText;
            this.patient.LastName = lastnameInfobox.TextboxText;
            this.patient.Birthdate = birthdateInfobox.GetDate();
            this.patient.Gender = genderInfobox.GetCheckedRadio();
            this.patient.Religion = religionInfobox.TextboxText;
            this.patient.Email = emailInfobox.TextboxText;
            this.patient.PhoneNumber = numberInfobox.TextboxText;

            Addresses address = new Addresses();
            address.Address1 = address1Infobox.TextboxText;
            address.Address2 = address2Infobox.TextboxText;
            address.City = cityInfobox.TextboxText;
            address.Province = provinceInfobox.TextboxText;
            address.Zipcode = zipcodeInfobox.TextboxText;
            address.Country = countryInfobox.TextboxText;

            db.EditPatient(patient, address);

            this.Close();
        }

        private void LoadViewPatient()
        {
            patientForm.Text = "Viewing Patient: " + this.patient.PatientID;
            // Visualizes Information and record
            personalGroupbox.Visible = true;
            addressGroupbox.Visible = true;
            appointmentGroupbox.Visible = true;
            // Configure user input
            personalGroupbox.Enabled = false;
            addressGroupbox.Enabled = false;
            appointmentGroupbox.Enabled = false;
            // Configure buttons
            deleteBtn.Visible = false;
            cancelBtn.Visible = true;
            modifyBtn.Visible = true;
            saveBtn.Visible = false;

            // Display Information
            Addresses address = db.GetAddress(this.patient.AddressID);

            firstnameInfobox.TextboxText = this.patient.FirstName;
            middlenameInfobox.TextboxText = this.patient.MiddleName;
            lastnameInfobox.TextboxText = this.patient.LastName;
            birthdateInfobox.DateText = this.patient.Birthdate;
            switch (this.patient.Gender)
            {
                case "Male":
                    genderInfobox.RadioChecked1 = true;
                    break;
                case "Female":
                    genderInfobox.RadioChecked2 = true;
                    break;
                default:
                    genderInfobox.RadioChecked3 = true;
                    genderInfobox.TextboxText = this.patient.Gender;
                    break;
            }
            religionInfobox.TextboxText = this.patient.Religion;
            emailInfobox.TextboxText = this.patient.Email;
            numberInfobox.TextboxText = this.patient.PhoneNumber;
            
            address1Infobox.TextboxText = address.Address1;
            address2Infobox.TextboxText = address.Address2;
            cityInfobox.TextboxText = address.City;
            provinceInfobox.TextboxText = address.Province;
            zipcodeInfobox.TextboxText = address.Zipcode;
            countryInfobox.TextboxText = address.Country;

            var registrations = db.GetListPatientRegistrations(this.patient.PatientID);

            DisplayHelper display = new DisplayHelper(DisplayPreview);

            display.DisplayAppointments(registrations);
        }

        #endregion

        // TODO: Create Messagebox warning
        #region Button Functions

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            db.RemovePatient(this.patient);

            this.Close();
        }

        private void modifyBtn_Click(object sender, EventArgs e)
        {
            LoadEditPatient();
        }

        #endregion
    }
}
