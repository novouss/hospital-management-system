
namespace experimental_hospital_management_system.gui.components
{
    partial class PreviewBox
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.Label0 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.MenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TableLayout.SuspendLayout();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // TableLayout
            // 
            this.TableLayout.BackColor = System.Drawing.Color.Transparent;
            this.TableLayout.ColumnCount = 4;
            this.TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TableLayout.Controls.Add(this.Label0, 0, 0);
            this.TableLayout.Controls.Add(this.Label1, 1, 0);
            this.TableLayout.Controls.Add(this.Label2, 2, 0);
            this.TableLayout.Controls.Add(this.Label3, 3, 0);
            this.TableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayout.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TableLayout.ForeColor = System.Drawing.Color.Black;
            this.TableLayout.Location = new System.Drawing.Point(0, 0);
            this.TableLayout.Name = "TableLayout";
            this.TableLayout.RowCount = 1;
            this.TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayout.Size = new System.Drawing.Size(1056, 40);
            this.TableLayout.TabIndex = 5;
            // 
            // Label0
            // 
            this.Label0.BackColor = System.Drawing.Color.Transparent;
            this.Label0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label0.Location = new System.Drawing.Point(3, 0);
            this.Label0.Name = "Label0";
            this.Label0.Size = new System.Drawing.Size(258, 40);
            this.Label0.TabIndex = 1;
            this.Label0.Text = "Label0";
            this.Label0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label1
            // 
            this.Label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label1.Location = new System.Drawing.Point(267, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(258, 40);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Label1";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label2
            // 
            this.Label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label2.Location = new System.Drawing.Point(531, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(258, 40);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "Label2";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label3
            // 
            this.Label3.ContextMenuStrip = this.MenuStrip;
            this.Label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label3.Location = new System.Drawing.Point(795, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(258, 40);
            this.Label3.TabIndex = 2;
            this.Label3.Text = "⋮";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.MenuStrip.ShowImageMargin = false;
            this.MenuStrip.Size = new System.Drawing.Size(83, 48);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(82, 22);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(82, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // PreviewBox
            // 
            this.Controls.Add(this.TableLayout);
            this.ForeColor = System.Drawing.Color.White;
            this.Size = new System.Drawing.Size(1056, 40);
            this.TableLayout.ResumeLayout(false);
            this.MenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label Label0;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label Label2;
        public System.Windows.Forms.TableLayoutPanel TableLayout;
        private System.Windows.Forms.ContextMenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}
