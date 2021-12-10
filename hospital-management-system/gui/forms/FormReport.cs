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
    public partial class formReport : Form
    {
        private dbAccess db = new dbAccess();
        private Reports report = null;
        public formReport(string function, Reports report = null, Registrations registration = null)
        {
            InitializeComponent();
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

        #region Form Methods

        private void LoadAddReport()
        {
            reportForm.Text = "Add Report";
            // Visualizes Information and record
            registrataionIdInfobox.Visible = true;
            deptIdInfobox.Visible = true;
            empIdInfobox.Visible = true;
            labIdInfobox.Visible = true;
            resultInfobox.Visible = true;
            // Configure user input
            registrataionIdInfobox.Enabled = true;
            deptIdInfobox.Enabled = true;
            empIdInfobox.Enabled = true;
            labIdInfobox.Enabled = true;
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
            reportForm.Text = "Edit Report" + this.report.ReportID;
            // Visualizes Information and record
            registrataionIdInfobox.Visible = true;
            deptIdInfobox.Visible = true;
            empIdInfobox.Visible = true;
            labIdInfobox.Visible = true;
            resultInfobox.Visible = true;
            // Configure user input
            registrataionIdInfobox.Enabled = true;
            deptIdInfobox.Enabled = true;
            empIdInfobox.Enabled = true;
            labIdInfobox.Enabled = true;
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
            reportForm.Text = "View Report" + this.report.ReportID;
            // Visualizes Information and record
            registrataionIdInfobox.Visible = true;
            deptIdInfobox.Visible = true;
            empIdInfobox.Visible = true;
            labIdInfobox.Visible = true;
            resultInfobox.Visible = true;
            // Configure user input
            registrataionIdInfobox.Enabled = false;
            deptIdInfobox.Enabled = false;
            empIdInfobox.Enabled = false;
            labIdInfobox.Enabled = false;
            resultInfobox.Enabled = false;
            // Configure buttons
            deleteBtn.Visible = false;
            cancelBtn.Visible = true;
            modifyBtn.Visible = true;
            saveBtn.Visible = false;

            //Display information
            registrataionIdInfobox.SelectedValue = this.report.RegistrationID;
            deptIdInfobox.SelectedValue = this.report.DepartmentID;
            empIdInfobox.SelectedValue = this.report.EmployeeID;
            labIdInfobox.SelectedValue = this.report.LaboratoryID;
            resultInfobox.TextboxText = this.report.Report;
        }

        private void SaveNewReport_Click(object sender, EventArgs e)
        {
            this.report = new Reports();
            this.report.RegistrationID = (int)registrataionIdInfobox.SelectedValue;
            this.report.DepartmentID = (int)deptIdInfobox.SelectedValue;
            this.report.EmployeeID = (int)empIdInfobox.SelectedValue;
            this.report.LaboratoryID = (int)labIdInfobox.SelectedValue;
            this.report.Report = resultInfobox.TextboxText;

            db.AddReport(this.report);

            this.Close();
        }

        private void SaveEditReport_Click(object sender, EventArgs e)
        {
            this.report.RegistrationID = (int)registrataionIdInfobox.SelectedValue;
            this.report.DepartmentID = (int)deptIdInfobox.SelectedValue;
            this.report.EmployeeID = (int)empIdInfobox.SelectedValue;
            this.report.LaboratoryID = (int)labIdInfobox.SelectedValue;
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