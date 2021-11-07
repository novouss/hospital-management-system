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

namespace hospital_management_system.gui.forms
{
    public partial class PageDashboard : Form
    {

        public PageDashboard(FormMain FormMain, EmployeeDetails employee)
        {
            InitializeComponent();
            // (Raymond) PageDashboard will self-destruct if button functions were used inside InitalizeComponent()
            InitalizeButtonFunctions(FormMain);
            greetingsText.Text = $"Welcome back { employee.FirstName }, ";

        }
    }
}
