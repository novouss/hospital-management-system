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
using hospital_management_system.gui.forms;
using hospital_management_system.classes;
using hospital_management_system.gui.components;

namespace hospital_management_system.gui.forms
{
    public partial class PageDashboard : Form
    {
        private dbAccess db = new dbAccess();
        private MoreColors morecolors = new MoreColors();

        public PageDashboard(FormMain FormMain, Employees employee)
        {
            InitializeComponent();
            InitializeCustomComponents();
            LoadPatients();
            LoadRegistrations();
            LoadReports();
            LoadEmployees();
            
        }

        private void LoadPatients()
        {
            var patients = db.GetListPatients();
            patientCard.CounterText = patients.Count + "";
        }

        private void LoadRegistrations()
        {
            var registrations = db.GetListRegistrations();
            registrationCard.CounterText = registrations.Count + "";
        }

        private void LoadReports()
        {
            var reports = db.GetListRegistrations();
            reportCard.CounterText = reports.Count + "";
        }

        private void LoadEmployees()
        {
            var employees = db.GetListEmployees();

            for (int i = 0; i < employees.Count; i++)
            {
                if (employees[i].EmployeeID == 1)
                {
                    // EmployeeID 1 is the Administrator
                    continue;
                }

                PreviewBox previewbox = new PreviewBox();
                previewbox.Value = employees[i];
                previewbox.Text0 = employees[i].EmployeeID + "";
                previewbox.Text1 = employees[i].GetFullname();

                if (employees[i].Status == 0) { previewbox.SetStatusColumn(morecolors.MediumSeaGreen, morecolors.White, "Available"); }
                else if (employees[i].Status == 1) { previewbox.SetStatusColumn(morecolors.Crimson, morecolors.White, "Unavailable"); }

                InitializePreviewbox(previewbox, this.employeeDisplay);
                previewbox.PreviewBox_SingleClick += new EventHandler((sender, e) => Previewbox_Click(sender, e, previewbox));
                previewbox.PreviewBox_DoubleClick += new EventHandler((sender, e) => ViewEmployee(sender, e, previewbox));

                DisplayPreviewbox(previewbox, this.employeeDisplay);
            }
        }

        private void ViewEmployee(object sender, EventArgs e, PreviewBox previewbox)
        {
            FormEmployee form = new FormEmployee("view", previewbox.Value as Employees);
            form.Show();
        }

        #region Active Button Functions

        private PreviewBox ActiveButton;

        private void Previewbox_Click(object sender, EventArgs e, PreviewBox previewbox)
        {
            ButtonEffect(previewbox);
        }

        private void ButtonEffect(PreviewBox previewbox)
        {

            if (ActiveButton != null)
            {
                this.ActiveButton.TableLayout.BackColor = Color.White;
                this.ActiveButton.TextForeColor0 = Color.Black;
                this.ActiveButton.TextForeColor1 = Color.Black;
                // this.ActiveButton.TextForeColor2 = Color.Black; // Text2 is a conditional State
                this.ActiveButton.TextForeColor3 = Color.Black;
            }

            this.ActiveButton = previewbox;

            this.ActiveButton.TextForeColor0 = Color.White;
            this.ActiveButton.TextForeColor1 = Color.White;
            this.ActiveButton.TextForeColor2 = Color.White;
            this.ActiveButton.TextForeColor3 = Color.White;
            this.ActiveButton.TableLayout.BackColor = morecolors.SteelBlue;
        }

        #endregion

        #region Initialize Previewbox

        private void InitializePreviewbox(PreviewBox previewbox, DisplayPreview displayPreview)
        {
            previewbox.BackColor = Color.White;
            previewbox.Margin = new System.Windows.Forms.Padding(0);
            previewbox.FlatStyle = FlatStyle.Flat;
            previewbox.Dock = DockStyle.Fill;
            previewbox.Column0 = displayPreview.Column0;
            previewbox.Column1 = displayPreview.Column1;
            previewbox.Column2 = displayPreview.Column2;
            previewbox.Column3 = displayPreview.Column3;
            previewbox.Width = displayPreview.Width;
        }

        private void DisplayPreviewbox(PreviewBox previewbox, DisplayPreview displayPreview)
        {
            displayPreview.TableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F)); // Adds a row
            displayPreview.TableLayout.Height += 40;
            displayPreview.TableLayout.Controls.Add(previewbox);
        
        }

        #endregion
    }
}
