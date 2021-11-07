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
            viewGroup.Text = "Patients";
        }

        private void loadEmployee()
        {
            viewGroup.Text = "Employees";
        }

        private void loadAppointment()
        {
            viewGroup.Text = "Appointments";
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
