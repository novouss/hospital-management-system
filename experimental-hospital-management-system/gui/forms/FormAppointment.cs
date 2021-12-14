using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using experimental_hospital_management_system.classes;
using experimental_hospital_management_system.gui.components;

namespace experimental_hospital_management_system
{
    public partial class FormAppointment : Form
    {
        private MoreColors COLORS = new MoreColors();
        private dbAccess db = new dbAccess();
        private Registrations registration = null;
        public FormAppointment(string function, Registrations registration = null)
        {
            InitializeComponent();
            InitializeCustomComponent();
            this.registration = registration;

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

        // TODO: FormRoom.cs does not exist yet.
        #region Buttonbox Functions

        private void InitializeCustomComponent()
        {
            statusInfobox.BackColorActiveState = COLORS.MediumSeaGreen;
            statusInfobox.BackColorInactiveState = COLORS.Crimson;
            statusInfobox.ButtonState("active");

            patientButtonbox.MainButtonbox_Click += PatientButtonbox_MainButtonbox_Click;
            roomButtonbox.MainButtonbox_Click += RoomButtonbox_MainButtonbox_Click;
            patientButtonbox.SubButtonbox_Click += PatientButtonbox_SubButtonbox_Click;
            // roomButtonbox.SubButtonbox_Click += RoomButtonbox_SubButtonbox_Click;
            statusInfobox.CheckedButton_Click += StatusInfobox_CheckedButton_Click;
        }

        private void StatusInfobox_CheckedButton_Click(object sender, EventArgs e)
        {
            if (statusInfobox.Status == 1)
            {
                statusInfobox.LabelButton = "Ongoing";
                statusInfobox.ButtonState("inactive");
                statusInfobox.Status = 0;
            }
            else
            {
                statusInfobox.LabelButton = "Finished";
                statusInfobox.ButtonState("active");
                statusInfobox.Status = 1;
            }
        }

        private void RoomButtonbox_SubButtonbox_Click(object sender, EventArgs e)
        {
            // Do nothing...
        }

        private void PatientButtonbox_SubButtonbox_Click(object sender, EventArgs e)
        {
            FormPatient form = new FormPatient("view", (patientButtonbox.Value as Patients));
            form.Show();
        }

        private void RoomButtonbox_MainButtonbox_Click(object sender, EventArgs e)
        {
            using (var form = new FormSelection("room"))
            {
                var result = form.ShowDialog();

                if (result == DialogResult.OK)
                {
                    roomButtonbox.Value = form.room;
                    roomButtonbox.VisibleSubButton = true;
                }
            }
        }

        private void PatientButtonbox_MainButtonbox_Click(object sender, EventArgs e)
        {
            using (var form = new FormSelection("patient"))
            {
                var result = form.ShowDialog();

                if (result == DialogResult.OK)
                {
                    patientButtonbox.Value = form.patient;
                    patientButtonbox.VisibleSubButton = true;
                }
            }
        }

        private bool CheckInput(InformationButtonbox buttonbox)
        {
            if (buttonbox.Value == null)
            {
                buttonbox.ForeColor = COLORS.Crimson;
                return false;
            }

            return true;
        }

        #endregion

        #region Form Methods

        private void LoadAddAppointments()
        {
            appointmentForm.Text = "Add Appointment";

            // Visualizes Information and record
            registrataionDetails.Visible = true;
            reportDetails.Visible = false;
            patientButtonbox.VisibleSubButton = false;
            roomButtonbox.VisibleSubButton = false;
            statusInfobox.Visible = false;

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
            addreportbtn.Visible = true;

            saveBtn.Click += SaveEditAppointment_Click;
        }

        private void LoadViewAppointment()
        {
            appointmentForm.Text = "View Appointment: " + this.registration.RegistrationID;

            //Visualizes Information and Record
            registrataionDetails.Visible = true;
            reportDetails.Visible = true;
            patientButtonbox.VisibleSubButton = true;
            roomButtonbox.VisibleSubButton = true;

            if (this.registration.Status == 1)
            {
                statusInfobox.LabelButton = "Finished";
                statusInfobox.ButtonState("active");
            }
            else
            {
                statusInfobox.LabelButton = "Ongoing";
                statusInfobox.ButtonState("inactive");
            }

            statusInfobox.Status = this.registration.Status;

            //User Input
            registrataionDetails.Enabled = false;
            reportDetails.Enabled = false;
            patientButtonbox.EnabledMainButton = false;
            roomButtonbox.EnabledMainButton = false;

            //Configure buttons
            cancelBtn.Visible = true;
            modifyBtn.Visible = true;
            saveBtn.Visible = false;
            deleteBtn.Visible = false;
            addreportbtn.Visible = false;

            //Display
            patientButtonbox.Value = db.GetPatient(this.registration.PatientID);
            roomButtonbox.Value = db.GetRooms(this.registration.RoomID);
            dateAdmissionInfobox.DateText = this.registration.AdmissionOn;
            dateDischargeInfobox.DateText = this.registration.DischargeOn;

            var reports = db.GetListRegistrationReport(this.registration.RegistrationID);

            DisplayHelper display = new DisplayHelper(DisplayPreview);

            display.DisplayReport(reports);
        }

        private void SaveEditAppointment_Click(object sender, EventArgs e)
        {
            this.registration.PatientID = (patientButtonbox.Value as Patients).PatientID;
            this.registration.RoomID = (roomButtonbox.Value as Rooms).RoomID;
            this.registration.Status = statusInfobox.Status;
            this.registration.AdmissionOn = dateAdmissionInfobox.GetDateTime();
            this.registration.DischargeOn = dateDischargeInfobox.GetDateTime();

            db.EditRegistration(this.registration);

            this.Close();
        }

        private void SaveNewAppointment_Click(object sender, EventArgs e)
        {
            if (CheckInput(patientButtonbox) & CheckInput(roomButtonbox))
            {
                this.registration = new Registrations();
                this.registration.PatientID = (patientButtonbox.Value as Patients).PatientID;
                this.registration.RoomID = (roomButtonbox.Value as Rooms).RoomID;
                this.registration.Status = statusInfobox.Status;
                this.registration.AdmissionOn = dateAdmissionInfobox.GetDateTime();
                this.registration.DischargeOn = dateDischargeInfobox.GetDateTime();

                db.AddRegistration(this.registration);

                this.Close();
            }
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
            db.RemoveRegistration(this.registration);
            this.Close();
        }

        private void modifyBtn_Click(object sender, EventArgs e)
        {
            LoadEditAppointment();
        }

        private void addreportbtn_Click(object sender, EventArgs e)
        {
            FormReport form = new FormReport("add", null, this.registration);
            form.Show();
        }

        #endregion


    }
}