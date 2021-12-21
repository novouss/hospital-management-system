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

namespace experimental_hospital_management_system.gui.pages
{
    public partial class PageView : Form
    {
        private dbAccess DB = new dbAccess();
        private MoreColors COLORS = new MoreColors();
        public PageView(string function)
        {
            // Load Form Components
            InitializeComponent();
            InitializeCustomComponent();

            // Load 
            switch (function)
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
                    // viewGroup.Text = "Error";
                    break;
            }
        }

        private void InitializeCustomComponent()
        {
            addpatientbtn.Visible = false;
            addappointmentbtn.Visible = false;
            addemployeebtn.Visible = false;
            addbillbtn.Visible = false;
        }

        /*
         * PageView is one Form used in different scenarios in order to display a list of objects. With the way this segment was programmed, there are different load configruations that has to be addressed for PageView to function.
         * 
         * Region Content:
         *      loadPatient()           - Responsible for loading patients with their associated PreviewBoxes.
         *      loadEmployee()           - Responsible for loading employees with their associated PreviewBoxes.
         *      loadAppointment()           - Responsible for loading appointment with their associated PreviewBoxes.
         */

        public void loadPatient()
        {
            // Setup table
            DisplayPreview.Label2 = "";

            // Set view group page
            DisplayPanelLabel.Text = "Patients";

            // Reset Display
            DisplayPreview.ResetDisplayPreviewbox();

            // Setup Sidebuttons
            addpatientbtn.Visible = true;
            addappointmentbtn.Visible = true;

            // Show PreviewBoxes
            var patients = DB.GetListPatients();
            DisplayHelper display = new DisplayHelper(DisplayPreview);

            display.DisplayPatients(patients);
        }
        public void loadEmployee()
        {
            // Set view group page
            DisplayPanelLabel.Text = "Employees";

            // Reset Display
            DisplayPreview.ResetDisplayPreviewbox();

            // Setup Sidebuttons
            addemployeebtn.Visible = true;

            // Show PreviewBoxes
            var employees = DB.GetListEmployees();
            DisplayHelper display = new DisplayHelper(DisplayPreview);

            display.DisplayEmployees(employees);
        }
        public void loadAppointment()
        {
            // Set view group page
            DisplayPanelLabel.Text = "Appointment";

            // Reset Display
            DisplayPreview.ResetDisplayPreviewbox();

            // Setup Sidebuttons
            addappointmentbtn.Visible = true;

            // Show PreviewBoxes
            var registrations = DB.GetListRegistrations();
            DisplayHelper display = new DisplayHelper(DisplayPreview);

            display.DisplayAppointments(registrations);
        }
        public void loadRoom()
        {

        }
        public void loadLaboratory()
        {

        }
        public void loadBilling()
        {
            // Set view group page
            DisplayPanelLabel.Text = "Billing";

            // Reset Display
            DisplayPreview.ResetDisplayPreviewbox();

            // Setup Table
            DisplayPreview.Label1 = "Registration Number ";

            // Setup Sidebuttons
            addappointmentbtn.Visible = true;
            addbillbtn.Visible = true;

            // Show PreviewBoxes
            var billings = DB.GetListBillings();
            DisplayHelper display = new DisplayHelper(DisplayPreview);

            display.DisplayBill(billings);
        }

        private void addpatient_Click(object sender, EventArgs e)
        {
            FormPatient form = new FormPatient("add");
            form.Show();
        }

        private void addemployee_Click(object sender, EventArgs e)
        {
            FormEmployee form = new FormEmployee("add");
            form.Show();
        }

        private void addappointment_Click(object sender, EventArgs e)
        {
            FormAppointment form = new FormAppointment("add");
            form.Show();
        }

        private void addbilling_Click(object sender, EventArgs e)
        {
            FormBilling form = new FormBilling("add");
            form.Show();
        }
    }
}
