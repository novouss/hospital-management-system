
namespace hospital_management_system.gui.forms
{
    partial class PageDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PageDashboard));
            this.dashboardGroup = new System.Windows.Forms.GroupBox();
            this.dashboard_layout = new System.Windows.Forms.TableLayoutPanel();
            this.patient_panel = new System.Windows.Forms.Panel();
            this.patient_view = new System.Windows.Forms.Button();
            this.greetingsText = new System.Windows.Forms.Label();
            this.patient_img = new System.Windows.Forms.PictureBox();
            this.patient_text = new System.Windows.Forms.Label();
            this.patient_label = new System.Windows.Forms.Label();
            this.doctor_panel = new System.Windows.Forms.Panel();
            this.doctor_label = new System.Windows.Forms.Label();
            this.doctor_count = new System.Windows.Forms.Label();
            this.doctor_img = new System.Windows.Forms.PictureBox();
            this.doctor_view = new System.Windows.Forms.Button();
            this.lab_panel = new System.Windows.Forms.Panel();
            this.lab_label = new System.Windows.Forms.Label();
            this.lab_count = new System.Windows.Forms.Label();
            this.lab_img = new System.Windows.Forms.PictureBox();
            this.lab_view = new System.Windows.Forms.Button();
            this.room_panel = new System.Windows.Forms.Panel();
            this.room_label = new System.Windows.Forms.Label();
            this.room_count = new System.Windows.Forms.Label();
            this.room_img = new System.Windows.Forms.PictureBox();
            this.room_view = new System.Windows.Forms.Button();
            this.app_panel = new System.Windows.Forms.Panel();
            this.app_label = new System.Windows.Forms.Label();
            this.app_count = new System.Windows.Forms.Label();
            this.app_img = new System.Windows.Forms.PictureBox();
            this.app_view = new System.Windows.Forms.Button();
            this.bill_panel = new System.Windows.Forms.Panel();
            this.bill_label = new System.Windows.Forms.Label();
            this.bill_count = new System.Windows.Forms.Label();
            this.bill_img = new System.Windows.Forms.PictureBox();
            this.bill_view = new System.Windows.Forms.Button();
            this.dashboardGroup.SuspendLayout();
            this.dashboard_layout.SuspendLayout();
            this.patient_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patient_img)).BeginInit();
            this.doctor_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doctor_img)).BeginInit();
            this.lab_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lab_img)).BeginInit();
            this.room_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.room_img)).BeginInit();
            this.app_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.app_img)).BeginInit();
            this.bill_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bill_img)).BeginInit();
            this.SuspendLayout();
            // 
            // dashboardGroup
            // 
            this.dashboardGroup.Controls.Add(this.dashboard_layout);
            this.dashboardGroup.Controls.Add(this.greetingsText);
            this.dashboardGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashboardGroup.Font = new System.Drawing.Font("Segoe UI", 36F);
            this.dashboardGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(132)))), ((int)(((byte)(222)))));
            this.dashboardGroup.Location = new System.Drawing.Point(0, 0);
            this.dashboardGroup.Name = "dashboardGroup";
            this.dashboardGroup.Size = new System.Drawing.Size(1223, 744);
            this.dashboardGroup.TabIndex = 4;
            this.dashboardGroup.TabStop = false;
            this.dashboardGroup.Text = "Dashboard";
            // 
            // dashboard_layout
            // 
            this.dashboard_layout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dashboard_layout.ColumnCount = 3;
            this.dashboard_layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.dashboard_layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.dashboard_layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.dashboard_layout.Controls.Add(this.bill_panel, 2, 1);
            this.dashboard_layout.Controls.Add(this.app_panel, 2, 0);
            this.dashboard_layout.Controls.Add(this.room_panel, 0, 1);
            this.dashboard_layout.Controls.Add(this.lab_panel, 0, 1);
            this.dashboard_layout.Controls.Add(this.patient_panel, 0, 0);
            this.dashboard_layout.Controls.Add(this.doctor_panel, 1, 0);
            this.dashboard_layout.Location = new System.Drawing.Point(16, 123);
            this.dashboard_layout.Name = "dashboard_layout";
            this.dashboard_layout.RowCount = 2;
            this.dashboard_layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.dashboard_layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.dashboard_layout.Size = new System.Drawing.Size(1201, 350);
            this.dashboard_layout.TabIndex = 1;
            // 
            // patient_panel
            // 
            this.patient_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(132)))), ((int)(((byte)(222)))));
            this.patient_panel.Controls.Add(this.patient_label);
            this.patient_panel.Controls.Add(this.patient_text);
            this.patient_panel.Controls.Add(this.patient_img);
            this.patient_panel.Controls.Add(this.patient_view);
            this.patient_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.patient_panel.Location = new System.Drawing.Point(3, 3);
            this.patient_panel.Name = "patient_panel";
            this.patient_panel.Size = new System.Drawing.Size(394, 169);
            this.patient_panel.TabIndex = 0;
            // 
            // patient_view
            // 
            this.patient_view.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(114)))), ((int)(((byte)(196)))));
            this.patient_view.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.patient_view.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.patient_view.FlatAppearance.BorderSize = 0;
            this.patient_view.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.patient_view.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.patient_view.ForeColor = System.Drawing.Color.White;
            this.patient_view.Location = new System.Drawing.Point(0, 124);
            this.patient_view.Name = "patient_view";
            this.patient_view.Size = new System.Drawing.Size(394, 45);
            this.patient_view.TabIndex = 1;
            this.patient_view.Text = "View Patients";
            this.patient_view.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.patient_view.UseVisualStyleBackColor = false;
            // 
            // greetingsText
            // 
            this.greetingsText.AutoSize = true;
            this.greetingsText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.greetingsText.ForeColor = System.Drawing.Color.Black;
            this.greetingsText.Location = new System.Drawing.Point(12, 67);
            this.greetingsText.Name = "greetingsText";
            this.greetingsText.Size = new System.Drawing.Size(117, 20);
            this.greetingsText.TabIndex = 0;
            this.greetingsText.Text = "Welcome back,";
            // 
            // patient_img
            // 
            this.patient_img.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.patient_img.Image = ((System.Drawing.Image)(resources.GetObject("patient_img.Image")));
            this.patient_img.Location = new System.Drawing.Point(3, 3);
            this.patient_img.Name = "patient_img";
            this.patient_img.Size = new System.Drawing.Size(115, 115);
            this.patient_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.patient_img.TabIndex = 2;
            this.patient_img.TabStop = false;
            // 
            // patient_text
            // 
            this.patient_text.AutoSize = true;
            this.patient_text.ForeColor = System.Drawing.Color.White;
            this.patient_text.Location = new System.Drawing.Point(124, 15);
            this.patient_text.Name = "patient_text";
            this.patient_text.Size = new System.Drawing.Size(132, 65);
            this.patient_text.TabIndex = 3;
            this.patient_text.Text = "1337";
            this.patient_text.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // patient_label
            // 
            this.patient_label.AutoSize = true;
            this.patient_label.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.patient_label.ForeColor = System.Drawing.Color.White;
            this.patient_label.Location = new System.Drawing.Point(131, 80);
            this.patient_label.Name = "patient_label";
            this.patient_label.Size = new System.Drawing.Size(64, 21);
            this.patient_label.TabIndex = 4;
            this.patient_label.Text = "Patients";
            // 
            // doctor_panel
            // 
            this.doctor_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(132)))), ((int)(((byte)(222)))));
            this.doctor_panel.Controls.Add(this.doctor_label);
            this.doctor_panel.Controls.Add(this.doctor_count);
            this.doctor_panel.Controls.Add(this.doctor_img);
            this.doctor_panel.Controls.Add(this.doctor_view);
            this.doctor_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.doctor_panel.Location = new System.Drawing.Point(403, 3);
            this.doctor_panel.Name = "doctor_panel";
            this.doctor_panel.Size = new System.Drawing.Size(394, 169);
            this.doctor_panel.TabIndex = 1;
            // 
            // doctor_label
            // 
            this.doctor_label.AutoSize = true;
            this.doctor_label.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.doctor_label.ForeColor = System.Drawing.Color.White;
            this.doctor_label.Location = new System.Drawing.Point(131, 80);
            this.doctor_label.Name = "doctor_label";
            this.doctor_label.Size = new System.Drawing.Size(64, 21);
            this.doctor_label.TabIndex = 4;
            this.doctor_label.Text = "Doctors";
            // 
            // doctor_count
            // 
            this.doctor_count.AutoSize = true;
            this.doctor_count.ForeColor = System.Drawing.Color.White;
            this.doctor_count.Location = new System.Drawing.Point(124, 15);
            this.doctor_count.Name = "doctor_count";
            this.doctor_count.Size = new System.Drawing.Size(132, 65);
            this.doctor_count.TabIndex = 3;
            this.doctor_count.Text = "1337";
            this.doctor_count.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // doctor_img
            // 
            this.doctor_img.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.doctor_img.Image = ((System.Drawing.Image)(resources.GetObject("doctor_img.Image")));
            this.doctor_img.Location = new System.Drawing.Point(3, 3);
            this.doctor_img.Name = "doctor_img";
            this.doctor_img.Size = new System.Drawing.Size(115, 115);
            this.doctor_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.doctor_img.TabIndex = 2;
            this.doctor_img.TabStop = false;
            // 
            // doctor_view
            // 
            this.doctor_view.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(114)))), ((int)(((byte)(196)))));
            this.doctor_view.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.doctor_view.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.doctor_view.FlatAppearance.BorderSize = 0;
            this.doctor_view.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.doctor_view.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.doctor_view.ForeColor = System.Drawing.Color.White;
            this.doctor_view.Location = new System.Drawing.Point(0, 124);
            this.doctor_view.Name = "doctor_view";
            this.doctor_view.Size = new System.Drawing.Size(394, 45);
            this.doctor_view.TabIndex = 1;
            this.doctor_view.Text = "View Doctors";
            this.doctor_view.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.doctor_view.UseVisualStyleBackColor = false;
            // 
            // lab_panel
            // 
            this.lab_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(132)))), ((int)(((byte)(222)))));
            this.lab_panel.Controls.Add(this.lab_label);
            this.lab_panel.Controls.Add(this.lab_count);
            this.lab_panel.Controls.Add(this.lab_img);
            this.lab_panel.Controls.Add(this.lab_view);
            this.lab_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lab_panel.Location = new System.Drawing.Point(3, 178);
            this.lab_panel.Name = "lab_panel";
            this.lab_panel.Size = new System.Drawing.Size(394, 169);
            this.lab_panel.TabIndex = 2;
            // 
            // lab_label
            // 
            this.lab_label.AutoSize = true;
            this.lab_label.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lab_label.ForeColor = System.Drawing.Color.White;
            this.lab_label.Location = new System.Drawing.Point(131, 80);
            this.lab_label.Name = "lab_label";
            this.lab_label.Size = new System.Drawing.Size(97, 21);
            this.lab_label.TabIndex = 4;
            this.lab_label.Text = "Laboratories";
            // 
            // lab_count
            // 
            this.lab_count.AutoSize = true;
            this.lab_count.ForeColor = System.Drawing.Color.White;
            this.lab_count.Location = new System.Drawing.Point(124, 15);
            this.lab_count.Name = "lab_count";
            this.lab_count.Size = new System.Drawing.Size(132, 65);
            this.lab_count.TabIndex = 3;
            this.lab_count.Text = "1337";
            this.lab_count.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lab_img
            // 
            this.lab_img.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lab_img.Image = ((System.Drawing.Image)(resources.GetObject("lab_img.Image")));
            this.lab_img.Location = new System.Drawing.Point(3, 3);
            this.lab_img.Name = "lab_img";
            this.lab_img.Size = new System.Drawing.Size(115, 115);
            this.lab_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.lab_img.TabIndex = 2;
            this.lab_img.TabStop = false;
            // 
            // lab_view
            // 
            this.lab_view.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(114)))), ((int)(((byte)(196)))));
            this.lab_view.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lab_view.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.lab_view.FlatAppearance.BorderSize = 0;
            this.lab_view.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lab_view.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lab_view.ForeColor = System.Drawing.Color.White;
            this.lab_view.Location = new System.Drawing.Point(0, 124);
            this.lab_view.Name = "lab_view";
            this.lab_view.Size = new System.Drawing.Size(394, 45);
            this.lab_view.TabIndex = 1;
            this.lab_view.Text = "View Laboratories";
            this.lab_view.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lab_view.UseVisualStyleBackColor = false;
            // 
            // room_panel
            // 
            this.room_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(132)))), ((int)(((byte)(222)))));
            this.room_panel.Controls.Add(this.room_label);
            this.room_panel.Controls.Add(this.room_count);
            this.room_panel.Controls.Add(this.room_img);
            this.room_panel.Controls.Add(this.room_view);
            this.room_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.room_panel.Location = new System.Drawing.Point(403, 178);
            this.room_panel.Name = "room_panel";
            this.room_panel.Size = new System.Drawing.Size(394, 169);
            this.room_panel.TabIndex = 3;
            // 
            // room_label
            // 
            this.room_label.AutoSize = true;
            this.room_label.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.room_label.ForeColor = System.Drawing.Color.White;
            this.room_label.Location = new System.Drawing.Point(131, 80);
            this.room_label.Name = "room_label";
            this.room_label.Size = new System.Drawing.Size(59, 21);
            this.room_label.TabIndex = 4;
            this.room_label.Text = "Rooms";
            // 
            // room_count
            // 
            this.room_count.AutoSize = true;
            this.room_count.ForeColor = System.Drawing.Color.White;
            this.room_count.Location = new System.Drawing.Point(124, 15);
            this.room_count.Name = "room_count";
            this.room_count.Size = new System.Drawing.Size(132, 65);
            this.room_count.TabIndex = 3;
            this.room_count.Text = "1337";
            this.room_count.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // room_img
            // 
            this.room_img.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.room_img.Image = ((System.Drawing.Image)(resources.GetObject("room_img.Image")));
            this.room_img.Location = new System.Drawing.Point(3, 3);
            this.room_img.Name = "room_img";
            this.room_img.Size = new System.Drawing.Size(115, 115);
            this.room_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.room_img.TabIndex = 2;
            this.room_img.TabStop = false;
            // 
            // room_view
            // 
            this.room_view.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(114)))), ((int)(((byte)(196)))));
            this.room_view.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.room_view.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.room_view.FlatAppearance.BorderSize = 0;
            this.room_view.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.room_view.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.room_view.ForeColor = System.Drawing.Color.White;
            this.room_view.Location = new System.Drawing.Point(0, 124);
            this.room_view.Name = "room_view";
            this.room_view.Size = new System.Drawing.Size(394, 45);
            this.room_view.TabIndex = 1;
            this.room_view.Text = "View Rooms";
            this.room_view.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.room_view.UseVisualStyleBackColor = false;
            // 
            // app_panel
            // 
            this.app_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(132)))), ((int)(((byte)(222)))));
            this.app_panel.Controls.Add(this.app_label);
            this.app_panel.Controls.Add(this.app_count);
            this.app_panel.Controls.Add(this.app_img);
            this.app_panel.Controls.Add(this.app_view);
            this.app_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.app_panel.Location = new System.Drawing.Point(803, 3);
            this.app_panel.Name = "app_panel";
            this.app_panel.Size = new System.Drawing.Size(395, 169);
            this.app_panel.TabIndex = 5;
            // 
            // app_label
            // 
            this.app_label.AutoSize = true;
            this.app_label.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.app_label.ForeColor = System.Drawing.Color.White;
            this.app_label.Location = new System.Drawing.Point(131, 80);
            this.app_label.Name = "app_label";
            this.app_label.Size = new System.Drawing.Size(108, 21);
            this.app_label.TabIndex = 4;
            this.app_label.Text = "Appointments";
            // 
            // app_count
            // 
            this.app_count.AutoSize = true;
            this.app_count.ForeColor = System.Drawing.Color.White;
            this.app_count.Location = new System.Drawing.Point(124, 15);
            this.app_count.Name = "app_count";
            this.app_count.Size = new System.Drawing.Size(132, 65);
            this.app_count.TabIndex = 3;
            this.app_count.Text = "1337";
            this.app_count.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // app_img
            // 
            this.app_img.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.app_img.Image = ((System.Drawing.Image)(resources.GetObject("app_img.Image")));
            this.app_img.Location = new System.Drawing.Point(3, 3);
            this.app_img.Name = "app_img";
            this.app_img.Size = new System.Drawing.Size(115, 115);
            this.app_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.app_img.TabIndex = 2;
            this.app_img.TabStop = false;
            // 
            // app_view
            // 
            this.app_view.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(114)))), ((int)(((byte)(196)))));
            this.app_view.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.app_view.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.app_view.FlatAppearance.BorderSize = 0;
            this.app_view.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.app_view.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.app_view.ForeColor = System.Drawing.Color.White;
            this.app_view.Location = new System.Drawing.Point(0, 124);
            this.app_view.Name = "app_view";
            this.app_view.Size = new System.Drawing.Size(395, 45);
            this.app_view.TabIndex = 1;
            this.app_view.Text = "View Appointments";
            this.app_view.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.app_view.UseVisualStyleBackColor = false;
            // 
            // bill_panel
            // 
            this.bill_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(132)))), ((int)(((byte)(222)))));
            this.bill_panel.Controls.Add(this.bill_label);
            this.bill_panel.Controls.Add(this.bill_count);
            this.bill_panel.Controls.Add(this.bill_img);
            this.bill_panel.Controls.Add(this.bill_view);
            this.bill_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bill_panel.Location = new System.Drawing.Point(803, 178);
            this.bill_panel.Name = "bill_panel";
            this.bill_panel.Size = new System.Drawing.Size(395, 169);
            this.bill_panel.TabIndex = 6;
            // 
            // bill_label
            // 
            this.bill_label.AutoSize = true;
            this.bill_label.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.bill_label.ForeColor = System.Drawing.Color.White;
            this.bill_label.Location = new System.Drawing.Point(131, 80);
            this.bill_label.Name = "bill_label";
            this.bill_label.Size = new System.Drawing.Size(60, 21);
            this.bill_label.TabIndex = 4;
            this.bill_label.Text = "Billings";
            // 
            // bill_count
            // 
            this.bill_count.AutoSize = true;
            this.bill_count.ForeColor = System.Drawing.Color.White;
            this.bill_count.Location = new System.Drawing.Point(124, 15);
            this.bill_count.Name = "bill_count";
            this.bill_count.Size = new System.Drawing.Size(132, 65);
            this.bill_count.TabIndex = 3;
            this.bill_count.Text = "1337";
            this.bill_count.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bill_img
            // 
            this.bill_img.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.bill_img.Image = ((System.Drawing.Image)(resources.GetObject("bill_img.Image")));
            this.bill_img.Location = new System.Drawing.Point(3, 3);
            this.bill_img.Name = "bill_img";
            this.bill_img.Size = new System.Drawing.Size(115, 115);
            this.bill_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bill_img.TabIndex = 2;
            this.bill_img.TabStop = false;
            // 
            // bill_view
            // 
            this.bill_view.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(114)))), ((int)(((byte)(196)))));
            this.bill_view.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bill_view.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bill_view.FlatAppearance.BorderSize = 0;
            this.bill_view.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bill_view.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bill_view.ForeColor = System.Drawing.Color.White;
            this.bill_view.Location = new System.Drawing.Point(0, 124);
            this.bill_view.Name = "bill_view";
            this.bill_view.Size = new System.Drawing.Size(395, 45);
            this.bill_view.TabIndex = 1;
            this.bill_view.Text = "View Billings";
            this.bill_view.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bill_view.UseVisualStyleBackColor = false;
            // 
            // PageDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 744);
            this.Controls.Add(this.dashboardGroup);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PageDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "dashboardForm";
            this.dashboardGroup.ResumeLayout(false);
            this.dashboardGroup.PerformLayout();
            this.dashboard_layout.ResumeLayout(false);
            this.patient_panel.ResumeLayout(false);
            this.patient_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patient_img)).EndInit();
            this.doctor_panel.ResumeLayout(false);
            this.doctor_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doctor_img)).EndInit();
            this.lab_panel.ResumeLayout(false);
            this.lab_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lab_img)).EndInit();
            this.room_panel.ResumeLayout(false);
            this.room_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.room_img)).EndInit();
            this.app_panel.ResumeLayout(false);
            this.app_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.app_img)).EndInit();
            this.bill_panel.ResumeLayout(false);
            this.bill_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bill_img)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox dashboardGroup;
        private System.Windows.Forms.Label greetingsText;
        private System.Windows.Forms.TableLayoutPanel dashboard_layout;
        private System.Windows.Forms.Panel patient_panel;
        private System.Windows.Forms.Button patient_view;
        private System.Windows.Forms.PictureBox patient_img;
        private System.Windows.Forms.Label patient_label;
        private System.Windows.Forms.Label patient_text;
        private System.Windows.Forms.Panel app_panel;
        private System.Windows.Forms.Label app_label;
        private System.Windows.Forms.Label app_count;
        private System.Windows.Forms.PictureBox app_img;
        private System.Windows.Forms.Button app_view;
        private System.Windows.Forms.Panel room_panel;
        private System.Windows.Forms.Label room_label;
        private System.Windows.Forms.Label room_count;
        private System.Windows.Forms.PictureBox room_img;
        private System.Windows.Forms.Button room_view;
        private System.Windows.Forms.Panel lab_panel;
        private System.Windows.Forms.Label lab_label;
        private System.Windows.Forms.Label lab_count;
        private System.Windows.Forms.PictureBox lab_img;
        private System.Windows.Forms.Button lab_view;
        private System.Windows.Forms.Panel doctor_panel;
        private System.Windows.Forms.Label doctor_label;
        private System.Windows.Forms.Label doctor_count;
        private System.Windows.Forms.PictureBox doctor_img;
        private System.Windows.Forms.Button doctor_view;
        private System.Windows.Forms.Panel bill_panel;
        private System.Windows.Forms.Label bill_label;
        private System.Windows.Forms.Label bill_count;
        private System.Windows.Forms.PictureBox bill_img;
        private System.Windows.Forms.Button bill_view;
    }
}