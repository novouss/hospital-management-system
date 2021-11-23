
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
            this.buttonFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.saveBtn = new System.Windows.Forms.Button();
            this.modifyBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.personalInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.firstnameInfobox = new hospital_management_system.gui.components.InformationTextbox();
            this.middlenameInfobox = new hospital_management_system.gui.components.InformationTextbox();
            this.lastnameInfobox = new hospital_management_system.gui.components.InformationTextbox();
            this.birthdateInfobox = new hospital_management_system.gui.components.InformationDateTimePicker();
            this.religionInfobox = new hospital_management_system.gui.components.InformationTextbox();
            this.emailAddressInfobox = new hospital_management_system.gui.components.InformationTextbox();
            this.contactNoInfobox = new hospital_management_system.gui.components.InformationTextbox();
            this.genderInfobox = new hospital_management_system.gui.components.InformationRadio();
            this.addressInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.cityInfobox = new hospital_management_system.gui.components.InformationTextbox();
            this.address2Infobox = new hospital_management_system.gui.components.InformationTextbox();
            this.address1Infobox = new hospital_management_system.gui.components.InformationTextbox();
            this.stateInfobox = new hospital_management_system.gui.components.InformationTextbox();
            this.postalInfobox = new hospital_management_system.gui.components.InformationTextbox();
            this.countryInfobox = new hospital_management_system.gui.components.InformationTextbox();
            this.appointmentHisGroupBox = new System.Windows.Forms.GroupBox();
            this.patientForm.SuspendLayout();
            this.patientPanel.SuspendLayout();
            this.buttonFlowLayout.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.personalInfoGroupBox.SuspendLayout();
            this.addressInfoGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // patientForm
            // 
            this.patientForm.AutoSize = true;
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
            // 
            // patientPanel
            // 
            this.patientPanel.AutoScroll = true;
            this.patientPanel.Controls.Add(this.appointmentHisGroupBox);
            this.patientPanel.Controls.Add(this.tableLayoutPanel1);
            this.patientPanel.Controls.Add(this.buttonFlowLayout);
            this.patientPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.patientPanel.Location = new System.Drawing.Point(9, 67);
            this.patientPanel.Name = "patientPanel";
            this.patientPanel.Size = new System.Drawing.Size(1062, 558);
            this.patientPanel.TabIndex = 3;
            // 
            // buttonFlowLayout
            // 
            this.buttonFlowLayout.Controls.Add(this.saveBtn);
            this.buttonFlowLayout.Controls.Add(this.modifyBtn);
            this.buttonFlowLayout.Controls.Add(this.cancelBtn);
            this.buttonFlowLayout.Controls.Add(this.deleteBtn);
            this.buttonFlowLayout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonFlowLayout.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.buttonFlowLayout.Location = new System.Drawing.Point(0, 507);
            this.buttonFlowLayout.Name = "buttonFlowLayout";
            this.buttonFlowLayout.Size = new System.Drawing.Size(1062, 51);
            this.buttonFlowLayout.TabIndex = 4;
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
            // 
            // cancelBtn
            // 
            this.cancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelBtn.BackColor = System.Drawing.Color.White;
            this.cancelBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cancelBtn.FlatAppearance.BorderSize = 0;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cancelBtn.ForeColor = System.Drawing.Color.Black;
            this.cancelBtn.Location = new System.Drawing.Point(498, 3);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(183, 45);
            this.cancelBtn.TabIndex = 4;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = false;
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
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.96422F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.03578F));
            this.tableLayoutPanel1.Controls.Add(this.addressInfoGroupBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.personalInfoGroupBox, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.18182F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1062, 365);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // personalInfoGroupBox
            // 
            this.personalInfoGroupBox.Controls.Add(this.genderInfobox);
            this.personalInfoGroupBox.Controls.Add(this.contactNoInfobox);
            this.personalInfoGroupBox.Controls.Add(this.emailAddressInfobox);
            this.personalInfoGroupBox.Controls.Add(this.religionInfobox);
            this.personalInfoGroupBox.Controls.Add(this.birthdateInfobox);
            this.personalInfoGroupBox.Controls.Add(this.lastnameInfobox);
            this.personalInfoGroupBox.Controls.Add(this.middlenameInfobox);
            this.personalInfoGroupBox.Controls.Add(this.firstnameInfobox);
            this.personalInfoGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.personalInfoGroupBox.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.personalInfoGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(132)))), ((int)(((byte)(222)))));
            this.personalInfoGroupBox.Location = new System.Drawing.Point(3, 3);
            this.personalInfoGroupBox.Name = "personalInfoGroupBox";
            this.personalInfoGroupBox.Size = new System.Drawing.Size(513, 359);
            this.personalInfoGroupBox.TabIndex = 0;
            this.personalInfoGroupBox.TabStop = false;
            this.personalInfoGroupBox.Text = "Personal Information";
            this.personalInfoGroupBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // firstnameInfobox
            // 
            this.firstnameInfobox.ColumnWidth0 = 165F;
            this.firstnameInfobox.Dock = System.Windows.Forms.DockStyle.Top;
            this.firstnameInfobox.LabelText = "Firstname";
            this.firstnameInfobox.Location = new System.Drawing.Point(3, 39);
            this.firstnameInfobox.Name = "firstnameInfobox";
            this.firstnameInfobox.Size = new System.Drawing.Size(507, 35);
            this.firstnameInfobox.TabIndex = 0;
            this.firstnameInfobox.TextboxText = "";
            // 
            // middlenameInfobox
            // 
            this.middlenameInfobox.ColumnWidth0 = 165F;
            this.middlenameInfobox.Dock = System.Windows.Forms.DockStyle.Top;
            this.middlenameInfobox.LabelText = "Middlename";
            this.middlenameInfobox.Location = new System.Drawing.Point(3, 74);
            this.middlenameInfobox.Name = "middlenameInfobox";
            this.middlenameInfobox.Size = new System.Drawing.Size(507, 35);
            this.middlenameInfobox.TabIndex = 1;
            this.middlenameInfobox.TextboxText = "";
            // 
            // lastnameInfobox
            // 
            this.lastnameInfobox.ColumnWidth0 = 165F;
            this.lastnameInfobox.Dock = System.Windows.Forms.DockStyle.Top;
            this.lastnameInfobox.LabelText = "Lastname";
            this.lastnameInfobox.Location = new System.Drawing.Point(3, 109);
            this.lastnameInfobox.Name = "lastnameInfobox";
            this.lastnameInfobox.Size = new System.Drawing.Size(507, 35);
            this.lastnameInfobox.TabIndex = 2;
            this.lastnameInfobox.TextboxText = "";
            this.lastnameInfobox.Load += new System.EventHandler(this.informationTextbox3_Load);
            // 
            // birthdateInfobox
            // 
            this.birthdateInfobox.ColumnWidth0 = 165F;
            this.birthdateInfobox.Dock = System.Windows.Forms.DockStyle.Top;
            this.birthdateInfobox.LabelText = "Birthdate";
            this.birthdateInfobox.Location = new System.Drawing.Point(3, 144);
            this.birthdateInfobox.Name = "birthdateInfobox";
            this.birthdateInfobox.Size = new System.Drawing.Size(507, 35);
            this.birthdateInfobox.TabIndex = 4;
            // 
            // religionInfobox
            // 
            this.religionInfobox.ColumnWidth0 = 165F;
            this.religionInfobox.Dock = System.Windows.Forms.DockStyle.Top;
            this.religionInfobox.LabelText = "Religion";
            this.religionInfobox.Location = new System.Drawing.Point(3, 179);
            this.religionInfobox.Name = "religionInfobox";
            this.religionInfobox.Size = new System.Drawing.Size(507, 35);
            this.religionInfobox.TabIndex = 5;
            this.religionInfobox.TextboxText = "";
            // 
            // emailAddressInfobox
            // 
            this.emailAddressInfobox.ColumnWidth0 = 165F;
            this.emailAddressInfobox.Dock = System.Windows.Forms.DockStyle.Top;
            this.emailAddressInfobox.LabelText = "Email Address";
            this.emailAddressInfobox.Location = new System.Drawing.Point(3, 214);
            this.emailAddressInfobox.Name = "emailAddressInfobox";
            this.emailAddressInfobox.Size = new System.Drawing.Size(507, 35);
            this.emailAddressInfobox.TabIndex = 6;
            this.emailAddressInfobox.TextboxText = "";
            // 
            // contactNoInfobox
            // 
            this.contactNoInfobox.ColumnWidth0 = 165F;
            this.contactNoInfobox.Dock = System.Windows.Forms.DockStyle.Top;
            this.contactNoInfobox.LabelText = "Contact Number";
            this.contactNoInfobox.Location = new System.Drawing.Point(3, 249);
            this.contactNoInfobox.Name = "contactNoInfobox";
            this.contactNoInfobox.Size = new System.Drawing.Size(507, 35);
            this.contactNoInfobox.TabIndex = 7;
            this.contactNoInfobox.TextboxText = "";
            // 
            // genderInfobox
            // 
            this.genderInfobox.ColumnWidth0 = 245F;
            this.genderInfobox.Dock = System.Windows.Forms.DockStyle.Top;
            this.genderInfobox.LabelText = "Gender";
            this.genderInfobox.Location = new System.Drawing.Point(3, 284);
            this.genderInfobox.Name = "genderInfobox";
            this.genderInfobox.RadioForeColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(132)))), ((int)(((byte)(222)))));
            this.genderInfobox.RadioForeColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(132)))), ((int)(((byte)(222)))));
            this.genderInfobox.RadioForeColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(132)))), ((int)(((byte)(222)))));
            this.genderInfobox.RadioText1 = "Male";
            this.genderInfobox.RadioText2 = "Female";
            this.genderInfobox.RadioText3 = "Others:";
            this.genderInfobox.Size = new System.Drawing.Size(507, 70);
            this.genderInfobox.TabIndex = 8;
            this.genderInfobox.TextboxText = "";
            // 
            // addressInfoGroupBox
            // 
            this.addressInfoGroupBox.Controls.Add(this.countryInfobox);
            this.addressInfoGroupBox.Controls.Add(this.postalInfobox);
            this.addressInfoGroupBox.Controls.Add(this.stateInfobox);
            this.addressInfoGroupBox.Controls.Add(this.cityInfobox);
            this.addressInfoGroupBox.Controls.Add(this.address2Infobox);
            this.addressInfoGroupBox.Controls.Add(this.address1Infobox);
            this.addressInfoGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addressInfoGroupBox.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.addressInfoGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(132)))), ((int)(((byte)(222)))));
            this.addressInfoGroupBox.Location = new System.Drawing.Point(522, 3);
            this.addressInfoGroupBox.Name = "addressInfoGroupBox";
            this.addressInfoGroupBox.Size = new System.Drawing.Size(537, 359);
            this.addressInfoGroupBox.TabIndex = 1;
            this.addressInfoGroupBox.TabStop = false;
            this.addressInfoGroupBox.Text = "Address Information";
            // 
            // cityInfobox
            // 
            this.cityInfobox.ColumnWidth0 = 165F;
            this.cityInfobox.Dock = System.Windows.Forms.DockStyle.Top;
            this.cityInfobox.LabelText = "City/Municipality";
            this.cityInfobox.Location = new System.Drawing.Point(3, 109);
            this.cityInfobox.Name = "cityInfobox";
            this.cityInfobox.Size = new System.Drawing.Size(531, 35);
            this.cityInfobox.TabIndex = 2;
            this.cityInfobox.TextboxText = "";
            // 
            // address2Infobox
            // 
            this.address2Infobox.ColumnWidth0 = 165F;
            this.address2Infobox.Dock = System.Windows.Forms.DockStyle.Top;
            this.address2Infobox.LabelText = "Address 2";
            this.address2Infobox.Location = new System.Drawing.Point(3, 74);
            this.address2Infobox.Name = "address2Infobox";
            this.address2Infobox.Size = new System.Drawing.Size(531, 35);
            this.address2Infobox.TabIndex = 1;
            this.address2Infobox.TextboxText = "";
            // 
            // address1Infobox
            // 
            this.address1Infobox.ColumnWidth0 = 165F;
            this.address1Infobox.Dock = System.Windows.Forms.DockStyle.Top;
            this.address1Infobox.LabelText = "Address 1";
            this.address1Infobox.Location = new System.Drawing.Point(3, 39);
            this.address1Infobox.Name = "address1Infobox";
            this.address1Infobox.Size = new System.Drawing.Size(531, 35);
            this.address1Infobox.TabIndex = 0;
            this.address1Infobox.TextboxText = "";
            this.address1Infobox.Load += new System.EventHandler(this.informationTextbox6_Load);
            // 
            // stateInfobox
            // 
            this.stateInfobox.ColumnWidth0 = 165F;
            this.stateInfobox.Dock = System.Windows.Forms.DockStyle.Top;
            this.stateInfobox.LabelText = "State/Province";
            this.stateInfobox.Location = new System.Drawing.Point(3, 144);
            this.stateInfobox.Name = "stateInfobox";
            this.stateInfobox.Size = new System.Drawing.Size(531, 35);
            this.stateInfobox.TabIndex = 3;
            this.stateInfobox.TextboxText = "";
            // 
            // postalInfobox
            // 
            this.postalInfobox.ColumnWidth0 = 165F;
            this.postalInfobox.Dock = System.Windows.Forms.DockStyle.Top;
            this.postalInfobox.LabelText = "Postal/Zip Code";
            this.postalInfobox.Location = new System.Drawing.Point(3, 179);
            this.postalInfobox.Name = "postalInfobox";
            this.postalInfobox.Size = new System.Drawing.Size(531, 35);
            this.postalInfobox.TabIndex = 4;
            this.postalInfobox.TextboxText = "";
            // 
            // countryInfobox
            // 
            this.countryInfobox.ColumnWidth0 = 165F;
            this.countryInfobox.Dock = System.Windows.Forms.DockStyle.Top;
            this.countryInfobox.LabelText = "Country";
            this.countryInfobox.Location = new System.Drawing.Point(3, 214);
            this.countryInfobox.Name = "countryInfobox";
            this.countryInfobox.Size = new System.Drawing.Size(531, 35);
            this.countryInfobox.TabIndex = 5;
            this.countryInfobox.TextboxText = "";
            // 
            // appointmentHisGroupBox
            // 
            this.appointmentHisGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.appointmentHisGroupBox.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.appointmentHisGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(132)))), ((int)(((byte)(222)))));
            this.appointmentHisGroupBox.Location = new System.Drawing.Point(0, 365);
            this.appointmentHisGroupBox.Name = "appointmentHisGroupBox";
            this.appointmentHisGroupBox.Size = new System.Drawing.Size(1062, 135);
            this.appointmentHisGroupBox.TabIndex = 6;
            this.appointmentHisGroupBox.TabStop = false;
            this.appointmentHisGroupBox.Text = "Appointment History";
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
            this.buttonFlowLayout.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.personalInfoGroupBox.ResumeLayout(false);
            this.addressInfoGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox patientForm;
        private System.Windows.Forms.Panel patientPanel;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.FlowLayoutPanel buttonFlowLayout;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button modifyBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox personalInfoGroupBox;
        private gui.components.InformationTextbox lastnameInfobox;
        private gui.components.InformationTextbox middlenameInfobox;
        private gui.components.InformationTextbox firstnameInfobox;
        private gui.components.InformationDateTimePicker birthdateInfobox;
        private gui.components.InformationTextbox contactNoInfobox;
        private gui.components.InformationTextbox emailAddressInfobox;
        private gui.components.InformationTextbox religionInfobox;
        private gui.components.InformationRadio genderInfobox;
        private System.Windows.Forms.GroupBox addressInfoGroupBox;
        private gui.components.InformationTextbox cityInfobox;
        private gui.components.InformationTextbox address2Infobox;
        private gui.components.InformationTextbox address1Infobox;
        private gui.components.InformationTextbox countryInfobox;
        private gui.components.InformationTextbox postalInfobox;
        private gui.components.InformationTextbox stateInfobox;
        private System.Windows.Forms.GroupBox appointmentHisGroupBox;
    }
}