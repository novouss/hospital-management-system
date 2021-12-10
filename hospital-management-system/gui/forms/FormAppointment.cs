using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using hospital_management_system.classes;

namespace hospital_management_system.gui.forms
{
    public partial class FormAppointment : Form
    {
        private dbAccess db = new dbAccess();
        private Registrations registration = null;
        public FormAppointment(string function, Registrations registration = null)
        {
            InitializeComponent();
            InitializeComboBoxItems();
            this.registration = null;

            switch (function)
            {
                case "view":
                    LoadViewAppointment();
                    break;
                case "edit":
                    LoadEditAppointment();
                    break;
                case "add":
                    LoadAddAppointments();
                    break;
            }

        }

        private void InitializeComboBoxItems()
        {
            //Initialize Patient ID
            List<Patients> patient = db.GetListPatients();
            patientIdInfobox.DataSource = patient;
            patientIdInfobox.ValueMemeber = null;
            patientIdInfobox.DisplayMember = "PatientID";

            //Initialize Room ID
            List<Rooms> room = db.GetListRooms();
            roomIdInfobox.DataSource = room;
            roomIdInfobox.ValueMemeber = null;
            roomIdInfobox.DisplayMember = "RoomID";

        }

        #region Form Methods
        private void LoadAddAppointments()
        {
            appointmentForm.Text = "Add Appointment";
            // Visualizes Information and record
            registrataionDetails.Visible = true;
            reportDetails.Visible = false;
           
            //User Input
            registrataionDetails.Enabled = true;
            reportDetails.Enabled = false;
            
            //Configure buttons
            cancelBtn.Visible = true;
            modifyBtn.Visible = false;
            saveBtn.Visible = true;
            deleteBtn.Visible = false;

            saveBtn.Click += SaveNewAppointment_Click;
        }

        private void LoadEditAppointment()
        {
            appointmentForm.Text = "Edit Appointment: " + this.registration.RegistrationID;
            
            // Visualizes Information and record
            registrataionDetails.Visible = true;
            reportDetails.Visible = true;

            //User Input
            registrataionDetails.Enabled = true;
            reportDetails.Enabled = true;

            //Configure buttons
            cancelBtn.Visible = true;
            modifyBtn.Visible = false;
            saveBtn.Visible = true;
            deleteBtn.Visible = false;

            saveBtn.Click += SaveEditAppointment_Click;
        }

        private void LoadViewAppointment()
        {
            appointmentForm.Text = "View Employee: " + this.registration.PatientID;
            //Visualizes Information and Record
            registrataionDetails.Visible = false;
            reportDetails.Visible = false;

            //User Input
            registrataionDetails.Enabled = false;
            reportDetails.Enabled = false;

            //Configure buttons
            cancelBtn.Visible = true;
            modifyBtn.Visible = true;
            saveBtn.Visible = false;
            deleteBtn.Visible = false;

            //Display
            this.registration = new Registrations();
            this.registration.PatientID = int.Parse(patientIdInfobox.ComboboxText);
            this.registration.RoomID = int.Parse(roomIdInfobox.ComboboxText);
            dateAdmissionInfobox.DateText = this.registration.AdmissionOn;
            dateDischargeInfobox.DateText = this.registration.DischargeOn;

        }

        private void SaveEditAppointment_Click(object sender, EventArgs e)
        {
            //Patient ID Combobox
            this.registration.PatientID = (patientIdInfobox.SelectedValue as Patients).PatientID;

            //Room ID Combobox
            this.registration.RoomID = (roomIdInfobox.SelectedValue as Rooms).RoomID;

            //Date Admission
            this.registration.AdmissionOn = dateAdmissionInfobox.GetDate();

            //Date Discharge
            this.registration.DischargeOn = dateDischargeInfobox.GetDate();

            db.EditAppointment(this.registration);

            this.Close();
        }

        private void SaveNewAppointment_Click(object sender, EventArgs e)
        {
            this.registration = new Registrations();

            //Patient ID Combobox
            this.registration.PatientID = (patientIdInfobox.SelectedValue as Patients).PatientID;

            //Room ID Combobox
            this.registration.RoomID = (roomIdInfobox.SelectedValue as Rooms).RoomID;

            //Date Admission
            this.registration.AdmissionOn = dateAdmissionInfobox.GetDate();

            //Date Discharge
            this.registration.DischargeOn = dateDischargeInfobox.GetDate();

            db.AddRegistration(this.registration);

            this.Close();
        }


        #endregion






        //Cancel Button
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Delete Button
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            // TODO: Create Messagebox warning
            db.RemoveRegistration(this.registration);

            this.Close();
        }

        //Modify Button
        private void modifyBtn_Click(object sender, EventArgs e)
        {
            LoadEditAppointment();
        }

        
    }
}