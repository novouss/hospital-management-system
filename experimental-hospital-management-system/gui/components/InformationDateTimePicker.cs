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
    public partial class InformationDateTimePicker : UserControl
    {
        public InformationDateTimePicker()
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

        public DateTime DateText
        {
            get { return DateTimePicker.Value; }
            set { DateTimePicker.Value = value; }
        }

        public DateTime GetDateTime()
        {
            return new DateTime(DateTimePicker.Value.Year, DateTimePicker.Value.Month, DateTimePicker.Value.Day, DateTimePicker.Value.Hour, DateTimePicker.Value.Minute, DateTimePicker.Value.Second);
        }

        public DateTime GetDate()
        {
            return new DateTime(DateTimePicker.Value.Year, DateTimePicker.Value.Month, DateTimePicker.Value.Day);
        }

    }
}
