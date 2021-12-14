
namespace experimental_hospital_management_system.gui.pages
{
    partial class PageView
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sidepanel = new experimental_hospital_management_system.gui.components.RoundedPanels();
            this.sidebuttonpanel = new System.Windows.Forms.Panel();
            this.addpatientbtn = new System.Windows.Forms.Label();
            this.addappointmentbtn = new System.Windows.Forms.Label();
            this.addemployeebtn = new System.Windows.Forms.Label();
            this.addbillbtn = new System.Windows.Forms.Label();
            this.filterlabel = new System.Windows.Forms.Label();
            this.MainPanel = new experimental_hospital_management_system.gui.components.RoundedPanels();
            this.DisplayPreview = new experimental_hospital_management_system.gui.components.DisplayPreview();
            this.DisplayPanelLabel = new System.Windows.Forms.Label();
            this.sidepanel.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidepanel
            // 
            this.sidepanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sidepanel.BackColor = System.Drawing.Color.White;
            this.sidepanel.Controls.Add(this.sidebuttonpanel);
            this.sidepanel.Controls.Add(this.addpatientbtn);
            this.sidepanel.Controls.Add(this.addappointmentbtn);
            this.sidepanel.Controls.Add(this.addemployeebtn);
            this.sidepanel.Controls.Add(this.addbillbtn);
            this.sidepanel.Controls.Add(this.filterlabel);
            this.sidepanel.ForeColor = System.Drawing.Color.Black;
            this.sidepanel.Location = new System.Drawing.Point(880, 12);
            this.sidepanel.Margin = new System.Windows.Forms.Padding(20);
            this.sidepanel.Name = "sidepanel";
            this.sidepanel.Size = new System.Drawing.Size(340, 652);
            this.sidepanel.TabIndex = 1;
            // 
            // sidebuttonpanel
            // 
            this.sidebuttonpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(132)))), ((int)(((byte)(222)))));
            this.sidebuttonpanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sidebuttonpanel.Location = new System.Drawing.Point(0, 467);
            this.sidebuttonpanel.Name = "sidebuttonpanel";
            this.sidebuttonpanel.Size = new System.Drawing.Size(340, 37);
            this.sidebuttonpanel.TabIndex = 9;
            // 
            // addpatientbtn
            // 
            this.addpatientbtn.BackColor = System.Drawing.Color.Transparent;
            this.addpatientbtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.addpatientbtn.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.addpatientbtn.ForeColor = System.Drawing.Color.Black;
            this.addpatientbtn.Location = new System.Drawing.Point(0, 504);
            this.addpatientbtn.Name = "addpatientbtn";
            this.addpatientbtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.addpatientbtn.Size = new System.Drawing.Size(340, 37);
            this.addpatientbtn.TabIndex = 8;
            this.addpatientbtn.Text = "Add new patient...";
            this.addpatientbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addpatientbtn.Click += new System.EventHandler(this.addpatient_Click);
            // 
            // addappointmentbtn
            // 
            this.addappointmentbtn.BackColor = System.Drawing.Color.Transparent;
            this.addappointmentbtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.addappointmentbtn.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.addappointmentbtn.ForeColor = System.Drawing.Color.Black;
            this.addappointmentbtn.Location = new System.Drawing.Point(0, 541);
            this.addappointmentbtn.Name = "addappointmentbtn";
            this.addappointmentbtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.addappointmentbtn.Size = new System.Drawing.Size(340, 37);
            this.addappointmentbtn.TabIndex = 7;
            this.addappointmentbtn.Text = "Start an appointment...";
            this.addappointmentbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addappointmentbtn.Click += new System.EventHandler(this.addappointment_Click);
            // 
            // addemployeebtn
            // 
            this.addemployeebtn.BackColor = System.Drawing.Color.Transparent;
            this.addemployeebtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.addemployeebtn.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.addemployeebtn.ForeColor = System.Drawing.Color.Black;
            this.addemployeebtn.Location = new System.Drawing.Point(0, 578);
            this.addemployeebtn.Name = "addemployeebtn";
            this.addemployeebtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.addemployeebtn.Size = new System.Drawing.Size(340, 37);
            this.addemployeebtn.TabIndex = 6;
            this.addemployeebtn.Text = "Add new employee...";
            this.addemployeebtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addemployeebtn.Click += new System.EventHandler(this.addemployee_Click);
            // 
            // addbillbtn
            // 
            this.addbillbtn.BackColor = System.Drawing.Color.Transparent;
            this.addbillbtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.addbillbtn.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.addbillbtn.ForeColor = System.Drawing.Color.Black;
            this.addbillbtn.Location = new System.Drawing.Point(0, 615);
            this.addbillbtn.Name = "addbillbtn";
            this.addbillbtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.addbillbtn.Size = new System.Drawing.Size(340, 37);
            this.addbillbtn.TabIndex = 5;
            this.addbillbtn.Text = "Create a bill...";
            this.addbillbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addbillbtn.Click += new System.EventHandler(this.addbilling_Click);
            // 
            // filterlabel
            // 
            this.filterlabel.AutoSize = true;
            this.filterlabel.BackColor = System.Drawing.Color.Transparent;
            this.filterlabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.filterlabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterlabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.filterlabel.Location = new System.Drawing.Point(0, 0);
            this.filterlabel.Name = "filterlabel";
            this.filterlabel.Padding = new System.Windows.Forms.Padding(10, 20, 0, 0);
            this.filterlabel.Size = new System.Drawing.Size(77, 50);
            this.filterlabel.TabIndex = 1;
            this.filterlabel.Text = "Filters";
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.White;
            this.MainPanel.Controls.Add(this.DisplayPreview);
            this.MainPanel.Controls.Add(this.DisplayPanelLabel);
            this.MainPanel.ForeColor = System.Drawing.Color.Black;
            this.MainPanel.Location = new System.Drawing.Point(12, 12);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(845, 651);
            this.MainPanel.TabIndex = 0;
            // 
            // DisplayPreview
            // 
            this.DisplayPreview.AutoSize = true;
            this.DisplayPreview.BackColorPanel = System.Drawing.Color.White;
            this.DisplayPreview.Column0 = 15F;
            this.DisplayPreview.Column1 = 70F;
            this.DisplayPreview.Column2 = 25F;
            this.DisplayPreview.Column3 = 10F;
            this.DisplayPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DisplayPreview.Label0 = "ID";
            this.DisplayPreview.Label1 = "Name";
            this.DisplayPreview.Label2 = "Status";
            this.DisplayPreview.Label3 = "";
            this.DisplayPreview.Location = new System.Drawing.Point(0, 60);
            this.DisplayPreview.Name = "DisplayPreview";
            this.DisplayPreview.Size = new System.Drawing.Size(845, 591);
            this.DisplayPreview.TabIndex = 2;
            // 
            // DisplayPanelLabel
            // 
            this.DisplayPanelLabel.AutoSize = true;
            this.DisplayPanelLabel.BackColor = System.Drawing.Color.Transparent;
            this.DisplayPanelLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.DisplayPanelLabel.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.DisplayPanelLabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.DisplayPanelLabel.Location = new System.Drawing.Point(0, 0);
            this.DisplayPanelLabel.Name = "DisplayPanelLabel";
            this.DisplayPanelLabel.Padding = new System.Windows.Forms.Padding(10, 20, 0, 10);
            this.DisplayPanelLabel.Size = new System.Drawing.Size(115, 60);
            this.DisplayPanelLabel.TabIndex = 1;
            this.DisplayPanelLabel.Text = "{function}";
            // 
            // PageView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 675);
            this.Controls.Add(this.sidepanel);
            this.Controls.Add(this.MainPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PageView";
            this.Text = "PageView";
            this.sidepanel.ResumeLayout(false);
            this.sidepanel.PerformLayout();
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private components.RoundedPanels MainPanel;
        private experimental_hospital_management_system.gui.components.DisplayPreview DisplayPreview;
        private System.Windows.Forms.Label DisplayPanelLabel;
        private components.RoundedPanels sidepanel;
        private System.Windows.Forms.Label addpatientbtn;
        private System.Windows.Forms.Label addappointmentbtn;
        private System.Windows.Forms.Label addemployeebtn;
        private System.Windows.Forms.Label addbillbtn;
        private System.Windows.Forms.Label filterlabel;
        private System.Windows.Forms.Panel sidebuttonpanel;
    }
}