
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.navigationBar = new System.Windows.Forms.Panel();
            this.minimizeIcon = new System.Windows.Forms.PictureBox();
            this.maximizeIcon = new System.Windows.Forms.PictureBox();
            this.closeIcon = new System.Windows.Forms.PictureBox();
            this.hamburgerIcon = new System.Windows.Forms.PictureBox();
            this.navigationText = new System.Windows.Forms.Label();
            this.navigationMenu = new System.Windows.Forms.Panel();
            this.billSubMenu = new System.Windows.Forms.Panel();
            this.removeBillBtn = new System.Windows.Forms.Button();
            this.addBillBtn = new System.Windows.Forms.Button();
            this.billBtn = new System.Windows.Forms.Button();
            this.roomBtn = new System.Windows.Forms.Button();
            this.labBtn = new System.Windows.Forms.Button();
            this.regSubMenu = new System.Windows.Forms.Panel();
            this.removeRegBtn = new System.Windows.Forms.Button();
            this.addRegBtn = new System.Windows.Forms.Button();
            this.regBtn = new System.Windows.Forms.Button();
            this.doctorSubMenu = new System.Windows.Forms.Panel();
            this.removeDoctorBtn = new System.Windows.Forms.Button();
            this.addDoctorBtn = new System.Windows.Forms.Button();
            this.doctorBtn = new System.Windows.Forms.Button();
            this.patientSubMenu = new System.Windows.Forms.Panel();
            this.removePatientBtn = new System.Windows.Forms.Button();
            this.addPatientBtn = new System.Windows.Forms.Button();
            this.patientBtn = new System.Windows.Forms.Button();
            this.dashboardBtn = new System.Windows.Forms.Button();
            this.displayPanel = new System.Windows.Forms.Panel();
            this.loginPanel = new System.Windows.Forms.Panel();
            this.passwordPanel = new System.Windows.Forms.Panel();
            this.passwordTextbox = new System.Windows.Forms.TextBox();
            this.emailPanel = new System.Windows.Forms.Panel();
            this.emailTextbox = new System.Windows.Forms.TextBox();
            this.titleText = new System.Windows.Forms.Label();
            this.loginBtn = new System.Windows.Forms.Button();
            this.passwordText = new System.Windows.Forms.Label();
            this.emailText = new System.Windows.Forms.Label();
            this.navigationBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximizeIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hamburgerIcon)).BeginInit();
            this.navigationMenu.SuspendLayout();
            this.billSubMenu.SuspendLayout();
            this.regSubMenu.SuspendLayout();
            this.doctorSubMenu.SuspendLayout();
            this.patientSubMenu.SuspendLayout();
            this.displayPanel.SuspendLayout();
            this.loginPanel.SuspendLayout();
            this.passwordPanel.SuspendLayout();
            this.emailPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // navigationBar
            // 
            this.navigationBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.navigationBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(132)))), ((int)(((byte)(222)))));
            this.navigationBar.Controls.Add(this.minimizeIcon);
            this.navigationBar.Controls.Add(this.maximizeIcon);
            this.navigationBar.Controls.Add(this.closeIcon);
            this.navigationBar.Controls.Add(this.hamburgerIcon);
            this.navigationBar.Controls.Add(this.navigationText);
            this.navigationBar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navigationBar.ForeColor = System.Drawing.Color.White;
            this.navigationBar.Location = new System.Drawing.Point(12, 12);
            this.navigationBar.Name = "navigationBar";
            this.navigationBar.Size = new System.Drawing.Size(1256, 45);
            this.navigationBar.TabIndex = 0;
            // 
            // minimizeIcon
            // 
            this.minimizeIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeIcon.Image = ((System.Drawing.Image)(resources.GetObject("minimizeIcon.Image")));
            this.minimizeIcon.Location = new System.Drawing.Point(1109, 0);
            this.minimizeIcon.Name = "minimizeIcon";
            this.minimizeIcon.Size = new System.Drawing.Size(45, 45);
            this.minimizeIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimizeIcon.TabIndex = 4;
            this.minimizeIcon.TabStop = false;
            this.minimizeIcon.Click += new System.EventHandler(this.minimizeIcon_Click);
            // 
            // maximizeIcon
            // 
            this.maximizeIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximizeIcon.Image = ((System.Drawing.Image)(resources.GetObject("maximizeIcon.Image")));
            this.maximizeIcon.Location = new System.Drawing.Point(1160, 0);
            this.maximizeIcon.Name = "maximizeIcon";
            this.maximizeIcon.Size = new System.Drawing.Size(45, 45);
            this.maximizeIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.maximizeIcon.TabIndex = 3;
            this.maximizeIcon.TabStop = false;
            this.maximizeIcon.Click += new System.EventHandler(this.maximizeIcon_Click);
            // 
            // closeIcon
            // 
            this.closeIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeIcon.Image = ((System.Drawing.Image)(resources.GetObject("closeIcon.Image")));
            this.closeIcon.Location = new System.Drawing.Point(1211, 0);
            this.closeIcon.Name = "closeIcon";
            this.closeIcon.Size = new System.Drawing.Size(45, 45);
            this.closeIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeIcon.TabIndex = 2;
            this.closeIcon.TabStop = false;
            this.closeIcon.Click += new System.EventHandler(this.closeIcon_Click);
            // 
            // hamburgerIcon
            // 
            this.hamburgerIcon.Image = ((System.Drawing.Image)(resources.GetObject("hamburgerIcon.Image")));
            this.hamburgerIcon.Location = new System.Drawing.Point(0, 0);
            this.hamburgerIcon.Name = "hamburgerIcon";
            this.hamburgerIcon.Size = new System.Drawing.Size(45, 45);
            this.hamburgerIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hamburgerIcon.TabIndex = 1;
            this.hamburgerIcon.TabStop = false;
            // 
            // navigationText
            // 
            this.navigationText.AutoSize = true;
            this.navigationText.Location = new System.Drawing.Point(51, 12);
            this.navigationText.Name = "navigationText";
            this.navigationText.Size = new System.Drawing.Size(335, 21);
            this.navigationText.TabIndex = 0;
            this.navigationText.Text = "Hosptial Management Information System";
            // 
            // navigationMenu
            // 
            this.navigationMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.navigationMenu.AutoScroll = true;
            this.navigationMenu.BackColor = System.Drawing.Color.White;
            this.navigationMenu.Controls.Add(this.billSubMenu);
            this.navigationMenu.Controls.Add(this.billBtn);
            this.navigationMenu.Controls.Add(this.roomBtn);
            this.navigationMenu.Controls.Add(this.labBtn);
            this.navigationMenu.Controls.Add(this.regSubMenu);
            this.navigationMenu.Controls.Add(this.regBtn);
            this.navigationMenu.Controls.Add(this.doctorSubMenu);
            this.navigationMenu.Controls.Add(this.doctorBtn);
            this.navigationMenu.Controls.Add(this.patientSubMenu);
            this.navigationMenu.Controls.Add(this.patientBtn);
            this.navigationMenu.Controls.Add(this.dashboardBtn);
            this.navigationMenu.Location = new System.Drawing.Point(13, 63);
            this.navigationMenu.Name = "navigationMenu";
            this.navigationMenu.Size = new System.Drawing.Size(200, 645);
            this.navigationMenu.TabIndex = 1;
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
            this.removeBillBtn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.removeBillBtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
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
            this.addBillBtn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.addBillBtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.addBillBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBillBtn.Location = new System.Drawing.Point(0, 0);
            this.addBillBtn.Name = "addBillBtn";
            this.addBillBtn.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.addBillBtn.Size = new System.Drawing.Size(183, 45);
            this.addBillBtn.TabIndex = 2;
            this.addBillBtn.Text = "Add Billing";
            this.addBillBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addBillBtn.UseVisualStyleBackColor = false;
            // 
            // billBtn
            // 
            this.billBtn.BackColor = System.Drawing.Color.White;
            this.billBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.billBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.billBtn.FlatAppearance.BorderSize = 0;
            this.billBtn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.billBtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
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
            this.roomBtn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.roomBtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
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
            this.labBtn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.labBtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
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
            // regSubMenu
            // 
            this.regSubMenu.Controls.Add(this.removeRegBtn);
            this.regSubMenu.Controls.Add(this.addRegBtn);
            this.regSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.regSubMenu.Location = new System.Drawing.Point(0, 360);
            this.regSubMenu.Name = "regSubMenu";
            this.regSubMenu.Size = new System.Drawing.Size(183, 90);
            this.regSubMenu.TabIndex = 10;
            this.regSubMenu.Visible = false;
            // 
            // removeRegBtn
            // 
            this.removeRegBtn.BackColor = System.Drawing.Color.White;
            this.removeRegBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.removeRegBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.removeRegBtn.FlatAppearance.BorderSize = 0;
            this.removeRegBtn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.removeRegBtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.removeRegBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeRegBtn.Location = new System.Drawing.Point(0, 45);
            this.removeRegBtn.Name = "removeRegBtn";
            this.removeRegBtn.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.removeRegBtn.Size = new System.Drawing.Size(183, 45);
            this.removeRegBtn.TabIndex = 3;
            this.removeRegBtn.Text = "Remove Registration";
            this.removeRegBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.removeRegBtn.UseVisualStyleBackColor = false;
            // 
            // addRegBtn
            // 
            this.addRegBtn.BackColor = System.Drawing.Color.White;
            this.addRegBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.addRegBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.addRegBtn.FlatAppearance.BorderSize = 0;
            this.addRegBtn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.addRegBtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.addRegBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addRegBtn.Location = new System.Drawing.Point(0, 0);
            this.addRegBtn.Name = "addRegBtn";
            this.addRegBtn.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.addRegBtn.Size = new System.Drawing.Size(183, 45);
            this.addRegBtn.TabIndex = 2;
            this.addRegBtn.Text = "Add Registration";
            this.addRegBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addRegBtn.UseVisualStyleBackColor = false;
            // 
            // regBtn
            // 
            this.regBtn.BackColor = System.Drawing.Color.White;
            this.regBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.regBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.regBtn.FlatAppearance.BorderSize = 0;
            this.regBtn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.regBtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.regBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.regBtn.Location = new System.Drawing.Point(0, 315);
            this.regBtn.Name = "regBtn";
            this.regBtn.Size = new System.Drawing.Size(183, 45);
            this.regBtn.TabIndex = 9;
            this.regBtn.Text = "Registration";
            this.regBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.regBtn.UseVisualStyleBackColor = false;
            this.regBtn.Click += new System.EventHandler(this.regBtn_Click);
            // 
            // doctorSubMenu
            // 
            this.doctorSubMenu.Controls.Add(this.removeDoctorBtn);
            this.doctorSubMenu.Controls.Add(this.addDoctorBtn);
            this.doctorSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.doctorSubMenu.Location = new System.Drawing.Point(0, 225);
            this.doctorSubMenu.Name = "doctorSubMenu";
            this.doctorSubMenu.Size = new System.Drawing.Size(183, 90);
            this.doctorSubMenu.TabIndex = 4;
            this.doctorSubMenu.Visible = false;
            // 
            // removeDoctorBtn
            // 
            this.removeDoctorBtn.BackColor = System.Drawing.Color.White;
            this.removeDoctorBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.removeDoctorBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.removeDoctorBtn.FlatAppearance.BorderSize = 0;
            this.removeDoctorBtn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.removeDoctorBtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.removeDoctorBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeDoctorBtn.Location = new System.Drawing.Point(0, 45);
            this.removeDoctorBtn.Name = "removeDoctorBtn";
            this.removeDoctorBtn.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.removeDoctorBtn.Size = new System.Drawing.Size(183, 45);
            this.removeDoctorBtn.TabIndex = 3;
            this.removeDoctorBtn.Text = "Remove Doctor";
            this.removeDoctorBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.removeDoctorBtn.UseVisualStyleBackColor = false;
            // 
            // addDoctorBtn
            // 
            this.addDoctorBtn.BackColor = System.Drawing.Color.White;
            this.addDoctorBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.addDoctorBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.addDoctorBtn.FlatAppearance.BorderSize = 0;
            this.addDoctorBtn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.addDoctorBtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.addDoctorBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addDoctorBtn.Location = new System.Drawing.Point(0, 0);
            this.addDoctorBtn.Name = "addDoctorBtn";
            this.addDoctorBtn.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.addDoctorBtn.Size = new System.Drawing.Size(183, 45);
            this.addDoctorBtn.TabIndex = 2;
            this.addDoctorBtn.Text = "Add Doctor";
            this.addDoctorBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addDoctorBtn.UseVisualStyleBackColor = false;
            // 
            // doctorBtn
            // 
            this.doctorBtn.BackColor = System.Drawing.Color.White;
            this.doctorBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.doctorBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.doctorBtn.FlatAppearance.BorderSize = 0;
            this.doctorBtn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.doctorBtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.doctorBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.doctorBtn.Location = new System.Drawing.Point(0, 180);
            this.doctorBtn.Name = "doctorBtn";
            this.doctorBtn.Size = new System.Drawing.Size(183, 45);
            this.doctorBtn.TabIndex = 3;
            this.doctorBtn.Text = "Doctor";
            this.doctorBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.doctorBtn.UseVisualStyleBackColor = false;
            this.doctorBtn.Click += new System.EventHandler(this.doctorBtn_Click);
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
            this.removePatientBtn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.removePatientBtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
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
            this.addPatientBtn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.addPatientBtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.addPatientBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addPatientBtn.Location = new System.Drawing.Point(0, 0);
            this.addPatientBtn.Name = "addPatientBtn";
            this.addPatientBtn.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.addPatientBtn.Size = new System.Drawing.Size(183, 45);
            this.addPatientBtn.TabIndex = 2;
            this.addPatientBtn.Text = "Add Patient";
            this.addPatientBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addPatientBtn.UseVisualStyleBackColor = false;
            // 
            // patientBtn
            // 
            this.patientBtn.BackColor = System.Drawing.Color.White;
            this.patientBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.patientBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.patientBtn.FlatAppearance.BorderSize = 0;
            this.patientBtn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.patientBtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
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
            this.dashboardBtn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.dashboardBtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
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
            this.displayPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.displayPanel.Controls.Add(this.loginPanel);
            this.displayPanel.Location = new System.Drawing.Point(220, 63);
            this.displayPanel.Name = "displayPanel";
            this.displayPanel.Size = new System.Drawing.Size(1048, 645);
            this.displayPanel.TabIndex = 2;
            // 
            // loginPanel
            // 
            this.loginPanel.Controls.Add(this.passwordPanel);
            this.loginPanel.Controls.Add(this.emailPanel);
            this.loginPanel.Controls.Add(this.titleText);
            this.loginPanel.Controls.Add(this.loginBtn);
            this.loginPanel.Controls.Add(this.passwordText);
            this.loginPanel.Controls.Add(this.emailText);
            this.loginPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginPanel.Location = new System.Drawing.Point(0, 0);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(1048, 645);
            this.loginPanel.TabIndex = 3;
            // 
            // passwordPanel
            // 
            this.passwordPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordPanel.BackColor = System.Drawing.Color.White;
            this.passwordPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordPanel.Controls.Add(this.passwordTextbox);
            this.passwordPanel.Location = new System.Drawing.Point(292, 334);
            this.passwordPanel.Name = "passwordPanel";
            this.passwordPanel.Size = new System.Drawing.Size(465, 38);
            this.passwordPanel.TabIndex = 6;
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTextbox.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.passwordTextbox.Location = new System.Drawing.Point(0, 9);
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.PasswordChar = '*';
            this.passwordTextbox.Size = new System.Drawing.Size(463, 15);
            this.passwordTextbox.TabIndex = 0;
            // 
            // emailPanel
            // 
            this.emailPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.emailPanel.BackColor = System.Drawing.Color.White;
            this.emailPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailPanel.Controls.Add(this.emailTextbox);
            this.emailPanel.Location = new System.Drawing.Point(292, 277);
            this.emailPanel.Name = "emailPanel";
            this.emailPanel.Size = new System.Drawing.Size(465, 38);
            this.emailPanel.TabIndex = 5;
            // 
            // emailTextbox
            // 
            this.emailTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.emailTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailTextbox.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.emailTextbox.Location = new System.Drawing.Point(0, 9);
            this.emailTextbox.Name = "emailTextbox";
            this.emailTextbox.Size = new System.Drawing.Size(463, 15);
            this.emailTextbox.TabIndex = 0;
            // 
            // titleText
            // 
            this.titleText.AutoSize = true;
            this.titleText.Font = new System.Drawing.Font("Segoe UI", 36F);
            this.titleText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(132)))), ((int)(((byte)(222)))));
            this.titleText.Location = new System.Drawing.Point(281, 192);
            this.titleText.Name = "titleText";
            this.titleText.Size = new System.Drawing.Size(146, 65);
            this.titleText.TabIndex = 4;
            this.titleText.Text = "Login";
            // 
            // loginBtn
            // 
            this.loginBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(132)))), ((int)(((byte)(222)))));
            this.loginBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(132)))), ((int)(((byte)(222)))));
            this.loginBtn.FlatAppearance.BorderSize = 0;
            this.loginBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(132)))), ((int)(((byte)(222)))));
            this.loginBtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.ForeColor = System.Drawing.Color.White;
            this.loginBtn.Location = new System.Drawing.Point(292, 378);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(465, 45);
            this.loginBtn.TabIndex = 2;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // passwordText
            // 
            this.passwordText.AutoSize = true;
            this.passwordText.Location = new System.Drawing.Point(288, 318);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(53, 13);
            this.passwordText.TabIndex = 2;
            this.passwordText.Text = "Password";
            // 
            // emailText
            // 
            this.emailText.AutoSize = true;
            this.emailText.Location = new System.Drawing.Point(288, 257);
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(73, 13);
            this.emailText.TabIndex = 1;
            this.emailText.Text = "Email Address";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.displayPanel);
            this.Controls.Add(this.navigationMenu);
            this.Controls.Add(this.navigationBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mainWindow";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.draggable_window);
            this.navigationBar.ResumeLayout(false);
            this.navigationBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximizeIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hamburgerIcon)).EndInit();
            this.navigationMenu.ResumeLayout(false);
            this.billSubMenu.ResumeLayout(false);
            this.regSubMenu.ResumeLayout(false);
            this.doctorSubMenu.ResumeLayout(false);
            this.patientSubMenu.ResumeLayout(false);
            this.displayPanel.ResumeLayout(false);
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            this.passwordPanel.ResumeLayout(false);
            this.passwordPanel.PerformLayout();
            this.emailPanel.ResumeLayout(false);
            this.emailPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel navigationBar;
        private System.Windows.Forms.Label navigationText;
        private System.Windows.Forms.Panel navigationMenu;
        private System.Windows.Forms.Button dashboardBtn;
        private System.Windows.Forms.Button patientBtn;
        private System.Windows.Forms.Panel billSubMenu;
        private System.Windows.Forms.Button removeBillBtn;
        private System.Windows.Forms.Button addBillBtn;
        private System.Windows.Forms.Button billBtn;
        private System.Windows.Forms.Button roomBtn;
        private System.Windows.Forms.Button labBtn;
        private System.Windows.Forms.Panel doctorSubMenu;
        private System.Windows.Forms.Button removeDoctorBtn;
        private System.Windows.Forms.Button addDoctorBtn;
        private System.Windows.Forms.Button doctorBtn;
        private System.Windows.Forms.Panel patientSubMenu;
        private System.Windows.Forms.Button removePatientBtn;
        private System.Windows.Forms.Button addPatientBtn;
        private System.Windows.Forms.Button regBtn;
        private System.Windows.Forms.Panel regSubMenu;
        private System.Windows.Forms.Button removeRegBtn;
        private System.Windows.Forms.Button addRegBtn;
        private System.Windows.Forms.Panel displayPanel;
        private System.Windows.Forms.PictureBox closeIcon;
        private System.Windows.Forms.PictureBox hamburgerIcon;
        private System.Windows.Forms.PictureBox minimizeIcon;
        private System.Windows.Forms.PictureBox maximizeIcon;
        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.Label titleText;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Label passwordText;
        private System.Windows.Forms.Label emailText;
        private System.Windows.Forms.TextBox emailTextbox;
        private System.Windows.Forms.Panel passwordPanel;
        private System.Windows.Forms.TextBox passwordTextbox;
        private System.Windows.Forms.Panel emailPanel;
    }
}