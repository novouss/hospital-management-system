
namespace hospital_management_system
{
    partial class window
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.navigation_bar = new System.Windows.Forms.Panel();
            this.navigation_profile = new System.Windows.Forms.Label();
            this.navigation_menu = new System.Windows.Forms.Panel();
            this.billing_panel = new System.Windows.Forms.Panel();
            this.removeBill_btn = new System.Windows.Forms.Button();
            this.addBill_btn = new System.Windows.Forms.Button();
            this.billing_btn = new System.Windows.Forms.Button();
            this.laboratory_panel = new System.Windows.Forms.Panel();
            this.removeLab_btn = new System.Windows.Forms.Button();
            this.addLab_btn = new System.Windows.Forms.Button();
            this.laboratory_btn = new System.Windows.Forms.Button();
            this.appointment_panel = new System.Windows.Forms.Panel();
            this.removeApp_btn = new System.Windows.Forms.Button();
            this.addApp_btn = new System.Windows.Forms.Button();
            this.appointment_btn = new System.Windows.Forms.Button();
            this.doctor_panel = new System.Windows.Forms.Panel();
            this.removeDoc_btn = new System.Windows.Forms.Button();
            this.addDoc_btn = new System.Windows.Forms.Button();
            this.doctor_btn = new System.Windows.Forms.Button();
            this.patient_panel = new System.Windows.Forms.Panel();
            this.removePat_btn = new System.Windows.Forms.Button();
            this.addPat_btn = new System.Windows.Forms.Button();
            this.patient_btn = new System.Windows.Forms.Button();
            this.overview_btn = new System.Windows.Forms.Button();
            this.display_child_window = new System.Windows.Forms.Panel();
            this.navigation_bar.SuspendLayout();
            this.navigation_menu.SuspendLayout();
            this.billing_panel.SuspendLayout();
            this.laboratory_panel.SuspendLayout();
            this.appointment_panel.SuspendLayout();
            this.doctor_panel.SuspendLayout();
            this.patient_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // navigation_bar
            // 
            this.navigation_bar.BackColor = System.Drawing.Color.White;
            this.navigation_bar.Controls.Add(this.navigation_profile);
            this.navigation_bar.Dock = System.Windows.Forms.DockStyle.Top;
            this.navigation_bar.Location = new System.Drawing.Point(0, 0);
            this.navigation_bar.Name = "navigation_bar";
            this.navigation_bar.Size = new System.Drawing.Size(1264, 105);
            this.navigation_bar.TabIndex = 0;
            // 
            // navigation_profile
            // 
            this.navigation_profile.AutoSize = true;
            this.navigation_profile.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.navigation_profile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(132)))), ((int)(((byte)(222)))));
            this.navigation_profile.Location = new System.Drawing.Point(12, 18);
            this.navigation_profile.Name = "navigation_profile";
            this.navigation_profile.Size = new System.Drawing.Size(464, 65);
            this.navigation_profile.TabIndex = 0;
            this.navigation_profile.Text = "Hello Administrator, ";
            // 
            // navigation_menu
            // 
            this.navigation_menu.AutoScroll = true;
            this.navigation_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(132)))), ((int)(((byte)(222)))));
            this.navigation_menu.Controls.Add(this.billing_panel);
            this.navigation_menu.Controls.Add(this.billing_btn);
            this.navigation_menu.Controls.Add(this.laboratory_panel);
            this.navigation_menu.Controls.Add(this.laboratory_btn);
            this.navigation_menu.Controls.Add(this.appointment_panel);
            this.navigation_menu.Controls.Add(this.appointment_btn);
            this.navigation_menu.Controls.Add(this.doctor_panel);
            this.navigation_menu.Controls.Add(this.doctor_btn);
            this.navigation_menu.Controls.Add(this.patient_panel);
            this.navigation_menu.Controls.Add(this.patient_btn);
            this.navigation_menu.Controls.Add(this.overview_btn);
            this.navigation_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.navigation_menu.Location = new System.Drawing.Point(0, 105);
            this.navigation_menu.Name = "navigation_menu";
            this.navigation_menu.Size = new System.Drawing.Size(200, 576);
            this.navigation_menu.TabIndex = 1;
            // 
            // billing_panel
            // 
            this.billing_panel.BackColor = System.Drawing.Color.White;
            this.billing_panel.Controls.Add(this.removeBill_btn);
            this.billing_panel.Controls.Add(this.addBill_btn);
            this.billing_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.billing_panel.Location = new System.Drawing.Point(0, 700);
            this.billing_panel.Name = "billing_panel";
            this.billing_panel.Size = new System.Drawing.Size(183, 100);
            this.billing_panel.TabIndex = 10;
            this.billing_panel.Visible = false;
            // 
            // removeBill_btn
            // 
            this.removeBill_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.removeBill_btn.FlatAppearance.BorderSize = 0;
            this.removeBill_btn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.removeBill_btn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.removeBill_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeBill_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.removeBill_btn.Location = new System.Drawing.Point(0, 50);
            this.removeBill_btn.Name = "removeBill_btn";
            this.removeBill_btn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.removeBill_btn.Size = new System.Drawing.Size(183, 50);
            this.removeBill_btn.TabIndex = 2;
            this.removeBill_btn.Text = "Remove Billing";
            this.removeBill_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.removeBill_btn.UseVisualStyleBackColor = true;
            // 
            // addBill_btn
            // 
            this.addBill_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.addBill_btn.FlatAppearance.BorderSize = 0;
            this.addBill_btn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.addBill_btn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.addBill_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBill_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addBill_btn.Location = new System.Drawing.Point(0, 0);
            this.addBill_btn.Name = "addBill_btn";
            this.addBill_btn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.addBill_btn.Size = new System.Drawing.Size(183, 50);
            this.addBill_btn.TabIndex = 1;
            this.addBill_btn.Text = "Add Billing";
            this.addBill_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addBill_btn.UseVisualStyleBackColor = true;
            // 
            // billing_btn
            // 
            this.billing_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.billing_btn.FlatAppearance.BorderSize = 0;
            this.billing_btn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.billing_btn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.billing_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.billing_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.billing_btn.ForeColor = System.Drawing.Color.White;
            this.billing_btn.Location = new System.Drawing.Point(0, 650);
            this.billing_btn.Name = "billing_btn";
            this.billing_btn.Size = new System.Drawing.Size(183, 50);
            this.billing_btn.TabIndex = 9;
            this.billing_btn.Text = "Billing";
            this.billing_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.billing_btn.UseVisualStyleBackColor = true;
            this.billing_btn.Click += new System.EventHandler(this.billing_btn_Click);
            // 
            // laboratory_panel
            // 
            this.laboratory_panel.BackColor = System.Drawing.Color.White;
            this.laboratory_panel.Controls.Add(this.removeLab_btn);
            this.laboratory_panel.Controls.Add(this.addLab_btn);
            this.laboratory_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.laboratory_panel.Location = new System.Drawing.Point(0, 550);
            this.laboratory_panel.Name = "laboratory_panel";
            this.laboratory_panel.Size = new System.Drawing.Size(183, 100);
            this.laboratory_panel.TabIndex = 8;
            this.laboratory_panel.Visible = false;
            // 
            // removeLab_btn
            // 
            this.removeLab_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.removeLab_btn.FlatAppearance.BorderSize = 0;
            this.removeLab_btn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.removeLab_btn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.removeLab_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeLab_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.removeLab_btn.Location = new System.Drawing.Point(0, 50);
            this.removeLab_btn.Name = "removeLab_btn";
            this.removeLab_btn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.removeLab_btn.Size = new System.Drawing.Size(183, 50);
            this.removeLab_btn.TabIndex = 2;
            this.removeLab_btn.Text = "Remove Laboratory";
            this.removeLab_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.removeLab_btn.UseVisualStyleBackColor = true;
            // 
            // addLab_btn
            // 
            this.addLab_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.addLab_btn.FlatAppearance.BorderSize = 0;
            this.addLab_btn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.addLab_btn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.addLab_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addLab_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addLab_btn.Location = new System.Drawing.Point(0, 0);
            this.addLab_btn.Name = "addLab_btn";
            this.addLab_btn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.addLab_btn.Size = new System.Drawing.Size(183, 50);
            this.addLab_btn.TabIndex = 1;
            this.addLab_btn.Text = "Add Laboratory";
            this.addLab_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addLab_btn.UseVisualStyleBackColor = true;
            // 
            // laboratory_btn
            // 
            this.laboratory_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.laboratory_btn.FlatAppearance.BorderSize = 0;
            this.laboratory_btn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.laboratory_btn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.laboratory_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.laboratory_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.laboratory_btn.ForeColor = System.Drawing.Color.White;
            this.laboratory_btn.Location = new System.Drawing.Point(0, 500);
            this.laboratory_btn.Name = "laboratory_btn";
            this.laboratory_btn.Size = new System.Drawing.Size(183, 50);
            this.laboratory_btn.TabIndex = 7;
            this.laboratory_btn.Text = "Laboratory";
            this.laboratory_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.laboratory_btn.UseVisualStyleBackColor = true;
            this.laboratory_btn.Click += new System.EventHandler(this.laboratory_btn_Click);
            // 
            // appointment_panel
            // 
            this.appointment_panel.BackColor = System.Drawing.Color.White;
            this.appointment_panel.Controls.Add(this.removeApp_btn);
            this.appointment_panel.Controls.Add(this.addApp_btn);
            this.appointment_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.appointment_panel.Location = new System.Drawing.Point(0, 400);
            this.appointment_panel.Name = "appointment_panel";
            this.appointment_panel.Size = new System.Drawing.Size(183, 100);
            this.appointment_panel.TabIndex = 6;
            this.appointment_panel.Visible = false;
            // 
            // removeApp_btn
            // 
            this.removeApp_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.removeApp_btn.FlatAppearance.BorderSize = 0;
            this.removeApp_btn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.removeApp_btn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.removeApp_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeApp_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.removeApp_btn.Location = new System.Drawing.Point(0, 50);
            this.removeApp_btn.Name = "removeApp_btn";
            this.removeApp_btn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.removeApp_btn.Size = new System.Drawing.Size(183, 50);
            this.removeApp_btn.TabIndex = 2;
            this.removeApp_btn.Text = "Remove Registration";
            this.removeApp_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.removeApp_btn.UseVisualStyleBackColor = true;
            // 
            // addApp_btn
            // 
            this.addApp_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.addApp_btn.FlatAppearance.BorderSize = 0;
            this.addApp_btn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.addApp_btn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.addApp_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addApp_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addApp_btn.Location = new System.Drawing.Point(0, 0);
            this.addApp_btn.Name = "addApp_btn";
            this.addApp_btn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.addApp_btn.Size = new System.Drawing.Size(183, 50);
            this.addApp_btn.TabIndex = 1;
            this.addApp_btn.Text = "Add Registration";
            this.addApp_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addApp_btn.UseVisualStyleBackColor = true;
            // 
            // appointment_btn
            // 
            this.appointment_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.appointment_btn.FlatAppearance.BorderSize = 0;
            this.appointment_btn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.appointment_btn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.appointment_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.appointment_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.appointment_btn.ForeColor = System.Drawing.Color.White;
            this.appointment_btn.Location = new System.Drawing.Point(0, 350);
            this.appointment_btn.Name = "appointment_btn";
            this.appointment_btn.Size = new System.Drawing.Size(183, 50);
            this.appointment_btn.TabIndex = 5;
            this.appointment_btn.Text = "Registration";
            this.appointment_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.appointment_btn.UseVisualStyleBackColor = true;
            this.appointment_btn.Click += new System.EventHandler(this.appointment_btn_Click);
            // 
            // doctor_panel
            // 
            this.doctor_panel.BackColor = System.Drawing.Color.White;
            this.doctor_panel.Controls.Add(this.removeDoc_btn);
            this.doctor_panel.Controls.Add(this.addDoc_btn);
            this.doctor_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.doctor_panel.Location = new System.Drawing.Point(0, 250);
            this.doctor_panel.Name = "doctor_panel";
            this.doctor_panel.Size = new System.Drawing.Size(183, 100);
            this.doctor_panel.TabIndex = 4;
            this.doctor_panel.Visible = false;
            // 
            // removeDoc_btn
            // 
            this.removeDoc_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.removeDoc_btn.FlatAppearance.BorderSize = 0;
            this.removeDoc_btn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.removeDoc_btn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.removeDoc_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeDoc_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.removeDoc_btn.Location = new System.Drawing.Point(0, 50);
            this.removeDoc_btn.Name = "removeDoc_btn";
            this.removeDoc_btn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.removeDoc_btn.Size = new System.Drawing.Size(183, 50);
            this.removeDoc_btn.TabIndex = 2;
            this.removeDoc_btn.Text = "Remove Doctor";
            this.removeDoc_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.removeDoc_btn.UseVisualStyleBackColor = true;
            // 
            // addDoc_btn
            // 
            this.addDoc_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.addDoc_btn.FlatAppearance.BorderSize = 0;
            this.addDoc_btn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.addDoc_btn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.addDoc_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addDoc_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addDoc_btn.Location = new System.Drawing.Point(0, 0);
            this.addDoc_btn.Name = "addDoc_btn";
            this.addDoc_btn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.addDoc_btn.Size = new System.Drawing.Size(183, 50);
            this.addDoc_btn.TabIndex = 1;
            this.addDoc_btn.Text = "Add Doctor";
            this.addDoc_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addDoc_btn.UseVisualStyleBackColor = true;
            // 
            // doctor_btn
            // 
            this.doctor_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.doctor_btn.FlatAppearance.BorderSize = 0;
            this.doctor_btn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.doctor_btn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.doctor_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.doctor_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.doctor_btn.ForeColor = System.Drawing.Color.White;
            this.doctor_btn.Location = new System.Drawing.Point(0, 200);
            this.doctor_btn.Name = "doctor_btn";
            this.doctor_btn.Size = new System.Drawing.Size(183, 50);
            this.doctor_btn.TabIndex = 2;
            this.doctor_btn.Text = "Doctors";
            this.doctor_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.doctor_btn.UseVisualStyleBackColor = true;
            this.doctor_btn.Click += new System.EventHandler(this.doctor_btn_Click);
            // 
            // patient_panel
            // 
            this.patient_panel.BackColor = System.Drawing.Color.White;
            this.patient_panel.Controls.Add(this.removePat_btn);
            this.patient_panel.Controls.Add(this.addPat_btn);
            this.patient_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.patient_panel.Location = new System.Drawing.Point(0, 100);
            this.patient_panel.Name = "patient_panel";
            this.patient_panel.Size = new System.Drawing.Size(183, 100);
            this.patient_panel.TabIndex = 1;
            this.patient_panel.Visible = false;
            // 
            // removePat_btn
            // 
            this.removePat_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.removePat_btn.FlatAppearance.BorderSize = 0;
            this.removePat_btn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.removePat_btn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.removePat_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removePat_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.removePat_btn.Location = new System.Drawing.Point(0, 50);
            this.removePat_btn.Name = "removePat_btn";
            this.removePat_btn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.removePat_btn.Size = new System.Drawing.Size(183, 50);
            this.removePat_btn.TabIndex = 2;
            this.removePat_btn.Text = "Remove Patient";
            this.removePat_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.removePat_btn.UseVisualStyleBackColor = true;
            // 
            // addPat_btn
            // 
            this.addPat_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.addPat_btn.FlatAppearance.BorderSize = 0;
            this.addPat_btn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.addPat_btn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.addPat_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addPat_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addPat_btn.Location = new System.Drawing.Point(0, 0);
            this.addPat_btn.Name = "addPat_btn";
            this.addPat_btn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.addPat_btn.Size = new System.Drawing.Size(183, 50);
            this.addPat_btn.TabIndex = 1;
            this.addPat_btn.Text = "Add Patient";
            this.addPat_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addPat_btn.UseVisualStyleBackColor = true;
            this.addPat_btn.Click += new System.EventHandler(this.addPatient_btn_Click);
            // 
            // patient_btn
            // 
            this.patient_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.patient_btn.FlatAppearance.BorderSize = 0;
            this.patient_btn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.patient_btn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.patient_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.patient_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.patient_btn.ForeColor = System.Drawing.Color.White;
            this.patient_btn.Location = new System.Drawing.Point(0, 50);
            this.patient_btn.Name = "patient_btn";
            this.patient_btn.Size = new System.Drawing.Size(183, 50);
            this.patient_btn.TabIndex = 3;
            this.patient_btn.Text = "Patient";
            this.patient_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.patient_btn.UseVisualStyleBackColor = true;
            this.patient_btn.Click += new System.EventHandler(this.patient_btn_Click);
            // 
            // overview_btn
            // 
            this.overview_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.overview_btn.FlatAppearance.BorderSize = 0;
            this.overview_btn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.overview_btn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.overview_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.overview_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.overview_btn.ForeColor = System.Drawing.Color.White;
            this.overview_btn.Location = new System.Drawing.Point(0, 0);
            this.overview_btn.Name = "overview_btn";
            this.overview_btn.Size = new System.Drawing.Size(183, 50);
            this.overview_btn.TabIndex = 0;
            this.overview_btn.Text = "Overview";
            this.overview_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.overview_btn.UseVisualStyleBackColor = true;
            this.overview_btn.Click += new System.EventHandler(this.overview_btn_Click);
            // 
            // display_child_window
            // 
            this.display_child_window.AutoScroll = true;
            this.display_child_window.Dock = System.Windows.Forms.DockStyle.Fill;
            this.display_child_window.Location = new System.Drawing.Point(200, 105);
            this.display_child_window.Name = "display_child_window";
            this.display_child_window.Size = new System.Drawing.Size(1064, 576);
            this.display_child_window.TabIndex = 2;
            // 
            // window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.display_child_window);
            this.Controls.Add(this.navigation_menu);
            this.Controls.Add(this.navigation_bar);
            this.MinimumSize = new System.Drawing.Size(510, 650);
            this.Name = "window";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hospital Information System";
            this.navigation_bar.ResumeLayout(false);
            this.navigation_bar.PerformLayout();
            this.navigation_menu.ResumeLayout(false);
            this.billing_panel.ResumeLayout(false);
            this.laboratory_panel.ResumeLayout(false);
            this.appointment_panel.ResumeLayout(false);
            this.doctor_panel.ResumeLayout(false);
            this.patient_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel navigation_bar;
        private System.Windows.Forms.Label navigation_profile;
        private System.Windows.Forms.Panel navigation_menu;
        private System.Windows.Forms.Panel doctor_panel;
        private System.Windows.Forms.Button removeDoc_btn;
        private System.Windows.Forms.Button addDoc_btn;
        private System.Windows.Forms.Button doctor_btn;
        private System.Windows.Forms.Panel patient_panel;
        private System.Windows.Forms.Button removePat_btn;
        private System.Windows.Forms.Button addPat_btn;
        private System.Windows.Forms.Button patient_btn;
        private System.Windows.Forms.Button overview_btn;
        private System.Windows.Forms.Panel laboratory_panel;
        private System.Windows.Forms.Button removeLab_btn;
        private System.Windows.Forms.Button addLab_btn;
        private System.Windows.Forms.Button laboratory_btn;
        private System.Windows.Forms.Panel appointment_panel;
        private System.Windows.Forms.Button removeApp_btn;
        private System.Windows.Forms.Button addApp_btn;
        private System.Windows.Forms.Button appointment_btn;
        private System.Windows.Forms.Panel billing_panel;
        private System.Windows.Forms.Button removeBill_btn;
        private System.Windows.Forms.Button addBill_btn;
        private System.Windows.Forms.Button billing_btn;
        private System.Windows.Forms.Panel display_child_window;
    }
}

