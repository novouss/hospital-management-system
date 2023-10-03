
namespace hospital_management_system.gui.forms
{
    partial class FormMain
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
            this.navigationMenu = new System.Windows.Forms.Panel();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.billSubMenu = new System.Windows.Forms.Panel();
            this.removeBillBtn = new System.Windows.Forms.Button();
            this.addBillBtn = new System.Windows.Forms.Button();
            this.billBtn = new System.Windows.Forms.Button();
            this.roomBtn = new System.Windows.Forms.Button();
            this.labBtn = new System.Windows.Forms.Button();
            this.appSubMenu = new System.Windows.Forms.Panel();
            this.removeAppBtn = new System.Windows.Forms.Button();
            this.addAppBtn = new System.Windows.Forms.Button();
            this.appBtn = new System.Windows.Forms.Button();
            this.employeeSubMenu = new System.Windows.Forms.Panel();
            this.removeEmployeeBtn = new System.Windows.Forms.Button();
            this.addEmployeeBtn = new System.Windows.Forms.Button();
            this.employeeBtn = new System.Windows.Forms.Button();
            this.patientSubMenu = new System.Windows.Forms.Panel();
            this.removePatientBtn = new System.Windows.Forms.Button();
            this.addPatientBtn = new System.Windows.Forms.Button();
            this.patientBtn = new System.Windows.Forms.Button();
            this.dashboardBtn = new System.Windows.Forms.Button();
            this.displayPanel = new System.Windows.Forms.Panel();
            this.loginPanel = new System.Windows.Forms.Panel();
            this.loginGroup = new System.Windows.Forms.GroupBox();
            this.emailPanel = new System.Windows.Forms.Panel();
            this.emailTextbox = new System.Windows.Forms.TextBox();
            this.passwordPanel = new System.Windows.Forms.Panel();
            this.passwordTextbox = new System.Windows.Forms.TextBox();
            this.emailText = new System.Windows.Forms.Label();
            this.passwordText = new System.Windows.Forms.Label();
            this.loginBtn = new System.Windows.Forms.Button();
            this.navigationMenu.SuspendLayout();
            this.billSubMenu.SuspendLayout();
            this.appSubMenu.SuspendLayout();
            this.employeeSubMenu.SuspendLayout();
            this.patientSubMenu.SuspendLayout();
            this.displayPanel.SuspendLayout();
            this.loginPanel.SuspendLayout();
            this.loginGroup.SuspendLayout();
            this.emailPanel.SuspendLayout();
            this.passwordPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // navigationMenu
            // 
            this.navigationMenu.AutoScroll = true;
            this.navigationMenu.BackColor = System.Drawing.Color.White;
            this.navigationMenu.Controls.Add(this.logoutBtn);
            this.navigationMenu.Controls.Add(this.billSubMenu);
            this.navigationMenu.Controls.Add(this.billBtn);
            this.navigationMenu.Controls.Add(this.roomBtn);
            this.navigationMenu.Controls.Add(this.labBtn);
            this.navigationMenu.Controls.Add(this.appSubMenu);
            this.navigationMenu.Controls.Add(this.appBtn);
            this.navigationMenu.Controls.Add(this.employeeSubMenu);
            this.navigationMenu.Controls.Add(this.employeeBtn);
            this.navigationMenu.Controls.Add(this.patientSubMenu);
            this.navigationMenu.Controls.Add(this.patientBtn);
            this.navigationMenu.Controls.Add(this.dashboardBtn);
            this.navigationMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.navigationMenu.Location = new System.Drawing.Point(0, 0);
            this.navigationMenu.Name = "navigationMenu";
            this.navigationMenu.Size = new System.Drawing.Size(200, 681);
            this.navigationMenu.TabIndex = 1;
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.Color.White;
            this.logoutBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.logoutBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.logoutBtn.FlatAppearance.BorderSize = 0;
            this.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutBtn.Location = new System.Drawing.Point(0, 675);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(183, 45);
            this.logoutBtn.TabIndex = 11;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.UseVisualStyleBackColor = false;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // billSubMenu
            // 
            this.billSubMenu.Controls.Add(this.removeBillBtn);
            this.billSubMenu.Controls.Add(this.addBillBtn);
            this.billSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.billSubMenu.Location = new System.Drawing.Point(0, 585);
            this.billSubMenu.Name = "billSubMenu";
            this.billSubMenu.Size = new System.Drawing.Size(183, 90);
            this.billSubMenu.TabIndex = 6;
            this.billSubMenu.Visible = false;
            // 
            // removeBillBtn
            // 
            this.removeBillBtn.BackColor = System.Drawing.Color.White;
            this.removeBillBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.removeBillBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.removeBillBtn.FlatAppearance.BorderSize = 0;
            this.removeBillBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeBillBtn.Location = new System.Drawing.Point(0, 45);
            this.removeBillBtn.Name = "removeBillBtn";
            this.removeBillBtn.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.removeBillBtn.Size = new System.Drawing.Size(183, 45);
            this.removeBillBtn.TabIndex = 3;
            this.removeBillBtn.Text = "Remove Billing";
            this.removeBillBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.removeBillBtn.UseVisualStyleBackColor = false;
            // 
            // addBillBtn
            // 
            this.addBillBtn.BackColor = System.Drawing.Color.White;
            this.addBillBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.addBillBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.addBillBtn.FlatAppearance.BorderSize = 0;
            this.addBillBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBillBtn.Location = new System.Drawing.Point(0, 0);
            this.addBillBtn.Name = "addBillBtn";
            this.addBillBtn.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.addBillBtn.Size = new System.Drawing.Size(183, 45);
            this.addBillBtn.TabIndex = 2;
            this.addBillBtn.Text = "Add Billing";
            this.addBillBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addBillBtn.UseVisualStyleBackColor = false;
            this.addBillBtn.Click += new System.EventHandler(this.addBillBtn_Click);
            // 
            // billBtn
            // 
            this.billBtn.BackColor = System.Drawing.Color.White;
            this.billBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.billBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.billBtn.FlatAppearance.BorderSize = 0;
            this.billBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.billBtn.Location = new System.Drawing.Point(0, 540);
            this.billBtn.Name = "billBtn";
            this.billBtn.Size = new System.Drawing.Size(183, 45);
            this.billBtn.TabIndex = 5;
            this.billBtn.Text = "Billing";
            this.billBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.billBtn.UseVisualStyleBackColor = false;
            this.billBtn.Click += new System.EventHandler(this.billBtn_Click);
            // 
            // roomBtn
            // 
            this.roomBtn.BackColor = System.Drawing.Color.White;
            this.roomBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.roomBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.roomBtn.FlatAppearance.BorderSize = 0;
            this.roomBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roomBtn.Location = new System.Drawing.Point(0, 495);
            this.roomBtn.Name = "roomBtn";
            this.roomBtn.Size = new System.Drawing.Size(183, 45);
            this.roomBtn.TabIndex = 8;
            this.roomBtn.Text = "Rooms";
            this.roomBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.roomBtn.UseVisualStyleBackColor = false;
            this.roomBtn.Click += new System.EventHandler(this.roomBtn_Click);
            // 
            // labBtn
            // 
            this.labBtn.BackColor = System.Drawing.Color.White;
            this.labBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.labBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.labBtn.FlatAppearance.BorderSize = 0;
            this.labBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labBtn.Location = new System.Drawing.Point(0, 450);
            this.labBtn.Name = "labBtn";
            this.labBtn.Size = new System.Drawing.Size(183, 45);
            this.labBtn.TabIndex = 7;
            this.labBtn.Text = "Laboratory";
            this.labBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labBtn.UseVisualStyleBackColor = false;
            this.labBtn.Click += new System.EventHandler(this.labBtn_Click);
            // 
            // appSubMenu
            // 
            this.appSubMenu.Controls.Add(this.removeAppBtn);
            this.appSubMenu.Controls.Add(this.addAppBtn);
            this.appSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.appSubMenu.Location = new System.Drawing.Point(0, 360);
            this.appSubMenu.Name = "appSubMenu";
            this.appSubMenu.Size = new System.Drawing.Size(183, 90);
            this.appSubMenu.TabIndex = 10;
            this.appSubMenu.Visible = false;
            // 
            // removeAppBtn
            // 
            this.removeAppBtn.BackColor = System.Drawing.Color.White;
            this.removeAppBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.removeAppBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.removeAppBtn.FlatAppearance.BorderSize = 0;
            this.removeAppBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeAppBtn.Location = new System.Drawing.Point(0, 45);
            this.removeAppBtn.Name = "removeAppBtn";
            this.removeAppBtn.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.removeAppBtn.Size = new System.Drawing.Size(183, 45);
            this.removeAppBtn.TabIndex = 3;
            this.removeAppBtn.Text = "Remove Appointment";
            this.removeAppBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.removeAppBtn.UseVisualStyleBackColor = false;
            // 
            // addAppBtn
            // 
            this.addAppBtn.BackColor = System.Drawing.Color.White;
            this.addAppBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.addAppBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.addAppBtn.FlatAppearance.BorderSize = 0;
            this.addAppBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addAppBtn.Location = new System.Drawing.Point(0, 0);
            this.addAppBtn.Name = "addAppBtn";
            this.addAppBtn.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.addAppBtn.Size = new System.Drawing.Size(183, 45);
            this.addAppBtn.TabIndex = 2;
            this.addAppBtn.Text = "Add Appointment";
            this.addAppBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addAppBtn.UseVisualStyleBackColor = false;
            this.addAppBtn.Click += new System.EventHandler(this.addRegBtn_Click);
            // 
            // appBtn
            // 
            this.appBtn.BackColor = System.Drawing.Color.White;
            this.appBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.appBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.appBtn.FlatAppearance.BorderSize = 0;
            this.appBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.appBtn.Location = new System.Drawing.Point(0, 315);
            this.appBtn.Name = "appBtn";
            this.appBtn.Size = new System.Drawing.Size(183, 45);
            this.appBtn.TabIndex = 9;
            this.appBtn.Text = "Appointment";
            this.appBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.appBtn.UseVisualStyleBackColor = false;
            this.appBtn.Click += new System.EventHandler(this.regBtn_Click);
            // 
            // employeeSubMenu
            // 
            this.employeeSubMenu.Controls.Add(this.removeEmployeeBtn);
            this.employeeSubMenu.Controls.Add(this.addEmployeeBtn);
            this.employeeSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.employeeSubMenu.Location = new System.Drawing.Point(0, 225);
            this.employeeSubMenu.Name = "employeeSubMenu";
            this.employeeSubMenu.Size = new System.Drawing.Size(183, 90);
            this.employeeSubMenu.TabIndex = 4;
            this.employeeSubMenu.Visible = false;
            // 
            // removeEmployeeBtn
            // 
            this.removeEmployeeBtn.BackColor = System.Drawing.Color.White;
            this.removeEmployeeBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.removeEmployeeBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.removeEmployeeBtn.FlatAppearance.BorderSize = 0;
            this.removeEmployeeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeEmployeeBtn.Location = new System.Drawing.Point(0, 45);
            this.removeEmployeeBtn.Name = "removeEmployeeBtn";
            this.removeEmployeeBtn.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.removeEmployeeBtn.Size = new System.Drawing.Size(183, 45);
            this.removeEmployeeBtn.TabIndex = 3;
            this.removeEmployeeBtn.Text = "Remove Employee";
            this.removeEmployeeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.removeEmployeeBtn.UseVisualStyleBackColor = false;
            // 
            // addEmployeeBtn
            // 
            this.addEmployeeBtn.BackColor = System.Drawing.Color.White;
            this.addEmployeeBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.addEmployeeBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.addEmployeeBtn.FlatAppearance.BorderSize = 0;
            this.addEmployeeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addEmployeeBtn.Location = new System.Drawing.Point(0, 0);
            this.addEmployeeBtn.Name = "addEmployeeBtn";
            this.addEmployeeBtn.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.addEmployeeBtn.Size = new System.Drawing.Size(183, 45);
            this.addEmployeeBtn.TabIndex = 2;
            this.addEmployeeBtn.Text = "Add Employee";
            this.addEmployeeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addEmployeeBtn.UseVisualStyleBackColor = false;
            this.addEmployeeBtn.Click += new System.EventHandler(this.addEmployeeBtn_Click);
            // 
            // employeeBtn
            // 
            this.employeeBtn.BackColor = System.Drawing.Color.White;
            this.employeeBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.employeeBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.employeeBtn.FlatAppearance.BorderSize = 0;
            this.employeeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.employeeBtn.Location = new System.Drawing.Point(0, 180);
            this.employeeBtn.Name = "employeeBtn";
            this.employeeBtn.Size = new System.Drawing.Size(183, 45);
            this.employeeBtn.TabIndex = 3;
            this.employeeBtn.Text = "Employee";
            this.employeeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.employeeBtn.UseVisualStyleBackColor = false;
            this.employeeBtn.Click += new System.EventHandler(this.doctorBtn_Click);
            // 
            // patientSubMenu
            // 
            this.patientSubMenu.Controls.Add(this.removePatientBtn);
            this.patientSubMenu.Controls.Add(this.addPatientBtn);
            this.patientSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.patientSubMenu.Location = new System.Drawing.Point(0, 90);
            this.patientSubMenu.Name = "patientSubMenu";
            this.patientSubMenu.Size = new System.Drawing.Size(183, 90);
            this.patientSubMenu.TabIndex = 2;
            this.patientSubMenu.Visible = false;
            // 
            // removePatientBtn
            // 
            this.removePatientBtn.BackColor = System.Drawing.Color.White;
            this.removePatientBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.removePatientBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.removePatientBtn.FlatAppearance.BorderSize = 0;
            this.removePatientBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removePatientBtn.Location = new System.Drawing.Point(0, 45);
            this.removePatientBtn.Name = "removePatientBtn";
            this.removePatientBtn.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.removePatientBtn.Size = new System.Drawing.Size(183, 45);
            this.removePatientBtn.TabIndex = 3;
            this.removePatientBtn.Text = "Remove Patient";
            this.removePatientBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.removePatientBtn.UseVisualStyleBackColor = false;
            // 
            // addPatientBtn
            // 
            this.addPatientBtn.BackColor = System.Drawing.Color.White;
            this.addPatientBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.addPatientBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.addPatientBtn.FlatAppearance.BorderSize = 0;
            this.addPatientBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addPatientBtn.Location = new System.Drawing.Point(0, 0);
            this.addPatientBtn.Name = "addPatientBtn";
            this.addPatientBtn.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.addPatientBtn.Size = new System.Drawing.Size(183, 45);
            this.addPatientBtn.TabIndex = 2;
            this.addPatientBtn.Text = "Add Patient";
            this.addPatientBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addPatientBtn.UseVisualStyleBackColor = false;
            this.addPatientBtn.Click += new System.EventHandler(this.addPatientBtn_Click);
            // 
            // patientBtn
            // 
            this.patientBtn.BackColor = System.Drawing.Color.White;
            this.patientBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.patientBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.patientBtn.FlatAppearance.BorderSize = 0;
            this.patientBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.patientBtn.Location = new System.Drawing.Point(0, 45);
            this.patientBtn.Name = "patientBtn";
            this.patientBtn.Size = new System.Drawing.Size(183, 45);
            this.patientBtn.TabIndex = 1;
            this.patientBtn.Text = "Patient";
            this.patientBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.patientBtn.UseVisualStyleBackColor = false;
            this.patientBtn.Click += new System.EventHandler(this.patientBtn_Click);
            // 
            // dashboardBtn
            // 
            this.dashboardBtn.BackColor = System.Drawing.Color.White;
            this.dashboardBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.dashboardBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.dashboardBtn.FlatAppearance.BorderSize = 0;
            this.dashboardBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboardBtn.Location = new System.Drawing.Point(0, 0);
            this.dashboardBtn.Name = "dashboardBtn";
            this.dashboardBtn.Size = new System.Drawing.Size(183, 45);
            this.dashboardBtn.TabIndex = 0;
            this.dashboardBtn.Text = "Dashboard";
            this.dashboardBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboardBtn.UseVisualStyleBackColor = false;
            this.dashboardBtn.Click += new System.EventHandler(this.dashboardBtn_Click);
            // 
            // displayPanel
            // 
            this.displayPanel.Controls.Add(this.loginPanel);
            this.displayPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.displayPanel.Location = new System.Drawing.Point(200, 0);
            this.displayPanel.Name = "displayPanel";
            this.displayPanel.Size = new System.Drawing.Size(1064, 681);
            this.displayPanel.TabIndex = 2;
            // 
            // loginPanel
            // 
            this.loginPanel.BackColor = System.Drawing.SystemColors.Control;
            this.loginPanel.Controls.Add(this.loginGroup);
            this.loginPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginPanel.Location = new System.Drawing.Point(0, 0);
            this.loginPanel.MinimumSize = new System.Drawing.Size(520, 286);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(1064, 681);
            this.loginPanel.TabIndex = 3;
            // 
            // loginGroup
            // 
            this.loginGroup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginGroup.BackColor = System.Drawing.Color.White;
            this.loginGroup.Controls.Add(this.emailPanel);
            this.loginGroup.Controls.Add(this.passwordPanel);
            this.loginGroup.Controls.Add(this.emailText);
            this.loginGroup.Controls.Add(this.passwordText);
            this.loginGroup.Controls.Add(this.loginBtn);
            this.loginGroup.Font = new System.Drawing.Font("Segoe UI", 36F);
            this.loginGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(132)))), ((int)(((byte)(222)))));
            this.loginGroup.Location = new System.Drawing.Point(357, 197);
            this.loginGroup.Name = "loginGroup";
            this.loginGroup.Size = new System.Drawing.Size(350, 266);
            this.loginGroup.TabIndex = 7;
            this.loginGroup.TabStop = false;
            this.loginGroup.Text = "Login";
            // 
            // emailPanel
            // 
            this.emailPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.emailPanel.BackColor = System.Drawing.Color.White;
            this.emailPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailPanel.Controls.Add(this.emailTextbox);
            this.emailPanel.Location = new System.Drawing.Point(17, 94);
            this.emailPanel.Name = "emailPanel";
            this.emailPanel.Size = new System.Drawing.Size(323, 38);
            this.emailPanel.TabIndex = 5;
            // 
            // emailTextbox
            // 
            this.emailTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextbox.Location = new System.Drawing.Point(3, 9);
            this.emailTextbox.Name = "emailTextbox";
            this.emailTextbox.Size = new System.Drawing.Size(315, 19);
            this.emailTextbox.TabIndex = 0;
            this.emailTextbox.Click += new System.EventHandler(this.emailTextbox_Click);
            // 
            // passwordPanel
            // 
            this.passwordPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordPanel.BackColor = System.Drawing.Color.White;
            this.passwordPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordPanel.Controls.Add(this.passwordTextbox);
            this.passwordPanel.Location = new System.Drawing.Point(17, 158);
            this.passwordPanel.Name = "passwordPanel";
            this.passwordPanel.Size = new System.Drawing.Size(323, 38);
            this.passwordPanel.TabIndex = 6;
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextbox.Location = new System.Drawing.Point(3, 9);
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.PasswordChar = '*';
            this.passwordTextbox.Size = new System.Drawing.Size(315, 19);
            this.passwordTextbox.TabIndex = 0;
            this.passwordTextbox.Click += new System.EventHandler(this.passwordTextbox_Click);
            // 
            // emailText
            // 
            this.emailText.AutoSize = true;
            this.emailText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailText.ForeColor = System.Drawing.Color.Black;
            this.emailText.Location = new System.Drawing.Point(13, 71);
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(111, 20);
            this.emailText.TabIndex = 1;
            this.emailText.Text = "Email Address";
            // 
            // passwordText
            // 
            this.passwordText.AutoSize = true;
            this.passwordText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordText.ForeColor = System.Drawing.Color.Black;
            this.passwordText.Location = new System.Drawing.Point(13, 135);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(78, 20);
            this.passwordText.TabIndex = 2;
            this.passwordText.Text = "Password";
            // 
            // loginBtn
            // 
            this.loginBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(132)))), ((int)(((byte)(222)))));
            this.loginBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(132)))), ((int)(((byte)(222)))));
            this.loginBtn.FlatAppearance.BorderSize = 0;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.loginBtn.ForeColor = System.Drawing.Color.White;
            this.loginBtn.Location = new System.Drawing.Point(17, 202);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(323, 45);
            this.loginBtn.TabIndex = 2;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.displayPanel);
            this.Controls.Add(this.navigationMenu);
            this.MinimumSize = new System.Drawing.Size(610, 515);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hospital Information Management System";
            this.navigationMenu.ResumeLayout(false);
            this.billSubMenu.ResumeLayout(false);
            this.appSubMenu.ResumeLayout(false);
            this.employeeSubMenu.ResumeLayout(false);
            this.patientSubMenu.ResumeLayout(false);
            this.displayPanel.ResumeLayout(false);
            this.loginPanel.ResumeLayout(false);
            this.loginGroup.ResumeLayout(false);
            this.loginGroup.PerformLayout();
            this.emailPanel.ResumeLayout(false);
            this.emailPanel.PerformLayout();
            this.passwordPanel.ResumeLayout(false);
            this.passwordPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel navigationMenu;
        private System.Windows.Forms.Button dashboardBtn;
        private System.Windows.Forms.Button patientBtn;
        private System.Windows.Forms.Panel billSubMenu;
        private System.Windows.Forms.Button removeBillBtn;
        private System.Windows.Forms.Button addBillBtn;
        private System.Windows.Forms.Button billBtn;
        private System.Windows.Forms.Button roomBtn;
        private System.Windows.Forms.Button labBtn;
        private System.Windows.Forms.Panel employeeSubMenu;
        private System.Windows.Forms.Button removeEmployeeBtn;
        private System.Windows.Forms.Button addEmployeeBtn;
        private System.Windows.Forms.Button employeeBtn;
        private System.Windows.Forms.Panel patientSubMenu;
        private System.Windows.Forms.Button removePatientBtn;
        private System.Windows.Forms.Button addPatientBtn;
        private System.Windows.Forms.Button appBtn;
        private System.Windows.Forms.Panel appSubMenu;
        private System.Windows.Forms.Button removeAppBtn;
        private System.Windows.Forms.Button addAppBtn;
        private System.Windows.Forms.Panel displayPanel;
        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Label passwordText;
        private System.Windows.Forms.Label emailText;
        private System.Windows.Forms.TextBox emailTextbox;
        private System.Windows.Forms.Panel passwordPanel;
        private System.Windows.Forms.TextBox passwordTextbox;
        private System.Windows.Forms.Panel emailPanel;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.GroupBox loginGroup;
    }
}