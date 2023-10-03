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
    public partial class InformationTextbox : UserControl
    {
        public InformationTextbox()
        {
            InitializeComponent();
        }

        public String LabelText {
            get { return Label.Text; }
            set { Label.Text = value; } 
        }

        public float ColumnWidth0 {
            get { return TableLayout.ColumnStyles[0].Width; }
            set { TableLayout.ColumnStyles[0].Width = value; } 
        }

        public String TextboxText {
            get { return Textbox.Text; }
            set { Textbox.Text = value; }
        }

        public char TextboxPasswordChar
        {
            get { return Textbox.PasswordChar; }
            set { Textbox.PasswordChar = value; }
        }
    }
}
