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
            this.TableLayout.Size = new System.Drawing.Size(440, 10);
            this.TableLayout.TabIndex = 0;
            Panel.Controls.Add(this.TableLayout);
        }
    }
}
