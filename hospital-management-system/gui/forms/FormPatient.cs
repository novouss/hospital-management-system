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
    public partial class FormPatient : Form
    {

        private dbAccess db = new dbAccess();
        private Patients patient = null;
        public FormPatient(string function, Patients patient = null)
        {
            InitializeComponent();
            // this.patient = patient;
            // loadPatient(function);
        }
        /*
        private void loadPatient(string function)
        {
            switch (function)
            {
                case "view":
                    patientForm.Text = "View Patient ID: " + patient.PatientID;
                    viewPatient(this.patient);
                    break;
                case "modify":
                    patientForm.Text = "Modify Patient ID: " + patient.PatientID;
                    modifyPatient();
                    break;
                case "add":
                    patientForm.Text = "Add Patient";
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
            appointmentGroup.Visible = false;

            // Allow for user input
            infoGroup.Enabled = true;
            addressGroup.Enabled = true;
            appointmentGroup.Visible = false;

            // Visualize Buttons
            deleteBtn.Visible = false;
            cancelBtn.Visible = true;
            modifyBtn.Visible = false;
            saveBtn.Visible = true;

            // Button Function
            saveBtn.Click += AddPatientSaveBtn_Click;
            cancelBtn.Click += CancelBtn_Click;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddPatientSaveBtn_Click(object sender, EventArgs e)
        {
            Patients patient = new Patients();

            patient.FirstName = firstnameTextbox.Text;
            patient.LastName = lastnameTextbox.Text;
            patient.MiddleName = middlenameTextbox.Text;
            patient.Birthdate = new DateTime(birthdateCalendar.Value.Year, birthdateCalendar.Value.Month, birthdateCalendar.Value.Day);
            
            if (maleRadio.Checked)
            {
                patient.Gender = maleRadio.Text;
            } else if (femaleRadio.Checked)
            {
                patient.Gender = femaleRadio.Text;
            } else if (othersRadio.Checked)
            {
                patient.Gender = anyGenderTextbox.Text;
            }

            patient.Religion = religionTextbox.Text;
            patient.Email = emailTextbox.Text;
            patient.PhoneNumber = phoneTextbox.Text;

            patient.Address1 = address1Textbox.Text;
            patient.Address2 = address2Textbox.Text;
            patient.City = cityTextbox.Text;
            patient.Province = stateTextbox.Text;
            patient.Zipcode = zipcodeTextbox.Text;
            patient.Country = countryTextbox.Text;

            db.addPatient(patient);

            this.Close();
        }

        private void viewPatient(Patients patient)
        {
            this.patient = patient;
            // Visualize information
            infoGroup.Visible = true;
            addressGroup.Visible = true;
            appointmentGroup.Visible = true;

            // Do not allow for user input
            infoGroup.Enabled = false;
            addressGroup.Enabled = false;
            appointmentGroup.Enabled = false;

            // Visualize Buttons
            deleteBtn.Visible = true;
            cancelBtn.Visible = false;
            modifyBtn.Visible = true;
            saveBtn.Visible = false;

            // Visualize Information
            firstnameTextbox.Text = patient.FirstName;
            lastnameTextbox.Text = patient.LastName;
            middlenameTextbox.Text = patient.MiddleName;
            birthdateCalendar.Value = patient.Birthdate;
            
            maleRadio.Checked = patient.Gender == "Male";
            femaleRadio.Checked = patient.Gender == "Female";

            if (patient.Gender != "Male" && patient.Gender != "Female")
            {
                othersRadio.Checked = true;
                anyGenderTextbox.Text = patient.Gender;
            }

            religionTextbox.Text = patient.Religion;
            emailTextbox.Text = patient.Email;
            phoneTextbox.Text = patient.PhoneNumber;

            address1Textbox.Text = patient.Address1;
            address2Textbox.Text = patient.Address2;
            cityTextbox.Text = patient.City;
            stateTextbox.Text = patient.Province;
            zipcodeTextbox.Text = patient.Zipcode;
            countryTextbox.Text = patient.Country;

            // Button Function
            modifyBtn.Click += ModifyPatientBtn_Click;
        }

        private void ModifyPatientBtn_Click(object sender, EventArgs e)
        {
            loadPatient("modify");
        }

        private void modifyPatient()
        {
            // Visualize information
            infoGroup.Visible = true;
            addressGroup.Visible = true;
            appointmentGroup.Visible = false;

            // Allow for user input
            infoGroup.Enabled = true;
            addressGroup.Enabled = true;
            appointmentGroup.Enabled = false;

            // Visualize Buttons
            deleteBtn.Visible = true;
            cancelBtn.Visible = true;
            modifyBtn.Visible = false;
            saveBtn.Visible = true;

            saveBtn.Click += SaveModifiedPaitentBtn_Click;
        }

        private void SaveModifiedPaitentBtn_Click(object sender, EventArgs e)
        {
            this.patient.FirstName = firstnameTextbox.Text;
            this.patient.LastName = lastnameTextbox.Text;
            this.patient.MiddleName = middlenameLabel.Text;
            this.patient.Birthdate = new DateTime(birthdateCalendar.Value.Year, birthdateCalendar.Value.Month, birthdateCalendar.Value.Day);

            if (maleRadio.Checked)
            {
                this.patient.Gender = maleRadio.Text;
            }
            else if (femaleRadio.Checked)
            {
                this.patient.Gender = femaleRadio.Text;
            }
            else if (othersRadio.Checked)
            {
                this.patient.Gender = anyGenderTextbox.Text;
            }

            this.patient.Religion = religionTextbox.Text;
            this.patient.Email = emailTextbox.Text;
            this.patient.PhoneNumber = phoneTextbox.Text;

            this.patient.Address1 = address1Textbox.Text;
            this.patient.Address2 = address2Textbox.Text;
            this.patient.City = cityTextbox.Text;
            this.patient.Province = stateTextbox.Text;
            this.patient.Zipcode = zipcodeTextbox.Text;
            this.patient.Country = countryTextbox.Text;

            db.modifyPatient(this.patient);
            this.Close();
        }

        private void othersRadio_CheckedChanged(object sender, EventArgs e)
        {
            anyGenderTextbox.Enabled = othersRadio.Checked;
        }

        private void femaleRadio_CheckedChanged(object sender, EventArgs e)
        {
            anyGenderTextbox.Enabled = othersRadio.Checked;
            anyGenderTextbox.Text = "";
        }

        private void maleRadio_CheckedChanged(object sender, EventArgs e)
        {
            anyGenderTextbox.Enabled = othersRadio.Checked;
            anyGenderTextbox.Text = "";
        }
        */
    }
}
