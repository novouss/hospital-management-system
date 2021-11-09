
namespace hospital_management_system.gui.forms
{
    partial class FormTreatments
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
            this.appointmentGroup = new System.Windows.Forms.GroupBox();
            this.registrationTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.labPanel = new System.Windows.Forms.Panel();
            this.labTexbox = new System.Windows.Forms.TextBox();
            this.labLabel = new System.Windows.Forms.Label();
            this.roomPanel = new System.Windows.Forms.Panel();
            this.roomTextbox = new System.Windows.Forms.TextBox();
            this.roomLabel = new System.Windows.Forms.Label();
            this.employeePanel = new System.Windows.Forms.Panel();
            this.employeeTextbox = new System.Windows.Forms.TextBox();
            this.employeeLabel = new System.Windows.Forms.Label();
            this.patientPanel = new System.Windows.Forms.Panel();
            this.patientTextbox = new System.Windows.Forms.TextBox();
            this.patientLabel = new System.Windows.Forms.Label();
            this.appointmentForm = new System.Windows.Forms.GroupBox();
            this.dischargePanel = new System.Windows.Forms.Panel();
            this.dischargeLabel = new System.Windows.Forms.Label();
            this.admissionPanel = new System.Windows.Forms.Panel();
            this.addmissionLabel = new System.Windows.Forms.Label();
            this.admissionCalendar = new System.Windows.Forms.DateTimePicker();
            this.dischageCalendar = new System.Windows.Forms.DateTimePicker();
            this.registrationPanel = new System.Windows.Forms.Panel();
            this.resultGroup = new System.Windows.Forms.GroupBox();
            this.resultTextgroup = new System.Windows.Forms.RichTextBox();
            this.appointmentGroup.SuspendLayout();
            this.registrationTableLayout.SuspendLayout();
            this.labPanel.SuspendLayout();
            this.roomPanel.SuspendLayout();
            this.employeePanel.SuspendLayout();
            this.patientPanel.SuspendLayout();
            this.appointmentForm.SuspendLayout();
            this.dischargePanel.SuspendLayout();
            this.admissionPanel.SuspendLayout();
            this.registrationPanel.SuspendLayout();
            this.resultGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // appointmentGroup
            // 
            this.appointmentGroup.BackColor = System.Drawing.Color.White;
            this.appointmentGroup.Controls.Add(this.registrationTableLayout);
            this.appointmentGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.appointmentGroup.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.appointmentGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(132)))), ((int)(((byte)(222)))));
            this.appointmentGroup.Location = new System.Drawing.Point(0, 0);
            this.appointmentGroup.Name = "appointmentGroup";
            this.appointmentGroup.Size = new System.Drawing.Size(1010, 234);
            this.appointmentGroup.TabIndex = 1;
            this.appointmentGroup.TabStop = false;
            this.appointmentGroup.Text = "Appointment Details";
            // 
            // registrationTableLayout
            // 
            this.registrationTableLayout.ColumnCount = 2;
            this.registrationTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.registrationTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.registrationTableLayout.Controls.Add(this.admissionPanel, 0, 2);
            this.registrationTableLayout.Controls.Add(this.dischargePanel, 0, 2);
            this.registrationTableLayout.Controls.Add(this.labPanel, 1, 1);
            this.registrationTableLayout.Controls.Add(this.roomPanel, 0, 1);
            this.registrationTableLayout.Controls.Add(this.employeePanel, 1, 0);
            this.registrationTableLayout.Controls.Add(this.patientPanel, 0, 0);
            this.registrationTableLayout.Dock = System.Windows.Forms.DockStyle.Top;
            this.registrationTableLayout.Location = new System.Drawing.Point(3, 39);
            this.registrationTableLayout.Name = "registrationTableLayout";
            this.registrationTableLayout.RowCount = 3;
            this.registrationTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.registrationTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.registrationTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.registrationTableLayout.Size = new System.Drawing.Size(1004, 189);
            this.registrationTableLayout.TabIndex = 0;
            // 
            // labPanel
            // 
            this.labPanel.Controls.Add(this.labTexbox);
            this.labPanel.Controls.Add(this.labLabel);
            this.labPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labPanel.Location = new System.Drawing.Point(505, 64);
            this.labPanel.Name = "labPanel";
            this.labPanel.Size = new System.Drawing.Size(496, 55);
            this.labPanel.TabIndex = 4;
            // 
            // labTexbox
            // 
            this.labTexbox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labTexbox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labTexbox.Location = new System.Drawing.Point(0, 26);
            this.labTexbox.Name = "labTexbox";
            this.labTexbox.Size = new System.Drawing.Size(496, 29);
            this.labTexbox.TabIndex = 5;
            // 
            // labLabel
            // 
            this.labLabel.AutoSize = true;
            this.labLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labLabel.Location = new System.Drawing.Point(3, 6);
            this.labLabel.Name = "labLabel";
            this.labLabel.Size = new System.Drawing.Size(148, 21);
            this.labLabel.TabIndex = 4;
            this.labLabel.Text = "Laboratory Number";
            // 
            // roomPanel
            // 
            this.roomPanel.Controls.Add(this.roomTextbox);
            this.roomPanel.Controls.Add(this.roomLabel);
            this.roomPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roomPanel.Location = new System.Drawing.Point(3, 64);
            this.roomPanel.Name = "roomPanel";
            this.roomPanel.Size = new System.Drawing.Size(496, 55);
            this.roomPanel.TabIndex = 3;
            // 
            // roomTextbox
            // 
            this.roomTextbox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.roomTextbox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.roomTextbox.Location = new System.Drawing.Point(0, 26);
            this.roomTextbox.Name = "roomTextbox";
            this.roomTextbox.Size = new System.Drawing.Size(496, 29);
            this.roomTextbox.TabIndex = 4;
            // 
            // roomLabel
            // 
            this.roomLabel.AutoSize = true;
            this.roomLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.roomLabel.Location = new System.Drawing.Point(3, 6);
            this.roomLabel.Name = "roomLabel";
            this.roomLabel.Size = new System.Drawing.Size(114, 21);
            this.roomLabel.TabIndex = 3;
            this.roomLabel.Text = "Room Number";
            // 
            // employeePanel
            // 
            this.employeePanel.Controls.Add(this.employeeTextbox);
            this.employeePanel.Controls.Add(this.employeeLabel);
            this.employeePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeePanel.Location = new System.Drawing.Point(505, 3);
            this.employeePanel.Name = "employeePanel";
            this.employeePanel.Size = new System.Drawing.Size(496, 55);
            this.employeePanel.TabIndex = 1;
            // 
            // employeeTextbox
            // 
            this.employeeTextbox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.employeeTextbox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.employeeTextbox.Location = new System.Drawing.Point(0, 26);
            this.employeeTextbox.Name = "employeeTextbox";
            this.employeeTextbox.Size = new System.Drawing.Size(496, 29);
            this.employeeTextbox.TabIndex = 2;
            // 
            // employeeLabel
            // 
            this.employeeLabel.AutoSize = true;
            this.employeeLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.employeeLabel.Location = new System.Drawing.Point(3, 6);
            this.employeeLabel.Name = "employeeLabel";
            this.employeeLabel.Size = new System.Drawing.Size(97, 21);
            this.employeeLabel.TabIndex = 1;
            this.employeeLabel.Text = "Employee ID";
            // 
            // patientPanel
            // 
            this.patientPanel.Controls.Add(this.patientTextbox);
            this.patientPanel.Controls.Add(this.patientLabel);
            this.patientPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.patientPanel.Location = new System.Drawing.Point(3, 3);
            this.patientPanel.Name = "patientPanel";
            this.patientPanel.Size = new System.Drawing.Size(496, 55);
            this.patientPanel.TabIndex = 0;
            // 
            // patientTextbox
            // 
            this.patientTextbox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.patientTextbox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.patientTextbox.Location = new System.Drawing.Point(0, 26);
            this.patientTextbox.Name = "patientTextbox";
            this.patientTextbox.Size = new System.Drawing.Size(496, 29);
            this.patientTextbox.TabIndex = 1;
            // 
            // patientLabel
            // 
            this.patientLabel.AutoSize = true;
            this.patientLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.patientLabel.Location = new System.Drawing.Point(3, 6);
            this.patientLabel.Name = "patientLabel";
            this.patientLabel.Size = new System.Drawing.Size(76, 21);
            this.patientLabel.TabIndex = 0;
            this.patientLabel.Text = "Patient ID";
            // 
            // appointmentForm
            // 
            this.appointmentForm.AutoSize = true;
            this.appointmentForm.Controls.Add(this.registrationPanel);
            this.appointmentForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.appointmentForm.Font = new System.Drawing.Font("Segoe UI", 36F);
            this.appointmentForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(132)))), ((int)(((byte)(222)))));
            this.appointmentForm.Location = new System.Drawing.Point(0, 0);
            this.appointmentForm.Name = "appointmentForm";
            this.appointmentForm.Padding = new System.Windows.Forms.Padding(9, 3, 9, 3);
            this.appointmentForm.Size = new System.Drawing.Size(1028, 554);
            this.appointmentForm.TabIndex = 8;
            this.appointmentForm.TabStop = false;
            this.appointmentForm.Text = "{function}_appointment";
            // 
            // dischargePanel
            // 
            this.dischargePanel.Controls.Add(this.dischageCalendar);
            this.dischargePanel.Controls.Add(this.dischargeLabel);
            this.dischargePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dischargePanel.Location = new System.Drawing.Point(505, 125);
            this.dischargePanel.Name = "dischargePanel";
            this.dischargePanel.Size = new System.Drawing.Size(496, 61);
            this.dischargePanel.TabIndex = 5;
            // 
            // dischargeLabel
            // 
            this.dischargeLabel.AutoSize = true;
            this.dischargeLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dischargeLabel.Location = new System.Drawing.Point(3, 6);
            this.dischargeLabel.Name = "dischargeLabel";
            this.dischargeLabel.Size = new System.Drawing.Size(113, 21);
            this.dischargeLabel.TabIndex = 3;
            this.dischargeLabel.Text = "Discharged On";
            // 
            // admissionPanel
            // 
            this.admissionPanel.Controls.Add(this.admissionCalendar);
            this.admissionPanel.Controls.Add(this.addmissionLabel);
            this.admissionPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.admissionPanel.Location = new System.Drawing.Point(3, 125);
            this.admissionPanel.Name = "admissionPanel";
            this.admissionPanel.Size = new System.Drawing.Size(496, 61);
            this.admissionPanel.TabIndex = 6;
            // 
            // addmissionLabel
            // 
            this.addmissionLabel.AutoSize = true;
            this.addmissionLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.addmissionLabel.Location = new System.Drawing.Point(3, 6);
            this.addmissionLabel.Name = "addmissionLabel";
            this.addmissionLabel.Size = new System.Drawing.Size(125, 21);
            this.addmissionLabel.TabIndex = 3;
            this.addmissionLabel.Text = "Admissioned On";
            // 
            // admissionCalendar
            // 
            this.admissionCalendar.CalendarFont = new System.Drawing.Font("Segoe UI", 12F);
            this.admissionCalendar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.admissionCalendar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.admissionCalendar.Location = new System.Drawing.Point(0, 32);
            this.admissionCalendar.Name = "admissionCalendar";
            this.admissionCalendar.Size = new System.Drawing.Size(496, 29);
            this.admissionCalendar.TabIndex = 5;
            this.admissionCalendar.Value = new System.DateTime(2021, 10, 19, 0, 0, 0, 0);
            // 
            // dischageCalendar
            // 
            this.dischageCalendar.CalendarFont = new System.Drawing.Font("Segoe UI", 12F);
            this.dischageCalendar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dischageCalendar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dischageCalendar.Location = new System.Drawing.Point(0, 32);
            this.dischageCalendar.Name = "dischageCalendar";
            this.dischageCalendar.Size = new System.Drawing.Size(496, 29);
            this.dischageCalendar.TabIndex = 5;
            this.dischageCalendar.Value = new System.DateTime(2021, 10, 19, 0, 0, 0, 0);
            // 
            // registrationPanel
            // 
            this.registrationPanel.AutoScroll = true;
            this.registrationPanel.Controls.Add(this.resultGroup);
            this.registrationPanel.Controls.Add(this.appointmentGroup);
            this.registrationPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.registrationPanel.Location = new System.Drawing.Point(9, 67);
            this.registrationPanel.Name = "registrationPanel";
            this.registrationPanel.Size = new System.Drawing.Size(1010, 484);
            this.registrationPanel.TabIndex = 3;
            // 
            // resultGroup
            // 
            this.resultGroup.Controls.Add(this.resultTextgroup);
            this.resultGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.resultGroup.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.resultGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(132)))), ((int)(((byte)(222)))));
            this.resultGroup.Location = new System.Drawing.Point(0, 234);
            this.resultGroup.Name = "resultGroup";
            this.resultGroup.Size = new System.Drawing.Size(1010, 205);
            this.resultGroup.TabIndex = 2;
            this.resultGroup.TabStop = false;
            this.resultGroup.Text = "Laboratory Results";
            // 
            // resultTextgroup
            // 
            this.resultTextgroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.resultTextgroup.Location = new System.Drawing.Point(3, 39);
            this.resultTextgroup.Name = "resultTextgroup";
            this.resultTextgroup.Size = new System.Drawing.Size(1004, 158);
            this.resultTextgroup.TabIndex = 0;
            this.resultTextgroup.Text = "";
            // 
            // FormTreatments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 554);
            this.Controls.Add(this.appointmentForm);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormTreatments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.appointmentGroup.ResumeLayout(false);
            this.registrationTableLayout.ResumeLayout(false);
            this.labPanel.ResumeLayout(false);
            this.labPanel.PerformLayout();
            this.roomPanel.ResumeLayout(false);
            this.roomPanel.PerformLayout();
            this.employeePanel.ResumeLayout(false);
            this.employeePanel.PerformLayout();
            this.patientPanel.ResumeLayout(false);
            this.patientPanel.PerformLayout();
            this.appointmentForm.ResumeLayout(false);
            this.dischargePanel.ResumeLayout(false);
            this.dischargePanel.PerformLayout();
            this.admissionPanel.ResumeLayout(false);
            this.admissionPanel.PerformLayout();
            this.registrationPanel.ResumeLayout(false);
            this.resultGroup.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox appointmentGroup;
        private System.Windows.Forms.TableLayoutPanel registrationTableLayout;
        private System.Windows.Forms.Panel labPanel;
        private System.Windows.Forms.TextBox labTexbox;
        private System.Windows.Forms.Label labLabel;
        private System.Windows.Forms.Panel roomPanel;
        private System.Windows.Forms.TextBox roomTextbox;
        private System.Windows.Forms.Label roomLabel;
        private System.Windows.Forms.Panel employeePanel;
        private System.Windows.Forms.TextBox employeeTextbox;
        private System.Windows.Forms.Label employeeLabel;
        private System.Windows.Forms.Panel patientPanel;
        private System.Windows.Forms.TextBox patientTextbox;
        private System.Windows.Forms.Label patientLabel;
        private System.Windows.Forms.GroupBox appointmentForm;
        private System.Windows.Forms.Panel admissionPanel;
        private System.Windows.Forms.Label addmissionLabel;
        private System.Windows.Forms.Panel dischargePanel;
        private System.Windows.Forms.Label dischargeLabel;
        private System.Windows.Forms.DateTimePicker admissionCalendar;
        private System.Windows.Forms.DateTimePicker dischageCalendar;
        private System.Windows.Forms.Panel registrationPanel;
        private System.Windows.Forms.GroupBox resultGroup;
        private System.Windows.Forms.RichTextBox resultTextgroup;
    }
}