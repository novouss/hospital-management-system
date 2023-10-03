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
    public partial class DisplayPreview : UserControl
    {
        public DisplayPreview()
        {
            InitializeComponent();
        }

        public Color BackColorPanel
        {
            get { return Panel.BackColor; }
            set { Panel.BackColor = value; }
        }
        public float Column0 {
            get { return ColumnTableLayout.ColumnStyles[0].Width; }
            set { ColumnTableLayout.ColumnStyles[0].Width = value; } 
        }
        public float Column1 {
            get { return ColumnTableLayout.ColumnStyles[1].Width; }
            set { ColumnTableLayout.ColumnStyles[1].Width = value; } 
        }
        public float Column2 {
            get { return ColumnTableLayout.ColumnStyles[2].Width; }
            set { ColumnTableLayout.ColumnStyles[2].Width = value; } 
        }
        public float Column3 {
            get { return ColumnTableLayout.ColumnStyles[3].Width; }
            set { ColumnTableLayout.ColumnStyles[3].Width = value; } 
        }

        public String Label0 {
            get { return label1.Text; }
            set { label1.Text = value; } 
        }
        public String Label1 {
            get { return label2.Text; }
            set { label2.Text = value; } 
        }
        public String Label2 {
            get { return label3.Text; }
            set { label3.Text = value; } 
        }
        public String Label3 {
            get { return label4.Text; }
            set { label4.Text = value; } 
        }

        public void ResetDisplayPreviewbox()
        {
            // Restarts Display
            // (Raymond): Sketchy af
            Panel.Controls.Remove(this.TableLayout);
            this.TableLayout.BackColor = System.Drawing.Color.Transparent;
            this.TableLayout.ColumnCount = 1;
            this.TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayout.Dock = System.Windows.Forms.DockStyle.Top;
            this.TableLayout.Location = new System.Drawing.Point(0, 0);
            this.TableLayout.Margin = new System.Windows.Forms.Padding(0);
            this.TableLayout.Name = "TableLayout";
            this.TableLayout.RowCount = 1;
            this.TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayout.Size = new System.Drawing.Size(440, 0);
            this.TableLayout.TabIndex = 0;
            Panel.Controls.Add(this.TableLayout);
        }

        public void InitializePreviewbox(PreviewBox previewbox)
        {
            previewbox.BackColor = Color.White;
            previewbox.Margin = new System.Windows.Forms.Padding(0);
            previewbox.FlatStyle = FlatStyle.Flat;
            previewbox.Dock = DockStyle.Fill;
            previewbox.Column0 = this.Column0;
            previewbox.Column1 = this.Column1;
            previewbox.Column2 = this.Column2;
            previewbox.Column3 = this.Column3;
            previewbox.Width = this.Width;
            this.TableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F)); // Adds a row
            this.TableLayout.Height += 40;
            this.TableLayout.Controls.Add(previewbox);
        }
    }
}
