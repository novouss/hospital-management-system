using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace experimental_hospital_management_system.gui.components
{
    public partial class InformationComboBox : UserControl
    {
        public InformationComboBox()
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

        public string ComboboxText
        {
            get { return ComboBox.Text; }
            set { ComboBox.Text = value; }
        }

        public string ValueMemeber {
            get { return ComboBox.ValueMember; }
            set { ComboBox.ValueMember = value; } 
        }

        public string DisplayMember {
            get { return ComboBox.DisplayMember; }
            set { ComboBox.DisplayMember = value; } 
        }

        public object DataSource {
            get { return ComboBox.DataSource; }
            set { ComboBox.DataSource = value; } 
        }

        public object SelectedValue { 
            get { return ComboBox.SelectedValue; }
            set { ComboBox.SelectedValue = value; } 
        }
    }
}
