
namespace hospital_management_system
{
    partial class FormPatient
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
            this.patientForm = new System.Windows.Forms.GroupBox();
            this.patientPanel = new System.Windows.Forms.Panel();
            this.appointmentGroupbox = new System.Windows.Forms.GroupBox();
            this.appoinmentPanel = new System.Windows.Forms.Panel();
            this.TableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.addressGroupbox = new System.Windows.Forms.GroupBox();
            this.countryInfobox = new hospital_management_system.gui.components.InformationTextbox();
            this.zipcodeInfobox = new hospital_management_system.gui.components.InformationTextbox();
            this.provinceInfobox = new hospital_management_system.gui.components.InformationTextbox();
            this.cityInfobox = new hospital_management_system.gui.components.InformationTextbox();
            this.address2Infobox = new hospital_management_system.gui.components.InformationTextbox();
            this.address1Infobox = new hospital_management_system.gui.components.InformationTextbox();
            this.personalGroupbox = new System.Windows.Forms.GroupBox();
            this.numberInfobox = new hospital_management_system.gui.components.InformationTextbox();
            this.emailInfobox = new hospital_management_system.gui.components.InformationTextbox();
            this.religionInfobox = new hospital_management_system.gui.components.InformationTextbox();
            this.genderInfobox = new hospital_management_system.gui.components.InformationRadio();
            this.birthdateInfobox = new hospital_management_system.gui.components.InformationDateTimePicker();
            this.lastnameInfobox = new hospital_management_system.gui.components.InformationTextbox();
            this.middlenameInfobox = new hospital_management_system.gui.components.InformationTextbox();
            this.firstnameInfobox = new hospital_management_system.gui.components.InformationTextbox();
            this.FlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.saveBtn = new System.Windows.Forms.Button();
            this.modifyBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.patientForm.SuspendLayout();
            this.patientPanel.SuspendLayout();
            this.appointmentGroupbox.SuspendLayout();
            this.TableLayout.SuspendLayout();
            this.addressGroupbox.SuspendLayout();
            this.personalGroupbox.SuspendLayout();
            this.FlowLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // patientForm
            // 
            this.patientForm.AutoSize = true;
            this.patientForm.BackColor = System.Drawing.Color.White;
            this.patientForm.Controls.Add(this.patientPanel);
            this.patientForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.patientForm.Font = new System.Drawing.Font("Segoe UI", 36F);
            this.patientForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(132)))), ((int)(((byte)(222)))));
            this.patientForm.Location = new System.Drawing.Point(0, 0);
            this.patientForm.Name = "patientForm";
            this.patientForm.Padding = new System.Windows.Forms.Padding(9, 3, 9, 3);
            this.patientForm.Size = new System.Drawing.Size(1080, 628);
            this.patientForm.TabIndex = 5;
            this.patientForm.TabStop = false;
            this.patientForm.Text = "{function}_patient";
            this.patientForm.Enter += new System.EventHandler(this.patientForm_Enter);
            // 
            // patientPanel
            // 
            this.patientPanel.AutoScroll = true;
            this.patientPanel.Controls.Add(this.appointmentGroupbox);
            this.patientPanel.Controls.Add(this.TableLayout);
            this.patientPanel.Controls.Add(this.FlowLayout);
            this.patientPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.patientPanel.Location = new System.Drawing.Point(9, 67);
            this.patientPanel.Name = "patientPanel";
            this.patientPanel.Size = new System.Drawing.Size(1062, 558);
            this.patientPanel.TabIndex = 3;
            // 
            // appointmentGroupbox
            // 
            this.appointmentGroupbox.Controls.Add(this.appoinmentPanel);
            this.appointmentGroupbox.Dock = System.Windows.Forms.DockStyle.Top;
            this.appointmentGroupbox.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.appointmentGroupbox.ForeColor = System.Drawing.Color.Black;
            this.appointmentGroupbox.Location = new System.Drawing.Point(0, 365);
            this.appointmentGroupbox.Name = "appointmentGroupbox";
            this.appointmentGroupbox.Size = new System.Drawing.Size(1062, 141);
            this.appointmentGroupbox.TabIndex = 6;
            this.appointmentGroupbox.TabStop = false;
            this.appointmentGroupbox.Text = "Appointment History";
            // 
            // appoinmentPanel
            // 
            this.appoinmentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.appoinmentPanel.Location = new System.Drawing.Point(3, 39);
            this.appoinmentPanel.Name = "appoinmentPanel";
            this.appoinmentPanel.Size = new System.Drawing.Size(1056, 99);
            this.appoinmentPanel.TabIndex = 0;
            // 
            // TableLayout
            // 
            this.TableLayout.ColumnCount = 2;
            this.TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.96422F));
            this.TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.03578F));
            this.TableLayout.Controls.Add(this.addressGroupbox, 1, 0);
            this.TableLayout.Controls.Add(this.personalGroupbox, 0, 0);
            this.TableLayout.Dock = System.Windows.Forms.DockStyle.Top;
            this.TableLayout.Location = new System.Drawing.Point(0, 0);
            this.TableLayout.Name = "TableLayout";
            this.TableLayout.RowCount = 1;
            this.TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.18182F));
            this.TableLayout.Size = new System.Drawing.Size(1062, 365);
            this.TableLayout.TabIndex = 5;
            // 
            // addressGroupbox
            // 
            this.addressGroupbox.Controls.Add(this.countryInfobox);
            this.addressGroupbox.Controls.Add(this.zipcodeInfobox);
            this.addressGroupbox.Controls.Add(this.provinceInfobox);
            this.addressGroupbox.Controls.Add(this.cityInfobox);
            this.addressGroupbox.Controls.Add(this.address2Infobox);
            this.addressGroupbox.Controls.Add(this.address1Infobox);
            this.addressGroupbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addressGroupbox.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.addressGroupbox.ForeColor = System.Drawing.Color.Black;
            this.addressGroupbox.Location = new System.Drawing.Point(522, 3);
            this.addressGroupbox.Name = "addressGroupbox";
            this.addressGroupbox.Size = new System.Drawing.Size(537, 359);
            this.addressGroupbox.TabIndex = 1;
            this.addressGroupbox.TabStop = false;
            this.addressGroupbox.Text = "Address Information";
            // 
            // countryInfobox
            // 
            this.countryInfobox.ColumnWidth0 = 145F;
            this.countryInfobox.Dock = System.Windows.Forms.DockStyle.Top;
            this.countryInfobox.LabelText = "Country";
            this.countryInfobox.Location = new System.Drawing.Point(3, 214);
            this.countryInfobox.Name = "countryInfobox";
            this.countryInfobox.Size = new System.Drawing.Size(531, 35);
            this.countryInfobox.TabIndex = 5;
            this.countryInfobox.TextboxPasswordChar = '\0';
            this.countryInfobox.TextboxText = "";
            // 
            // zipcodeInfobox
            // 
            this.zipcodeInfobox.ColumnWidth0 = 145F;
            this.zipcodeInfobox.Dock = System.Windows.Forms.DockStyle.Top;
            this.zipcodeInfobox.LabelText = "Postal/Zip Code";
            this.zipcodeInfobox.Location = new System.Drawing.Point(3, 179);
            this.zipcodeInfobox.Name = "zipcodeInfobox";
            this.zipcodeInfobox.Size = new System.Drawing.Size(531, 35);
            this.zipcodeInfobox.TabIndex = 4;
            this.zipcodeInfobox.TextboxPasswordChar = '\0';
            this.zipcodeInfobox.TextboxText = "";
            // 
            // provinceInfobox
            // 
            this.provinceInfobox.ColumnWidth0 = 145F;
            this.provinceInfobox.Dock = System.Windows.Forms.DockStyle.Top;
            this.provinceInfobox.LabelText = "State/Province";
            this.provinceInfobox.Location = new System.Drawing.Point(3, 144);
            this.provinceInfobox.Name = "provinceInfobox";
            this.provinceInfobox.Size = new System.Drawing.Size(531, 35);
            this.provinceInfobox.TabIndex = 3;
            this.provinceInfobox.TextboxPasswordChar = '\0';
            this.provinceInfobox.TextboxText = "";
            // 
            // cityInfobox
            // 
            this.cityInfobox.ColumnWidth0 = 145F;
            this.cityInfobox.Dock = System.Windows.Forms.DockStyle.Top;
            this.cityInfobox.LabelText = "City/Municipality";
            this.cityInfobox.Location = new System.Drawing.Point(3, 109);
            this.cityInfobox.Name = "cityInfobox";
            this.cityInfobox.Size = new System.Drawing.Size(531, 35);
            this.cityInfobox.TabIndex = 2;
            this.cityInfobox.TextboxPasswordChar = '\0';
            this.cityInfobox.TextboxText = "";
            // 
            // address2Infobox
            // 
            this.address2Infobox.ColumnWidth0 = 145F;
            this.address2Infobox.Dock = System.Windows.Forms.DockStyle.Top;
            this.address2Infobox.LabelText = "Address 2";
            this.address2Infobox.Location = new System.Drawing.Point(3, 74);
            this.address2Infobox.Name = "address2Infobox";
            this.address2Infobox.Size = new System.Drawing.Size(531, 35);
            this.address2Infobox.TabIndex = 1;
            this.address2Infobox.TextboxPasswordChar = '\0';
            this.address2Infobox.TextboxText = "";
            // 
            // address1Infobox
            // 
            this.address1Infobox.ColumnWidth0 = 145F;
            this.address1Infobox.Dock = System.Windows.Forms.DockStyle.Top;
            this.address1Infobox.LabelText = "Address 1";
            this.address1Infobox.Location = new System.Drawing.Point(3, 39);
            this.address1Infobox.Name = "address1Infobox";
            this.address1Infobox.Size = new System.Drawing.Size(531, 35);
            this.address1Infobox.TabIndex = 0;
            this.address1Infobox.TextboxPasswordChar = '\0';
            this.address1Infobox.TextboxText = "";
            // 
            // personalGroupbox
            // 
            this.personalGroupbox.Controls.Add(this.numberInfobox);
            this.personalGroupbox.Controls.Add(this.emailInfobox);
            this.personalGroupbox.Controls.Add(this.religionInfobox);
            this.personalGroupbox.Controls.Add(this.genderInfobox);
            this.personalGroupbox.Controls.Add(this.birthdateInfobox);
            this.personalGroupbox.Controls.Add(this.lastnameInfobox);
            this.personalGroupbox.Controls.Add(this.middlenameInfobox);
            this.personalGroupbox.Controls.Add(this.firstnameInfobox);
            this.personalGroupbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.personalGroupbox.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.personalGroupbox.ForeColor = System.Drawing.Color.Black;
            this.personalGroupbox.Location = new System.Drawing.Point(3, 3);
            this.personalGroupbox.Name = "personalGroupbox";
            this.personalGroupbox.Size = new System.Drawing.Size(513, 359);
            this.personalGroupbox.TabIndex = 0;
            this.personalGroupbox.TabStop = false;
            this.personalGroupbox.Text = "Personal Information";
            // 
            // numberInfobox
            // 
            this.numberInfobox.ColumnWidth0 = 145F;
            this.numberInfobox.Dock = System.Windows.Forms.DockStyle.Top;
            this.numberInfobox.LabelText = "Contact Number";
            this.numberInfobox.Location = new System.Drawing.Point(3, 319);
            this.numberInfobox.Name = "numberInfobox";
            this.numberInfobox.Size = new System.Drawing.Size(507, 35);
            this.numberInfobox.TabIndex = 7;
            this.numberInfobox.TextboxPasswordChar = '\0';
            this.numberInfobox.TextboxText = "";
            // 
            // emailInfobox
            // 
            this.emailInfobox.ColumnWidth0 = 145F;
            this.emailInfobox.Dock = System.Windows.Forms.DockStyle.Top;
            this.emailInfobox.LabelText = "Email Address";
            this.emailInfobox.Location = new System.Drawing.Point(3, 284);
            this.emailInfobox.Name = "emailInfobox";
            this.emailInfobox.Size = new System.Drawing.Size(507, 35);
            this.emailInfobox.TabIndex = 6;
            this.emailInfobox.TextboxPasswordChar = '\0';
            this.emailInfobox.TextboxText = "";
            // 
            // religionInfobox
            // 
            this.religionInfobox.ColumnWidth0 = 145F;
            this.religionInfobox.Dock = System.Windows.Forms.DockStyle.Top;
            this.religionInfobox.LabelText = "Religion";
            this.religionInfobox.Location = new System.Drawing.Point(3, 249);
            this.religionInfobox.Name = "religionInfobox";
            this.religionInfobox.Size = new System.Drawing.Size(507, 35);
            this.religionInfobox.TabIndex = 5;
            this.religionInfobox.TextboxPasswordChar = '\0';
            this.religionInfobox.TextboxText = "";
            // 
            // genderInfobox
            // 
            this.genderInfobox.ColumnWidth0 = 145F;
            this.genderInfobox.Dock = System.Windows.Forms.DockStyle.Top;
            this.genderInfobox.LabelText = "Gender";
            this.genderInfobox.Location = new System.Drawing.Point(3, 179);
            this.genderInfobox.Name = "genderInfobox";
            this.genderInfobox.RadioChecked1 = false;
            this.genderInfobox.RadioChecked2 = false;
            this.genderInfobox.RadioChecked3 = false;
            this.genderInfobox.RadioForeColor1 = System.Drawing.Color.Black;
            this.genderInfobox.RadioForeColor2 = System.Drawing.Color.Black;
            this.genderInfobox.RadioForeColor3 = System.Drawing.Color.Black;
            this.genderInfobox.RadioText1 = "Male";
            this.genderInfobox.RadioText2 = "Female";
            this.genderInfobox.RadioText3 = "Others:";
            this.genderInfobox.Size = new System.Drawing.Size(507, 70);
            this.genderInfobox.TabIndex = 8;
            this.genderInfobox.TextboxEnabled = false;
            this.genderInfobox.TextboxText = "";
            // 
            // birthdateInfobox
            // 
            this.birthdateInfobox.ColumnWidth0 = 145F;
            this.birthdateInfobox.DateText = new System.DateTime(2021, 11, 28, 12, 41, 45, 920);
            this.birthdateInfobox.Dock = System.Windows.Forms.DockStyle.Top;
            this.birthdateInfobox.LabelText = "Birthdate";
            this.birthdateInfobox.Location = new System.Drawing.Point(3, 144);
            this.birthdateInfobox.Name = "birthdateInfobox";
            this.birthdateInfobox.Size = new System.Drawing.Size(507, 35);
            this.birthdateInfobox.TabIndex = 4;
            // 
            // lastnameInfobox
            // 
            this.lastnameInfobox.ColumnWidth0 = 145F;
            this.lastnameInfobox.Dock = System.Windows.Forms.DockStyle.Top;
            this.lastnameInfobox.LabelText = "Lastname";
            this.lastnameInfobox.Location = new System.Drawing.Point(3, 109);
            this.lastnameInfobox.Name = "lastnameInfobox";
            this.lastnameInfobox.Size = new System.Drawing.Size(507, 35);
            this.lastnameInfobox.TabIndex = 2;
            this.lastnameInfobox.TextboxPasswordChar = '\0';
            this.lastnameInfobox.TextboxText = "";
            // 
            // middlenameInfobox
            // 
            this.middlenameInfobox.ColumnWidth0 = 145F;
            this.middlenameInfobox.Dock = System.Windows.Forms.DockStyle.Top;
            this.middlenameInfobox.LabelText = "Middlename";
            this.middlenameInfobox.Location = new System.Drawing.Point(3, 74);
            this.middlenameInfobox.Name = "middlenameInfobox";
            this.middlenameInfobox.Size = new System.Drawing.Size(507, 35);
            this.middlenameInfobox.TabIndex = 1;
            this.middlenameInfobox.TextboxPasswordChar = '\0';
            this.middlenameInfobox.TextboxText = "";
            // 
            // firstnameInfobox
            // 
            this.firstnameInfobox.ColumnWidth0 = 145F;
            this.firstnameInfobox.Dock = System.Windows.Forms.DockStyle.Top;
            this.firstnameInfobox.LabelText = "Firstname";
            this.firstnameInfobox.Location = new System.Drawing.Point(3, 39);
            this.firstnameInfobox.Name = "firstnameInfobox";
            this.firstnameInfobox.Size = new System.Drawing.Size(507, 35);
            this.firstnameInfobox.TabIndex = 0;
            this.firstnameInfobox.TextboxPasswordChar = '\0';
            this.firstnameInfobox.TextboxText = "";
            // 
            // FlowLayout
            // 
            this.FlowLayout.Controls.Add(this.saveBtn);
            this.FlowLayout.Controls.Add(this.modifyBtn);
            this.FlowLayout.Controls.Add(this.cancelBtn);
            this.FlowLayout.Controls.Add(this.deleteBtn);
            this.FlowLayout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FlowLayout.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.FlowLayout.Location = new System.Drawing.Point(0, 507);
            this.FlowLayout.Name = "FlowLayout";
            this.FlowLayout.Size = new System.Drawing.Size(1062, 51);
            this.FlowLayout.TabIndex = 4;
            // 
            // saveBtn
            // 
            this.saveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(132)))), ((int)(((byte)(222)))));
            this.saveBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(132)))), ((int)(((byte)(222)))));
            this.saveBtn.FlatAppearance.BorderSize = 0;
            this.saveBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(132)))), ((int)(((byte)(222)))));
            this.saveBtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.Location = new System.Drawing.Point(876, 3);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(183, 45);
            this.saveBtn.TabIndex = 3;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = false;
            // 
            // modifyBtn
            // 
            this.modifyBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.modifyBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(132)))), ((int)(((byte)(222)))));
            this.modifyBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(132)))), ((int)(((byte)(222)))));
            this.modifyBtn.FlatAppearance.BorderSize = 0;
            this.modifyBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(132)))), ((int)(((byte)(222)))));
            this.modifyBtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.modifyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modifyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.modifyBtn.ForeColor = System.Drawing.Color.White;
            this.modifyBtn.Location = new System.Drawing.Point(687, 3);
            this.modifyBtn.Name = "modifyBtn";
            this.modifyBtn.Size = new System.Drawing.Size(183, 45);
            this.modifyBtn.TabIndex = 6;
            this.modifyBtn.Text = "Modify";
            this.modifyBtn.UseVisualStyleBackColor = false;
            this.modifyBtn.Click += new System.EventHandler(this.modifyBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(132)))), ((int)(((byte)(222)))));
            this.cancelBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cancelBtn.FlatAppearance.BorderSize = 0;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cancelBtn.ForeColor = System.Drawing.Color.White;
            this.cancelBtn.Location = new System.Drawing.Point(498, 3);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(183, 45);
            this.cancelBtn.TabIndex = 4;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.deleteBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.deleteBtn.FlatAppearance.BorderSize = 0;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.deleteBtn.ForeColor = System.Drawing.Color.White;
            this.deleteBtn.Location = new System.Drawing.Point(309, 3);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(183, 45);
            this.deleteBtn.TabIndex = 5;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // FormPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1080, 628);
            this.Controls.Add(this.patientForm);
            this.Name = "FormPatient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.patientForm.ResumeLayout(false);
            this.patientPanel.ResumeLayout(false);
            this.appointmentGroupbox.ResumeLayout(false);
            this.TableLayout.ResumeLayout(false);
            this.addressGroupbox.ResumeLayout(false);
            this.personalGroupbox.ResumeLayout(false);
            this.FlowLayout.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox patientForm;
        private System.Windows.Forms.Panel patientPanel;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.FlowLayoutPanel FlowLayout;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button modifyBtn;
        private System.Windows.Forms.TableLayoutPanel TableLayout;
        private System.Windows.Forms.GroupBox personalGroupbox;
        private gui.components.InformationTextbox lastnameInfobox;
        private gui.components.InformationTextbox middlenameInfobox;
        private gui.components.InformationTextbox firstnameInfobox;
        private gui.components.InformationDateTimePicker birthdateInfobox;
        private gui.components.InformationTextbox numberInfobox;
        private gui.components.InformationTextbox emailInfobox;
        private gui.components.InformationTextbox religionInfobox;
        private gui.components.InformationRadio genderInfobox;
        private System.Windows.Forms.GroupBox addressGroupbox;
        private gui.components.InformationTextbox cityInfobox;
        private gui.components.InformationTextbox address2Infobox;
        private gui.components.InformationTextbox address1Infobox;
        private gui.components.InformationTextbox countryInfobox;
        private gui.components.InformationTextbox zipcodeInfobox;
        private gui.components.InformationTextbox provinceInfobox;
        private System.Windows.Forms.GroupBox appointmentGroupbox;
        private System.Windows.Forms.Panel appoinmentPanel;
    }
}