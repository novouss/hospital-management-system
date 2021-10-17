
namespace hospital_management_system
{
    partial class overview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(overview));
            this.overview_group = new System.Windows.Forms.GroupBox();
            this.overview_flowlayout = new System.Windows.Forms.FlowLayoutPanel();
            this.overview_patient = new System.Windows.Forms.Panel();
            this.patient_label = new System.Windows.Forms.Label();
            this.patient_count = new System.Windows.Forms.Label();
            this.patient_picture = new System.Windows.Forms.PictureBox();
            this.view_patient = new System.Windows.Forms.Button();
            this.overview_doctor = new System.Windows.Forms.Panel();
            this.doctor_label = new System.Windows.Forms.Label();
            this.doctor_count = new System.Windows.Forms.Label();
            this.doctor_picture = new System.Windows.Forms.PictureBox();
            this.view_doctor = new System.Windows.Forms.Button();
            this.overview_register = new System.Windows.Forms.Panel();
            this.appointment_label = new System.Windows.Forms.Label();
            this.appointment_count = new System.Windows.Forms.Label();
            this.appointment_photo = new System.Windows.Forms.PictureBox();
            this.view_appointment = new System.Windows.Forms.Button();
            this.overview_laboratory = new System.Windows.Forms.Panel();
            this.view_laboratory = new System.Windows.Forms.Button();
            this.overview_rooms = new System.Windows.Forms.Panel();
            this.view_rooms = new System.Windows.Forms.Button();
            this.overview_group.SuspendLayout();
            this.overview_flowlayout.SuspendLayout();
            this.overview_patient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patient_picture)).BeginInit();
            this.overview_doctor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doctor_picture)).BeginInit();
            this.overview_register.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appointment_photo)).BeginInit();
            this.overview_laboratory.SuspendLayout();
            this.overview_rooms.SuspendLayout();
            this.SuspendLayout();
            // 
            // overview_group
            // 
            this.overview_group.Controls.Add(this.overview_flowlayout);
            this.overview_group.Dock = System.Windows.Forms.DockStyle.Fill;
            this.overview_group.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.overview_group.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(132)))), ((int)(((byte)(222)))));
            this.overview_group.Location = new System.Drawing.Point(0, 0);
            this.overview_group.Name = "overview_group";
            this.overview_group.Size = new System.Drawing.Size(1064, 576);
            this.overview_group.TabIndex = 4;
            this.overview_group.TabStop = false;
            this.overview_group.Text = "Overview";
            // 
            // overview_flowlayout
            // 
            this.overview_flowlayout.Controls.Add(this.overview_patient);
            this.overview_flowlayout.Controls.Add(this.overview_doctor);
            this.overview_flowlayout.Controls.Add(this.overview_register);
            this.overview_flowlayout.Controls.Add(this.overview_laboratory);
            this.overview_flowlayout.Controls.Add(this.overview_rooms);
            this.overview_flowlayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.overview_flowlayout.Location = new System.Drawing.Point(3, 67);
            this.overview_flowlayout.Name = "overview_flowlayout";
            this.overview_flowlayout.Padding = new System.Windows.Forms.Padding(10);
            this.overview_flowlayout.Size = new System.Drawing.Size(1058, 506);
            this.overview_flowlayout.TabIndex = 1;
            // 
            // overview_patient
            // 
            this.overview_patient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(132)))), ((int)(((byte)(222)))));
            this.overview_patient.Controls.Add(this.patient_label);
            this.overview_patient.Controls.Add(this.patient_count);
            this.overview_patient.Controls.Add(this.patient_picture);
            this.overview_patient.Controls.Add(this.view_patient);
            this.overview_patient.Location = new System.Drawing.Point(15, 15);
            this.overview_patient.Margin = new System.Windows.Forms.Padding(5);
            this.overview_patient.Name = "overview_patient";
            this.overview_patient.Size = new System.Drawing.Size(270, 135);
            this.overview_patient.TabIndex = 0;
            // 
            // patient_label
            // 
            this.patient_label.AutoSize = true;
            this.patient_label.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.patient_label.ForeColor = System.Drawing.Color.White;
            this.patient_label.Location = new System.Drawing.Point(178, 56);
            this.patient_label.Name = "patient_label";
            this.patient_label.Size = new System.Drawing.Size(86, 30);
            this.patient_label.TabIndex = 3;
            this.patient_label.Text = "Patients";
            this.patient_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // patient_count
            // 
            this.patient_count.AutoSize = true;
            this.patient_count.ForeColor = System.Drawing.Color.White;
            this.patient_count.Location = new System.Drawing.Point(210, 0);
            this.patient_count.Name = "patient_count";
            this.patient_count.Size = new System.Drawing.Size(54, 65);
            this.patient_count.TabIndex = 2;
            this.patient_count.Text = "0";
            this.patient_count.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // patient_picture
            // 
            this.patient_picture.Dock = System.Windows.Forms.DockStyle.Left;
            this.patient_picture.Image = ((System.Drawing.Image)(resources.GetObject("patient_picture.Image")));
            this.patient_picture.Location = new System.Drawing.Point(0, 0);
            this.patient_picture.Name = "patient_picture";
            this.patient_picture.Size = new System.Drawing.Size(96, 96);
            this.patient_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.patient_picture.TabIndex = 1;
            this.patient_picture.TabStop = false;
            // 
            // view_patient
            // 
            this.view_patient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(114)))), ((int)(((byte)(196)))));
            this.view_patient.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.view_patient.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.view_patient.FlatAppearance.BorderSize = 0;
            this.view_patient.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.view_patient.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.view_patient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.view_patient.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.view_patient.ForeColor = System.Drawing.Color.White;
            this.view_patient.Location = new System.Drawing.Point(0, 96);
            this.view_patient.Margin = new System.Windows.Forms.Padding(0);
            this.view_patient.Name = "view_patient";
            this.view_patient.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.view_patient.Size = new System.Drawing.Size(270, 39);
            this.view_patient.TabIndex = 0;
            this.view_patient.Text = "View";
            this.view_patient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.view_patient.UseVisualStyleBackColor = true;
            this.view_patient.Click += new System.EventHandler(this.view_patient_Click);
            // 
            // overview_doctor
            // 
            this.overview_doctor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(132)))), ((int)(((byte)(222)))));
            this.overview_doctor.Controls.Add(this.doctor_label);
            this.overview_doctor.Controls.Add(this.doctor_count);
            this.overview_doctor.Controls.Add(this.doctor_picture);
            this.overview_doctor.Controls.Add(this.view_doctor);
            this.overview_doctor.Location = new System.Drawing.Point(295, 15);
            this.overview_doctor.Margin = new System.Windows.Forms.Padding(5);
            this.overview_doctor.Name = "overview_doctor";
            this.overview_doctor.Size = new System.Drawing.Size(270, 135);
            this.overview_doctor.TabIndex = 1;
            // 
            // doctor_label
            // 
            this.doctor_label.AutoSize = true;
            this.doctor_label.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.doctor_label.ForeColor = System.Drawing.Color.White;
            this.doctor_label.Location = new System.Drawing.Point(179, 56);
            this.doctor_label.Name = "doctor_label";
            this.doctor_label.Size = new System.Drawing.Size(85, 30);
            this.doctor_label.TabIndex = 6;
            this.doctor_label.Text = "Doctors";
            this.doctor_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // doctor_count
            // 
            this.doctor_count.AutoSize = true;
            this.doctor_count.ForeColor = System.Drawing.Color.White;
            this.doctor_count.Location = new System.Drawing.Point(210, 0);
            this.doctor_count.Name = "doctor_count";
            this.doctor_count.Size = new System.Drawing.Size(54, 65);
            this.doctor_count.TabIndex = 5;
            this.doctor_count.Text = "0";
            this.doctor_count.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // doctor_picture
            // 
            this.doctor_picture.Dock = System.Windows.Forms.DockStyle.Left;
            this.doctor_picture.Image = ((System.Drawing.Image)(resources.GetObject("doctor_picture.Image")));
            this.doctor_picture.Location = new System.Drawing.Point(0, 0);
            this.doctor_picture.Name = "doctor_picture";
            this.doctor_picture.Size = new System.Drawing.Size(96, 96);
            this.doctor_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.doctor_picture.TabIndex = 4;
            this.doctor_picture.TabStop = false;
            // 
            // view_doctor
            // 
            this.view_doctor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(114)))), ((int)(((byte)(196)))));
            this.view_doctor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.view_doctor.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.view_doctor.FlatAppearance.BorderSize = 0;
            this.view_doctor.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.view_doctor.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.view_doctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.view_doctor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.view_doctor.ForeColor = System.Drawing.Color.White;
            this.view_doctor.Location = new System.Drawing.Point(0, 96);
            this.view_doctor.Margin = new System.Windows.Forms.Padding(0);
            this.view_doctor.Name = "view_doctor";
            this.view_doctor.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.view_doctor.Size = new System.Drawing.Size(270, 39);
            this.view_doctor.TabIndex = 0;
            this.view_doctor.Text = "View";
            this.view_doctor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.view_doctor.UseVisualStyleBackColor = true;
            // 
            // overview_register
            // 
            this.overview_register.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(132)))), ((int)(((byte)(222)))));
            this.overview_register.Controls.Add(this.appointment_label);
            this.overview_register.Controls.Add(this.appointment_count);
            this.overview_register.Controls.Add(this.appointment_photo);
            this.overview_register.Controls.Add(this.view_appointment);
            this.overview_register.Location = new System.Drawing.Point(575, 15);
            this.overview_register.Margin = new System.Windows.Forms.Padding(5);
            this.overview_register.Name = "overview_register";
            this.overview_register.Size = new System.Drawing.Size(270, 135);
            this.overview_register.TabIndex = 2;
            // 
            // appointment_label
            // 
            this.appointment_label.AutoSize = true;
            this.appointment_label.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.appointment_label.ForeColor = System.Drawing.Color.White;
            this.appointment_label.Location = new System.Drawing.Point(129, 56);
            this.appointment_label.Name = "appointment_label";
            this.appointment_label.Size = new System.Drawing.Size(135, 30);
            this.appointment_label.TabIndex = 9;
            this.appointment_label.Text = "Appointment";
            this.appointment_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // appointment_count
            // 
            this.appointment_count.AutoSize = true;
            this.appointment_count.ForeColor = System.Drawing.Color.White;
            this.appointment_count.Location = new System.Drawing.Point(213, 0);
            this.appointment_count.Name = "appointment_count";
            this.appointment_count.Size = new System.Drawing.Size(54, 65);
            this.appointment_count.TabIndex = 8;
            this.appointment_count.Text = "0";
            this.appointment_count.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // appointment_photo
            // 
            this.appointment_photo.Dock = System.Windows.Forms.DockStyle.Left;
            this.appointment_photo.Image = ((System.Drawing.Image)(resources.GetObject("appointment_photo.Image")));
            this.appointment_photo.Location = new System.Drawing.Point(0, 0);
            this.appointment_photo.Name = "appointment_photo";
            this.appointment_photo.Size = new System.Drawing.Size(96, 96);
            this.appointment_photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.appointment_photo.TabIndex = 7;
            this.appointment_photo.TabStop = false;
            // 
            // view_appointment
            // 
            this.view_appointment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(114)))), ((int)(((byte)(196)))));
            this.view_appointment.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.view_appointment.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.view_appointment.FlatAppearance.BorderSize = 0;
            this.view_appointment.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.view_appointment.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.view_appointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.view_appointment.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.view_appointment.ForeColor = System.Drawing.Color.White;
            this.view_appointment.Location = new System.Drawing.Point(0, 96);
            this.view_appointment.Margin = new System.Windows.Forms.Padding(0);
            this.view_appointment.Name = "view_appointment";
            this.view_appointment.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.view_appointment.Size = new System.Drawing.Size(270, 39);
            this.view_appointment.TabIndex = 0;
            this.view_appointment.Text = "View";
            this.view_appointment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.view_appointment.UseVisualStyleBackColor = true;
            // 
            // overview_laboratory
            // 
            this.overview_laboratory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(132)))), ((int)(((byte)(222)))));
            this.overview_laboratory.Controls.Add(this.view_laboratory);
            this.overview_laboratory.Location = new System.Drawing.Point(15, 160);
            this.overview_laboratory.Margin = new System.Windows.Forms.Padding(5);
            this.overview_laboratory.Name = "overview_laboratory";
            this.overview_laboratory.Size = new System.Drawing.Size(270, 135);
            this.overview_laboratory.TabIndex = 3;
            // 
            // view_laboratory
            // 
            this.view_laboratory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(114)))), ((int)(((byte)(196)))));
            this.view_laboratory.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.view_laboratory.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.view_laboratory.FlatAppearance.BorderSize = 0;
            this.view_laboratory.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.view_laboratory.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.view_laboratory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.view_laboratory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.view_laboratory.ForeColor = System.Drawing.Color.White;
            this.view_laboratory.Location = new System.Drawing.Point(0, 96);
            this.view_laboratory.Margin = new System.Windows.Forms.Padding(0);
            this.view_laboratory.Name = "view_laboratory";
            this.view_laboratory.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.view_laboratory.Size = new System.Drawing.Size(270, 39);
            this.view_laboratory.TabIndex = 0;
            this.view_laboratory.Text = "View";
            this.view_laboratory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.view_laboratory.UseVisualStyleBackColor = true;
            // 
            // overview_rooms
            // 
            this.overview_rooms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(132)))), ((int)(((byte)(222)))));
            this.overview_rooms.Controls.Add(this.view_rooms);
            this.overview_rooms.Location = new System.Drawing.Point(295, 160);
            this.overview_rooms.Margin = new System.Windows.Forms.Padding(5);
            this.overview_rooms.Name = "overview_rooms";
            this.overview_rooms.Size = new System.Drawing.Size(270, 135);
            this.overview_rooms.TabIndex = 4;
            // 
            // view_rooms
            // 
            this.view_rooms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(114)))), ((int)(((byte)(196)))));
            this.view_rooms.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.view_rooms.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.view_rooms.FlatAppearance.BorderSize = 0;
            this.view_rooms.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.view_rooms.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.view_rooms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.view_rooms.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.view_rooms.ForeColor = System.Drawing.Color.White;
            this.view_rooms.Location = new System.Drawing.Point(0, 96);
            this.view_rooms.Margin = new System.Windows.Forms.Padding(0);
            this.view_rooms.Name = "view_rooms";
            this.view_rooms.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.view_rooms.Size = new System.Drawing.Size(270, 39);
            this.view_rooms.TabIndex = 0;
            this.view_rooms.Text = "View";
            this.view_rooms.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.view_rooms.UseVisualStyleBackColor = true;
            // 
            // overview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 576);
            this.Controls.Add(this.overview_group);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "overview";
            this.Text = "overview";
            this.overview_group.ResumeLayout(false);
            this.overview_flowlayout.ResumeLayout(false);
            this.overview_patient.ResumeLayout(false);
            this.overview_patient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patient_picture)).EndInit();
            this.overview_doctor.ResumeLayout(false);
            this.overview_doctor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doctor_picture)).EndInit();
            this.overview_register.ResumeLayout(false);
            this.overview_register.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appointment_photo)).EndInit();
            this.overview_laboratory.ResumeLayout(false);
            this.overview_rooms.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox overview_group;
        private System.Windows.Forms.FlowLayoutPanel overview_flowlayout;
        private System.Windows.Forms.Panel overview_patient;
        private System.Windows.Forms.Button view_patient;
        private System.Windows.Forms.Panel overview_doctor;
        private System.Windows.Forms.Button view_doctor;
        private System.Windows.Forms.Panel overview_register;
        private System.Windows.Forms.Button view_appointment;
        private System.Windows.Forms.Panel overview_laboratory;
        private System.Windows.Forms.Button view_laboratory;
        private System.Windows.Forms.Panel overview_rooms;
        private System.Windows.Forms.Button view_rooms;
        private System.Windows.Forms.PictureBox patient_picture;
        private System.Windows.Forms.Label patient_label;
        private System.Windows.Forms.Label patient_count;
        private System.Windows.Forms.PictureBox doctor_picture;
        private System.Windows.Forms.Label doctor_label;
        private System.Windows.Forms.Label doctor_count;
        private System.Windows.Forms.PictureBox appointment_photo;
        private System.Windows.Forms.Label appointment_label;
        private System.Windows.Forms.Label appointment_count;
    }
}