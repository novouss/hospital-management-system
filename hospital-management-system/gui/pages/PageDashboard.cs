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
    public partial class PageDashboard : Form
    {
        public PageDashboard(EmployeeDetails employee)
        {
            InitializeComponent();
            greetingsText.Text = $"Welcome back { employee.FirstName }, ";
        }
    }
}
