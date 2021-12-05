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
    public partial class PreviewCards : UserControl
    {
        public PreviewCards()
        {
            InitializeComponent();
        }

        public string CounterText { 
            get { return counter.Text; }
            set { counter.Text = value; } 
        }
        public string LabelText {
            get { return text.Text; }
            set { text.Text = value; } 
        }

        public Color CounterColor
        {
            get { return counter.ForeColor; }
            set { counter.ForeColor = value; }
        }

        public Color TextColor
        {
            get { return text.ForeColor; }
            set { text.ForeColor = value; }
        }
    }
}
