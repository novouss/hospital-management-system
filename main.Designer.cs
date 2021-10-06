
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
            this.displayLayout = new System.Windows.Forms.TableLayoutPanel();
            this.navigationPanel = new System.Windows.Forms.Panel();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.billingBtn = new System.Windows.Forms.Button();
            this.removeDoctorBtn = new System.Windows.Forms.Button();
            this.addDoctorsBtn = new System.Windows.Forms.Button();
            this.doctorBtn = new System.Windows.Forms.Button();
            this.removePatientBtn = new System.Windows.Forms.Button();
            this.addPatientBtn = new System.Windows.Forms.Button();
            this.patientBtn = new System.Windows.Forms.Button();
            this.addPatientPanel = new System.Windows.Forms.Panel();
            this.addPatientLabel = new System.Windows.Forms.Label();
            this.firstnameLabel = new System.Windows.Forms.Label();
            this.middlenameLabel = new System.Windows.Forms.Label();
            this.lastnameLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.firstnameTextbox = new System.Windows.Forms.TextBox();
            this.middlenameTextbox = new System.Windows.Forms.TextBox();
            this.lastnameTextbox = new System.Windows.Forms.TextBox();
            this.addressTextbox = new System.Windows.Forms.TextBox();
            this.navigationBar = new System.Windows.Forms.Panel();
            this.profileLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.displayLayout.SuspendLayout();
            this.navigationPanel.SuspendLayout();
            this.addPatientPanel.SuspendLayout();
            this.navigationBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // displayLayout
            // 
            this.displayLayout.ColumnCount = 2;
            this.displayLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 177F));
            this.displayLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.displayLayout.Controls.Add(this.navigationPanel, 0, 0);
            this.displayLayout.Controls.Add(this.addPatientPanel, 1, 0);
            this.displayLayout.Location = new System.Drawing.Point(0, 100);
            this.displayLayout.Name = "displayLayout";
            this.displayLayout.RowCount = 1;
            this.displayLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.displayLayout.Size = new System.Drawing.Size(1265, 580);
            this.displayLayout.TabIndex = 0;
            // 
            // navigationPanel
            // 
            this.navigationPanel.BackColor = System.Drawing.Color.White;
            this.navigationPanel.Controls.Add(this.logoutBtn);
            this.navigationPanel.Controls.Add(this.billingBtn);
            this.navigationPanel.Controls.Add(this.removeDoctorBtn);
            this.navigationPanel.Controls.Add(this.addDoctorsBtn);
            this.navigationPanel.Controls.Add(this.doctorBtn);
            this.navigationPanel.Controls.Add(this.removePatientBtn);
            this.navigationPanel.Controls.Add(this.addPatientBtn);
            this.navigationPanel.Controls.Add(this.patientBtn);
            this.navigationPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationPanel.Location = new System.Drawing.Point(3, 3);
            this.navigationPanel.Name = "navigationPanel";
            this.navigationPanel.Size = new System.Drawing.Size(171, 574);
            this.navigationPanel.TabIndex = 0;
            // 
            // logoutBtn
            // 
            this.logoutBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.logoutBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.logoutBtn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.logoutBtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutBtn.Location = new System.Drawing.Point(0, 524);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.logoutBtn.Size = new System.Drawing.Size(171, 50);
            this.logoutBtn.TabIndex = 7;
            this.logoutBtn.Text = "Log-Out";
            this.logoutBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutBtn.UseVisualStyleBackColor = false;
            // 
            // billingBtn
            // 
            this.billingBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.billingBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.billingBtn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.billingBtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.billingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
            this.removeDoctorBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.removeDoctorBtn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.removeDoctorBtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.removeDoctorBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
            this.addDoctorsBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.addDoctorsBtn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.addDoctorsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.addDoctorsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
            this.doctorBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.doctorBtn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.doctorBtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.doctorBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.doctorBtn.Location = new System.Drawing.Point(0, 150);
            this.doctorBtn.Name = "doctorBtn";
            this.doctorBtn.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.doctorBtn.Size = new System.Drawing.Size(171, 50);
            this.doctorBtn.TabIndex = 3;
            this.doctorBtn.Text = "Doctors";
            this.doctorBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.doctorBtn.UseVisualStyleBackColor = false;
            this.doctorBtn.Click += new System.EventHandler(this.doctorBtn_Click);
            // 
            // removePatientBtn
            // 
            this.removePatientBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.removePatientBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.removePatientBtn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.removePatientBtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.removePatientBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
            this.addPatientBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.addPatientBtn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.addPatientBtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.addPatientBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addPatientBtn.Location = new System.Drawing.Point(0, 50);
            this.addPatientBtn.Name = "addPatientBtn";
            this.addPatientBtn.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.addPatientBtn.Size = new System.Drawing.Size(171, 50);
            this.addPatientBtn.TabIndex = 1;
            this.addPatientBtn.Text = "Add Patient";
            this.addPatientBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addPatientBtn.UseVisualStyleBackColor = false;
            this.addPatientBtn.Visible = false;
            this.addPatientBtn.Click += new System.EventHandler(this.addPatientBtn_Click);
            // 
            // patientBtn
            // 
            this.patientBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.patientBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.patientBtn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.patientBtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.patientBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.patientBtn.Location = new System.Drawing.Point(0, 0);
            this.patientBtn.Name = "patientBtn";
            this.patientBtn.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.patientBtn.Size = new System.Drawing.Size(171, 50);
            this.patientBtn.TabIndex = 0;
            this.patientBtn.Text = "Patients";
            this.patientBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.patientBtn.UseVisualStyleBackColor = false;
            this.patientBtn.Click += new System.EventHandler(this.patientBtn_Click);
            // 
            // addPatientPanel
            // 
            this.addPatientPanel.Controls.Add(this.label1);
            this.addPatientPanel.Controls.Add(this.addPatientLabel);
            this.addPatientPanel.Controls.Add(this.firstnameLabel);
            this.addPatientPanel.Controls.Add(this.middlenameLabel);
            this.addPatientPanel.Controls.Add(this.lastnameLabel);
            this.addPatientPanel.Controls.Add(this.addressLabel);
            this.addPatientPanel.Controls.Add(this.firstnameTextbox);
            this.addPatientPanel.Controls.Add(this.middlenameTextbox);
            this.addPatientPanel.Controls.Add(this.lastnameTextbox);
            this.addPatientPanel.Controls.Add(this.addressTextbox);
            this.addPatientPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addPatientPanel.Location = new System.Drawing.Point(180, 3);
            this.addPatientPanel.Name = "addPatientPanel";
            this.addPatientPanel.Size = new System.Drawing.Size(1082, 574);
            this.addPatientPanel.TabIndex = 1;
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
            // firstnameLabel
            // 
            this.firstnameLabel.AutoSize = true;
            this.firstnameLabel.Location = new System.Drawing.Point(40, 119);
            this.firstnameLabel.Name = "firstnameLabel";
            this.firstnameLabel.Size = new System.Drawing.Size(57, 13);
            this.firstnameLabel.TabIndex = 6;
            this.firstnameLabel.Text = "Firstname";
            // 
            // middlenameLabel
            // 
            this.middlenameLabel.AutoSize = true;
            this.middlenameLabel.Location = new System.Drawing.Point(705, 119);
            this.middlenameLabel.Name = "middlenameLabel";
            this.middlenameLabel.Size = new System.Drawing.Size(71, 13);
            this.middlenameLabel.TabIndex = 8;
            this.middlenameLabel.Text = "Middlename";
            // 
            // lastnameLabel
            // 
            this.lastnameLabel.AutoSize = true;
            this.lastnameLabel.Location = new System.Drawing.Point(371, 119);
            this.lastnameLabel.Name = "lastnameLabel";
            this.lastnameLabel.Size = new System.Drawing.Size(55, 13);
            this.lastnameLabel.TabIndex = 7;
            this.lastnameLabel.Text = "Lastname";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(40, 181);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(48, 13);
            this.addressLabel.TabIndex = 10;
            this.addressLabel.Text = "Address";
            // 
            // firstnameTextbox
            // 
            this.firstnameTextbox.Location = new System.Drawing.Point(40, 138);
            this.firstnameTextbox.Name = "firstnameTextbox";
            this.firstnameTextbox.Size = new System.Drawing.Size(328, 22);
            this.firstnameTextbox.TabIndex = 3;
            // 
            // middlenameTextbox
            // 
            this.middlenameTextbox.Location = new System.Drawing.Point(708, 138);
            this.middlenameTextbox.Name = "middlenameTextbox";
            this.middlenameTextbox.Size = new System.Drawing.Size(328, 22);
            this.middlenameTextbox.TabIndex = 5;
            // 
            // lastnameTextbox
            // 
            this.lastnameTextbox.Location = new System.Drawing.Point(374, 138);
            this.lastnameTextbox.Name = "lastnameTextbox";
            this.lastnameTextbox.Size = new System.Drawing.Size(328, 22);
            this.lastnameTextbox.TabIndex = 4;
            // 
            // addressTextbox
            // 
            this.addressTextbox.Location = new System.Drawing.Point(40, 200);
            this.addressTextbox.Name = "addressTextbox";
            this.addressTextbox.Size = new System.Drawing.Size(996, 22);
            this.addressTextbox.TabIndex = 9;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Birthdate";
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.navigationBar);
            this.Controls.Add(this.displayLayout);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "mainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hospital Management System";
            this.displayLayout.ResumeLayout(false);
            this.navigationPanel.ResumeLayout(false);
            this.addPatientPanel.ResumeLayout(false);
            this.addPatientPanel.PerformLayout();
            this.navigationBar.ResumeLayout(false);
            this.navigationBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel displayLayout;
        private System.Windows.Forms.Panel navigationPanel;
        private System.Windows.Forms.Button patientBtn;
        private System.Windows.Forms.Panel navigationBar;
        private System.Windows.Forms.Label profileLabel;
        private System.Windows.Forms.Button billingBtn;
        private System.Windows.Forms.Button doctorBtn;
        private System.Windows.Forms.Button removePatientBtn;
        private System.Windows.Forms.Button addPatientBtn;
        private System.Windows.Forms.Button removeDoctorBtn;
        private System.Windows.Forms.Button addDoctorsBtn;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Panel addPatientPanel;
        private System.Windows.Forms.TextBox middlenameTextbox;
        private System.Windows.Forms.TextBox lastnameTextbox;
        private System.Windows.Forms.TextBox firstnameTextbox;
        private System.Windows.Forms.Label addPatientLabel;
        private System.Windows.Forms.Label firstnameLabel;
        private System.Windows.Forms.Label middlenameLabel;
        private System.Windows.Forms.Label lastnameLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.TextBox addressTextbox;
        private System.Windows.Forms.Label label1;
    }
}

