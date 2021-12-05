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
using hospital_management_system.gui.components;

namespace hospital_management_system.gui.forms
{
    public partial class PageView : Form
    {
        private dbAccess db = new dbAccess();
        private MoreColors morecolors = new MoreColors();
        public PageView(string name)
        {
            // Load Form Components
            InitializeComponent();
            InitializeCustomComponents();

            // Load 
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
                    // loadAppointment();
                    break;
                case "room":
                    // loadRoom();
                    break;
                case "laboratory":
                    // loadLaboratory();
                    break;
                case "billing":
                    // loadBilling();
                    break;

                default:
                    // viewGroup.Text = "Error";
                    break;
            }
        }
        
        #region Patient Functions

        /*
         * PageView is one Form used in different scenarios in order to display a list of objects. With the way this segment was programmed, there are different load configruations that has to be addressed for PageView to function.
         * 
         * Region Content:
         *      loadPatient()           - Responsible for loading patients with their associated PreviewBoxes.
         *      
         *      ViewPatient(object sender, Eventargs e, PreviewBox previewbox)
         *      - Displays FormPatient window for viewing from 'previewbox' parameter's 'Value' property.
         *      DeletePatient(object sender, Eventargs e, PreviewBox previewbox)
         *      - Displays a Messagebox that informs and confirms the user if they want to delete the data.
         */

        public void loadPatient()
        {
            // Setup table
            DisplayPreview.Label2 = "";

            // Set view group page
            DisplayPanel.LabelText = "Patients";

            // Reset Display
            DisplayPreview.ResetDisplayPreviewbox();

            // Search function

            // Show PreviewBoxes
            var patients = db.GetListPatients();

            for (int i = 0; i < patients.Count; i++)
            {
                PreviewBox previewbox = new PreviewBox();
                DisplayPreviewbox(previewbox);

                previewbox.Value = patients[i];
                previewbox.Text0 = patients[i].PatientID + "";
                previewbox.Text1 = patients[i].GetFullname();
                previewbox.Text2 = "";
                InitializePreviewbox(previewbox);
                previewbox.PreviewBox_SingleClick += new EventHandler((sender, e) => Previewbox_Click(sender, e, previewbox));
                previewbox.PreviewBox_DoubleClick += new EventHandler((sender, e) => ViewPatient(sender, e, previewbox));   
            }
        }

        private void ViewPatient(object sender, EventArgs e, PreviewBox preview)
        {
            FormPatient form = new FormPatient("view", preview.Value as Patients);
            form.Show();
        }

        private void DeletePatient(object sender, EventArgs e, PreviewBox preview)
        {
            // TODO: Create Messagebox warning
            db.RemovePatient(preview.Value as Patients);
            loadPatient();
        }

        #endregion

        #region Employee Function

        /*
         * Region Content:
         *      loadEmployee()           - Responsible for loading employees with their associated PreviewBoxes.
         *      
         *      ViewEmployee(object sender, Eventargs e, PreviewBox previewbox)
         *      - Displays FormEmployee window for viewing from 'previewbox' parameter's 'Value' property.
         *      DeleteEmployee(object sender, Eventargs e, PreviewBox previewbox)
         *      - Displays a Messagebox that informs and confirms the user if they want to delete the data.
         */
        
        public void loadEmployee()
        {
            // Set view group page
            DisplayPanel.LabelText = "Employees";

            // Reset Display
            DisplayPreview.ResetDisplayPreviewbox();

            // Search function

            // Show PreviewBoxes
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

                InitializePreviewbox(previewbox);
                previewbox.PreviewBox_SingleClick += new EventHandler((sender, e) => Previewbox_Click(sender, e, previewbox));
                previewbox.PreviewBox_DoubleClick += new EventHandler((sender, e) => ViewEmployee(sender, e, previewbox));

                DisplayPreviewbox(previewbox);
            }

        }

        private void ViewEmployee(object sender, EventArgs e, PreviewBox previewbox)
        {
            FormEmployee form = new FormEmployee("view", previewbox.Value as Employees);
            form.Show();
        }

        private void DeleteEmployees(object sender, EventArgs e, PreviewBox previewbox)
        {
            // TODO: Create Messagebox warning
            db.RemoveEmployee(previewbox.Value as Employees);
            loadEmployee();
        }

        #endregion

        private void loadAppointment()
        {
            // Set view group page
            DisplayPanel.LabelText = "Registrations";

            // Reset Display
            DisplayPreview.ResetDisplayPreviewbox();

            // Search function

            // Show PreviewBoxes
            var registrations = db.GetListRegistrations();

            for (int i = 0; i < registrations.Count; i++)
            {
                if (registrations[i].RegistrationID == 1)
                {
                    // EmployeeID 1 is the Administrator
                    continue;
                }

                PreviewBox previewbox = new PreviewBox();
                previewbox.Value = registrations[i];
                previewbox.Text0 = registrations[i].RegistrationID + "";
                previewbox.Text1 = "";

                InitializePreviewbox(previewbox);
                previewbox.PreviewBox_SingleClick += new EventHandler((sender, e) => Previewbox_Click(sender, e, previewbox));
                previewbox.PreviewBox_DoubleClick += new EventHandler((sender, e) => ViewRegistration(sender, e, previewbox));

                DisplayPreviewbox(previewbox);
            }

        }

        private void ViewRegistration(object sender, EventArgs e, PreviewBox previewbox)
        {
            FormAppointment form = new FormAppointment("view", previewbox.Value as Registrations); 
            form.Show();
        }

        //private void loadRoom()
        //{
        //    viewGroup.Text = "Rooms";
        //}

        //private void loadLaboratory()
        //{
        //    viewGroup.Text = "Laboratories";
        //}

        //private void loadBilling()
        //{
        //    viewGroup.Text = "Billings";
        //}

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

        private void InitializePreviewbox(PreviewBox previewbox)
        {
            previewbox.BackColor = Color.White;
            previewbox.Margin = new System.Windows.Forms.Padding(0);
            previewbox.FlatStyle = FlatStyle.Flat;
            previewbox.Dock = DockStyle.Fill;
            previewbox.Column0 = DisplayPreview.Column0;
            previewbox.Column1 = DisplayPreview.Column1;
            previewbox.Column2 = DisplayPreview.Column2;
            previewbox.Column3 = DisplayPreview.Column3;
            previewbox.Width = DisplayPreview.Width;
        }

        private void DisplayPreviewbox(PreviewBox previewbox)
        {
            DisplayPreview.TableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F)); // Adds a row
            DisplayPreview.TableLayout.Height += 40;
            DisplayPreview.TableLayout.Controls.Add(previewbox);
        }

        #endregion
    }
}
