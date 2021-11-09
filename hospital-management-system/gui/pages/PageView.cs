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
    public partial class PageView : Form
    {
        private dbAccess db = new dbAccess();
        public PageView(string name)
        {
            InitializeComponent();

            switch (name)
            {
                case "patient":
                    loadPatient();
                    break;
                case "employee":
                    loadEmployee();
                    break;
                case "appointment":
                case "registration":
                    loadAppointment();
                    break;
                case "room":
                    loadRoom();
                    break;
                case "laboratory":
                    loadLaboratory();
                    break;
                case "billing":
                    loadBilling();
                    break;

                default:
                    viewGroup.Text = "Error";
                    break;
            }
        }

        private void loadPatient()
        {
            // Set view group page
            viewGroup.Text = "Patients";

            // Search function

            // Show Grid Information
            var patients = db.getPatientInformation();

            viewDatagrid.DataSource = patients;
            viewDatagrid.Columns["PatientID"].Visible = false;
            viewDatagrid.Columns["AddressID"].Visible = false;
            viewDatagrid.Columns["CreatedOn"].Visible = false;
            viewDatagrid.Columns["ModifiedOn"].Visible = false;

            // Content Click
            viewDatagrid.CellClick += ViewPatientDatagrid_CellClick;
        }

        private void ViewPatientDatagrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var selectedPatient = viewDatagrid.SelectedRows[0].DataBoundItem as PatientDetails;

                FormPatient form = new FormPatient("view", selectedPatient);
                form.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error code: " + ex.Message + " - " + ex.Source);
            }
        }

        private void loadEmployee()
        {
            // Set view group page
            viewGroup.Text = "Employees";

            // Search function

            // Show Grid Information
            var employees = db.getEmployeeInformation();

            viewDatagrid.DataSource = employees;
            viewDatagrid.Columns["EmployeeID"].Visible = false;
            viewDatagrid.Columns["Password"].Visible = false;
            viewDatagrid.Columns["RoleID"].Visible = false;
            viewDatagrid.Columns["DepartmentID"].Visible = false;
            viewDatagrid.Columns["AddressID"].Visible = false;
            viewDatagrid.Columns["CreatedOn"].Visible = false;
            viewDatagrid.Columns["ModifiedOn"].Visible = false;

            // Content Click
            viewDatagrid.CellClick += ViewEmployeeDatagrid_CellClick;
        }

        private void ViewEmployeeDatagrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var selectedEmployee = viewDatagrid.SelectedRows[0].DataBoundItem as EmployeeDetails;

                FormEmployee form = new FormEmployee("view", selectedEmployee);
                form.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error code: " + ex.Message + " - " + ex.Source);
            }
        }

        private void loadAppointment()
        {
            // Set view group page
            viewGroup.Text = "Appointments";

            // Search function

            // Show Grid Information
            var appointments = db.getRegistrationInformation();

            viewDatagrid.DataSource = appointments;
            viewDatagrid.Columns["ReportID"].Visible = false;
            viewDatagrid.Columns["CreatedOn"].Visible = false;
            viewDatagrid.Columns["ModifiedOn"].Visible = false;

            // Content Click

        }

        private void loadRoom()
        {
            viewGroup.Text = "Rooms";
        }

        private void loadLaboratory()
        {
            viewGroup.Text = "Laboratories";
        }

        private void loadBilling()
        {
            viewGroup.Text = "Billings";
        }
    }
}
