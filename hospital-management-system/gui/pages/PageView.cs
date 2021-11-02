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
                case "doctor":
                    break;
                case "appointment":
                    break;
                case "room":
                    break;
                case "laboratory":
                    break;
                case "billing":
                    break;
            }
        }

        private void loadPatient()
        {
            viewGroup.Text = "Patients";
        }
    }
}
