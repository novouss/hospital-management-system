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
    public partial class InformationRadio : UserControl
    {
        public InformationRadio()
        {
            InitializeComponent();
        }
        
        public String LabelText {
            get { return Label.Text; }
            set { Label.Text = value; } 
        }

        public float ColumnWidth0
        {
            get { return TableLayout.ColumnStyles[0].Width; }
            set { TableLayout.ColumnStyles[0].Width = value; }
        }

        public String RadioText1 { 
            get { return radioButton1.Text; }
            set { radioButton1.Text = value; } 
        }
        public String RadioText2 { 
            get { return radioButton2.Text; }
            set { radioButton1.Text = value; } 
        }
        public String RadioText3 { 
            get { return radioButton3.Text; }
            set { radioButton1.Text = value; } 
        }

        public Color RadioForeColor1 {
            get { return radioButton1.ForeColor; }
            set { radioButton1.ForeColor = value; }
        }

        public Color RadioForeColor2 {
            get { return radioButton2.ForeColor; }
            set { radioButton2.ForeColor = value; }
        }

        public Color RadioForeColor3 {
            get { return radioButton3.ForeColor; }
            set { radioButton3.ForeColor = value; }
        }
        public String TextboxText {
            get { return Textbox.Text; }
            set { Textbox.Text = value; } 
        }
        

    }
}
