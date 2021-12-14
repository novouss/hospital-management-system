
namespace experimental_hospital_management_system
{
    partial class FormWindow
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
            this.sidepanel = new System.Windows.Forms.Panel();
            this.billingbtn = new System.Windows.Forms.PictureBox();
            this.appointmentbtn = new System.Windows.Forms.PictureBox();
            this.employeebtn = new System.Windows.Forms.PictureBox();
            this.patientbtn = new System.Windows.Forms.PictureBox();
            this.dashboardbtn = new System.Windows.Forms.PictureBox();
            this.logobox = new System.Windows.Forms.PictureBox();
            this.headerpanel = new System.Windows.Forms.Panel();
            this.minimizebtn = new System.Windows.Forms.Button();
            this.maximizebtn = new System.Windows.Forms.Button();
            this.closebtn = new System.Windows.Forms.Button();
            this.headerlabel = new System.Windows.Forms.Label();
            this.displaypanel = new System.Windows.Forms.Panel();
            this.sidepanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.billingbtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentbtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeebtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientbtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardbtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logobox)).BeginInit();
            this.headerpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidepanel
            // 
            this.sidepanel.BackColor = System.Drawing.Color.RoyalBlue;
            this.sidepanel.Controls.Add(this.billingbtn);
            this.sidepanel.Controls.Add(this.appointmentbtn);
            this.sidepanel.Controls.Add(this.employeebtn);
            this.sidepanel.Controls.Add(this.patientbtn);
            this.sidepanel.Controls.Add(this.dashboardbtn);
            this.sidepanel.Controls.Add(this.logobox);
            this.sidepanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidepanel.Location = new System.Drawing.Point(0, 0);
            this.sidepanel.Name = "sidepanel";
            this.sidepanel.Size = new System.Drawing.Size(45, 720);
            this.sidepanel.TabIndex = 0;
            // 
            // billingbtn
            // 
            this.billingbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.billingbtn.Image = global::experimental_hospital_management_system.Properties.Resources.billing;
            this.billingbtn.Location = new System.Drawing.Point(0, 225);
            this.billingbtn.Name = "billingbtn";
            this.billingbtn.Padding = new System.Windows.Forms.Padding(10);
            this.billingbtn.Size = new System.Drawing.Size(45, 45);
            this.billingbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.billingbtn.TabIndex = 5;
            this.billingbtn.TabStop = false;
            this.billingbtn.Click += new System.EventHandler(this.billingbtn_Click);
            // 
            // appointmentbtn
            // 
            this.appointmentbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.appointmentbtn.Image = global::experimental_hospital_management_system.Properties.Resources.appointment;
            this.appointmentbtn.Location = new System.Drawing.Point(0, 180);
            this.appointmentbtn.Name = "appointmentbtn";
            this.appointmentbtn.Padding = new System.Windows.Forms.Padding(10);
            this.appointmentbtn.Size = new System.Drawing.Size(45, 45);
            this.appointmentbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.appointmentbtn.TabIndex = 4;
            this.appointmentbtn.TabStop = false;
            this.appointmentbtn.Click += new System.EventHandler(this.appointmentbtn_Click);
            // 
            // employeebtn
            // 
            this.employeebtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.employeebtn.Image = global::experimental_hospital_management_system.Properties.Resources.doctor;
            this.employeebtn.Location = new System.Drawing.Point(0, 135);
            this.employeebtn.Name = "employeebtn";
            this.employeebtn.Padding = new System.Windows.Forms.Padding(10);
            this.employeebtn.Size = new System.Drawing.Size(45, 45);
            this.employeebtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.employeebtn.TabIndex = 3;
            this.employeebtn.TabStop = false;
            this.employeebtn.Click += new System.EventHandler(this.employeebtn_Click);
            // 
            // patientbtn
            // 
            this.patientbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.patientbtn.Image = global::experimental_hospital_management_system.Properties.Resources.patient;
            this.patientbtn.Location = new System.Drawing.Point(0, 90);
            this.patientbtn.Name = "patientbtn";
            this.patientbtn.Padding = new System.Windows.Forms.Padding(10);
            this.patientbtn.Size = new System.Drawing.Size(45, 45);
            this.patientbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.patientbtn.TabIndex = 2;
            this.patientbtn.TabStop = false;
            this.patientbtn.Click += new System.EventHandler(this.patientbtn_Click);
            // 
            // dashboardbtn
            // 
            this.dashboardbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.dashboardbtn.Image = global::experimental_hospital_management_system.Properties.Resources.home;
            this.dashboardbtn.Location = new System.Drawing.Point(0, 45);
            this.dashboardbtn.Name = "dashboardbtn";
            this.dashboardbtn.Padding = new System.Windows.Forms.Padding(10);
            this.dashboardbtn.Size = new System.Drawing.Size(45, 45);
            this.dashboardbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dashboardbtn.TabIndex = 1;
            this.dashboardbtn.TabStop = false;
            this.dashboardbtn.Click += new System.EventHandler(this.dashboardbtn_Click);
            // 
            // logobox
            // 
            this.logobox.Dock = System.Windows.Forms.DockStyle.Top;
            this.logobox.Image = global::experimental_hospital_management_system.Properties.Resources.logo;
            this.logobox.Location = new System.Drawing.Point(0, 0);
            this.logobox.Name = "logobox";
            this.logobox.Padding = new System.Windows.Forms.Padding(10);
            this.logobox.Size = new System.Drawing.Size(45, 45);
            this.logobox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logobox.TabIndex = 0;
            this.logobox.TabStop = false;
            // 
            // headerpanel
            // 
            this.headerpanel.BackColor = System.Drawing.Color.White;
            this.headerpanel.Controls.Add(this.minimizebtn);
            this.headerpanel.Controls.Add(this.maximizebtn);
            this.headerpanel.Controls.Add(this.closebtn);
            this.headerpanel.Controls.Add(this.headerlabel);
            this.headerpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerpanel.Location = new System.Drawing.Point(45, 0);
            this.headerpanel.Name = "headerpanel";
            this.headerpanel.Size = new System.Drawing.Size(1235, 45);
            this.headerpanel.TabIndex = 5;
            this.headerpanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.headerpanel_MouseDown);
            // 
            // minimizebtn
            // 
            this.minimizebtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.minimizebtn.FlatAppearance.BorderSize = 0;
            this.minimizebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizebtn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizebtn.Location = new System.Drawing.Point(1100, 0);
            this.minimizebtn.Name = "minimizebtn";
            this.minimizebtn.Size = new System.Drawing.Size(45, 45);
            this.minimizebtn.TabIndex = 3;
            this.minimizebtn.Text = "_";
            this.minimizebtn.UseVisualStyleBackColor = true;
            this.minimizebtn.Click += new System.EventHandler(this.minimizebtn_Click);
            // 
            // maximizebtn
            // 
            this.maximizebtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.maximizebtn.FlatAppearance.BorderSize = 0;
            this.maximizebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maximizebtn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maximizebtn.Location = new System.Drawing.Point(1145, 0);
            this.maximizebtn.Name = "maximizebtn";
            this.maximizebtn.Size = new System.Drawing.Size(45, 45);
            this.maximizebtn.TabIndex = 2;
            this.maximizebtn.Text = "🗖";
            this.maximizebtn.UseVisualStyleBackColor = true;
            this.maximizebtn.Click += new System.EventHandler(this.maximizebtn_Click);
            // 
            // closebtn
            // 
            this.closebtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.closebtn.FlatAppearance.BorderSize = 0;
            this.closebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.closebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closebtn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closebtn.Location = new System.Drawing.Point(1190, 0);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(45, 45);
            this.closebtn.TabIndex = 1;
            this.closebtn.Text = "ꭓ";
            this.closebtn.UseVisualStyleBackColor = true;
            this.closebtn.Click += new System.EventHandler(this.closebtn_Click);
            // 
            // headerlabel
            // 
            this.headerlabel.AutoSize = true;
            this.headerlabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.headerlabel.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.headerlabel.Location = new System.Drawing.Point(0, 0);
            this.headerlabel.Name = "headerlabel";
            this.headerlabel.Padding = new System.Windows.Forms.Padding(10, 5, 0, 0);
            this.headerlabel.Size = new System.Drawing.Size(376, 35);
            this.headerlabel.TabIndex = 0;
            this.headerlabel.Text = "Generic Hospital Management System";
            // 
            // displaypanel
            // 
            this.displaypanel.BackColor = System.Drawing.SystemColors.Control;
            this.displaypanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.displaypanel.Location = new System.Drawing.Point(45, 45);
            this.displaypanel.Name = "displaypanel";
            this.displaypanel.Size = new System.Drawing.Size(1235, 675);
            this.displaypanel.TabIndex = 6;
            // 
            // FormWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.displaypanel);
            this.Controls.Add(this.headerpanel);
            this.Controls.Add(this.sidepanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.sidepanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.billingbtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentbtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeebtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientbtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardbtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logobox)).EndInit();
            this.headerpanel.ResumeLayout(false);
            this.headerpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidepanel;
        private System.Windows.Forms.Panel headerpanel;
        private System.Windows.Forms.Panel displaypanel;
        private System.Windows.Forms.PictureBox logobox;
        private System.Windows.Forms.Label headerlabel;
        private System.Windows.Forms.Button minimizebtn;
        private System.Windows.Forms.Button maximizebtn;
        private System.Windows.Forms.Button closebtn;
        private System.Windows.Forms.PictureBox billingbtn;
        private System.Windows.Forms.PictureBox appointmentbtn;
        private System.Windows.Forms.PictureBox employeebtn;
        private System.Windows.Forms.PictureBox patientbtn;
        private System.Windows.Forms.PictureBox dashboardbtn;
    }
}

