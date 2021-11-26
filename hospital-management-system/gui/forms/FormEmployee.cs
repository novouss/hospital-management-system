using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using hospital_management_system.classes;

namespace hospital_management_system
{
    public partial class FormEmployee : Form
    {

        private dbAccess db = new dbAccess();
        private Employees employee = null;

        public FormEmployee(string function, int id = 0)
        {
            InitializeComponent();
            // InitalizeComboboxItems();
            // this.employee = employee;
            // loadEmployee(function);
        }


    }
}
