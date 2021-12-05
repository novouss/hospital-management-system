using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hospital_management_system.gui.components
{
    public partial class RoundedGroupbox : UserControl
    {
        public RoundedGroupbox()
        {
            InitializeComponent();
        }

        public string LabelText { 
            get { return label1.Text; }
            set { label1.Text = value; } 
        }

        public void AddControl(Control value)
        {
            panel1.Controls.Add(value);
        }
    }
}
