using hospital_management_system.gui.components;

namespace hospital_management_system.gui.forms
{
    partial class PageDashboard
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.reportCard = new hospital_management_system.gui.components.PreviewCards();
            this.patientCard = new hospital_management_system.gui.components.PreviewCards();
            this.registrationCard = new hospital_management_system.gui.components.PreviewCards();
            this.billingDisplay = new hospital_management_system.gui.components.DisplayPreview();
            this.employeeDisplay = new hospital_management_system.gui.components.DisplayPreview();
            this.billingCard = new hospital_management_system.gui.components.RoundedGroupbox();
            this.employeeCard = new hospital_management_system.gui.components.RoundedGroupbox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.reportCard, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.patientCard, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.registrationCard, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(651, 119);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // reportCard
            // 
            this.reportCard.CounterColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(132)))), ((int)(((byte)(222)))));
            this.reportCard.CounterText = "1337";
            this.reportCard.LabelText = "Reports";
            this.reportCard.Location = new System.Drawing.Point(438, 4);
            this.reportCard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.reportCard.Name = "reportCard";
            this.reportCard.Size = new System.Drawing.Size(209, 111);
            this.reportCard.TabIndex = 2;
            this.reportCard.TextColor = System.Drawing.Color.Black;
            // 
            // patientCard
            // 
            this.patientCard.CounterColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(132)))), ((int)(((byte)(222)))));
            this.patientCard.CounterText = "1337";
            this.patientCard.LabelText = "Patients";
            this.patientCard.Location = new System.Drawing.Point(4, 4);
            this.patientCard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.patientCard.Name = "patientCard";
            this.patientCard.Size = new System.Drawing.Size(209, 110);
            this.patientCard.TabIndex = 0;
            this.patientCard.TextColor = System.Drawing.Color.Black;
            // 
            // registrationCard
            // 
            this.registrationCard.CounterColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(132)))), ((int)(((byte)(222)))));
            this.registrationCard.CounterText = "1337";
            this.registrationCard.LabelText = "Registrations";
            this.registrationCard.Location = new System.Drawing.Point(221, 4);
            this.registrationCard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.registrationCard.Name = "registrationCard";
            this.registrationCard.Size = new System.Drawing.Size(209, 111);
            this.registrationCard.TabIndex = 1;
            this.registrationCard.TextColor = System.Drawing.Color.Black;
            // 
            // billingDisplay
            // 
            this.billingDisplay.AutoSize = true;
            this.billingDisplay.Column0 = 15F;
            this.billingDisplay.Column1 = 70F;
            this.billingDisplay.Column2 = 20F;
            this.billingDisplay.Column3 = 10F;
            this.billingDisplay.Label0 = "ID";
            this.billingDisplay.Label1 = "";
            this.billingDisplay.Label2 = "Status";
            this.billingDisplay.Label3 = "";
            this.billingDisplay.Location = new System.Drawing.Point(690, 115);
            this.billingDisplay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.billingDisplay.Name = "billingDisplay";
            this.billingDisplay.Size = new System.Drawing.Size(364, 251);
            this.billingDisplay.TabIndex = 4;
            // 
            // employeeDisplay
            // 
            this.employeeDisplay.AutoSize = true;
            this.employeeDisplay.Column0 = 15F;
            this.employeeDisplay.Column1 = 70F;
            this.employeeDisplay.Column2 = 20F;
            this.employeeDisplay.Column3 = 10F;
            this.employeeDisplay.Label0 = "ID";
            this.employeeDisplay.Label1 = "Name";
            this.employeeDisplay.Label2 = "Status";
            this.employeeDisplay.Label3 = "";
            this.employeeDisplay.Location = new System.Drawing.Point(16, 238);
            this.employeeDisplay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.employeeDisplay.Name = "employeeDisplay";
            this.employeeDisplay.Size = new System.Drawing.Size(645, 185);
            this.employeeDisplay.TabIndex = 3;
            // 
            // billingCard
            // 
            this.billingCard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.billingCard.LabelText = "Billings";
            this.billingCard.Location = new System.Drawing.Point(669, 13);
            this.billingCard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.billingCard.Name = "billingCard";
            this.billingCard.Size = new System.Drawing.Size(399, 712);
            this.billingCard.TabIndex = 2;
            // 
            // employeeCard
            // 
            this.employeeCard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.employeeCard.LabelText = "Employees";
            this.employeeCard.Location = new System.Drawing.Point(12, 137);
            this.employeeCard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.employeeCard.Name = "employeeCard";
            this.employeeCard.Size = new System.Drawing.Size(651, 587);
            this.employeeCard.TabIndex = 1;
            // 
            // PageDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1080, 736);
            this.Controls.Add(this.billingDisplay);
            this.Controls.Add(this.employeeDisplay);
            this.Controls.Add(this.billingCard);
            this.Controls.Add(this.employeeCard);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(115, 736);
            this.Name = "PageDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "dashboardForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public void InitializeCustomComponents()
        {
            this.employeeDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.billingDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeeCard.AddControl(this.employeeDisplay);
            this.billingCard.AddControl(this.billingDisplay);
        }

        private FormMain FormMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private PreviewCards reportCard;
        private PreviewCards patientCard;
        private PreviewCards registrationCard;
        private RoundedGroupbox employeeCard;
        private RoundedGroupbox billingCard;
        private DisplayPreview employeeDisplay;
        private DisplayPreview billingDisplay;
    }
}