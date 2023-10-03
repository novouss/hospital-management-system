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
    public partial class InformationCheckBox : UserControl
    {
        public InformationCheckBox()
        {
            InitializeComponent();
        }

        public int Status { get; set; }
        public String LabelText
        {
            get { return Label.Text; }
            set { Label.Text = value; }
        }

        public float ColumnWidth0
        {
            get { return TableLayout.ColumnStyles[0].Width; }
            set { TableLayout.ColumnStyles[0].Width = value; }
        }

        public String LabelButton
        {
            get { return Button.Text; }
            set { Button.Text = value; }
        }

        public Color BackColorActiveState { get; set; }
        public Color BackColorInactiveState { get; set; }

        public Color BackColorButton
        {
            get { return Button.BackColor; }
            set { Button.BackColor = value; }
        }

        public Color ForeColorButton
        {
            get { return Button.ForeColor; }
            set { Button.ForeColor = value; }
        }

        public event EventHandler CheckedButton_Click 
        { 
            add { Button.Click += value; } 
            remove { Button.Click -= value; } 
        }

        public void ButtonState(string function)
        {
            switch(function)
            {
                case "active":
                    BackColorButton = BackColorActiveState;
                    break;
                case "inactive":
                    BackColorButton = BackColorInactiveState;
                    break;
            }
        }
    }
}
