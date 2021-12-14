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
    public partial class CustomDate : UserControl
    {
        private DateTime date = DateTime.Now;
        public CustomDate()
        {
            /*
             *  Label1 Label2 Label3 Label4 Label5
             *  Label6 Label7 Label8 Label9 Label10
             */
            InitializeComponent();
            SetupDate(label1, label6, this.date.Year, this.date.ToString("MMM"), this.date.Day - 2);
            SetupDate(label2, label7, this.date.Year, this.date.ToString("MMM"), this.date.Day - 1);
            SetupDate(label3, label8, this.date.Year, this.date.ToString("MMM"), this.date.Day); // Center
            SetupDate(label4, label9, this.date.Year, this.date.ToString("MMM"), this.date.Day + 1);
            SetupDate(label5, label10, this.date.Year, this.date.ToString("MMM"), this.date.Day + 2);
        }

        public Color FontColor { get; set; }
        public Font FontTop {
            get { return label1.Font; }
            set
            {
                label1.Font = value;
                label2.Font = value;
                label3.Font = value;
                label4.Font = value;
                label5.Font = value;
            } 
        }
        public Font FontBottom
        {
            get { return label6.Font; }
            set
            {
                label6.Font = value;
                label7.Font = value;
                label8.Font = value;
                label9.Font = value;
                label10.Font = value;
            }
        }
        public Color ForeColorNow 
        { 
            get { return label3.ForeColor; } 
            set 
            { 
                label3.ForeColor = value;
                label8.ForeColor = value;
            } 
        }
        public Font FontTopNow
        { 
            get { return label3.Font; }
            set { label3.Font = value; } 
        }
        public Font FontBottomNow { 
            get { return label8.Font; } 
            set { label8.Font = value; } 
        }
        private void SetupDate(Label label1, Label label2, int year, string month, int day)
        {
            label1.Text = $"{month}";
            label2.Text = $"{day} {year}";
        }
    }
}
