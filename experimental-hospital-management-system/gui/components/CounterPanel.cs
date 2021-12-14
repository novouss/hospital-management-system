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
    public partial class CounterPanel : Panel
    {
        public CounterPanel()
        {
            InitializeComponent();
        }

        public string LabelCounter {
            get { return label1.Text; }
            set { label1.Text = value; }
        }
        public string LabelText {
            get { return label2.Text; } 
            set { label2.Text = value; } 
        }
        public Font FontCounter {
            get { return label1.Font; } 
            set { label1.Font = value; } 
        }
        public Font FontText { 
            get { return label2.Font; } 
            set { label2.Font = value; } 
        }
        public Color ForeColorCounter {
            get { return label1.ForeColor; }
            set { label1.ForeColor = value; } 
        }
        public Color ForeColorText {
            get { return label2.ForeColor; }
            set { label2.ForeColor = value; } 
        }
    }
}
