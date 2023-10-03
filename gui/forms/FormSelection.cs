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

namespace hospital_management_system
{
    public partial class FormSelection : Form
    {
        private PreviewboxEffects BoxEffects = new PreviewboxEffects();
        private dbAccess DB = new dbAccess();
        private MoreColors COLORS = new MoreColors();

        #region Properties

        public Patients patient { get; set; }
        public Employees employee { get; set; }
        public Registrations registration { get; set; }
        public Reports report { get; set; }
        public Rooms room { get; set; }
        public Laboratories laboratory { get; set; }

        #endregion

        public FormSelection(string function, int dep_id = 0)
        {
            InitializeComponent();

            // Load 
            switch (function)
            {
                case "patient":
                    loadPatient();
                    break;
                case "employee":
                    loadEmployee(function);
                    break;
                case "department-employees":
                    loadEmployee(function, dep_id);
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
                    // loadBilling();
                    break;

                default:
                    // viewGroup.Text = "Error";
                    break;
            }
        }

        private void Previewbox_Click(object sender, EventArgs e, PreviewBox previewbox)
        {
            this.BoxEffects.ButtonEffect(previewbox);
        }

        #region Patient Functions

        private void loadPatient()
        {
            // Setup table
            DisplayPreview.Label2 = "";

            // Reset Display
            DisplayPreview.ResetDisplayPreviewbox();

            // Show PreviewBoxes
            var patients = DB.GetListPatients();

            for (int i = 0; i < patients.Count; i++)
            {
                PreviewBox previewbox = new PreviewBox();

                previewbox.Value = patients[i];
                previewbox.Text0 = patients[i].PatientID + "";
                previewbox.Text1 = patients[i].GetFullname();
                previewbox.Text2 = "";
                previewbox.PreviewBox_SingleClick += new EventHandler((sender, e) => Previewbox_Click(sender, e, previewbox));
                previewbox.PreviewBox_DoubleClick += new EventHandler((sender, e) => SelectPatient(sender, e, previewbox)); 
                previewbox.ViewContextMenu_Click += new EventHandler((sender, e) => ViewPatient(sender, e, previewbox));
                previewbox.DeleteContextMenu_Click += new EventHandler((sender, e) => DeletePatient(sender, e, previewbox));

                DisplayPreview.InitializePreviewbox(previewbox);
            }
        }

