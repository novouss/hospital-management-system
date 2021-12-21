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
    public partial class PreviewBox : Button
    {
        public PreviewBox()
        {
            InitializeComponent();
            Label3.Text = "⋮";
            this.Font = new System.Drawing.Font("Segoe UI", 7F);

        }

        public object Value { get; set; }

        public string Text0 
        {
            get { return Label0.Text; }
            set { Label0.Text = value; } 
        }

        public string Text1
        {
            get { return Label1.Text; }
            set { Label1.Text = value; }
        }

        public string Text2
        {
            get { return Label2.Text; }
            set { Label2.Text = value; }
        }

        public string Text3
        {
            get { return Label3.Text; }
            set { Label3.Text = value; }
        }

        public Font TextFont0
        {
            get { return Label0.Font; }
            set { Label0.Font = value; }
        }
        public Font TextFont1
        {
            get { return Label1.Font; }
            set { Label1.Font = value; }
        }
        public Font TextFont2
        {
            get { return Label2.Font; }
            set { Label2.Font = value; }
        }
        public Font TextFont3
        {
            get { return Label3.Font; }
            set { Label3.Font = value; }
        }

        public Color TextForeColor0
        {
            get { return Label0.ForeColor; }
            set { Label0.ForeColor = value; }
        }

        public Color TextForeColor1
        {
            get { return Label1.ForeColor; }
            set { Label1.ForeColor = value; }
        }

        public Color TextForeColor2
        {
            get { return Label2.ForeColor; }
            set { Label2.ForeColor = value; }
        }

        public Color TextForeColor3
        {
            get { return Label3.ForeColor; }
            set { Label3.ForeColor = value; }
        }

        public float Column0
        {
            get { return TableLayout.ColumnStyles[0].Width; }
            set { TableLayout.ColumnStyles[0].Width = value; }
        }
        public float Column1
        {
            get { return TableLayout.ColumnStyles[1].Width; }
            set { TableLayout.ColumnStyles[1].Width = value; }
        }
        public float Column2
        {
            get { return TableLayout.ColumnStyles[2].Width; }
            set { TableLayout.ColumnStyles[2].Width = value; }
        }
        public float Column3
        {
            get { return TableLayout.ColumnStyles[3].Width; }
            set { TableLayout.ColumnStyles[3].Width = value; }
        }

        public event EventHandler PreviewBox_SingleClick
        {
            add {
                this.Label0.Click += value;
                this.Label1.Click += value;
                this.Label2.Click += value;
                this.Label3.Click += value;
            }
            remove { this.Click -= value; }
        }

        public event EventHandler PreviewBox_DoubleClick
        {
            add {
                this.Label0.DoubleClick += value;
                this.Label1.DoubleClick += value;
                this.Label2.DoubleClick += value;
                this.Label3.DoubleClick += value;
            }
            remove { this.DoubleClick -= value; }
        }

        public void SetStatusColumn(Color BackColor, Color ForeColor, string text)
        {
            Label2.BackColor = BackColor;
            Label2.ForeColor = ForeColor;
            Label2.Text = text;
        }

        private void Label3_Click(object sender, EventArgs e)
        {
            Label objectsender = (Label) sender;
            Point point = new Point(objectsender.Width, 0);
            point = objectsender.PointToScreen(point);
            MenuStrip.Show(point);
        }

        public event EventHandler ViewContextMenu_Click
        {
            add { this.viewToolStripMenuItem.Click += value; }
            remove { this.viewToolStripMenuItem.Click -= value; }
        }

        public event EventHandler DeleteContextMenu_Click
        {
            add { this.deleteToolStripMenuItem.Click += value; }
            remove { this.deleteToolStripMenuItem.Click -= value; }
        }
    }
}
