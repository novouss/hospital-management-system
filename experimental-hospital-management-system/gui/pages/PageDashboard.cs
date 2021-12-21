using experimental_hospital_management_system.gui.components;
using experimental_hospital_management_system;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace experimental_hospital_management_system.gui.pages
{
    public partial class PageDashboard : Form
    {
        private MoreColors COLORS = new MoreColors();
        private dbAccess DB = new dbAccess();
        private FormWindow form = null;
        private Employees employee;
        public PageDashboard(FormWindow form, Employees employee)
        {
            this.form = form;
            this.employee = employee;
            InitializeComponent();
            InitializeCustomComponent();
            LoadDatabase();
        }

        private void InitializeCustomComponent()
        {
            greetingspanel.BackColor = COLORS.RoyalBlue;
            greetingslabel.ForeColor = COLORS.White;

            employeelabel.ForeColor = COLORS.RoyalBlue;
            patientcounter.ForeColorCounter = COLORS.RoyalBlue;
            roomcounter.ForeColorCounter = COLORS.RoyalBlue;
            labcounter.ForeColorCounter = COLORS.RoyalBlue;
            billingcounter.ForeColorCounter = COLORS.MediumSeaGreen;

            schedulelabel.ForeColor = COLORS.RoyalBlue;
            scheduledate.ForeColorNow = COLORS.RoyalBlue;
            
            appointmentlabel.ForeColor = COLORS.RoyalBlue;

            greetingslabel.Text = $"Welcome back { this.employee.FirstName }";
            
        }

        private void LoadDatabase()
        {
            var patients = DB.GetListPatients();
            var employees = DB.GetListEmployees();
            var regs = DB.GetListRegistrations();
            var rooms = DB.GetListRooms();
            var labs = DB.GetListLaboratories();
            var bills = DB.GetListBillings();

            patientcounter.LabelCounter = patients.Count + "";
            roomcounter.LabelCounter = rooms.Count + "";
            labcounter.LabelCounter = labs.Count + "";
            billingcounter.LabelCounter = bills.Count + "";

            DisplayHelper preview_emp = new DisplayHelper(DisplayEmployeePreview);
            preview_emp.DisplayEmployees(employees, 8);

            DisplayHelper preview_reg = new DisplayHelper(DisplayAppointmentPreview);
            preview_reg.DisplayAppointments(regs, 10, false);
        }

        private void viewmoreemployees_Click(object sender, EventArgs e)
        {
            this.form.employeebtn_Click(sender, e);   
        }

        private void viewmoreappointments_Click(object sender, EventArgs e)
        {
            this.form.appointmentbtn_Click(sender, e);
        }
    }
}
