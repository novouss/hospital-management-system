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
    public partial class InformationButtonbox : UserControl
    {
        public InformationButtonbox()
        {
            InitializeComponent();
        }

        public object Value { get; set; }
        public String TextLabel1
        {
            get { return Label1.Text; }
            set { Label1.Text = value; }
        }
        public String TextMainButton 
        { 
            get { return MainButton.Text; } 
            set { MainButton.Text = value; } 
        }
        public String TextSubButton 
        { 
            get { return SubButton.Text; } 
            set { SubButton.Text = value; } 
        }
        public float ColumnWidth0
        {
            get { return TableLayout.ColumnStyles[0].Width; }
            set { TableLayout.ColumnStyles[0].Width = value; }
        }
        public float ColumnWidth1
        {
            get { return TableLayout.ColumnStyles[1].Width; }
            set { TableLayout.ColumnStyles[1].Width = value; }
        }
        public Color ForeColorMainButton 
        { 
            get { return MainButton.ForeColor; } 
            set { MainButton.ForeColor = value; } 
        }
        public Color BackColorMainButton 
        { 
            get { return MainButton.BackColor; }
            set { MainButton.BackColor = value; } 
        }
        public Color ForeColorSubButton
        {
            get { return SubButton.ForeColor; }
            set { SubButton.ForeColor = value; }
        }
        public Color BackColorSubButton
        {
            get { return SubButton.BackColor; }
            set { SubButton.BackColor = value; }
        }
        public bool VisibleMainButton
        {
            get { return MainButton.Visible; }
            set { MainButton.Visible = value; }
        }
        public bool VisibleSubButton
        {
            get { return SubButton.Visible; }
            set { SubButton.Visible = value; }
        }
        public bool EnabledMainButton
        {
            get { return MainButton.Enabled; }
            set { MainButton.Enabled = value; }
        }
        public event EventHandler MainButtonbox_Click 
        {
            add { MainButton.Click += value; }
            remove { MainButton.Click -= value; }
        }

        public event EventHandler SubButtonbox_Click
        {
            add { SubButton.Click += value; }
            remove { SubButton.Click -= value; }
        }
    }
}
