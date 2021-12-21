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
            set { radioButton2.Text = value; } 
        }
        public String RadioText3 { 
            get { return radioButton3.Text; }
            set { radioButton3.Text = value; } 
        }
        public Color RadioForeColor1
        {
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
        public bool RadioChecked1
        {
            get { return radioButton1.Checked; }
            set { radioButton1.Checked = value; }
        }
        public bool RadioChecked2
        {
            get { return radioButton2.Checked; }
            set { radioButton2.Checked = value; }
        }
        public bool RadioChecked3
        {
            get { return radioButton3.Checked; }
            set { radioButton3.Checked = value; }
        }
        public String TextboxText {
            get { return Textbox.Text; }
            set { Textbox.Text = value; } 
        }

        public bool TextboxEnabled {
            get { return Textbox.Enabled; }
            set { Textbox.Enabled = value; } 
        }
        public string GetCheckedRadio()
        {
            if (radioButton1.Checked)
            {
                return radioButton1.Text;
            }
            else if (radioButton2.Checked)
            {
                return radioButton2.Text;
            }
            else
            {
                return Textbox.Text;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Textbox.Enabled = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Textbox.Enabled = false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Textbox.Enabled = true;
        }
    }
}
