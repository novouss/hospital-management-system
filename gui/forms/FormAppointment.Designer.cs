namespace hospital_management_system
{
    partial class FormAppointment
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
            this.appointmentForm = new System.Windows.Forms.GroupBox();
            this.appointmentPanel = new System.Windows.Forms.Panel();
            this.appointmentLayout = new System.Windows.Forms.TableLayoutPanel();
            this.reportDetails = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.addreportbtn = new System.Windows.Forms.Button();
            this.DisplayPreview = new hospital_management_system.gui.components.DisplayPreview();
            this.registrataionDetails = new System.Windows.Forms.GroupBox();
            this.dateDischargeInfobox = new hospital_management_system.gui.components.InformationDateTimePicker();
            this.dateAdmissionInfobox = new hospital_management_system.gui.components.InformationDateTimePicker();
            this.statusInfobox = new hospital_management_system.gui.components.InformationCheckBox();
            this.roomButtonbox = new hospital_management_system.gui.components.InformationButtonbox();
            this.patientButtonbox = new hospital_management_system.gui.components.InformationButtonbox();
            this.buttonFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.saveBtn = new System.Windows.Forms.Button();
            this.modifyBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.appointmentForm.SuspendLayout();
            this.appointmentPanel.SuspendLayout();
            this.appointmentLayout.SuspendLayout();
            this.reportDetails.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.registrataionDetails.SuspendLayout();
            this.buttonFlowLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // appointmentForm
            // 
            this.appointmentForm.AutoSize = true;
            this.appointmentForm.BackColor = System.Drawing.Color.White;
            this.appointmentForm.Controls.Add(this.appointmentPanel);
            this.appointmentForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.appointmentForm.Font = new System.Drawing.Font("Segoe UI", 36F);
            this.appointmentForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(132)))), ((int)(((byte)(222)))));
            this.appointmentForm.Location = new System.Drawing.Point(0, 0);
            this.appointmentForm.Name = "appointmentForm";
            this.appointmentForm.Padding = new System.Windows.Forms.Padding(9, 3, 9, 3);
            this.appointmentForm.Size = new System.Drawing.Size(1028, 573);
            this.appointmentForm.TabIndex = 8;
            this.appointmentForm.TabStop = false;
            this.appointmentForm.Text = "{function}_appointment";
            // 
            // appointmentPanel
            // 
            this.appointmentPanel.AutoScroll = true;
            this.appointmentPanel.Controls.Add(this.appointmentLayout);
            this.appointmentPanel.Controls.Add(this.buttonFlowLayout);
            this.appointmentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.appointmentPanel.Location = new System.Drawing.Point(9, 67);
            this.appointmentPanel.Name = "appointmentPanel";
            this.appointmentPanel.Size = new System.Drawing.Size(1010, 503);
            this.appointmentPanel.TabIndex = 3;
            // 
            // appointmentLayout
            // 
            this.appointmentLayout.ColumnCount = 2;
            this.appointmentLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.appointmentLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.appointmentLayout.Controls.Add(this.reportDetails, 1, 0);
            this.appointmentLayout.Controls.Add(this.registrataionDetails, 0, 0);
            this.appointmentLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.appointmentLayout.Location = new System.Drawing.Point(0, 0);
            this.appointmentLayout.Margin = new System.Windows.Forms.Padding(2);
            this.appointmentLayout.Name = "appointmentLayout";
            this.appointmentLayout.RowCount = 1;
            this.appointmentLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.appointmentLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 452F));
            this.appointmentLayout.Size = new System.Drawing.Size(1010, 452);
            this.appointmentLayout.TabIndex = 6;
            // 
            // reportDetails
            // 
            this.reportDetails.Controls.Add(this.flowLayoutPanel1);
            this.reportDetails.Controls.Add(this.DisplayPreview);
            this.reportDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportDetails.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.reportDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(132)))), ((int)(((byte)(222)))));
            this.reportDetails.Location = new System.Drawing.Point(508, 3);
            this.reportDetails.Name = "reportDetails";
            this.reportDetails.Size = new System.Drawing.Size(499, 446);
            this.reportDetails.TabIndex = 19;
            this.reportDetails.TabStop = false;
            this.reportDetails.Text = "Report Details";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.addreportbtn);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 392);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(493, 51);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // addreportbtn
            // 
            this.addreportbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addreportbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(132)))), ((int)(((byte)(222)))));
            this.addreportbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(132)))), ((int)(((byte)(222)))));
            this.addreportbtn.FlatAppearance.BorderSize = 0;
            this.addreportbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(132)))), ((int)(((byte)(222)))));
            this.addreportbtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.addreportbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addreportbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.addreportbtn.ForeColor = System.Drawing.Color.White;
            this.addreportbtn.Location = new System.Drawing.Point(307, 3);
            this.addreportbtn.Name = "addreportbtn";
            this.addreportbtn.Size = new System.Drawing.Size(183, 45);
            this.addreportbtn.TabIndex = 3;
            this.addreportbtn.Text = "Add";
            this.addreportbtn.UseVisualStyleBackColor = false;
            this.addreportbtn.Click += new System.EventHandler(this.addreportbtn_Click);
            // 
            // DisplayPreview
            // 
            this.DisplayPreview.AutoSize = true;
            this.DisplayPreview.BackColorPanel = System.Drawing.Color.White;
            this.DisplayPreview.Column0 = 15F;
            this.DisplayPreview.Column1 = 35F;
            this.DisplayPreview.Column2 = 35F;
            this.DisplayPreview.Column3 = 10F;
            this.DisplayPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DisplayPreview.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.DisplayPreview.Label0 = "ID";
            this.DisplayPreview.Label1 = "Date Conducted";
            this.DisplayPreview.Label2 = "Department";
            this.DisplayPreview.Label3 = "";
            this.DisplayPreview.Location = new System.Drawing.Point(3, 39);
            this.DisplayPreview.Name = "DisplayPreview";
            this.DisplayPreview.Size = new System.Drawing.Size(493, 404);
            this.DisplayPreview.TabIndex = 0;
            // 
            // registrataionDetails
            // 
            this.registrataionDetails.Controls.Add(this.dateDischargeInfobox);
            this.registrataionDetails.Controls.Add(this.dateAdmissionInfobox);
            this.registrataionDetails.Controls.Add(this.statusInfobox);
            this.registrataionDetails.Controls.Add(this.roomButtonbox);
            this.registrataionDetails.Controls.Add(this.patientButtonbox);
            this.registrataionDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.registrataionDetails.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.registrataionDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(132)))), ((int)(((byte)(222)))));
            this.registrataionDetails.Location = new System.Drawing.Point(3, 3);
            this.registrataionDetails.Name = "registrataionDetails";
            this.registrataionDetails.Size = new System.Drawing.Size(499, 446);
            this.registrataionDetails.TabIndex = 18;
            this.registrataionDetails.TabStop = false;
            this.registrataionDetails.Text = "Registration Details";
            // 
            // dateDischargeInfobox
            // 
            this.dateDischargeInfobox.ColumnWidth0 = 200F;
            this.dateDischargeInfobox.DateText = new System.DateTime(2021, 12, 5, 15, 28, 14, 586);
            this.dateDischargeInfobox.Dock = System.Windows.Forms.DockStyle.Top;
            this.dateDischargeInfobox.LabelText = "Discharged On";
            this.dateDischargeInfobox.Location = new System.Drawing.Point(3, 179);
            this.dateDischargeInfobox.Margin = new System.Windows.Forms.Padding(2);
            this.dateDischargeInfobox.Name = "dateDischargeInfobox";
            this.dateDischargeInfobox.Size = new System.Drawing.Size(493, 35);
            this.dateDischargeInfobox.TabIndex = 4;
            // 
            // dateAdmissionInfobox
            // 
            this.dateAdmissionInfobox.ColumnWidth0 = 200F;
            this.dateAdmissionInfobox.DateText = new System.DateTime(2021, 12, 5, 15, 28, 14, 594);
            this.dateAdmissionInfobox.Dock = System.Windows.Forms.DockStyle.Top;
            this.dateAdmissionInfobox.LabelText = "Admissioned On";
            this.dateAdmissionInfobox.Location = new System.Drawing.Point(3, 144);
            this.dateAdmissionInfobox.Margin = new System.Windows.Forms.Padding(2);
            this.dateAdmissionInfobox.Name = "dateAdmissionInfobox";
            this.dateAdmissionInfobox.Size = new System.Drawing.Size(493, 35);
            this.dateAdmissionInfobox.TabIndex = 3;
            // 
            // statusInfobox
            // 
            this.statusInfobox.BackColorButton = System.Drawing.Color.White;
            this.statusInfobox.BackColorActiveState = System.Drawing.Color.Empty;
            this.statusInfobox.BackColorInactiveState = System.Drawing.Color.Empty;
            this.statusInfobox.ColumnWidth0 = 200F;
            this.statusInfobox.Dock = System.Windows.Forms.DockStyle.Top;
            this.statusInfobox.ForeColorButton = System.Drawing.Color.White;
            this.statusInfobox.LabelButton = "";
            this.statusInfobox.LabelText = "Status";
            this.statusInfobox.Location = new System.Drawing.Point(3, 109);
            this.statusInfobox.Name = "statusInfobox";
            this.statusInfobox.Size = new System.Drawing.Size(493, 35);
            this.statusInfobox.TabIndex = 9;
            // 
            // roomButtonbox
            // 
            this.roomButtonbox.BackColorMainButton = System.Drawing.Color.RoyalBlue;
            this.roomButtonbox.BackColorSubButton = System.Drawing.Color.RoyalBlue;
            this.roomButtonbox.ColumnWidth0 = 200F;
            this.roomButtonbox.ColumnWidth1 = 193F;
            this.roomButtonbox.Dock = System.Windows.Forms.DockStyle.Top;
            this.roomButtonbox.EnabledMainButton = true;
            this.roomButtonbox.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.roomButtonbox.ForeColorMainButton = System.Drawing.Color.White;
            this.roomButtonbox.ForeColorSubButton = System.Drawing.Color.White;
            this.roomButtonbox.Location = new System.Drawing.Point(3, 74);
            this.roomButtonbox.Margin = new System.Windows.Forms.Padding(0);
            this.roomButtonbox.Name = "roomButtonbox";
            this.roomButtonbox.Size = new System.Drawing.Size(493, 35);
            this.roomButtonbox.TabIndex = 7;
            this.roomButtonbox.TextLabel1 = "Select Room:";
            this.roomButtonbox.TextMainButton = "Choose";
            this.roomButtonbox.TextSubButton = "View Room";
            this.roomButtonbox.Value = null;
            this.roomButtonbox.VisibleMainButton = true;
            this.roomButtonbox.VisibleSubButton = true;
            // 
            // patientButtonbox
            // 
            this.patientButtonbox.BackColorMainButton = System.Drawing.Color.RoyalBlue;
            this.patientButtonbox.BackColorSubButton = System.Drawing.Color.RoyalBlue;
            this.patientButtonbox.ColumnWidth0 = 200F;
            this.patientButtonbox.ColumnWidth1 = 193F;
            this.patientButtonbox.Dock = System.Windows.Forms.DockStyle.Top;
            this.patientButtonbox.EnabledMainButton = true;
            this.patientButtonbox.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.patientButtonbox.ForeColorMainButton = System.Drawing.Color.White;
            this.patientButtonbox.ForeColorSubButton = System.Drawing.Color.White;
            this.patientButtonbox.Location = new System.Drawing.Point(3, 39);
            this.patientButtonbox.Margin = new System.Windows.Forms.Padding(0);
            this.patientButtonbox.Name = "patientButtonbox";
            this.patientButtonbox.Size = new System.Drawing.Size(493, 35);
            this.patientButtonbox.TabIndex = 6;
            this.patientButtonbox.TextLabel1 = "Select Patient:";
            this.patientButtonbox.TextMainButton = "Choose";
            this.patientButtonbox.TextSubButton = "View Patient";
            this.patientButtonbox.Value = null;
            this.patientButtonbox.VisibleMainButton = true;
            this.patientButtonbox.VisibleSubButton = true;
            // 
            // buttonFlowLayout
            // 
            this.buttonFlowLayout.Controls.Add(this.saveBtn);
            this.buttonFlowLayout.Controls.Add(this.modifyBtn);
            this.buttonFlowLayout.Controls.Add(this.cancelBtn);
            this.buttonFlowLayout.Controls.Add(this.deleteBtn);
            this.buttonFlowLayout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonFlowLayout.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.buttonFlowLayout.Location = new System.Drawing.Point(0, 452);
            this.buttonFlowLayout.Name = "buttonFlowLayout";
            this.buttonFlowLayout.Size = new System.Drawing.Size(1010, 51);
            this.buttonFlowLayout.TabIndex = 5;
            // 
            // saveBtn
            // 
            this.saveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(132)))), ((int)(((byte)(222)))));
            this.saveBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(132)))), ((int)(((byte)(222)))));
            this.saveBtn.FlatAppearance.BorderSize = 0;
            this.saveBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(132)))), ((int)(((byte)(222)))));
            this.saveBtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.Location = new System.Drawing.Point(824, 3);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(183, 45);
            this.saveBtn.TabIndex = 3;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = false;
            // 
            // modifyBtn
            // 
            this.modifyBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.modifyBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(132)))), ((int)(((byte)(222)))));
            this.modifyBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(132)))), ((int)(((byte)(222)))));
            this.modifyBtn.FlatAppearance.BorderSize = 0;
            this.modifyBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(132)))), ((int)(((byte)(222)))));
            this.modifyBtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.modifyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modifyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.modifyBtn.ForeColor = System.Drawing.Color.White;
            this.modifyBtn.Location = new System.Drawing.Point(635, 3);
            this.modifyBtn.Name = "modifyBtn";
            this.modifyBtn.Size = new System.Drawing.Size(183, 45);
            this.modifyBtn.TabIndex = 6;
            this.modifyBtn.Text = "Modify";
            this.modifyBtn.UseVisualStyleBackColor = false;
            this.modifyBtn.Click += new System.EventHandler(this.modifyBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(132)))), ((int)(((byte)(222)))));
            this.cancelBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cancelBtn.FlatAppearance.BorderSize = 0;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cancelBtn.ForeColor = System.Drawing.Color.White;
            this.cancelBtn.Location = new System.Drawing.Point(446, 3);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(183, 45);
            this.cancelBtn.TabIndex = 4;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.deleteBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.deleteBtn.FlatAppearance.BorderSize = 0;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.deleteBtn.ForeColor = System.Drawing.Color.White;
            this.deleteBtn.Location = new System.Drawing.Point(257, 3);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(183, 45);
            this.deleteBtn.TabIndex = 5;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // FormAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 573);
            this.Controls.Add(this.appointmentForm);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormAppointment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.appointmentForm.ResumeLayout(false);
            this.appointmentPanel.ResumeLayout(false);
            this.appointmentLayout.ResumeLayout(false);
            this.reportDetails.ResumeLayout(false);
            this.reportDetails.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.registrataionDetails.ResumeLayout(false);
            this.buttonFlowLayout.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox appointmentForm;
        private System.Windows.Forms.Panel appointmentPanel;
        private System.Windows.Forms.FlowLayoutPanel buttonFlowLayout;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button modifyBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.TableLayoutPanel appointmentLayout;
        private System.Windows.Forms.GroupBox reportDetails;
        private System.Windows.Forms.GroupBox registrataionDetails;
        private gui.components.InformationDateTimePicker dateDischargeInfobox;
        private gui.components.InformationDateTimePicker dateAdmissionInfobox;
        private gui.components.InformationButtonbox patientButtonbox;
        private gui.components.DisplayPreview DisplayPreview;
        private gui.components.InformationButtonbox roomButtonbox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button addreportbtn;
        private gui.components.InformationCheckBox statusInfobox;
    }
}