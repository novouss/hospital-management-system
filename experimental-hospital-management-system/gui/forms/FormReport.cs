using experimental_hospital_management_system.gui.components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace experimental_hospital_management_system
{
    public partial class FormReport : Form
    {
        private MoreColors COLORS = new MoreColors();
        private dbAccess db = new dbAccess();
        private Reports report = null;
        public FormReport(string function, Reports report = null, Registrations registration = null)
        {
            InitializeComponent();
            InitializeCustomComponent();

            if (registration != null)
            {
                regButtonbox.Value = registration;
                regButtonbox.VisibleSubButton = true;
            } 

            this.report = report;

            switch (function)
            {
                case "view":
                    LoadViewReport();
                    break;
                case "edit":
                    LoadEditReport();
                    break;
                case "add":
                    LoadAddReport();
                    break;
            }
        }
        private void InitializeCustomComponent()
        {
            List<Departments> departments = db.GetListDepartments();
            departmentCombobox.DataSource = departments;
            departmentCombobox.ValueMemeber = null;
            departmentCombobox.DisplayMember = "Description";

            regButtonbox.MainButtonbox_Click += RegButtonbox_MainButtonbox_Click;
            employeeButtonbox.MainButtonbox_Click += EmployeeButtonbox_MainButtonbox_Click;
            labButtonbox.MainButtonbox_Click += LabButtonbox_MainButtonbox_Click;
            regButtonbox.SubButtonbox_Click += RegButtonbox_SubButtonbox_Click;
            employeeButtonbox.SubButtonbox_Click += EmployeeButtonbox_SubButtonbox_Click;
        }

        private void EmployeeButtonbox_SubButtonbox_Click(object sender, EventArgs e)
        {
            FormEmployee form = new FormEmployee("view", (employeeButtonbox.Value as Employees));
            form.Show();
        }

        private void RegButtonbox_SubButtonbox_Click(object sender, EventArgs e)
        {
            FormAppointment form = new FormAppointment("view", (regButtonbox.Value as Registrations));
            form.Show();
        }

        private void LabButtonbox_MainButtonbox_Click(object sender, EventArgs e)
        {
            using (var form = new FormSelection("laboratory"))
            {
                var result = form.ShowDialog();

                if (result == DialogResult.OK)
                {
                    labButtonbox.Value = form.laboratory;
                    labButtonbox.VisibleSubButton = true;
                }
            }
        }

        private void EmployeeButtonbox_MainButtonbox_Click(object sender, EventArgs e)
        {
            using (var form = new FormSelection("department-employees", (departmentCombobox.SelectedValue as Departments).DepartmentID))
            {
                var result = form.ShowDialog();

                if (result == DialogResult.OK)
                {
                    employeeButtonbox.Value = form.employee;
                    employeeButtonbox.VisibleSubButton = true;
                }
            }
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

        private bool CheckInput(InformationButtonbox buttonbox)
        {
            if (buttonbox.Value == null)
            {
                buttonbox.ForeColor = COLORS.Crimson;
                return false;
            }

            return true;
        }

        #region Form Methods

        private void LoadAddReport()
        {
            reportForm.Text = "Add Report";

            // Visualizes Information and record
            regButtonbox.Visible = true;
            departmentCombobox.Visible = true;
            employeeButtonbox.Visible = true;
            labButtonbox.Visible = true;
            resultInfobox.Visible = true;

            regButtonbox.VisibleSubButton = regButtonbox.Value != null;
            employeeButtonbox.VisibleSubButton = false;
            labButtonbox.VisibleSubButton = false;
            
            // Configure user input
            regButtonbox.Enabled = true;
            departmentCombobox.Enabled = true;
            employeeButtonbox.Enabled = true;
            labButtonbox.Enabled = true;
            resultInfobox.Enabled = true;
            
            // Configure buttons
            deleteBtn.Visible = false;
            cancelBtn.Visible = true;
            modifyBtn.Visible = false;
            saveBtn.Visible = true;

            saveBtn.Click += SaveNewReport_Click;
        }

        private void LoadEditReport()
        {
            reportForm.Text = "Edit Report: " + this.report.ReportID;
            // Visualizes Information and record
            regButtonbox.Visible = true;
            departmentCombobox.Visible = true;
            employeeButtonbox.Visible = true;
            labButtonbox.Visible = true;
            resultInfobox.Visible = true;
            
            // Configure user input
            regButtonbox.Enabled = true;
            departmentCombobox.Enabled = true;
            employeeButtonbox.Enabled = true;
            labButtonbox.Enabled = true;
            resultInfobox.Enabled = true;
            
            // Configure buttons
            deleteBtn.Visible = true;
            cancelBtn.Visible = true;
            modifyBtn.Visible = false;
            saveBtn.Visible = true;

            saveBtn.Click += SaveNewReport_Click;
        }

        private void LoadViewReport()
        {
            reportForm.Text = "View Report: " + this.report.ReportID;

            // Visualizes Information and record            
            regButtonbox.VisibleSubButton = true;
            employeeButtonbox.VisibleSubButton = true;
            labButtonbox.VisibleSubButton = true;
            
            // Configure user input
            regButtonbox.Enabled = false;
            departmentCombobox.Enabled = false;
            employeeButtonbox.Enabled = false;
            labButtonbox.Enabled = false;
            resultInfobox.Enabled = false;
            
            // Configure buttons
            deleteBtn.Visible = false;
            cancelBtn.Visible = true;
            modifyBtn.Visible = true;
            saveBtn.Visible = false;

            //Display information
            regButtonbox.Value = db.GetRegistration(this.report.RegistrationID);
            departmentCombobox.ComboboxText = db.GetDepartments(this.report.DepartmentID).Description;
            employeeButtonbox.Value = db.GetEmployee(this.report.EmployeeID);
            labButtonbox.Value = db.GetLaboratories(this.report.LaboratoryID);
            resultInfobox.TextboxText = this.report.Report;
        }

        private void SaveNewReport_Click(object sender, EventArgs e)
        {
            if (CheckInput(regButtonbox) & CheckInput(employeeButtonbox) & CheckInput(labButtonbox))
            {
                this.report = new Reports();

                this.report.RegistrationID = (regButtonbox.Value as Registrations).RegistrationID;
                this.report.DepartmentID = (departmentCombobox.SelectedValue as Departments).DepartmentID;
                this.report.EmployeeID = (employeeButtonbox.Value as Employees).EmployeeID;
                this.report.LaboratoryID = (labButtonbox.Value as Laboratories).LaboratoryID;
                this.report.Report = resultInfobox.TextboxText;

                db.AddReport(this.report);

                this.Close();
            }
            
        }

        private void SaveEditReport_Click(object sender, EventArgs e)
        {

            this.report.RegistrationID = (regButtonbox.Value as Registrations).RegistrationID;
            this.report.DepartmentID = (departmentCombobox.SelectedValue as Departments).DepartmentID;
            this.report.EmployeeID = (employeeButtonbox.Value as Employees).EmployeeID;
            this.report.LaboratoryID = (labButtonbox.Value as Laboratories).LaboratoryID;
            this.report.Report = resultInfobox.TextboxText;

            db.EditReport(this.report);
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            // TODO: Create Messagebox warning
            db.RemoveReport(this.report);

            this.Close();
        }

        private void modifyBtn_Click(object sender, EventArgs e)
        {
            LoadEditReport();
        }

        #endregion

    }
}