
namespace hospital_management_system
{
    partial class window
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
            this.window_layout = new System.Windows.Forms.TableLayoutPanel();
            this.nav_profile = new System.Windows.Forms.Panel();
            this.nav_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_dash = new System.Windows.Forms.Button();
            this.btn_patient = new System.Windows.Forms.Button();
            this.btn_doctor = new System.Windows.Forms.Button();
            this.btn_billing = new System.Windows.Forms.Button();
            this.display_panel = new System.Windows.Forms.Panel();
            this.window_layout.SuspendLayout();
            this.nav_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // window_layout
            // 
            this.window_layout.BackColor = System.Drawing.Color.White;
            this.window_layout.ColumnCount = 2;
            this.window_layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.window_layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.window_layout.Controls.Add(this.nav_profile, 0, 0);
            this.window_layout.Controls.Add(this.nav_panel, 0, 1);
            this.window_layout.Controls.Add(this.display_panel, 1, 1);
            this.window_layout.Location = new System.Drawing.Point(0, 0);
            this.window_layout.Margin = new System.Windows.Forms.Padding(0);
            this.window_layout.Name = "window_layout";
            this.window_layout.RowCount = 2;
            this.window_layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.window_layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.window_layout.Size = new System.Drawing.Size(1280, 720);
            this.window_layout.TabIndex = 7;
            // 
            // nav_profile
            // 
            this.nav_profile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(114)))), ((int)(((byte)(196)))));
            this.nav_profile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nav_profile.Location = new System.Drawing.Point(0, 0);
            this.nav_profile.Margin = new System.Windows.Forms.Padding(0);
            this.nav_profile.Name = "nav_profile";
            this.nav_profile.Size = new System.Drawing.Size(250, 85);
            this.nav_profile.TabIndex = 2;
            // 
            // nav_panel
            // 
            this.nav_panel.Controls.Add(this.btn_dash);
            this.nav_panel.Controls.Add(this.btn_patient);
            this.nav_panel.Controls.Add(this.btn_doctor);
            this.nav_panel.Controls.Add(this.btn_billing);
            this.nav_panel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.nav_panel.Location = new System.Drawing.Point(0, 85);
            this.nav_panel.Margin = new System.Windows.Forms.Padding(0);
            this.nav_panel.Name = "nav_panel";
            this.nav_panel.Size = new System.Drawing.Size(250, 635);
            this.nav_panel.TabIndex = 3;
            // 
            // btn_dash
            // 
            this.btn_dash.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_dash.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btn_dash.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btn_dash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dash.Location = new System.Drawing.Point(0, 0);
            this.btn_dash.Margin = new System.Windows.Forms.Padding(0);
            this.btn_dash.Name = "btn_dash";
            this.btn_dash.Size = new System.Drawing.Size(250, 50);
            this.btn_dash.TabIndex = 1;
            this.btn_dash.Text = "Dashboard";
            this.btn_dash.UseVisualStyleBackColor = true;
            // 
            // btn_patient
            // 
            this.btn_patient.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_patient.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btn_patient.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btn_patient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_patient.Location = new System.Drawing.Point(0, 50);
            this.btn_patient.Margin = new System.Windows.Forms.Padding(0);
            this.btn_patient.Name = "btn_patient";
            this.btn_patient.Size = new System.Drawing.Size(250, 50);
            this.btn_patient.TabIndex = 2;
            this.btn_patient.Text = "Patient";
            this.btn_patient.UseVisualStyleBackColor = true;
            // 
            // btn_doctor
            // 
            this.btn_doctor.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_doctor.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btn_doctor.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btn_doctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_doctor.Location = new System.Drawing.Point(0, 100);
            this.btn_doctor.Margin = new System.Windows.Forms.Padding(0);
            this.btn_doctor.Name = "btn_doctor";
            this.btn_doctor.Size = new System.Drawing.Size(250, 50);
            this.btn_doctor.TabIndex = 3;
            this.btn_doctor.Text = "Doctor";
            this.btn_doctor.UseVisualStyleBackColor = true;
            // 
            // btn_billing
            // 
            this.btn_billing.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_billing.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btn_billing.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btn_billing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_billing.Location = new System.Drawing.Point(0, 150);
            this.btn_billing.Margin = new System.Windows.Forms.Padding(0);
            this.btn_billing.Name = "btn_billing";
            this.btn_billing.Size = new System.Drawing.Size(250, 50);
            this.btn_billing.TabIndex = 4;
            this.btn_billing.Text = "Billing";
            this.btn_billing.UseVisualStyleBackColor = true;
            // 
            // display_panel
            // 
            this.display_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.display_panel.Location = new System.Drawing.Point(250, 85);
            this.display_panel.Margin = new System.Windows.Forms.Padding(0);
            this.display_panel.Name = "display_panel";
            this.display_panel.Size = new System.Drawing.Size(1030, 632);
            this.display_panel.TabIndex = 4;
            // 
            // window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.window_layout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "window";
            this.Text = "Hospital Information Management System (HIMS)";
            this.window_layout.ResumeLayout(false);
            this.nav_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel window_layout;
        private System.Windows.Forms.FlowLayoutPanel nav_panel;
        private System.Windows.Forms.Button btn_dash;
        private System.Windows.Forms.Button btn_patient;
        private System.Windows.Forms.Button btn_doctor;
        private System.Windows.Forms.Button btn_billing;
        private System.Windows.Forms.Panel nav_profile;
        private System.Windows.Forms.Panel display_panel;
    }
}

