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
        private PatientRegistration registration = new PatientRegistration();
        public FormAppointment(string function, PatientRegistration registration = null)
        {
            InitializeComponent();
            InitalizeComboboxItems();
            this.registration = registration;
            loadAppointment(function);
        }

        private void InitalizeComboboxItems()
        {
            // Get Patients
            List<PatientDetails> patients = new List<PatientDetails>();
            patients = db.getPatientInformation();

            patientCombobox.ValueMember = null;
            patientCombobox.DisplayMember = "PatientID";
            patientCombobox.DataSource = patients;

            // Get Departments
            List<Department> departments = new List<Department>();
            departments = db.getDepartments();

            departmentCombobox.ValueMember = null;
            departmentCombobox.DisplayMember = "DepartmentName";
            departmentCombobox.DataSource = departments;

            departmentCombobox.SelectedValueChanged += DepartmentCombobox_SelectedValueChanged;

            // Get Employees 
            // Is stored in <DepartmentCombobox_SelectedValueChanged> method.

            // Get Rooms
            List<Room> rooms = new List<Room>();
            rooms = db.getRoomInformation();

            roomCombobox.ValueMember = null;
            roomCombobox.DisplayMember = "RoomID";
            roomCombobox.DataSource = rooms;

            // Get Laboratories
            List<Laboratory> laboratories = new List<Laboratory>();
            laboratories = db.getLaboratoryInformation();

            laboratoryCombobox.ValueMember = null;
            laboratoryCombobox.DisplayMember = "LaboratoryID";
            laboratoryCombobox.DataSource = laboratories;

        }

        private void DepartmentCombobox_SelectedValueChanged(object sender, EventArgs e)
        {
            employeeCombobox.Enabled = true;
            
            if (departmentCombobox.SelectedValue != null)
            {
                Department department = (Department) departmentCombobox.SelectedValue;
                
                List<EmployeeDepartment> emps_dep = new List<EmployeeDepartment>();
                emps_dep = db.findDepartmentEmployees(department.DepartmentID);

                employeeCombobox.ValueMember = null;
                employeeCombobox.DisplayMember = "EmployeeID";
                employeeCombobox.DataSource = emps_dep;
            }
        }

        private void loadAppointment(string function)
        {
            switch (function)
            {
                case "view":
                    appointmentForm.Text = "View Appointment ID: " + registration.RegistrationID;
                    viewAppointment(this.registration);
                    break;
                case "modify":
                    appointmentForm.Text = "Modify Appointment ID: " + registration.RegistrationID;
                    modifyAppointment();
                    break;
                case "add":
                    appointmentForm.Text = "Add Appointment";
                    addAppointment();
                    break;
                default:
                    break;

            }
        }

        private void addAppointment()
        {
            // Visualize information
            appointmentGroup.Visible = true;
            resultGroup.Visible = false;

            // Allow for user input
            appointmentGroup.Enabled = true;
            resultGroup.Enabled = true;

            // Visualize Buttons
            deleteBtn.Visible = false;
            cancelBtn.Visible = true;
            modifyBtn.Visible = false;
            saveBtn.Visible = true;

            // Button Function
            saveBtn.Click += AddRegistrationSaveBtn_Click;

        }

        private void AddRegistrationSaveBtn_Click(object sender, EventArgs e)
        {
            PatientRegistration registration = new PatientRegistration();

            registration.PatientID = int.Parse(patientCombobox.Text);
            registration.EmployeeID = int.Parse(employeeCombobox.Text);
            registration.RoomID = int.Parse(roomCombobox.Text);
            registration.LaboratoryID = int.Parse(laboratoryCombobox.Text);
            registration.AdmissionOn = new DateTime(admissionCalendar.Value.Year, admissionCalendar.Value.Month, admissionCalendar.Value.Day, admissionCalendar.Value.Hour, admissionCalendar.Value.Minute, admissionCalendar.Value.Second);            
            registration.DischargeOn = new DateTime(dischageCalendar.Value.Year, dischageCalendar.Value.Month, dischageCalendar.Value.Day, dischageCalendar.Value.Hour, dischageCalendar.Value.Minute, dischageCalendar.Value.Second);
            Console.WriteLine(registration.DischargeOn);
            registration.Results = resultTextgroup.Text;

            db.addAppointment(registration);

            this.Close();
        }

        private void viewAppointment(PatientRegistration registration)
        {
            this.registration = registration;
            // Visualize information
            appointmentGroup.Visible = true;
            resultGroup.Visible = true;

            // Do not allow for user input
            appointmentGroup.Enabled = false;
            resultGroup.Enabled = false;

            // Visualize Buttons
            deleteBtn.Visible = true;
            cancelBtn.Visible = false;
            modifyBtn.Visible = true;
            saveBtn.Visible = false;

            // Visualize Information
            patientCombobox.Text = registration.PatientID + "";
            employeeCombobox.Text = registration.EmployeeID + "";
            roomCombobox.Text = registration.RoomID + "";
            laboratoryCombobox.Text = registration.LaboratoryID + "";
            admissionCalendar.Value = registration.AdmissionOn;
            dischageCalendar.Value = registration.DischargeOn;
            resultTextgroup.Text = registration.Results;

            // Button Function
            modifyBtn.Click += ModifyAppointmentBtn_Click;
        }

        private void ModifyAppointmentBtn_Click(object sender, EventArgs e)
        {
            loadAppointment("modify");
        }

        private void modifyAppointment()
        {
            // Visualize information
            appointmentGroup.Visible = true;
            resultGroup.Visible = true;

            // Allow for user input
            appointmentGroup.Enabled = true;
            resultGroup.Enabled = true;

            // Visualize Buttons
            deleteBtn.Visible = true;
            cancelBtn.Visible = true;
            modifyBtn.Visible = false;
            saveBtn.Visible = true;
        }
    }
}
