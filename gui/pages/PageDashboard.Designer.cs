
namespace hospital_management_system.gui.pages
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
            this.counterpanel = new hospital_management_system.gui.components.RoundedPanels();
            this.TableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.billingcounter = new hospital_management_system.gui.components.CounterPanel();
            this.labcounter = new hospital_management_system.gui.components.CounterPanel();
            this.roomcounter = new hospital_management_system.gui.components.CounterPanel();
            this.patientcounter = new hospital_management_system.gui.components.CounterPanel();
            this.employeepanel = new hospital_management_system.gui.components.RoundedPanels();
            this.DisplayEmployeePreview = new hospital_management_system.gui.components.DisplayPreview();
            this.viewmoreemployees = new System.Windows.Forms.Label();
            this.employeelabel = new System.Windows.Forms.Label();
            this.greetingspanel = new hospital_management_system.gui.components.RoundedPanels();
            this.greetingslabel = new System.Windows.Forms.Label();
            this.schedulepanel = new hospital_management_system.gui.components.RoundedPanels();
            this.DisplayAppointmentPreview = new hospital_management_system.gui.components.DisplayPreview();
            this.viewmoreappointments = new System.Windows.Forms.Label();
            this.appointmentlabel = new System.Windows.Forms.Label();
            this.scheduledate = new hospital_management_system.gui.components.CustomDate();
            this.schedulelabel = new System.Windows.Forms.Label();
            this.counterpanel.SuspendLayout();
            this.TableLayout.SuspendLayout();
            this.employeepanel.SuspendLayout();
            this.greetingspanel.SuspendLayout();
            this.schedulepanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // counterpanel
            // 
            this.counterpanel.BackColor = System.Drawing.Color.White;
            this.counterpanel.Controls.Add(this.TableLayout);
            this.counterpanel.ForeColor = System.Drawing.Color.Black;
            this.counterpanel.Location = new System.Drawing.Point(12, 87);
            this.counterpanel.Margin = new System.Windows.Forms.Padding(10);
            this.counterpanel.Name = "counterpanel";
            this.counterpanel.Size = new System.Drawing.Size(845, 112);
            this.counterpanel.TabIndex = 2;
            // 
            // TableLayout
            // 
            this.TableLayout.ColumnCount = 4;
            this.TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TableLayout.Controls.Add(this.billingcounter, 3, 0);
            this.TableLayout.Controls.Add(this.labcounter, 2, 0);
            this.TableLayout.Controls.Add(this.roomcounter, 1, 0);
            this.TableLayout.Controls.Add(this.patientcounter, 0, 0);
            this.TableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayout.Location = new System.Drawing.Point(0, 0);
            this.TableLayout.Name = "TableLayout";
            this.TableLayout.RowCount = 1;
            this.TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayout.Size = new System.Drawing.Size(845, 112);
            this.TableLayout.TabIndex = 0;
            // 
            // billingcounter
            // 
            this.billingcounter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.billingcounter.FontCounter = new System.Drawing.Font("Segoe UI", 24F);
            this.billingcounter.FontText = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billingcounter.ForeColorCounter = System.Drawing.Color.MediumSeaGreen;
            this.billingcounter.ForeColorText = System.Drawing.Color.Black;
            this.billingcounter.LabelCounter = "9999";
            this.billingcounter.LabelText = "Billings";
            this.billingcounter.Location = new System.Drawing.Point(636, 3);
            this.billingcounter.Name = "billingcounter";
            this.billingcounter.Size = new System.Drawing.Size(206, 106);
            this.billingcounter.TabIndex = 4;
            // 
            // labcounter
            // 
            this.labcounter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labcounter.FontCounter = new System.Drawing.Font("Segoe UI", 24F);
            this.labcounter.FontText = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labcounter.ForeColorCounter = System.Drawing.Color.Black;
            this.labcounter.ForeColorText = System.Drawing.Color.Black;
            this.labcounter.LabelCounter = "9999";
            this.labcounter.LabelText = "Laboratories";
            this.labcounter.Location = new System.Drawing.Point(425, 3);
            this.labcounter.Name = "labcounter";
            this.labcounter.Size = new System.Drawing.Size(205, 106);
            this.labcounter.TabIndex = 3;
            // 
            // roomcounter
            // 
            this.roomcounter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roomcounter.FontCounter = new System.Drawing.Font("Segoe UI", 24F);
            this.roomcounter.FontText = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomcounter.ForeColorCounter = System.Drawing.Color.Black;
            this.roomcounter.ForeColorText = System.Drawing.Color.Black;
            this.roomcounter.LabelCounter = "9999";
            this.roomcounter.LabelText = "Rooms";
            this.roomcounter.Location = new System.Drawing.Point(214, 3);
            this.roomcounter.Name = "roomcounter";
            this.roomcounter.Size = new System.Drawing.Size(205, 106);
            this.roomcounter.TabIndex = 2;
            // 
            // patientcounter
            // 
            this.patientcounter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.patientcounter.FontCounter = new System.Drawing.Font("Segoe UI", 24F);
            this.patientcounter.FontText = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientcounter.ForeColorCounter = System.Drawing.Color.Black;
            this.patientcounter.ForeColorText = System.Drawing.Color.Black;
            this.patientcounter.LabelCounter = "9999";
            this.patientcounter.LabelText = "Patients";
            this.patientcounter.Location = new System.Drawing.Point(3, 3);
            this.patientcounter.Name = "patientcounter";
            this.patientcounter.Size = new System.Drawing.Size(205, 106);
            this.patientcounter.TabIndex = 1;
            // 
            // employeepanel
            // 
            this.employeepanel.BackColor = System.Drawing.Color.White;
            this.employeepanel.Controls.Add(this.DisplayEmployeePreview);
            this.employeepanel.Controls.Add(this.viewmoreemployees);
            this.employeepanel.Controls.Add(this.employeelabel);
            this.employeepanel.ForeColor = System.Drawing.Color.Black;
            this.employeepanel.Location = new System.Drawing.Point(12, 211);
            this.employeepanel.Margin = new System.Windows.Forms.Padding(20);
            this.employeepanel.Name = "employeepanel";
            this.employeepanel.Size = new System.Drawing.Size(845, 453);
            this.employeepanel.TabIndex = 1;
            // 
            // DisplayEmployeePreview
            // 
            this.DisplayEmployeePreview.AutoSize = true;
            this.DisplayEmployeePreview.BackColor = System.Drawing.Color.White;
            this.DisplayEmployeePreview.BackColorPanel = System.Drawing.Color.White;
            this.DisplayEmployeePreview.Column0 = 15F;
            this.DisplayEmployeePreview.Column1 = 70F;
            this.DisplayEmployeePreview.Column2 = 25F;
            this.DisplayEmployeePreview.Column3 = 10F;
            this.DisplayEmployeePreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DisplayEmployeePreview.Label0 = "ID";
            this.DisplayEmployeePreview.Label1 = "Employee Name";
            this.DisplayEmployeePreview.Label2 = "Status";
            this.DisplayEmployeePreview.Label3 = "";
            this.DisplayEmployeePreview.Location = new System.Drawing.Point(0, 60);
            this.DisplayEmployeePreview.Name = "DisplayEmployeePreview";
            this.DisplayEmployeePreview.Size = new System.Drawing.Size(845, 356);
            this.DisplayEmployeePreview.TabIndex = 7;
            // 
            // viewmoreemployees
            // 
            this.viewmoreemployees.BackColor = System.Drawing.Color.Transparent;
            this.viewmoreemployees.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.viewmoreemployees.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.viewmoreemployees.ForeColor = System.Drawing.Color.Black;
            this.viewmoreemployees.Location = new System.Drawing.Point(0, 416);
            this.viewmoreemployees.Name = "viewmoreemployees";
            this.viewmoreemployees.Size = new System.Drawing.Size(845, 37);
            this.viewmoreemployees.TabIndex = 1;
            this.viewmoreemployees.Text = "View more...";
            this.viewmoreemployees.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.viewmoreemployees.Click += new System.EventHandler(this.viewmoreemployees_Click);
            // 
            // employeelabel
            // 
            this.employeelabel.AutoSize = true;
            this.employeelabel.BackColor = System.Drawing.Color.Transparent;
            this.employeelabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.employeelabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeelabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.employeelabel.Location = new System.Drawing.Point(0, 0);
            this.employeelabel.Name = "employeelabel";
            this.employeelabel.Padding = new System.Windows.Forms.Padding(10, 20, 0, 10);
            this.employeelabel.Size = new System.Drawing.Size(122, 60);
            this.employeelabel.TabIndex = 0;
            this.employeelabel.Text = "Employees";
            // 
            // greetingspanel
            // 
            this.greetingspanel.BackColor = System.Drawing.Color.RoyalBlue;
            this.greetingspanel.Controls.Add(this.greetingslabel);
            this.greetingspanel.ForeColor = System.Drawing.Color.Black;
            this.greetingspanel.Location = new System.Drawing.Point(12, 12);
            this.greetingspanel.Margin = new System.Windows.Forms.Padding(20);
            this.greetingspanel.Name = "greetingspanel";
            this.greetingspanel.Size = new System.Drawing.Size(845, 62);
            this.greetingspanel.TabIndex = 1;
            // 
            // greetingslabel
            // 
            this.greetingslabel.AutoSize = true;
            this.greetingslabel.BackColor = System.Drawing.Color.Transparent;
            this.greetingslabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greetingslabel.ForeColor = System.Drawing.SystemColors.Window;
            this.greetingslabel.Location = new System.Drawing.Point(20, 15);
            this.greetingslabel.Margin = new System.Windows.Forms.Padding(20);
            this.greetingslabel.Name = "greetingslabel";
            this.greetingslabel.Size = new System.Drawing.Size(352, 30);
            this.greetingslabel.TabIndex = 0;
            this.greetingslabel.Text = "Welcome back {employee_firstname}";
            // 
            // schedulepanel
            // 
            this.schedulepanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.schedulepanel.BackColor = System.Drawing.Color.White;
            this.schedulepanel.Controls.Add(this.DisplayAppointmentPreview);
            this.schedulepanel.Controls.Add(this.viewmoreappointments);
            this.schedulepanel.Controls.Add(this.appointmentlabel);
            this.schedulepanel.Controls.Add(this.scheduledate);
            this.schedulepanel.Controls.Add(this.schedulelabel);
            this.schedulepanel.ForeColor = System.Drawing.Color.Black;
            this.schedulepanel.Location = new System.Drawing.Point(880, 12);
            this.schedulepanel.Margin = new System.Windows.Forms.Padding(20);
            this.schedulepanel.Name = "schedulepanel";
            this.schedulepanel.Size = new System.Drawing.Size(340, 652);
            this.schedulepanel.TabIndex = 0;
            // 
            // DisplayAppointmentPreview
            // 
            this.DisplayAppointmentPreview.AutoSize = true;
            this.DisplayAppointmentPreview.BackColor = System.Drawing.Color.White;
            this.DisplayAppointmentPreview.BackColorPanel = System.Drawing.Color.White;
            this.DisplayAppointmentPreview.Column0 = 15F;
            this.DisplayAppointmentPreview.Column1 = 70F;
            this.DisplayAppointmentPreview.Column2 = 20F;
            this.DisplayAppointmentPreview.Column3 = 10F;
            this.DisplayAppointmentPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DisplayAppointmentPreview.Label0 = "ID";
            this.DisplayAppointmentPreview.Label1 = "Appointment Details";
            this.DisplayAppointmentPreview.Label2 = "";
            this.DisplayAppointmentPreview.Label3 = "";
            this.DisplayAppointmentPreview.Location = new System.Drawing.Point(0, 199);
            this.DisplayAppointmentPreview.Name = "DisplayAppointmentPreview";
            this.DisplayAppointmentPreview.Size = new System.Drawing.Size(340, 416);
            this.DisplayAppointmentPreview.TabIndex = 6;
            // 
            // viewmoreappointments
            // 
            this.viewmoreappointments.BackColor = System.Drawing.Color.Transparent;
            this.viewmoreappointments.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.viewmoreappointments.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.viewmoreappointments.ForeColor = System.Drawing.Color.Black;
            this.viewmoreappointments.Location = new System.Drawing.Point(0, 615);
            this.viewmoreappointments.Name = "viewmoreappointments";
            this.viewmoreappointments.Size = new System.Drawing.Size(340, 37);
            this.viewmoreappointments.TabIndex = 5;
            this.viewmoreappointments.Text = "View more...";
            this.viewmoreappointments.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.viewmoreappointments.Click += new System.EventHandler(this.viewmoreappointments_Click);
            // 
            // appointmentlabel
            // 
            this.appointmentlabel.AutoSize = true;
            this.appointmentlabel.BackColor = System.Drawing.Color.Transparent;
            this.appointmentlabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.appointmentlabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentlabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.appointmentlabel.Location = new System.Drawing.Point(0, 129);
            this.appointmentlabel.Name = "appointmentlabel";
            this.appointmentlabel.Padding = new System.Windows.Forms.Padding(10, 20, 0, 20);
            this.appointmentlabel.Size = new System.Drawing.Size(154, 70);
            this.appointmentlabel.TabIndex = 3;
            this.appointmentlabel.Text = "Appointments";
            // 
            // scheduledate
            // 
            this.scheduledate.BackColor = System.Drawing.Color.White;
            this.scheduledate.Dock = System.Windows.Forms.DockStyle.Top;
            this.scheduledate.FontBottom = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scheduledate.FontBottomNow = new System.Drawing.Font("Segoe UI", 8.25F);
            this.scheduledate.FontColor = System.Drawing.Color.Empty;
            this.scheduledate.FontTop = new System.Drawing.Font("Segoe UI", 12F);
            this.scheduledate.FontTopNow = new System.Drawing.Font("Segoe UI", 16F);
            this.scheduledate.ForeColorNow = System.Drawing.Color.RoyalBlue;
            this.scheduledate.Location = new System.Drawing.Point(0, 50);
            this.scheduledate.Name = "scheduledate";
            this.scheduledate.Padding = new System.Windows.Forms.Padding(3);
            this.scheduledate.Size = new System.Drawing.Size(340, 79);
            this.scheduledate.TabIndex = 0;
            // 
            // schedulelabel
            // 
            this.schedulelabel.AutoSize = true;
            this.schedulelabel.BackColor = System.Drawing.Color.Transparent;
            this.schedulelabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.schedulelabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.schedulelabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.schedulelabel.Location = new System.Drawing.Point(0, 0);
            this.schedulelabel.Name = "schedulelabel";
            this.schedulelabel.Padding = new System.Windows.Forms.Padding(10, 20, 0, 0);
            this.schedulelabel.Size = new System.Drawing.Size(107, 50);
            this.schedulelabel.TabIndex = 1;
            this.schedulelabel.Text = "Schedule";
            // 
            // PageDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 675);
            this.Controls.Add(this.counterpanel);
            this.Controls.Add(this.employeepanel);
            this.Controls.Add(this.greetingspanel);
            this.Controls.Add(this.schedulepanel);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PageDashboard";
            this.Text = "PageDashboard";
            this.counterpanel.ResumeLayout(false);
            this.TableLayout.ResumeLayout(false);
            this.employeepanel.ResumeLayout(false);
            this.employeepanel.PerformLayout();
            this.greetingspanel.ResumeLayout(false);
            this.greetingspanel.PerformLayout();
            this.schedulepanel.ResumeLayout(false);
            this.schedulepanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private components.RoundedPanels schedulepanel;
        private components.RoundedPanels greetingspanel;
        private System.Windows.Forms.Label greetingslabel;
        private components.RoundedPanels employeepanel;
        private components.RoundedPanels counterpanel;
        private System.Windows.Forms.TableLayoutPanel TableLayout;
        private System.Windows.Forms.Label employeelabel;
        private System.Windows.Forms.Label schedulelabel;
        private System.Windows.Forms.Label appointmentlabel;
        private components.CustomDate scheduledate;
        private components.CounterPanel billingcounter;
        private components.CounterPanel labcounter;
        private components.CounterPanel roomcounter;
        private components.CounterPanel patientcounter;
        private hospital_management_system.gui.components.DisplayPreview DisplayEmployeePreview;
        private System.Windows.Forms.Label viewmoreemployees;
        private hospital_management_system.gui.components.DisplayPreview DisplayAppointmentPreview;
        private System.Windows.Forms.Label viewmoreappointments;
    }
}