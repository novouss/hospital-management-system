
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
            this.appointmentGroup = new System.Windows.Forms.GroupBox();
            this.registrationTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.admissionPanel = new System.Windows.Forms.Panel();
            this.admissionCalendar = new System.Windows.Forms.DateTimePicker();
            this.addmissionLabel = new System.Windows.Forms.Label();
            this.dischargePanel = new System.Windows.Forms.Panel();
            this.dischageCalendar = new System.Windows.Forms.DateTimePicker();
            this.dischargeLabel = new System.Windows.Forms.Label();
            this.labPanel = new System.Windows.Forms.Panel();
            this.laboratoryCombobox = new System.Windows.Forms.ComboBox();
            this.labLabel = new System.Windows.Forms.Label();
            this.roomPanel = new System.Windows.Forms.Panel();
            this.roomCombobox = new System.Windows.Forms.ComboBox();
            this.roomLabel = new System.Windows.Forms.Label();
            this.employeePanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.departmentCombobox = new System.Windows.Forms.ComboBox();
            this.departmentLabel = new System.Windows.Forms.Label();
            this.employeeCombobox = new System.Windows.Forms.ComboBox();
            this.employeeLabel = new System.Windows.Forms.Label();
            this.patientPanel = new System.Windows.Forms.Panel();
            this.patientCombobox = new System.Windows.Forms.ComboBox();
            this.patientLabel = new System.Windows.Forms.Label();
            this.appointmentForm = new System.Windows.Forms.GroupBox();
            this.appointmentPanel = new System.Windows.Forms.Panel();
            this.buttonFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.saveBtn = new System.Windows.Forms.Button();
            this.modifyBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.resultGroup = new System.Windows.Forms.GroupBox();
            this.resultTextgroup = new System.Windows.Forms.RichTextBox();
            this.appointmentGroup.SuspendLayout();
            this.registrationTableLayout.SuspendLayout();
            this.admissionPanel.SuspendLayout();
            this.dischargePanel.SuspendLayout();
            this.labPanel.SuspendLayout();
            this.roomPanel.SuspendLayout();
            this.employeePanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.patientPanel.SuspendLayout();
            this.appointmentForm.SuspendLayout();
            this.appointmentPanel.SuspendLayout();
            this.buttonFlowLayout.SuspendLayout();
            this.resultGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // appointmentGroup
            // 
            this.appointmentGroup.BackColor = System.Drawing.SystemColors.Control;
            this.appointmentGroup.Controls.Add(this.registrationTableLayout);
            this.appointmentGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.appointmentGroup.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.appointmentGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(132)))), ((int)(((byte)(222)))));
            this.appointmentGroup.Location = new System.Drawing.Point(0, 0);
            this.appointmentGroup.Name = "appointmentGroup";
            this.appointmentGroup.Size = new System.Drawing.Size(1010, 243);
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
            this.registrationTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.registrationTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.registrationTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.registrationTableLayout.Size = new System.Drawing.Size(1004, 200);
            this.registrationTableLayout.TabIndex = 0;
            // 
            // admissionPanel
            // 
            this.admissionPanel.Controls.Add(this.admissionCalendar);
            this.admissionPanel.Controls.Add(this.addmissionLabel);
            this.admissionPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.admissionPanel.Location = new System.Drawing.Point(3, 135);
            this.admissionPanel.Name = "admissionPanel";
            this.admissionPanel.Size = new System.Drawing.Size(496, 62);
            this.admissionPanel.TabIndex = 6;
            // 
            // admissionCalendar
            // 
            this.admissionCalendar.CalendarFont = new System.Drawing.Font("Segoe UI", 12F);
            this.admissionCalendar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.admissionCalendar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.admissionCalendar.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.admissionCalendar.Location = new System.Drawing.Point(0, 33);
            this.admissionCalendar.Name = "admissionCalendar";
            this.admissionCalendar.Size = new System.Drawing.Size(496, 29);
            this.admissionCalendar.TabIndex = 6;
            this.admissionCalendar.Value = new System.DateTime(2021, 10, 19, 0, 0, 0, 0);
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
            // dischargePanel
            // 
            this.dischargePanel.Controls.Add(this.dischageCalendar);
            this.dischargePanel.Controls.Add(this.dischargeLabel);
            this.dischargePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dischargePanel.Location = new System.Drawing.Point(505, 135);
            this.dischargePanel.Name = "dischargePanel";
            this.dischargePanel.Size = new System.Drawing.Size(496, 62);
            this.dischargePanel.TabIndex = 5;
            // 
            // dischageCalendar
            // 
            this.dischageCalendar.CalendarFont = new System.Drawing.Font("Segoe UI", 12F);
            this.dischageCalendar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dischageCalendar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dischageCalendar.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dischageCalendar.Location = new System.Drawing.Point(0, 33);
            this.dischageCalendar.Name = "dischageCalendar";
            this.dischageCalendar.Size = new System.Drawing.Size(496, 29);
            this.dischageCalendar.TabIndex = 6;
            this.dischageCalendar.Value = new System.DateTime(2021, 10, 19, 0, 0, 0, 0);
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
            // labPanel
            // 
            this.labPanel.Controls.Add(this.laboratoryCombobox);
            this.labPanel.Controls.Add(this.labLabel);
            this.labPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labPanel.Location = new System.Drawing.Point(505, 69);
            this.labPanel.Name = "labPanel";
            this.labPanel.Size = new System.Drawing.Size(496, 60);
            this.labPanel.TabIndex = 4;
            // 
            // laboratoryCombobox
            // 
            this.laboratoryCombobox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.laboratoryCombobox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.laboratoryCombobox.FormattingEnabled = true;
            this.laboratoryCombobox.Location = new System.Drawing.Point(0, 31);
            this.laboratoryCombobox.Name = "laboratoryCombobox";
            this.laboratoryCombobox.Size = new System.Drawing.Size(496, 29);
            this.laboratoryCombobox.TabIndex = 5;
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
            this.roomPanel.Controls.Add(this.roomCombobox);
            this.roomPanel.Controls.Add(this.roomLabel);
            this.roomPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roomPanel.Location = new System.Drawing.Point(3, 69);
            this.roomPanel.Name = "roomPanel";
            this.roomPanel.Size = new System.Drawing.Size(496, 60);
            this.roomPanel.TabIndex = 3;
            // 
            // roomCombobox
            // 
            this.roomCombobox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.roomCombobox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.roomCombobox.FormattingEnabled = true;
            this.roomCombobox.Location = new System.Drawing.Point(0, 31);
            this.roomCombobox.Name = "roomCombobox";
            this.roomCombobox.Size = new System.Drawing.Size(496, 29);
            this.roomCombobox.TabIndex = 4;
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
            this.employeePanel.Controls.Add(this.tableLayoutPanel1);
            this.employeePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeePanel.Location = new System.Drawing.Point(505, 3);
            this.employeePanel.Name = "employeePanel";
            this.employeePanel.Size = new System.Drawing.Size(496, 60);
            this.employeePanel.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.departmentCombobox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.departmentLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.employeeCombobox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.employeeLabel, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, -1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.54099F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.45901F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(496, 61);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // departmentCombobox
            // 
            this.departmentCombobox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.departmentCombobox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.departmentCombobox.FormattingEnabled = true;
            this.departmentCombobox.Location = new System.Drawing.Point(3, 32);
            this.departmentCombobox.Name = "departmentCombobox";
            this.departmentCombobox.Size = new System.Drawing.Size(242, 29);
            this.departmentCombobox.TabIndex = 2;
            // 
            // departmentLabel
            // 
            this.departmentLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.departmentLabel.AutoSize = true;
            this.departmentLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.departmentLabel.Location = new System.Drawing.Point(3, 0);
            this.departmentLabel.Name = "departmentLabel";
            this.departmentLabel.Size = new System.Drawing.Size(242, 21);
            this.departmentLabel.TabIndex = 3;
            this.departmentLabel.Text = "Department";
            // 
            // employeeCombobox
            // 
            this.employeeCombobox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.employeeCombobox.Enabled = false;
            this.employeeCombobox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.employeeCombobox.FormattingEnabled = true;
            this.employeeCombobox.Location = new System.Drawing.Point(251, 32);
            this.employeeCombobox.Name = "employeeCombobox";
            this.employeeCombobox.Size = new System.Drawing.Size(242, 29);
            this.employeeCombobox.TabIndex = 3;
            // 
            // employeeLabel
            // 
            this.employeeLabel.AutoSize = true;
            this.employeeLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.employeeLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.employeeLabel.Location = new System.Drawing.Point(251, 0);
            this.employeeLabel.Name = "employeeLabel";
            this.employeeLabel.Size = new System.Drawing.Size(242, 21);
            this.employeeLabel.TabIndex = 1;
            this.employeeLabel.Text = "Employee ID";
            // 
            // patientPanel
            // 
            this.patientPanel.Controls.Add(this.patientCombobox);
            this.patientPanel.Controls.Add(this.patientLabel);
            this.patientPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.patientPanel.Location = new System.Drawing.Point(3, 3);
            this.patientPanel.Name = "patientPanel";
            this.patientPanel.Size = new System.Drawing.Size(496, 60);
            this.patientPanel.TabIndex = 0;
            // 
            // patientCombobox
            // 
            this.patientCombobox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.patientCombobox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.patientCombobox.FormattingEnabled = true;
            this.patientCombobox.Location = new System.Drawing.Point(0, 31);
            this.patientCombobox.Name = "patientCombobox";
            this.patientCombobox.Size = new System.Drawing.Size(496, 29);
            this.patientCombobox.TabIndex = 1;
            // 
            // patientLabel
            // 
            this.patientLabel.AutoSize = true;
            this.patientLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.patientLabel.Location = new System.Drawing.Point(0, 0);
            this.patientLabel.Name = "patientLabel";
            this.patientLabel.Size = new System.Drawing.Size(76, 21);
            this.patientLabel.TabIndex = 0;
            this.patientLabel.Text = "Patient ID";
            // 
            // appointmentForm
            // 
            this.appointmentForm.AutoSize = true;
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
            this.appointmentPanel.Controls.Add(this.buttonFlowLayout);
            this.appointmentPanel.Controls.Add(this.resultGroup);
            this.appointmentPanel.Controls.Add(this.appointmentGroup);
            this.appointmentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.appointmentPanel.Location = new System.Drawing.Point(9, 67);
            this.appointmentPanel.Name = "appointmentPanel";
            this.appointmentPanel.Size = new System.Drawing.Size(1010, 503);
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
            this.cancelBtn.Location = new System.Drawing.Point(446, 3);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(183, 45);
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
            this.deleteBtn.Location = new System.Drawing.Point(257, 3);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(183, 45);
            this.deleteBtn.TabIndex = 5;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = false;
            // 
            // resultGroup
            // 
            this.resultGroup.Controls.Add(this.resultTextgroup);
            this.resultGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.resultGroup.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.resultGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(132)))), ((int)(((byte)(222)))));
            this.resultGroup.Location = new System.Drawing.Point(0, 243);
            this.resultGroup.Name = "resultGroup";
            this.resultGroup.Size = new System.Drawing.Size(1010, 205);
            this.resultGroup.TabIndex = 2;
            this.resultGroup.TabStop = false;
            this.resultGroup.Text = "Laboratory Results";
            // 
            // resultTextgroup
            // 
            this.resultTextgroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.resultTextgroup.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.resultTextgroup.Location = new System.Drawing.Point(3, 39);
            this.resultTextgroup.Name = "resultTextgroup";
            this.resultTextgroup.Size = new System.Drawing.Size(1004, 158);
            this.resultTextgroup.TabIndex = 1;
            this.resultTextgroup.Text = "";
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
            this.appointmentGroup.ResumeLayout(false);
            this.registrationTableLayout.ResumeLayout(false);
            this.admissionPanel.ResumeLayout(false);
            this.admissionPanel.PerformLayout();
            this.dischargePanel.ResumeLayout(false);
            this.dischargePanel.PerformLayout();
            this.labPanel.ResumeLayout(false);
            this.labPanel.PerformLayout();
            this.roomPanel.ResumeLayout(false);
            this.roomPanel.PerformLayout();
            this.employeePanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.patientPanel.ResumeLayout(false);
            this.patientPanel.PerformLayout();
            this.appointmentForm.ResumeLayout(false);
            this.appointmentPanel.ResumeLayout(false);
            this.buttonFlowLayout.ResumeLayout(false);
            this.resultGroup.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox appointmentGroup;
        private System.Windows.Forms.TableLayoutPanel registrationTableLayout;
        private System.Windows.Forms.Panel labPanel;
        private System.Windows.Forms.Label labLabel;
        private System.Windows.Forms.Panel roomPanel;
        private System.Windows.Forms.Label roomLabel;
        private System.Windows.Forms.Label employeeLabel;
        private System.Windows.Forms.Panel patientPanel;
        private System.Windows.Forms.Label patientLabel;
        private System.Windows.Forms.GroupBox appointmentForm;
        private System.Windows.Forms.Panel admissionPanel;
        private System.Windows.Forms.Label addmissionLabel;
        private System.Windows.Forms.Panel dischargePanel;
        private System.Windows.Forms.Label dischargeLabel;
        private System.Windows.Forms.Panel appointmentPanel;
        private System.Windows.Forms.GroupBox resultGroup;
        private System.Windows.Forms.FlowLayoutPanel buttonFlowLayout;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button modifyBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.DateTimePicker admissionCalendar;
        private System.Windows.Forms.DateTimePicker dischageCalendar;
        private System.Windows.Forms.ComboBox laboratoryCombobox;
        private System.Windows.Forms.ComboBox roomCombobox;
        private System.Windows.Forms.ComboBox patientCombobox;
        private System.Windows.Forms.RichTextBox resultTextgroup;
        private System.Windows.Forms.Label departmentLabel;
        private System.Windows.Forms.Panel employeePanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox departmentCombobox;
        private System.Windows.Forms.ComboBox employeeCombobox;
    }
}