        private void SelectPatient(object sender, EventArgs e, PreviewBox previewbox)
        {
            this.patient = previewbox.Value as Patients;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void ViewPatient(object sender, EventArgs e, PreviewBox previewbox)
        {
            FormPatient form = new FormPatient("view", previewbox.Value as Patients);
            form.Show();
        }

        private void DeletePatient(object sender, EventArgs e, PreviewBox previewbox)
        {
            DB.RemovePatient(previewbox.Value as Patients);
            loadPatient();
        }

        #endregion

        #region Employee Functions

        private void loadEmployee(string function, int dep_id = 0)
        {
            // Reset Display
            DisplayPreview.ResetDisplayPreviewbox();

            var employees = new List<Employees>();

            if (function == "emplyoee") employees = DB.GetListEmployees();
            else if (function == "department-employees") employees = DB.GetListOpenDepartmentsEmployee(dep_id, 0);

            for (int i = 0; i < employees.Count; i++)
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

                if (employees[i].Status == 0) { previewbox.SetStatusColumn(COLORS.MediumSeaGreen, COLORS.White, "Open"); }
                else if (employees[i].Status == 1) { previewbox.SetStatusColumn(COLORS.Crimson, COLORS.White, "Unavailable"); }

                previewbox.PreviewBox_SingleClick += new EventHandler((sender, e) => Previewbox_Click(sender, e, previewbox));
                previewbox.PreviewBox_DoubleClick += new EventHandler((sender, e) => SelectEmployee(sender, e, previewbox));
                previewbox.ViewContextMenu_Click += new EventHandler((sender, e) => ViewEmployee(sender, e, previewbox));
                previewbox.DeleteContextMenu_Click += new EventHandler((sender, e) => DeleteEmployee(sender, e, previewbox));

                DisplayPreview.InitializePreviewbox(previewbox);
            }
        }
        private void SelectEmployee(object sender, EventArgs e, PreviewBox previewbox)
        {
            this.employee = previewbox.Value as Employees;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void ViewEmployee(object sender, EventArgs e, PreviewBox previewbox)
        {
            FormEmployee form = new FormEmployee("view", previewbox.Value as Employees);
            form.Show();
        }
        private void DeleteEmployee(object sender, EventArgs e, PreviewBox previewbox)
        {
            DB.RemoveEmployee(previewbox.Value as Employees);
        }

        #endregion

        #region Appointment Functions

        private void loadAppointment()
        {
            // Reset Display
            DisplayPreview.ResetDisplayPreviewbox();

            // Show PreviewBoxes
            var registrations = DB.GetListFinishedRegistration(1);

            for (int i = 0; i < registrations.Count; i++)
            {
                PreviewBox previewbox = new PreviewBox();
                previewbox.Value = registrations[i];
                previewbox.Text0 = registrations[i].RegistrationID + "";
                previewbox.Text1 = $"Created On: { registrations[i].CreatedOn.ToString() }";

                if (registrations[i].Status == 0) { previewbox.SetStatusColumn(COLORS.Crimson, COLORS.White, "Ongoing"); }
                else if (registrations[i].Status == 1) { previewbox.SetStatusColumn(COLORS.MediumSeaGreen, COLORS.White, "Finished"); }

                previewbox.PreviewBox_SingleClick += new EventHandler((sender, e) => Previewbox_Click(sender, e, previewbox));
                previewbox.PreviewBox_DoubleClick += new EventHandler((sender, e) => SelectAppointment(sender, e, previewbox));
                previewbox.ViewContextMenu_Click += new EventHandler((sender, e) => ViewAppointment(sender, e, previewbox));
                previewbox.DeleteContextMenu_Click += new EventHandler((sender, e) => DeleteAppoitment(sender, e, previewbox));

                DisplayPreview.InitializePreviewbox(previewbox);
            }

        }
        private void SelectAppointment(object sender, EventArgs e, PreviewBox previewbox)
        {
            this.registration = previewbox.Value as Registrations;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void ViewAppointment(object sender, EventArgs e, PreviewBox previewbox)
        {
            FormAppointment form = new FormAppointment("view", previewbox.Value as Registrations);
            form.Show();
        }

        private void DeleteAppoitment(object sender, EventArgs e, PreviewBox previewbox)
        {
            DB.RemoveRegistration(previewbox.Value as Registrations);
            loadAppointment();
        }

        #endregion

        #region Room Functions
        private void loadRoom()
        {
            // Setup table
            DisplayPreview.Label0 = "Room Number";
            DisplayPreview.Label1 = "Charge";
            DisplayPreview.Label2 = "Status";

            DisplayPreview.Column0 = 60;
            DisplayPreview.Column1 = 30;
            DisplayPreview.Column2 = 20;
            DisplayPreview.Column3 = 10;

            // Reset Display
            DisplayPreview.ResetDisplayPreviewbox();

            // Show PreviewBoxes
            var rooms = DB.GetListOpenRooms(0);

            for (int i = 0; i < rooms.Count; i++)
            {
                PreviewBox previewbox = new PreviewBox();

                previewbox.Value = rooms[i];
                previewbox.Text0 = $"Room { rooms[i].RoomID } ";
                previewbox.Text1 = $"${ rooms[i].Fee }";

                if (rooms[i].Status == 0) { previewbox.SetStatusColumn(COLORS.MediumSeaGreen, COLORS.White, "Open"); }
                else if (rooms[i].Status == 1) { previewbox.SetStatusColumn(COLORS.Crimson, COLORS.White, "Unavailable"); }

                previewbox.PreviewBox_SingleClick += new EventHandler((sender, e) => Previewbox_Click(sender, e, previewbox));
                previewbox.PreviewBox_DoubleClick += new EventHandler((sender, e) => SelectRoom(sender, e, previewbox));

                DisplayPreview.InitializePreviewbox(previewbox);
            }
        }

        private void SelectRoom(object sender, EventArgs e, PreviewBox previewbox)
        {
            this.room = previewbox.Value as Rooms;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        #endregion

        #region Laboratory Functions

        private void loadLaboratory()
        {
            // Setup table
            DisplayPreview.Label0 = "Laboratory Number";
            DisplayPreview.Label1 = "Charge";
            DisplayPreview.Label2 = "Status";

            DisplayPreview.Column0 = 60;
            DisplayPreview.Column1 = 30;
            DisplayPreview.Column2 = 20;
            DisplayPreview.Column3 = 10;

            // Reset Display
            DisplayPreview.ResetDisplayPreviewbox();

            // Show PreviewBoxes
            var rooms = DB.GetListOpenLaboratories(0);

            for (int i = 0; i < rooms.Count; i++)
            {
                PreviewBox previewbox = new PreviewBox();

                previewbox.Value = rooms[i];
                previewbox.Text0 = $"Laboartory { rooms[i].LaboratoryID } ";
                previewbox.Text1 = $"${ rooms[i].Fee }";

                if (rooms[i].Status == 0) { previewbox.SetStatusColumn(COLORS.MediumSeaGreen, COLORS.White, "Open"); }
                else if (rooms[i].Status == 1) { previewbox.SetStatusColumn(COLORS.Crimson, COLORS.White, "Unavailable"); }

                previewbox.PreviewBox_SingleClick += new EventHandler((sender, e) => Previewbox_Click(sender, e, previewbox));
                previewbox.PreviewBox_DoubleClick += new EventHandler((sender, e) => SelectLab(sender, e, previewbox));

                DisplayPreview.InitializePreviewbox(previewbox);
            }
        }

        private void SelectLab(object sender, EventArgs e, PreviewBox previewbox)
        {
            this.laboratory = previewbox.Value as Laboratories;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        #endregion

    }
}
