
namespace hospital_management_system
{
    partial class mainWindow
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
            this.components = new System.ComponentModel.Container();
            this.dataset = new hospital_management_system.Dataset();
            this.navigationBar = new System.Windows.Forms.Panel();
            this.profileLabel = new System.Windows.Forms.Label();
            this.navigationPanel = new System.Windows.Forms.Panel();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.billingBtn = new System.Windows.Forms.Button();
            this.removeDoctorBtn = new System.Windows.Forms.Button();
            this.addDoctorsBtn = new System.Windows.Forms.Button();
            this.doctorBtn = new System.Windows.Forms.Button();
            this.removePatientBtn = new System.Windows.Forms.Button();
            this.addPatientBtn = new System.Windows.Forms.Button();
            this.patientBtn = new System.Windows.Forms.Button();
            this.addPatientLabel = new System.Windows.Forms.Label();
            this.addPatientPanel = new System.Windows.Forms.Panel();
            this.addPatientClearBtn = new System.Windows.Forms.Button();
            this.addPatientSaveBtn = new System.Windows.Forms.Button();
            this.PatientPhoneTextbox = new System.Windows.Forms.TextBox();
            this.PatientPhoneLabel = new System.Windows.Forms.Label();
            this.PatientEmailTextbox = new System.Windows.Forms.TextBox();
            this.PatientEmailLabel = new System.Windows.Forms.Label();
            this.PatientWeightTexbox = new System.Windows.Forms.TextBox();
            this.PatientWeightLabel = new System.Windows.Forms.Label();
            this.PatientHeightTextbox = new System.Windows.Forms.TextBox();
            this.PatientHeightLabel = new System.Windows.Forms.Label();
            this.PatientBirthdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.PatientBirthdateLabel = new System.Windows.Forms.Label();
            this.PatientGenderOthersTextbox = new System.Windows.Forms.TextBox();
            this.PatientGenderOthersRadio = new System.Windows.Forms.RadioButton();
            this.PatientGenderFemaleRadio = new System.Windows.Forms.RadioButton();
            this.PatientGenderMaleRadio = new System.Windows.Forms.RadioButton();
            this.PatientGenderLabel = new System.Windows.Forms.Label();
            this.PatientFirstnameTextbox = new System.Windows.Forms.TextBox();
            this.PatientFirstnameLabel = new System.Windows.Forms.Label();
            this.PatientMiddlenameTextbox = new System.Windows.Forms.TextBox();
            this.PatientMiddlenameLabel = new System.Windows.Forms.Label();
            this.PatientLastnameTextbox = new System.Windows.Forms.TextBox();
            this.PatientLastnameLabel = new System.Windows.Forms.Label();
            this.PatientNameLabel = new System.Windows.Forms.Label();
            this.PatientAddressTextbox = new System.Windows.Forms.TextBox();
            this.PatientAddressLabel = new System.Windows.Forms.Label();
            this.patientPanel = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.patientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdOnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modifiedOnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientDetailsTableAdapter = new hospital_management_system.DatasetTableAdapters.PatientDetailsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataset)).BeginInit();
            this.navigationBar.SuspendLayout();
            this.navigationPanel.SuspendLayout();
            this.addPatientPanel.SuspendLayout();
            this.patientPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientDetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataset
            // 
            this.dataset.DataSetName = "Dataset";
            this.dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // navigationBar
            // 
            this.navigationBar.BackColor = System.Drawing.Color.White;
            this.navigationBar.Controls.Add(this.profileLabel);
            this.navigationBar.Location = new System.Drawing.Point(0, 0);
            this.navigationBar.Name = "navigationBar";
            this.navigationBar.Size = new System.Drawing.Size(1265, 105);
            this.navigationBar.TabIndex = 1;
            // 
            // profileLabel
            // 
            this.profileLabel.AutoSize = true;
            this.profileLabel.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(132)))), ((int)(((byte)(222)))));
            this.profileLabel.Location = new System.Drawing.Point(12, 18);
            this.profileLabel.Name = "profileLabel";
            this.profileLabel.Size = new System.Drawing.Size(451, 65);
            this.profileLabel.TabIndex = 0;
            this.profileLabel.Text = "Hello Administrator,";
            // 
            // navigationPanel
            // 
            this.navigationPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(132)))), ((int)(((byte)(222)))));
            this.navigationPanel.Controls.Add(this.logoutBtn);
            this.navigationPanel.Controls.Add(this.billingBtn);
            this.navigationPanel.Controls.Add(this.removeDoctorBtn);
            this.navigationPanel.Controls.Add(this.addDoctorsBtn);
            this.navigationPanel.Controls.Add(this.doctorBtn);
            this.navigationPanel.Controls.Add(this.removePatientBtn);
            this.navigationPanel.Controls.Add(this.addPatientBtn);
            this.navigationPanel.Controls.Add(this.patientBtn);
            this.navigationPanel.Location = new System.Drawing.Point(0, 102);
            this.navigationPanel.Name = "navigationPanel";
            this.navigationPanel.Size = new System.Drawing.Size(171, 578);
            this.navigationPanel.TabIndex = 2;
            // 
            // logoutBtn
            // 
            this.logoutBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.logoutBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(132)))), ((int)(((byte)(222)))));
            this.logoutBtn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.logoutBtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutBtn.ForeColor = System.Drawing.Color.White;
            this.logoutBtn.Location = new System.Drawing.Point(0, 528);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.logoutBtn.Size = new System.Drawing.Size(171, 50);
            this.logoutBtn.TabIndex = 7;
            this.logoutBtn.Text = "Log-Out";
            this.logoutBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutBtn.UseVisualStyleBackColor = false;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // billingBtn
            // 
            this.billingBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.billingBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(132)))), ((int)(((byte)(222)))));
            this.billingBtn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.billingBtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.billingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.billingBtn.ForeColor = System.Drawing.Color.White;
            this.billingBtn.Location = new System.Drawing.Point(0, 300);
            this.billingBtn.Name = "billingBtn";
            this.billingBtn.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.billingBtn.Size = new System.Drawing.Size(171, 50);
            this.billingBtn.TabIndex = 4;
            this.billingBtn.Text = "Billings";
            this.billingBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.billingBtn.UseVisualStyleBackColor = false;
            // 
            // removeDoctorBtn
            // 
            this.removeDoctorBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.removeDoctorBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(132)))), ((int)(((byte)(222)))));
            this.removeDoctorBtn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.removeDoctorBtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.removeDoctorBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeDoctorBtn.ForeColor = System.Drawing.Color.White;
            this.removeDoctorBtn.Location = new System.Drawing.Point(0, 250);
            this.removeDoctorBtn.Name = "removeDoctorBtn";
            this.removeDoctorBtn.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.removeDoctorBtn.Size = new System.Drawing.Size(171, 50);
            this.removeDoctorBtn.TabIndex = 6;
            this.removeDoctorBtn.Text = "Remove Doctor";
            this.removeDoctorBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.removeDoctorBtn.UseVisualStyleBackColor = false;
            this.removeDoctorBtn.Visible = false;
            // 
            // addDoctorsBtn
            // 
            this.addDoctorsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.addDoctorsBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(132)))), ((int)(((byte)(222)))));
            this.addDoctorsBtn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.addDoctorsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.addDoctorsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addDoctorsBtn.ForeColor = System.Drawing.Color.White;
            this.addDoctorsBtn.Location = new System.Drawing.Point(0, 200);
            this.addDoctorsBtn.Name = "addDoctorsBtn";
            this.addDoctorsBtn.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.addDoctorsBtn.Size = new System.Drawing.Size(171, 50);
            this.addDoctorsBtn.TabIndex = 5;
            this.addDoctorsBtn.Text = "Add Doctor";
            this.addDoctorsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addDoctorsBtn.UseVisualStyleBackColor = false;
            this.addDoctorsBtn.Visible = false;
            // 
            // doctorBtn
            // 
            this.doctorBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.doctorBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(132)))), ((int)(((byte)(222)))));
            this.doctorBtn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.doctorBtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.doctorBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.doctorBtn.ForeColor = System.Drawing.Color.White;
            this.doctorBtn.Location = new System.Drawing.Point(0, 150);
            this.doctorBtn.Name = "doctorBtn";
            this.doctorBtn.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.doctorBtn.Size = new System.Drawing.Size(171, 50);
            this.doctorBtn.TabIndex = 3;
            this.doctorBtn.Text = "Doctors";
            this.doctorBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.doctorBtn.UseVisualStyleBackColor = false;
            this.doctorBtn.Click += new System.EventHandler(this.doctorBtn_Click_1);
            // 
            // removePatientBtn
            // 
            this.removePatientBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.removePatientBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(132)))), ((int)(((byte)(222)))));
            this.removePatientBtn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.removePatientBtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.removePatientBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removePatientBtn.ForeColor = System.Drawing.Color.White;
            this.removePatientBtn.Location = new System.Drawing.Point(0, 100);
            this.removePatientBtn.Name = "removePatientBtn";
            this.removePatientBtn.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.removePatientBtn.Size = new System.Drawing.Size(171, 50);
            this.removePatientBtn.TabIndex = 2;
            this.removePatientBtn.Text = "Remove Patient";
            this.removePatientBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.removePatientBtn.UseVisualStyleBackColor = false;
            this.removePatientBtn.Visible = false;
            // 
            // addPatientBtn
            // 
            this.addPatientBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.addPatientBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(132)))), ((int)(((byte)(222)))));
            this.addPatientBtn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.addPatientBtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.addPatientBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addPatientBtn.ForeColor = System.Drawing.Color.White;
            this.addPatientBtn.Location = new System.Drawing.Point(0, 50);
            this.addPatientBtn.Name = "addPatientBtn";
            this.addPatientBtn.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.addPatientBtn.Size = new System.Drawing.Size(171, 50);
            this.addPatientBtn.TabIndex = 1;
            this.addPatientBtn.Text = "Add Patient";
            this.addPatientBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addPatientBtn.UseVisualStyleBackColor = false;
            this.addPatientBtn.Visible = false;
            this.addPatientBtn.Click += new System.EventHandler(this.addPatientBtn_Click_1);
            // 
            // patientBtn
            // 
            this.patientBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.patientBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(132)))), ((int)(((byte)(222)))));
            this.patientBtn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.patientBtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.patientBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.patientBtn.ForeColor = System.Drawing.Color.White;
            this.patientBtn.Location = new System.Drawing.Point(0, 0);
            this.patientBtn.Name = "patientBtn";
            this.patientBtn.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.patientBtn.Size = new System.Drawing.Size(171, 50);
            this.patientBtn.TabIndex = 0;
            this.patientBtn.Text = "Patients";
            this.patientBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.patientBtn.UseVisualStyleBackColor = false;
            this.patientBtn.Click += new System.EventHandler(this.patientBtn_Click_1);
            // 
            // addPatientLabel
            // 
            this.addPatientLabel.AutoSize = true;
            this.addPatientLabel.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPatientLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(132)))), ((int)(((byte)(222)))));
            this.addPatientLabel.Location = new System.Drawing.Point(32, 35);
            this.addPatientLabel.Name = "addPatientLabel";
            this.addPatientLabel.Size = new System.Drawing.Size(273, 65);
            this.addPatientLabel.TabIndex = 2;
            this.addPatientLabel.Text = "Add Patient";
            // 
            // addPatientPanel
            // 
            this.addPatientPanel.Controls.Add(this.addPatientClearBtn);
            this.addPatientPanel.Controls.Add(this.addPatientSaveBtn);
            this.addPatientPanel.Controls.Add(this.addPatientLabel);
            this.addPatientPanel.Controls.Add(this.PatientPhoneTextbox);
            this.addPatientPanel.Controls.Add(this.PatientPhoneLabel);
            this.addPatientPanel.Controls.Add(this.PatientEmailTextbox);
            this.addPatientPanel.Controls.Add(this.PatientEmailLabel);
            this.addPatientPanel.Controls.Add(this.PatientWeightTexbox);
            this.addPatientPanel.Controls.Add(this.PatientWeightLabel);
            this.addPatientPanel.Controls.Add(this.PatientHeightTextbox);
            this.addPatientPanel.Controls.Add(this.PatientHeightLabel);
            this.addPatientPanel.Controls.Add(this.PatientBirthdateTimePicker);
            this.addPatientPanel.Controls.Add(this.PatientBirthdateLabel);
            this.addPatientPanel.Controls.Add(this.PatientGenderOthersTextbox);
            this.addPatientPanel.Controls.Add(this.PatientGenderOthersRadio);
            this.addPatientPanel.Controls.Add(this.PatientGenderFemaleRadio);
            this.addPatientPanel.Controls.Add(this.PatientGenderMaleRadio);
            this.addPatientPanel.Controls.Add(this.PatientGenderLabel);
            this.addPatientPanel.Controls.Add(this.PatientFirstnameTextbox);
            this.addPatientPanel.Controls.Add(this.PatientFirstnameLabel);
            this.addPatientPanel.Controls.Add(this.PatientMiddlenameTextbox);
            this.addPatientPanel.Controls.Add(this.PatientMiddlenameLabel);
            this.addPatientPanel.Controls.Add(this.PatientLastnameTextbox);
            this.addPatientPanel.Controls.Add(this.PatientLastnameLabel);
            this.addPatientPanel.Controls.Add(this.PatientNameLabel);
            this.addPatientPanel.Controls.Add(this.PatientAddressTextbox);
            this.addPatientPanel.Controls.Add(this.PatientAddressLabel);
            this.addPatientPanel.Location = new System.Drawing.Point(171, 106);
            this.addPatientPanel.Name = "addPatientPanel";
            this.addPatientPanel.Size = new System.Drawing.Size(1094, 574);
            this.addPatientPanel.TabIndex = 3;
            this.addPatientPanel.Visible = false;
            // 
            // addPatientClearBtn
            // 
            this.addPatientClearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(132)))), ((int)(((byte)(222)))));
            this.addPatientClearBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(132)))), ((int)(((byte)(222)))));
            this.addPatientClearBtn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.addPatientClearBtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.addPatientClearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addPatientClearBtn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPatientClearBtn.ForeColor = System.Drawing.Color.White;
            this.addPatientClearBtn.Location = new System.Drawing.Point(700, 466);
            this.addPatientClearBtn.Name = "addPatientClearBtn";
            this.addPatientClearBtn.Size = new System.Drawing.Size(171, 50);
            this.addPatientClearBtn.TabIndex = 39;
            this.addPatientClearBtn.Text = "Clear All";
            this.addPatientClearBtn.UseVisualStyleBackColor = false;
            this.addPatientClearBtn.Click += new System.EventHandler(this.addPatientClearBtn_Click_1);
            // 
            // addPatientSaveBtn
            // 
            this.addPatientSaveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(132)))), ((int)(((byte)(222)))));
            this.addPatientSaveBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(132)))), ((int)(((byte)(222)))));
            this.addPatientSaveBtn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.addPatientSaveBtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.addPatientSaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addPatientSaveBtn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPatientSaveBtn.ForeColor = System.Drawing.Color.White;
            this.addPatientSaveBtn.Location = new System.Drawing.Point(877, 466);
            this.addPatientSaveBtn.Name = "addPatientSaveBtn";
            this.addPatientSaveBtn.Size = new System.Drawing.Size(171, 50);
            this.addPatientSaveBtn.TabIndex = 38;
            this.addPatientSaveBtn.Text = "Save";
            this.addPatientSaveBtn.UseVisualStyleBackColor = false;
            // 
            // PatientPhoneTextbox
            // 
            this.PatientPhoneTextbox.Location = new System.Drawing.Point(374, 400);
            this.PatientPhoneTextbox.Name = "PatientPhoneTextbox";
            this.PatientPhoneTextbox.Size = new System.Drawing.Size(328, 22);
            this.PatientPhoneTextbox.TabIndex = 37;
            // 
            // PatientPhoneLabel
            // 
            this.PatientPhoneLabel.AutoSize = true;
            this.PatientPhoneLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientPhoneLabel.Location = new System.Drawing.Point(370, 376);
            this.PatientPhoneLabel.Name = "PatientPhoneLabel";
            this.PatientPhoneLabel.Size = new System.Drawing.Size(116, 21);
            this.PatientPhoneLabel.TabIndex = 35;
            this.PatientPhoneLabel.Text = "Phone Number";
            // 
            // PatientEmailTextbox
            // 
            this.PatientEmailTextbox.Location = new System.Drawing.Point(41, 400);
            this.PatientEmailTextbox.Name = "PatientEmailTextbox";
            this.PatientEmailTextbox.Size = new System.Drawing.Size(328, 22);
            this.PatientEmailTextbox.TabIndex = 36;
            // 
            // PatientEmailLabel
            // 
            this.PatientEmailLabel.AutoSize = true;
            this.PatientEmailLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientEmailLabel.Location = new System.Drawing.Point(39, 376);
            this.PatientEmailLabel.Name = "PatientEmailLabel";
            this.PatientEmailLabel.Size = new System.Drawing.Size(108, 21);
            this.PatientEmailLabel.TabIndex = 34;
            this.PatientEmailLabel.Text = "Email Address";
            // 
            // PatientWeightTexbox
            // 
            this.PatientWeightTexbox.Location = new System.Drawing.Point(878, 310);
            this.PatientWeightTexbox.Name = "PatientWeightTexbox";
            this.PatientWeightTexbox.Size = new System.Drawing.Size(158, 22);
            this.PatientWeightTexbox.TabIndex = 33;
            // 
            // PatientWeightLabel
            // 
            this.PatientWeightLabel.AutoSize = true;
            this.PatientWeightLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientWeightLabel.Location = new System.Drawing.Point(874, 285);
            this.PatientWeightLabel.Name = "PatientWeightLabel";
            this.PatientWeightLabel.Size = new System.Drawing.Size(90, 21);
            this.PatientWeightLabel.TabIndex = 27;
            this.PatientWeightLabel.Text = "Weight (kg)";
            // 
            // PatientHeightTextbox
            // 
            this.PatientHeightTextbox.Location = new System.Drawing.Point(707, 310);
            this.PatientHeightTextbox.Name = "PatientHeightTextbox";
            this.PatientHeightTextbox.Size = new System.Drawing.Size(164, 22);
            this.PatientHeightTextbox.TabIndex = 32;
            // 
            // PatientHeightLabel
            // 
            this.PatientHeightLabel.AutoSize = true;
            this.PatientHeightLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientHeightLabel.Location = new System.Drawing.Point(708, 285);
            this.PatientHeightLabel.Name = "PatientHeightLabel";
            this.PatientHeightLabel.Size = new System.Drawing.Size(80, 21);
            this.PatientHeightLabel.TabIndex = 26;
            this.PatientHeightLabel.Text = "Height (ft)";
            // 
            // PatientBirthdateTimePicker
            // 
            this.PatientBirthdateTimePicker.Location = new System.Drawing.Point(374, 310);
            this.PatientBirthdateTimePicker.Name = "PatientBirthdateTimePicker";
            this.PatientBirthdateTimePicker.Size = new System.Drawing.Size(327, 22);
            this.PatientBirthdateTimePicker.TabIndex = 31;
            // 
            // PatientBirthdateLabel
            // 
            this.PatientBirthdateLabel.AutoSize = true;
            this.PatientBirthdateLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientBirthdateLabel.Location = new System.Drawing.Point(374, 285);
            this.PatientBirthdateLabel.Name = "PatientBirthdateLabel";
            this.PatientBirthdateLabel.Size = new System.Drawing.Size(73, 21);
            this.PatientBirthdateLabel.TabIndex = 12;
            this.PatientBirthdateLabel.Text = "Birthdate";
            // 
            // PatientGenderOthersTextbox
            // 
            this.PatientGenderOthersTextbox.Enabled = false;
            this.PatientGenderOthersTextbox.Location = new System.Drawing.Point(230, 310);
            this.PatientGenderOthersTextbox.Name = "PatientGenderOthersTextbox";
            this.PatientGenderOthersTextbox.Size = new System.Drawing.Size(138, 22);
            this.PatientGenderOthersTextbox.TabIndex = 23;
            // 
            // PatientGenderOthersRadio
            // 
            this.PatientGenderOthersRadio.AutoSize = true;
            this.PatientGenderOthersRadio.Location = new System.Drawing.Point(166, 314);
            this.PatientGenderOthersRadio.Name = "PatientGenderOthersRadio";
            this.PatientGenderOthersRadio.Size = new System.Drawing.Size(60, 17);
            this.PatientGenderOthersRadio.TabIndex = 22;
            this.PatientGenderOthersRadio.TabStop = true;
            this.PatientGenderOthersRadio.Text = "Others";
            this.PatientGenderOthersRadio.UseVisualStyleBackColor = true;
            // 
            // PatientGenderFemaleRadio
            // 
            this.PatientGenderFemaleRadio.AutoSize = true;
            this.PatientGenderFemaleRadio.Location = new System.Drawing.Point(99, 314);
            this.PatientGenderFemaleRadio.Name = "PatientGenderFemaleRadio";
            this.PatientGenderFemaleRadio.Size = new System.Drawing.Size(61, 17);
            this.PatientGenderFemaleRadio.TabIndex = 21;
            this.PatientGenderFemaleRadio.TabStop = true;
            this.PatientGenderFemaleRadio.Text = "Female";
            this.PatientGenderFemaleRadio.UseVisualStyleBackColor = true;
            // 
            // PatientGenderMaleRadio
            // 
            this.PatientGenderMaleRadio.AutoSize = true;
            this.PatientGenderMaleRadio.Location = new System.Drawing.Point(40, 315);
            this.PatientGenderMaleRadio.Name = "PatientGenderMaleRadio";
            this.PatientGenderMaleRadio.Size = new System.Drawing.Size(50, 17);
            this.PatientGenderMaleRadio.TabIndex = 19;
            this.PatientGenderMaleRadio.TabStop = true;
            this.PatientGenderMaleRadio.Text = "Male";
            this.PatientGenderMaleRadio.UseVisualStyleBackColor = true;
            // 
            // PatientGenderLabel
            // 
            this.PatientGenderLabel.AutoSize = true;
            this.PatientGenderLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientGenderLabel.Location = new System.Drawing.Point(39, 285);
            this.PatientGenderLabel.Name = "PatientGenderLabel";
            this.PatientGenderLabel.Size = new System.Drawing.Size(61, 21);
            this.PatientGenderLabel.TabIndex = 20;
            this.PatientGenderLabel.Text = "Gender";
            // 
            // PatientFirstnameTextbox
            // 
            this.PatientFirstnameTextbox.Location = new System.Drawing.Point(40, 153);
            this.PatientFirstnameTextbox.Name = "PatientFirstnameTextbox";
            this.PatientFirstnameTextbox.Size = new System.Drawing.Size(328, 22);
            this.PatientFirstnameTextbox.TabIndex = 3;
            // 
            // PatientFirstnameLabel
            // 
            this.PatientFirstnameLabel.AutoSize = true;
            this.PatientFirstnameLabel.Location = new System.Drawing.Point(40, 178);
            this.PatientFirstnameLabel.Name = "PatientFirstnameLabel";
            this.PatientFirstnameLabel.Size = new System.Drawing.Size(57, 13);
            this.PatientFirstnameLabel.TabIndex = 6;
            this.PatientFirstnameLabel.Text = "Firstname";
            // 
            // PatientMiddlenameTextbox
            // 
            this.PatientMiddlenameTextbox.Location = new System.Drawing.Point(708, 153);
            this.PatientMiddlenameTextbox.Name = "PatientMiddlenameTextbox";
            this.PatientMiddlenameTextbox.Size = new System.Drawing.Size(328, 22);
            this.PatientMiddlenameTextbox.TabIndex = 5;
            // 
            // PatientMiddlenameLabel
            // 
            this.PatientMiddlenameLabel.AutoSize = true;
            this.PatientMiddlenameLabel.Location = new System.Drawing.Point(705, 178);
            this.PatientMiddlenameLabel.Name = "PatientMiddlenameLabel";
            this.PatientMiddlenameLabel.Size = new System.Drawing.Size(71, 13);
            this.PatientMiddlenameLabel.TabIndex = 8;
            this.PatientMiddlenameLabel.Text = "Middlename";
            // 
            // PatientLastnameTextbox
            // 
            this.PatientLastnameTextbox.Location = new System.Drawing.Point(374, 153);
            this.PatientLastnameTextbox.Name = "PatientLastnameTextbox";
            this.PatientLastnameTextbox.Size = new System.Drawing.Size(328, 22);
            this.PatientLastnameTextbox.TabIndex = 4;
            // 
            // PatientLastnameLabel
            // 
            this.PatientLastnameLabel.AutoSize = true;
            this.PatientLastnameLabel.Location = new System.Drawing.Point(371, 178);
            this.PatientLastnameLabel.Name = "PatientLastnameLabel";
            this.PatientLastnameLabel.Size = new System.Drawing.Size(55, 13);
            this.PatientLastnameLabel.TabIndex = 7;
            this.PatientLastnameLabel.Text = "Lastname";
            // 
            // PatientNameLabel
            // 
            this.PatientNameLabel.AutoSize = true;
            this.PatientNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientNameLabel.Location = new System.Drawing.Point(39, 129);
            this.PatientNameLabel.Name = "PatientNameLabel";
            this.PatientNameLabel.Size = new System.Drawing.Size(132, 21);
            this.PatientNameLabel.TabIndex = 13;
            this.PatientNameLabel.Text = "Full Patient Name";
            // 
            // PatientAddressTextbox
            // 
            this.PatientAddressTextbox.Location = new System.Drawing.Point(40, 237);
            this.PatientAddressTextbox.Name = "PatientAddressTextbox";
            this.PatientAddressTextbox.Size = new System.Drawing.Size(996, 22);
            this.PatientAddressTextbox.TabIndex = 9;
            // 
            // PatientAddressLabel
            // 
            this.PatientAddressLabel.AutoSize = true;
            this.PatientAddressLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientAddressLabel.Location = new System.Drawing.Point(39, 213);
            this.PatientAddressLabel.Name = "PatientAddressLabel";
            this.PatientAddressLabel.Size = new System.Drawing.Size(66, 21);
            this.PatientAddressLabel.TabIndex = 10;
            this.PatientAddressLabel.Text = "Address";
            // 
            // patientPanel
            // 
            this.patientPanel.Controls.Add(this.dataGridView1);
            this.patientPanel.Location = new System.Drawing.Point(171, 106);
            this.patientPanel.Name = "patientPanel";
            this.patientPanel.Size = new System.Drawing.Size(1094, 574);
            this.patientPanel.TabIndex = 40;
            this.patientPanel.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.patientIDDataGridViewTextBoxColumn,
            this.firstnameDataGridViewTextBoxColumn,
            this.lastnameDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.birthdateDataGridViewTextBoxColumn,
            this.heightDataGridViewTextBoxColumn,
            this.weightDataGridViewTextBoxColumn,
            this.emailIDDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.createdOnDataGridViewTextBoxColumn,
            this.modifiedOnDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.patientDetailsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 181);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1075, 382);
            this.dataGridView1.TabIndex = 0;
            // 
            // patientIDDataGridViewTextBoxColumn
            // 
            this.patientIDDataGridViewTextBoxColumn.DataPropertyName = "PatientID";
            this.patientIDDataGridViewTextBoxColumn.HeaderText = "PatientID";
            this.patientIDDataGridViewTextBoxColumn.Name = "patientIDDataGridViewTextBoxColumn";
            this.patientIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "Firstname";
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "Firstname";
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            this.lastnameDataGridViewTextBoxColumn.DataPropertyName = "Lastname";
            this.lastnameDataGridViewTextBoxColumn.HeaderText = "Lastname";
            this.lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "Age";
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            // 
            // birthdateDataGridViewTextBoxColumn
            // 
            this.birthdateDataGridViewTextBoxColumn.DataPropertyName = "Birthdate";
            this.birthdateDataGridViewTextBoxColumn.HeaderText = "Birthdate";
            this.birthdateDataGridViewTextBoxColumn.Name = "birthdateDataGridViewTextBoxColumn";
            // 
            // heightDataGridViewTextBoxColumn
            // 
            this.heightDataGridViewTextBoxColumn.DataPropertyName = "Height";
            this.heightDataGridViewTextBoxColumn.HeaderText = "Height";
            this.heightDataGridViewTextBoxColumn.Name = "heightDataGridViewTextBoxColumn";
            // 
            // weightDataGridViewTextBoxColumn
            // 
            this.weightDataGridViewTextBoxColumn.DataPropertyName = "Weight";
            this.weightDataGridViewTextBoxColumn.HeaderText = "Weight";
            this.weightDataGridViewTextBoxColumn.Name = "weightDataGridViewTextBoxColumn";
            // 
            // emailIDDataGridViewTextBoxColumn
            // 
            this.emailIDDataGridViewTextBoxColumn.DataPropertyName = "EmailID";
            this.emailIDDataGridViewTextBoxColumn.HeaderText = "EmailID";
            this.emailIDDataGridViewTextBoxColumn.Name = "emailIDDataGridViewTextBoxColumn";
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            // 
            // createdOnDataGridViewTextBoxColumn
            // 
            this.createdOnDataGridViewTextBoxColumn.DataPropertyName = "CreatedOn";
            this.createdOnDataGridViewTextBoxColumn.HeaderText = "CreatedOn";
            this.createdOnDataGridViewTextBoxColumn.Name = "createdOnDataGridViewTextBoxColumn";
            // 
            // modifiedOnDataGridViewTextBoxColumn
            // 
            this.modifiedOnDataGridViewTextBoxColumn.DataPropertyName = "ModifiedOn";
            this.modifiedOnDataGridViewTextBoxColumn.HeaderText = "ModifiedOn";
            this.modifiedOnDataGridViewTextBoxColumn.Name = "modifiedOnDataGridViewTextBoxColumn";
            // 
            // patientDetailsBindingSource
            // 
            this.patientDetailsBindingSource.DataMember = "PatientDetails";
            this.patientDetailsBindingSource.DataSource = this.dataset;
            // 
            // patientDetailsTableAdapter
            // 
            this.patientDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.addPatientPanel);
            this.Controls.Add(this.patientPanel);
            this.Controls.Add(this.navigationBar);
            this.Controls.Add(this.navigationPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "mainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hospital Management System";
            this.Load += new System.EventHandler(this.mainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataset)).EndInit();
            this.navigationBar.ResumeLayout(false);
            this.navigationBar.PerformLayout();
            this.navigationPanel.ResumeLayout(false);
            this.addPatientPanel.ResumeLayout(false);
            this.addPatientPanel.PerformLayout();
            this.patientPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientDetailsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel navigationBar;
        private System.Windows.Forms.Label profileLabel;
        private Dataset dataset;
        private System.Windows.Forms.Panel navigationPanel;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Button billingBtn;
        private System.Windows.Forms.Button removeDoctorBtn;
        private System.Windows.Forms.Button addDoctorsBtn;
        private System.Windows.Forms.Button doctorBtn;
        private System.Windows.Forms.Button removePatientBtn;
        private System.Windows.Forms.Button addPatientBtn;
        private System.Windows.Forms.Button patientBtn;
        private System.Windows.Forms.Label addPatientLabel;
        private System.Windows.Forms.Panel addPatientPanel;
        private System.Windows.Forms.Button addPatientClearBtn;
        private System.Windows.Forms.Button addPatientSaveBtn;
        private System.Windows.Forms.TextBox PatientPhoneTextbox;
        private System.Windows.Forms.Label PatientPhoneLabel;
        private System.Windows.Forms.TextBox PatientEmailTextbox;
        private System.Windows.Forms.Label PatientEmailLabel;
        private System.Windows.Forms.TextBox PatientWeightTexbox;
        private System.Windows.Forms.Label PatientWeightLabel;
        private System.Windows.Forms.TextBox PatientHeightTextbox;
        private System.Windows.Forms.Label PatientHeightLabel;
        private System.Windows.Forms.DateTimePicker PatientBirthdateTimePicker;
        private System.Windows.Forms.Label PatientBirthdateLabel;
        private System.Windows.Forms.TextBox PatientGenderOthersTextbox;
        private System.Windows.Forms.RadioButton PatientGenderOthersRadio;
        private System.Windows.Forms.RadioButton PatientGenderFemaleRadio;
        private System.Windows.Forms.RadioButton PatientGenderMaleRadio;
        private System.Windows.Forms.Label PatientGenderLabel;
        private System.Windows.Forms.TextBox PatientFirstnameTextbox;
        private System.Windows.Forms.Label PatientFirstnameLabel;
        private System.Windows.Forms.TextBox PatientMiddlenameTextbox;
        private System.Windows.Forms.Label PatientMiddlenameLabel;
        private System.Windows.Forms.TextBox PatientLastnameTextbox;
        private System.Windows.Forms.Label PatientLastnameLabel;
        private System.Windows.Forms.Label PatientNameLabel;
        private System.Windows.Forms.TextBox PatientAddressTextbox;
        private System.Windows.Forms.Label PatientAddressLabel;
        private System.Windows.Forms.Panel patientPanel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource patientDetailsBindingSource;
        private DatasetTableAdapters.PatientDetailsTableAdapter patientDetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdOnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modifiedOnDataGridViewTextBoxColumn;
    }
}

