using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hospital_management_system.classes;

namespace hospital_management_system.gui.components
{
    public class DisplayHelper
    {
        private PreviewboxEffects BoxEffects = new PreviewboxEffects();
        private dbAccess DB = new dbAccess();
        private MoreColors COLORS = new MoreColors();

        private DisplayPreview display = null;
        public DisplayHelper(DisplayPreview display) 
        {
            this.display = display;
        }
        private void Previewbox_Click(object sender, EventArgs e, PreviewBox previewbox)
        {
            BoxEffects.ButtonEffect(previewbox);
        }
        private void Previewbox_Removed(PreviewBox previewbox)
        {
            previewbox.Text0 = "";
            previewbox.Text1 = "Record has been removed";
            previewbox.Text2 = "";
            previewbox.Text3 = "";
            previewbox.TableLayout.BackColor = COLORS.SlateGray;
            previewbox.Enabled = false;
        }
        // TODO: Create Messagebox warning when deleting
        #region Patient DisplayPreview
        /*
         * Region Content:
         *      DisplayPatients()           - Responsible for loading patients with their associated PreviewBoxes.
         *      
         *      ViewPatient(object sender, Eventargs e, PreviewBox previewbox)
         *      - Displays FormPatient window for viewing from 'previewbox' parameter's 'Value' property.
         *      DeletePatient(object sender, Eventargs e, PreviewBox previewbox)
         *      - Displays a Messagebox that informs and confirms the user if they want to delete the data.
         */
        public void DisplayPatients(List<Patients> patients, int max = 0)
        {
            if (max == 0) max = patients.Count;

            for (int i = 0; i < max; i++)
            {
                PreviewBox previewbox = new PreviewBox();

                previewbox.Value = patients[i];
                previewbox.Text0 = patients[i].PatientID + "";
                previewbox.Text1 = patients[i].GetFullname();
                previewbox.Text2 = "";
                previewbox.PreviewBox_SingleClick += new EventHandler((sender, e) => Previewbox_Click(sender, e, previewbox));
                previewbox.PreviewBox_DoubleClick += new EventHandler((sender, e) => ViewPatient(sender, e, previewbox));
                previewbox.ViewContextMenu_Click += new EventHandler((sender, e) => ViewPatient(sender, e, previewbox));
                previewbox.DeleteContextMenu_Click += new EventHandler((sender, e) => DeletePatient(sender, e, previewbox));

                this.display.InitializePreviewbox(previewbox);
            }
        }
        private void ViewPatient(object sender, EventArgs e, PreviewBox previewbox)
        {
            FormPatient form = new FormPatient("view", previewbox.Value as Patients);
            form.Show();
        }
        // FIXME: (@Novous) I dont know how to reload the page from here
        private void DeletePatient(object sender, EventArgs e, PreviewBox previewbox)
        {
            DB.RemovePatient(previewbox.Value as Patients);
            Previewbox_Removed(previewbox);
        }

        #endregion

        // TODO: Create Messagebox warning when deleting
        #region Employee DisplayPreview
        /*
         * Region Content:
         *      DisplayEmployees()           - Responsible for loading employees with their associated PreviewBoxes.
         *      
         *      ViewEmployee(object sender, Eventargs e, PreviewBox previewbox)
         *      - Displays FormEmployee window for viewing from 'previewbox' parameter's 'Value' property.
         *      DeleteEmployee(object sender, Eventargs e, PreviewBox previewbox)
         *      - Displays a Messagebox that informs and confirms the user if they want to delete the data.
         */
        public void DisplayEmployees(List<Employees> employees, int max = 0)
        {
            if (max == 0) max = employees.Count;

            for (int i = 0; i < max && i < employees.Count; i++)
            {
                if (employees[i].EmployeeID == 1)
                {
                    // Skip { EmployeeID: 1 } because this is the administrator
                    continue;
                }

                PreviewBox previewbox = new PreviewBox();
                previewbox.Value = employees[i];
                previewbox.Text0 = employees[i].EmployeeID + "";
                previewbox.Text1 = employees[i].GetFullname();

                if (employees[i].Status == 0) { previewbox.SetStatusColumn(COLORS.MediumSeaGreen, COLORS.White, "Available"); }
                else if (employees[i].Status == 1) { previewbox.SetStatusColumn(COLORS.Crimson, COLORS.White, "Unavailable"); }

                previewbox.PreviewBox_SingleClick += new EventHandler((sender, e) => Previewbox_Click(sender, e, previewbox));
                previewbox.PreviewBox_DoubleClick += new EventHandler((sender, e) => ViewEmployee(sender, e, previewbox));
                previewbox.ViewContextMenu_Click += new EventHandler((sender, e) => ViewEmployee(sender, e, previewbox));
                previewbox.DeleteContextMenu_Click += new EventHandler((sender, e) => DeleteEmployee(sender, e, previewbox));

                this.display.InitializePreviewbox(previewbox);
            }

        }
        private void ViewEmployee(object sender, EventArgs e, PreviewBox previewbox)
        {
            FormEmployee form = new FormEmployee("view", previewbox.Value as Employees);
            form.Show();
        }
        private void DeleteEmployee(object sender, EventArgs e, PreviewBox previewbox)
        {
            DB.RemoveEmployee(previewbox.Value as Employees);
            Previewbox_Removed(previewbox);
        }

        #endregion

