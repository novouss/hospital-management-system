using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace hospital_management_system
{
    public partial class mainWindow : Form
    {
        public mainWindow()
        {
            InitializeComponent();
            resetDisplayPanel();
            resetNavigationPanel();
        }

        private void resetDisplayPanel()
        {
            addPatientPanel.Visible = false;
            patientPanel.Visible = false;
        }

        private void resetNavigationPanel()
        {
            addPatientBtn.Visible = false;
            addDoctorsBtn.Visible = false;
            removePatientBtn.Visible = false;
            removeDoctorBtn.Visible = false;
        }
        //
        // Add Patient
        //
        private void resetGenderOthers()
        {
            PatientGenderOthersTextbox.Enabled = false;
            PatientGenderOthersTextbox.Text = "";
        }

        private void patientBtn_Click(object sender, EventArgs e)
        {
            resetNavigationPanel();
            patientPanel.Visible = true;
            removePatientBtn.Visible = true;
            addPatientBtn.Visible = true;
        }

        private void doctorBtn_Click(object sender, EventArgs e)
        {
            resetNavigationPanel();
            removeDoctorBtn.Visible = true;
            addDoctorsBtn.Visible = true;
        }

        private void addPatientBtn_Click(object sender, EventArgs e)
        {
            resetDisplayPanel();
            addPatientPanel.Visible = true;
        }

        private void genderOthersRadio_CheckedChanged(object sender, EventArgs e)
        {
            PatientGenderOthersTextbox.Enabled = true;
        }

        private void genderMaleRadio_CheckedChanged(object sender, EventArgs e)
        {
            resetGenderOthers();
        }

        private void genderFemaleRadio_CheckedChanged(object sender, EventArgs e)
        {
            resetGenderOthers();
        }

        private void addPatientClearBtn_Click(object sender, EventArgs e)
        {
            PatientFirstnameTextbox.Text = "";
            PatientLastnameTextbox.Text = "";
            PatientMiddlenameTextbox.Text = "";
            PatientAddressTextbox.Text = "";
            PatientGenderMaleRadio.Checked = false;
            PatientGenderFemaleRadio.Checked = false;
            PatientGenderOthersRadio.Checked = false;
            PatientGenderOthersTextbox.Text =  "";
            PatientHeightTextbox.Text = "";
            PatientWeightTexbox.Text = "";
            PatientEmailTextbox.Text = "";
            PatientPhoneTextbox.Text = "";
        }

        private void mainWindow_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataset.PatientDetails' table. You can move, or remove it, as needed.
            this.patientDetailsTableAdapter.Fill(this.dataset.PatientDetails);
            // TODO: This line of code loads data into the 'dataset.PatientDetails' table. You can move, or remove it, as needed.
            this.patientDetailsTableAdapter.Fill(this.dataset.PatientDetails);

        }

        private void patientBtn_Click_1(object sender, EventArgs e)
        {
            resetDisplayPanel();
            patientPanel.Visible = true;
            resetNavigationPanel();
            removePatientBtn.Visible = true;
            addPatientBtn.Visible = true;
        }

        private void doctorBtn_Click_1(object sender, EventArgs e)
        {
            resetNavigationPanel();
            removeDoctorBtn.Visible = true;
            addDoctorsBtn.Visible = true;
        }

        private void addPatientBtn_Click_1(object sender, EventArgs e)
        {
            resetDisplayPanel();
            addPatientPanel.Visible = true;
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addPatientClearBtn_Click_1(object sender, EventArgs e)
        {
            PatientFirstnameTextbox.Text = "";
            PatientLastnameTextbox.Text = "";
            PatientMiddlenameTextbox.Text = "";
            PatientAddressTextbox.Text = "";
            PatientGenderMaleRadio.Checked = false;
            PatientGenderFemaleRadio.Checked = false;
            PatientGenderOthersRadio.Checked = false;
            PatientGenderOthersTextbox.Text = "";
            PatientHeightTextbox.Text = "";
            PatientWeightTexbox.Text = "";
            PatientEmailTextbox.Text = "";
            PatientPhoneTextbox.Text = "";
        }
    }
}
