namespace hospital_management_system.gui.forms
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
            this.buttonFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.saveBtn = new System.Windows.Forms.Button();
            this.modifyBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.appointmentLayout = new System.Windows.Forms.TableLayoutPanel();
            this.registrataionDetails = new System.Windows.Forms.GroupBox();
            this.reportDetails = new System.Windows.Forms.GroupBox();
            this.patientIdInfobox = new hospital_management_system.gui.components.InformationComboBox();
            this.roomIdInfobox = new hospital_management_system.gui.components.InformationComboBox();
            this.dateAdmissionInfobox = new hospital_management_system.gui.components.InformationDateTimePicker();
            this.dateDischargeInfobox = new hospital_management_system.gui.components.InformationDateTimePicker();
            this.appointmentForm.SuspendLayout();
            this.appointmentPanel.SuspendLayout();
            this.buttonFlowLayout.SuspendLayout();
            this.appointmentLayout.SuspendLayout();
            this.registrataionDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // appointmentForm
            // 
            this.appointmentForm.AutoSize = true;
            this.appointmentForm.Controls.Add(this.appointmentPanel);
            this.appointmentForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.appointmentForm.Font = new System.Drawing.Font("Segoe UI", 36F);
            this.appointmentForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(132)))), ((int)(((byte)(222)))));
            this.appointmentForm.Location = new System.Drawing.Point(0, 0);
            this.appointmentForm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.appointmentForm.Name = "appointmentForm";
            this.appointmentForm.Padding = new System.Windows.Forms.Padding(12, 4, 12, 4);
            this.appointmentForm.Size = new System.Drawing.Size(1371, 705);
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
            this.appointmentPanel.Location = new System.Drawing.Point(12, 84);
            this.appointmentPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.appointmentPanel.Name = "appointmentPanel";
            this.appointmentPanel.Size = new System.Drawing.Size(1347, 617);
            this.appointmentPanel.TabIndex = 3;
            // 
            // buttonFlowLayout
            // 
            this.buttonFlowLayout.Controls.Add(this.saveBtn);
            this.buttonFlowLayout.Controls.Add(this.modifyBtn);
            this.buttonFlowLayout.Controls.Add(this.cancelBtn);
            this.buttonFlowLayout.Controls.Add(this.deleteBtn);
            this.buttonFlowLayout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonFlowLayout.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.buttonFlowLayout.Location = new System.Drawing.Point(0, 554);
            this.buttonFlowLayout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonFlowLayout.Name = "buttonFlowLayout";
            this.buttonFlowLayout.Size = new System.Drawing.Size(1347, 63);
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
            this.saveBtn.Location = new System.Drawing.Point(1099, 4);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(244, 55);
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
            this.modifyBtn.Location = new System.Drawing.Point(847, 4);
            this.modifyBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.modifyBtn.Name = "modifyBtn";
            this.modifyBtn.Size = new System.Drawing.Size(244, 55);
            this.modifyBtn.TabIndex = 6;
            this.modifyBtn.Text = "Modify";
            this.modifyBtn.UseVisualStyleBackColor = false;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelBtn.BackColor = System.Drawing.Color.White;
            this.cancelBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cancelBtn.FlatAppearance.BorderSize = 0;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cancelBtn.ForeColor = System.Drawing.Color.Black;
            this.cancelBtn.Location = new System.Drawing.Point(595, 4);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(244, 55);
            this.cancelBtn.TabIndex = 4;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = false;
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
            this.deleteBtn.Location = new System.Drawing.Point(343, 4);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(244, 55);
            this.deleteBtn.TabIndex = 5;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = false;
            // 
            // appointmentLayout
            // 
            this.appointmentLayout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.appointmentLayout.ColumnCount = 2;
            this.appointmentLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.appointmentLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.appointmentLayout.Controls.Add(this.reportDetails, 1, 0);
            this.appointmentLayout.Controls.Add(this.registrataionDetails, 0, 0);
            this.appointmentLayout.Location = new System.Drawing.Point(3, 3);
            this.appointmentLayout.Name = "appointmentLayout";
            this.appointmentLayout.RowCount = 1;
            this.appointmentLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.appointmentLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.appointmentLayout.Size = new System.Drawing.Size(1347, 548);
            this.appointmentLayout.TabIndex = 6;
            // 
            // registrataionDetails
            // 
            this.registrataionDetails.Controls.Add(this.dateDischargeInfobox);
            this.registrataionDetails.Controls.Add(this.dateAdmissionInfobox);
            this.registrataionDetails.Controls.Add(this.roomIdInfobox);
            this.registrataionDetails.Controls.Add(this.patientIdInfobox);
            this.registrataionDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.registrataionDetails.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.registrataionDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(132)))), ((int)(((byte)(222)))));
            this.registrataionDetails.Location = new System.Drawing.Point(4, 4);
            this.registrataionDetails.Margin = new System.Windows.Forms.Padding(4);
            this.registrataionDetails.Name = "registrataionDetails";
            this.registrataionDetails.Padding = new System.Windows.Forms.Padding(4);
            this.registrataionDetails.Size = new System.Drawing.Size(665, 540);
            this.registrataionDetails.TabIndex = 18;
            this.registrataionDetails.TabStop = false;
            this.registrataionDetails.Text = "Registration Details";
            // 
            // reportDetails
            // 
            this.reportDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportDetails.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.reportDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(132)))), ((int)(((byte)(222)))));
            this.reportDetails.Location = new System.Drawing.Point(677, 4);
            this.reportDetails.Margin = new System.Windows.Forms.Padding(4);
            this.reportDetails.Name = "reportDetails";
            this.reportDetails.Padding = new System.Windows.Forms.Padding(4);
            this.reportDetails.Size = new System.Drawing.Size(666, 540);
            this.reportDetails.TabIndex = 19;
            this.reportDetails.TabStop = false;
            this.reportDetails.Text = "Report Details";
            // 
            // patientIdInfobox
            // 
            this.patientIdInfobox.ColumnWidth0 = 200F;
            this.patientIdInfobox.Dock = System.Windows.Forms.DockStyle.Top;
            this.patientIdInfobox.LabelText = "Patient ID";
            this.patientIdInfobox.Location = new System.Drawing.Point(4, 49);
            this.patientIdInfobox.Name = "patientIdInfobox";
            this.patientIdInfobox.Size = new System.Drawing.Size(657, 43);
            this.patientIdInfobox.TabIndex = 1;
            // 
            // roomIdInfobox
            // 
            this.roomIdInfobox.ColumnWidth0 = 200F;
            this.roomIdInfobox.Dock = System.Windows.Forms.DockStyle.Top;
            this.roomIdInfobox.LabelText = "Room ID";
            this.roomIdInfobox.Location = new System.Drawing.Point(4, 92);
            this.roomIdInfobox.Name = "roomIdInfobox";
            this.roomIdInfobox.Size = new System.Drawing.Size(657, 43);
            this.roomIdInfobox.TabIndex = 2;
            // 
            // dateAdmissionInfobox
            // 
            this.dateAdmissionInfobox.ColumnWidth0 = 200F;
            this.dateAdmissionInfobox.Dock = System.Windows.Forms.DockStyle.Top;
            this.dateAdmissionInfobox.LabelText = "Admissioned On";
            this.dateAdmissionInfobox.Location = new System.Drawing.Point(4, 135);
            this.dateAdmissionInfobox.Name = "dateAdmissionInfobox";
            this.dateAdmissionInfobox.Size = new System.Drawing.Size(657, 43);
            this.dateAdmissionInfobox.TabIndex = 3;
            // 
            // dateDischargeInfobox
            // 
            this.dateDischargeInfobox.ColumnWidth0 = 200F;
            this.dateDischargeInfobox.Dock = System.Windows.Forms.DockStyle.Top;
            this.dateDischargeInfobox.LabelText = "Discharged On";
            this.dateDischargeInfobox.Location = new System.Drawing.Point(4, 178);
            this.dateDischargeInfobox.Name = "dateDischargeInfobox";
            this.dateDischargeInfobox.Size = new System.Drawing.Size(657, 43);
            this.dateDischargeInfobox.TabIndex = 4;
            // 
            // FormAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 705);
            this.Controls.Add(this.appointmentForm);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormAppointment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.appointmentForm.ResumeLayout(false);
            this.appointmentPanel.ResumeLayout(false);
            this.buttonFlowLayout.ResumeLayout(false);
            this.appointmentLayout.ResumeLayout(false);
            this.registrataionDetails.ResumeLayout(false);
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
        private components.InformationDateTimePicker dateDischargeInfobox;
        private components.InformationDateTimePicker dateAdmissionInfobox;
        private components.InformationComboBox roomIdInfobox;
        private components.InformationComboBox patientIdInfobox;
    }
}