        // TODO: Create Messagebox warning when deleting
        #region Appointment DisplayPreview
        public void DisplayAppointments(List<Registrations> registrations, int max = 0, bool display_status = true)
        {
            if (max == 0) max = registrations.Count;

            for (int i = 0; i < max && i < registrations.Count; i++)
            {
                PreviewBox previewbox = new PreviewBox();
                previewbox.Value = registrations[i];
                previewbox.Text0 = registrations[i].RegistrationID + "";
                previewbox.Text1 = $"{ registrations[i].AdmissionOn.ToString() }";
                previewbox.Text2 = "";
                

                if (display_status)
                {
                    if (registrations[i].Status == 0) { previewbox.SetStatusColumn(COLORS.Crimson, COLORS.White, "Ongoing"); }
                    else if (registrations[i].Status == 1) { previewbox.SetStatusColumn(COLORS.MediumSeaGreen, COLORS.White, "Finished"); }
                }

                previewbox.PreviewBox_SingleClick += new EventHandler((sender, e) => Previewbox_Click(sender, e, previewbox));
                previewbox.PreviewBox_DoubleClick += new EventHandler((sender, e) => ViewAppointment(sender, e, previewbox));
                previewbox.ViewContextMenu_Click += new EventHandler((sender, e) => ViewAppointment(sender, e, previewbox));
                previewbox.DeleteContextMenu_Click += new EventHandler((sender, e) => DeleteAppoitment(sender, e, previewbox));

                this.display.InitializePreviewbox(previewbox);
            }

        }

        private void ViewAppointment(object sender, EventArgs e, PreviewBox previewbox)
        {
            FormAppointment form = new FormAppointment("view", previewbox.Value as Registrations);
            form.Show();
        }

        private void DeleteAppoitment(object sender, EventArgs e, PreviewBox previewbox)
        {
            DB.RemoveRegistration(previewbox.Value as Registrations);
            Previewbox_Removed(previewbox);
        }

        #endregion

        // TODO: Create Messagebox warning when deleting
        #region Report DisplayPreview

        public void DisplayReport(List<Reports> reports, int max = 0)
        {

            for (int i = 0; i < reports.Count; i++)
            {
                PreviewBox previewbox = new PreviewBox();

                var department = DB.GetDepartments(reports[i].DepartmentID);

                previewbox.Value = reports[i];
                previewbox.Text0 = $"{ reports[i].ReportID }";
                previewbox.Text1 = $"{ reports[i].CreatedOn.ToString() }";
                previewbox.Text2 = $"{ department.Description }";

                previewbox.PreviewBox_SingleClick += new EventHandler((sender, e) => Previewbox_Click(sender, e, previewbox));
                previewbox.PreviewBox_DoubleClick += new EventHandler((sender, e) => ViewReport(sender, e, previewbox));
                previewbox.ViewContextMenu_Click += new EventHandler((sender, e) => ViewReport(sender, e, previewbox));
                previewbox.DeleteContextMenu_Click += new EventHandler((sender, e) => DeleteReport(sender, e, previewbox));

                this.display.InitializePreviewbox(previewbox);
            }
        }

        private void ViewReport(object sender, EventArgs e, PreviewBox previewbox)
        {
            FormReport form = new FormReport("view", (previewbox.Value as Reports));
            form.Show();
        }

        private void DeleteReport(object sender, EventArgs e, PreviewBox previewbox)
        {
            DB.RemoveReport(previewbox.Value as Reports);
        }

        #endregion

        #region Billing DisplayPreview

        public void DisplayBill(List<Billings> billings, int max = 0)
        {
            for (int i = 0; i < billings.Count; i++)
            {
                PreviewBox previewbox = new PreviewBox();

                previewbox.Value = billings[i];
                previewbox.Text0 = $"{ billings[i].BillingID }";
                previewbox.Text1 = $"Registration ID: { billings[i].RegistrationID }";

                if (billings[i].Status == 0) { previewbox.SetStatusColumn(COLORS.Crimson, COLORS.White, "Unpaid"); }
                else if (billings[i].Status == 1) { previewbox.SetStatusColumn(COLORS.MediumSeaGreen, COLORS.White, "Paid"); }

                previewbox.PreviewBox_SingleClick += new EventHandler((sender, e) => Previewbox_Click(sender, e, previewbox));
                previewbox.PreviewBox_DoubleClick += new EventHandler((sender, e) => ViewBilling(sender, e, previewbox));
                previewbox.ViewContextMenu_Click += new EventHandler((sender, e) => ViewBilling(sender, e, previewbox));
                previewbox.DeleteContextMenu_Click += new EventHandler((sender, e) => DeleteBilling(sender, e, previewbox));

                this.display.InitializePreviewbox(previewbox);
            }
        }

        private void ViewBilling(object sender, EventArgs e, PreviewBox previewbox)
        {
            FormBilling form = new FormBilling("view", (previewbox.Value as Billings));
            form.Show();
        }

        private void DeleteBilling(object sender, EventArgs e, PreviewBox previewbox)
        {
            DB.RemoveReport(previewbox.Value as Reports);
        }

        #endregion

        #region Rooms DisplayPreviewbox

        public void DisplayRooms(List<Rooms> rooms, int max = 0)
        {
            for (int i = 0; i < rooms.Count; i++)
            {
                PreviewBox previewbox = new PreviewBox();

                previewbox.Value = rooms[i];
                previewbox.Text0 = $"Room { rooms[i].RoomID } ";
                previewbox.Text1 = $"${ rooms[i].Fee }";

                if (rooms[i].Status == 0) { previewbox.SetStatusColumn(COLORS.MediumSeaGreen, COLORS.White, "Open"); }
                else if (rooms[i].Status == 1) { previewbox.SetStatusColumn(COLORS.Crimson, COLORS.White, "Unavailable"); }

                previewbox.PreviewBox_SingleClick += new EventHandler((sender, e) => Previewbox_Click(sender, e, previewbox));

                this.display.InitializePreviewbox(previewbox);
            }
        }

        #endregion

        #region Laboratories DisplayPreviewbox



        #endregion
    }
}
