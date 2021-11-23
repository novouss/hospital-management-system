
namespace hospital_management_system
{
    partial class FormEmployee
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
            this.employeeForm = new System.Windows.Forms.GroupBox();
            this.employeePanel = new System.Windows.Forms.Panel();
            this.staffInfoGroupbox = new System.Windows.Forms.GroupBox();
            this.staffTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.depInfobox = new hospital_management_system.gui.components.InformationComboBox();
            this.roleInfobox = new hospital_management_system.gui.components.InformationComboBox();
            this.passwordInfobox = new hospital_management_system.gui.components.InformationTextbox();
            this.confirmInfobox = new hospital_management_system.gui.components.InformationTextbox();
            this.buttonFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.saveBtn = new System.Windows.Forms.Button();
            this.modifyBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.TableLayout1 = new System.Windows.Forms.TableLayoutPanel();
            this.personalInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.genderInfobox = new hospital_management_system.gui.components.InformationRadio();
            this.contactNoInfobox = new hospital_management_system.gui.components.InformationTextbox();
            this.emailAddressInfobox = new hospital_management_system.gui.components.InformationTextbox();
            this.religionInfobox = new hospital_management_system.gui.components.InformationTextbox();
            this.birthdateInfoBox = new hospital_management_system.gui.components.InformationDateTimePicker();
            this.lastnameInfobox = new hospital_management_system.gui.components.InformationTextbox();
            this.middlenameInfobox = new hospital_management_system.gui.components.InformationTextbox();
            this.firstnameInfobox = new hospital_management_system.gui.components.InformationTextbox();
            this.addressInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.countryInfobox = new hospital_management_system.gui.components.InformationTextbox();
            this.postInfobox = new hospital_management_system.gui.components.InformationTextbox();
            this.stateInfobox = new hospital_management_system.gui.components.InformationTextbox();
            this.cityInfobox = new hospital_management_system.gui.components.InformationTextbox();
            this.address2Infobox = new hospital_management_system.gui.components.InformationTextbox();
            this.address1InfoBox = new hospital_management_system.gui.components.InformationTextbox();
            this.employeeForm.SuspendLayout();
            this.employeePanel.SuspendLayout();
            this.staffInfoGroupbox.SuspendLayout();
            this.staffTableLayout.SuspendLayout();
            this.buttonFlowLayout.SuspendLayout();
            this.TableLayout1.SuspendLayout();
            this.personalInfoGroupBox.SuspendLayout();
            this.addressInfoGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // employeeForm
            // 
            this.employeeForm.AutoSize = true;
            this.employeeForm.Controls.Add(this.employeePanel);
            this.employeeForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeeForm.Font = new System.Drawing.Font("Segoe UI", 36F);
            this.employeeForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(132)))), ((int)(((byte)(222)))));
            this.employeeForm.Location = new System.Drawing.Point(0, 0);
            this.employeeForm.Name = "employeeForm";
            this.employeeForm.Padding = new System.Windows.Forms.Padding(9, 3, 9, 3);
            this.employeeForm.Size = new System.Drawing.Size(1080, 628);
            this.employeeForm.TabIndex = 5;
            this.employeeForm.TabStop = false;
            this.employeeForm.Text = "{function}_employee";
            // 
            // employeePanel
            // 
            this.employeePanel.AutoScroll = true;
            this.employeePanel.Controls.Add(this.buttonFlowLayout);
            this.employeePanel.Controls.Add(this.staffInfoGroupbox);
            this.employeePanel.Controls.Add(this.TableLayout1);
            this.employeePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeePanel.Location = new System.Drawing.Point(9, 67);
            this.employeePanel.Name = "employeePanel";
            this.employeePanel.Size = new System.Drawing.Size(1062, 558);
            this.employeePanel.TabIndex = 0;
            // 
            // staffInfoGroupbox
            // 
            this.staffInfoGroupbox.Controls.Add(this.staffTableLayout);
            this.staffInfoGroupbox.Dock = System.Windows.Forms.DockStyle.Top;
            this.staffInfoGroupbox.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.staffInfoGroupbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(132)))), ((int)(((byte)(222)))));
            this.staffInfoGroupbox.Location = new System.Drawing.Point(0, 378);
            this.staffInfoGroupbox.Name = "staffInfoGroupbox";
            this.staffInfoGroupbox.Size = new System.Drawing.Size(1045, 142);
            this.staffInfoGroupbox.TabIndex = 0;
            this.staffInfoGroupbox.TabStop = false;
            this.staffInfoGroupbox.Text = "Staff Information";
            // 
            // staffTableLayout
            // 
            this.staffTableLayout.AutoScroll = true;
            this.staffTableLayout.ColumnCount = 2;
            this.staffTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.staffTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.staffTableLayout.Controls.Add(this.depInfobox, 0, 0);
            this.staffTableLayout.Controls.Add(this.roleInfobox, 1, 0);
            this.staffTableLayout.Controls.Add(this.passwordInfobox, 0, 1);
            this.staffTableLayout.Controls.Add(this.confirmInfobox, 1, 1);
            this.staffTableLayout.Dock = System.Windows.Forms.DockStyle.Top;
            this.staffTableLayout.Location = new System.Drawing.Point(3, 39);
            this.staffTableLayout.Name = "staffTableLayout";
            this.staffTableLayout.RowCount = 2;
            this.staffTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.staffTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.staffTableLayout.Size = new System.Drawing.Size(1039, 90);
            this.staffTableLayout.TabIndex = 0;
            // 
            // depInfobox
            // 
            this.depInfobox.ColumnWidth0 = 165F;
            this.depInfobox.Dock = System.Windows.Forms.DockStyle.Top;
            this.depInfobox.LabelText = "Department ";
            this.depInfobox.Location = new System.Drawing.Point(3, 3);
            this.depInfobox.Name = "depInfobox";
            this.depInfobox.Size = new System.Drawing.Size(513, 35);
            this.depInfobox.TabIndex = 0;
            // 
            // roleInfobox
            // 
            this.roleInfobox.ColumnWidth0 = 165F;
            this.roleInfobox.Dock = System.Windows.Forms.DockStyle.Top;
            this.roleInfobox.LabelText = "Role";
            this.roleInfobox.Location = new System.Drawing.Point(522, 3);
            this.roleInfobox.Name = "roleInfobox";
            this.roleInfobox.Size = new System.Drawing.Size(514, 35);
            this.roleInfobox.TabIndex = 1;
            // 
            // passwordInfobox
            // 
            this.passwordInfobox.ColumnWidth0 = 165F;
            this.passwordInfobox.Dock = System.Windows.Forms.DockStyle.Top;
            this.passwordInfobox.LabelText = "Password";
            this.passwordInfobox.Location = new System.Drawing.Point(3, 47);
            this.passwordInfobox.Name = "passwordInfobox";
            this.passwordInfobox.Size = new System.Drawing.Size(513, 35);
            this.passwordInfobox.TabIndex = 2;
            this.passwordInfobox.TextboxText = "";
            // 
            // confirmInfobox
            // 
            this.confirmInfobox.ColumnWidth0 = 165F;
            this.confirmInfobox.Dock = System.Windows.Forms.DockStyle.Top;
            this.confirmInfobox.LabelText = "Confirm Password";
            this.confirmInfobox.Location = new System.Drawing.Point(522, 47);
            this.confirmInfobox.Name = "confirmInfobox";
            this.confirmInfobox.Size = new System.Drawing.Size(514, 35);
            this.confirmInfobox.TabIndex = 3;
            this.confirmInfobox.TextboxText = "";
            // 
            // buttonFlowLayout
            // 
            this.buttonFlowLayout.AutoSize = true;
            this.buttonFlowLayout.Controls.Add(this.saveBtn);
            this.buttonFlowLayout.Controls.Add(this.modifyBtn);
            this.buttonFlowLayout.Controls.Add(this.cancelBtn);
            this.buttonFlowLayout.Controls.Add(this.deleteBtn);
            this.buttonFlowLayout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonFlowLayout.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.buttonFlowLayout.Location = new System.Drawing.Point(0, 520);
            this.buttonFlowLayout.Name = "buttonFlowLayout";
            this.buttonFlowLayout.Size = new System.Drawing.Size(1045, 51);
            this.buttonFlowLayout.TabIndex = 5;
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
            this.saveBtn.Location = new System.Drawing.Point(859, 3);
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
            this.modifyBtn.Location = new System.Drawing.Point(670, 3);
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
            this.cancelBtn.Location = new System.Drawing.Point(481, 3);
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
            this.deleteBtn.Location = new System.Drawing.Point(292, 3);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(183, 45);
            this.deleteBtn.TabIndex = 5;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = false;
            // 
            // TableLayout1
            // 
            this.TableLayout1.ColumnCount = 2;
            this.TableLayout1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayout1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayout1.Controls.Add(this.personalInfoGroupBox, 0, 0);
            this.TableLayout1.Controls.Add(this.addressInfoGroupBox, 1, 0);
            this.TableLayout1.Dock = System.Windows.Forms.DockStyle.Top;
            this.TableLayout1.Location = new System.Drawing.Point(0, 0);
            this.TableLayout1.Name = "TableLayout1";
            this.TableLayout1.RowCount = 1;
            this.TableLayout1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 68.53933F));
            this.TableLayout1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 378F));
            this.TableLayout1.Size = new System.Drawing.Size(1045, 378);
            this.TableLayout1.TabIndex = 0;
            // 
            // personalInfoGroupBox
            // 
            this.personalInfoGroupBox.Controls.Add(this.genderInfobox);
            this.personalInfoGroupBox.Controls.Add(this.contactNoInfobox);
            this.personalInfoGroupBox.Controls.Add(this.emailAddressInfobox);
            this.personalInfoGroupBox.Controls.Add(this.religionInfobox);
            this.personalInfoGroupBox.Controls.Add(this.birthdateInfoBox);
            this.personalInfoGroupBox.Controls.Add(this.lastnameInfobox);
            this.personalInfoGroupBox.Controls.Add(this.middlenameInfobox);
            this.personalInfoGroupBox.Controls.Add(this.firstnameInfobox);
            this.personalInfoGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.personalInfoGroupBox.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.personalInfoGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(132)))), ((int)(((byte)(222)))));
            this.personalInfoGroupBox.Location = new System.Drawing.Point(3, 3);
            this.personalInfoGroupBox.Name = "personalInfoGroupBox";
            this.personalInfoGroupBox.Size = new System.Drawing.Size(516, 372);
            this.personalInfoGroupBox.TabIndex = 0;
            this.personalInfoGroupBox.TabStop = false;
            this.personalInfoGroupBox.Text = "Personal Information";
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
            this.genderInfobox.RadioText1 = "Others:";
            this.genderInfobox.RadioText2 = "Female";
            this.genderInfobox.RadioText3 = "Others:";
            this.genderInfobox.Size = new System.Drawing.Size(510, 70);
            this.genderInfobox.TabIndex = 36;
            this.genderInfobox.TextboxText = "";
            // 
            // contactNoInfobox
            // 
            this.contactNoInfobox.ColumnWidth0 = 165F;
            this.contactNoInfobox.Dock = System.Windows.Forms.DockStyle.Top;
            this.contactNoInfobox.LabelText = "Contact Number";
            this.contactNoInfobox.Location = new System.Drawing.Point(3, 249);
            this.contactNoInfobox.Name = "contactNoInfobox";
            this.contactNoInfobox.Size = new System.Drawing.Size(510, 35);
            this.contactNoInfobox.TabIndex = 12;
            this.contactNoInfobox.TextboxText = "";
            // 
            // emailAddressInfobox
            // 
            this.emailAddressInfobox.ColumnWidth0 = 165F;
            this.emailAddressInfobox.Dock = System.Windows.Forms.DockStyle.Top;
            this.emailAddressInfobox.LabelText = "Email Address";
            this.emailAddressInfobox.Location = new System.Drawing.Point(3, 214);
            this.emailAddressInfobox.Name = "emailAddressInfobox";
            this.emailAddressInfobox.Size = new System.Drawing.Size(510, 35);
            this.emailAddressInfobox.TabIndex = 10;
            this.emailAddressInfobox.TextboxText = "";
            // 
            // religionInfobox
            // 
            this.religionInfobox.ColumnWidth0 = 165F;
            this.religionInfobox.Dock = System.Windows.Forms.DockStyle.Top;
            this.religionInfobox.LabelText = "Religion";
            this.religionInfobox.Location = new System.Drawing.Point(3, 179);
            this.religionInfobox.Name = "religionInfobox";
            this.religionInfobox.Size = new System.Drawing.Size(510, 35);
            this.religionInfobox.TabIndex = 9;
            this.religionInfobox.TextboxText = "";
            // 
            // birthdateInfoBox
            // 
            this.birthdateInfoBox.ColumnWidth0 = 165F;
            this.birthdateInfoBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.birthdateInfoBox.LabelText = "Birthdate";
            this.birthdateInfoBox.Location = new System.Drawing.Point(3, 144);
            this.birthdateInfoBox.Name = "birthdateInfoBox";
            this.birthdateInfoBox.Size = new System.Drawing.Size(510, 35);
            this.birthdateInfoBox.TabIndex = 5;
            // 
            // lastnameInfobox
            // 
            this.lastnameInfobox.ColumnWidth0 = 165F;
            this.lastnameInfobox.Dock = System.Windows.Forms.DockStyle.Top;
            this.lastnameInfobox.LabelText = "Lastname";
            this.lastnameInfobox.Location = new System.Drawing.Point(3, 109);
            this.lastnameInfobox.Name = "lastnameInfobox";
            this.lastnameInfobox.Size = new System.Drawing.Size(510, 35);
            this.lastnameInfobox.TabIndex = 2;
            this.lastnameInfobox.TextboxText = "";
            // 
            // middlenameInfobox
            // 
            this.middlenameInfobox.ColumnWidth0 = 165F;
            this.middlenameInfobox.Dock = System.Windows.Forms.DockStyle.Top;
            this.middlenameInfobox.LabelText = "Middlename";
            this.middlenameInfobox.Location = new System.Drawing.Point(3, 74);
            this.middlenameInfobox.Name = "middlenameInfobox";
            this.middlenameInfobox.Size = new System.Drawing.Size(510, 35);
            this.middlenameInfobox.TabIndex = 1;
            this.middlenameInfobox.TextboxText = "";
            // 
            // firstnameInfobox
            // 
            this.firstnameInfobox.ColumnWidth0 = 165F;
            this.firstnameInfobox.Dock = System.Windows.Forms.DockStyle.Top;
            this.firstnameInfobox.LabelText = "Firstname";
            this.firstnameInfobox.Location = new System.Drawing.Point(3, 39);
            this.firstnameInfobox.Name = "firstnameInfobox";
            this.firstnameInfobox.Size = new System.Drawing.Size(510, 35);
            this.firstnameInfobox.TabIndex = 0;
            this.firstnameInfobox.TextboxText = "";
            // 
            // addressInfoGroupBox
            // 
            this.addressInfoGroupBox.Controls.Add(this.countryInfobox);
            this.addressInfoGroupBox.Controls.Add(this.postInfobox);
            this.addressInfoGroupBox.Controls.Add(this.stateInfobox);
            this.addressInfoGroupBox.Controls.Add(this.cityInfobox);
            this.addressInfoGroupBox.Controls.Add(this.address2Infobox);
            this.addressInfoGroupBox.Controls.Add(this.address1InfoBox);
            this.addressInfoGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addressInfoGroupBox.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.addressInfoGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(132)))), ((int)(((byte)(222)))));
            this.addressInfoGroupBox.Location = new System.Drawing.Point(525, 3);
            this.addressInfoGroupBox.Name = "addressInfoGroupBox";
            this.addressInfoGroupBox.Size = new System.Drawing.Size(517, 372);
            this.addressInfoGroupBox.TabIndex = 1;
            this.addressInfoGroupBox.TabStop = false;
            this.addressInfoGroupBox.Text = "Address Information";
            // 
            // countryInfobox
            // 
            this.countryInfobox.ColumnWidth0 = 165F;
            this.countryInfobox.Dock = System.Windows.Forms.DockStyle.Top;
            this.countryInfobox.LabelText = "Country";
            this.countryInfobox.Location = new System.Drawing.Point(3, 214);
            this.countryInfobox.Name = "countryInfobox";
            this.countryInfobox.Size = new System.Drawing.Size(511, 35);
            this.countryInfobox.TabIndex = 35;
            this.countryInfobox.TextboxText = "";
            // 
            // postInfobox
            // 
            this.postInfobox.ColumnWidth0 = 165F;
            this.postInfobox.Dock = System.Windows.Forms.DockStyle.Top;
            this.postInfobox.LabelText = "Postal/Zip Code";
            this.postInfobox.Location = new System.Drawing.Point(3, 179);
            this.postInfobox.Name = "postInfobox";
            this.postInfobox.Size = new System.Drawing.Size(511, 35);
            this.postInfobox.TabIndex = 34;
            this.postInfobox.TextboxText = "";
            // 
            // stateInfobox
            // 
            this.stateInfobox.ColumnWidth0 = 165F;
            this.stateInfobox.Dock = System.Windows.Forms.DockStyle.Top;
            this.stateInfobox.LabelText = "State/Province";
            this.stateInfobox.Location = new System.Drawing.Point(3, 144);
            this.stateInfobox.Name = "stateInfobox";
            this.stateInfobox.Size = new System.Drawing.Size(511, 35);
            this.stateInfobox.TabIndex = 33;
            this.stateInfobox.TextboxText = "";
            // 
            // cityInfobox
            // 
            this.cityInfobox.ColumnWidth0 = 165F;
            this.cityInfobox.Dock = System.Windows.Forms.DockStyle.Top;
            this.cityInfobox.LabelText = "City/Municipality";
            this.cityInfobox.Location = new System.Drawing.Point(3, 109);
            this.cityInfobox.Name = "cityInfobox";
            this.cityInfobox.Size = new System.Drawing.Size(511, 35);
            this.cityInfobox.TabIndex = 32;
            this.cityInfobox.TextboxText = "";
            // 
            // address2Infobox
            // 
            this.address2Infobox.ColumnWidth0 = 165F;
            this.address2Infobox.Dock = System.Windows.Forms.DockStyle.Top;
            this.address2Infobox.LabelText = "Address 2";
            this.address2Infobox.Location = new System.Drawing.Point(3, 74);
            this.address2Infobox.Name = "address2Infobox";
            this.address2Infobox.Size = new System.Drawing.Size(511, 35);
            this.address2Infobox.TabIndex = 31;
            this.address2Infobox.TextboxText = "";
            // 
            // address1InfoBox
            // 
            this.address1InfoBox.ColumnWidth0 = 165F;
            this.address1InfoBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.address1InfoBox.LabelText = "Address 1";
            this.address1InfoBox.Location = new System.Drawing.Point(3, 39);
            this.address1InfoBox.Name = "address1InfoBox";
            this.address1InfoBox.Size = new System.Drawing.Size(511, 35);
            this.address1InfoBox.TabIndex = 17;
            this.address1InfoBox.TextboxText = "";
            // 
            // FormEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1080, 628);
            this.Controls.Add(this.employeeForm);
            this.Name = "FormEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.employeeForm.ResumeLayout(false);
            this.employeePanel.ResumeLayout(false);
            this.employeePanel.PerformLayout();
            this.staffInfoGroupbox.ResumeLayout(false);
            this.staffTableLayout.ResumeLayout(false);
            this.buttonFlowLayout.ResumeLayout(false);
            this.TableLayout1.ResumeLayout(false);
            this.personalInfoGroupBox.ResumeLayout(false);
            this.addressInfoGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox employeeForm;
        private System.Windows.Forms.Panel employeePanel;
        private System.Windows.Forms.TableLayoutPanel TableLayout1;
        private System.Windows.Forms.GroupBox personalInfoGroupBox;
        private gui.components.InformationTextbox firstnameInfobox;
        private gui.components.InformationTextbox contactNoInfobox;
        private gui.components.InformationTextbox emailAddressInfobox;
        private gui.components.InformationTextbox religionInfobox;
        private gui.components.InformationDateTimePicker birthdateInfoBox;
        private gui.components.InformationTextbox lastnameInfobox;
        private gui.components.InformationTextbox middlenameInfobox;
        private System.Windows.Forms.GroupBox addressInfoGroupBox;
        private gui.components.InformationTextbox address1InfoBox;
        private System.Windows.Forms.FlowLayoutPanel buttonFlowLayout;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button modifyBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button deleteBtn;
        private gui.components.InformationTextbox countryInfobox;
        private gui.components.InformationTextbox postInfobox;
        private gui.components.InformationTextbox stateInfobox;
        private gui.components.InformationTextbox cityInfobox;
        private gui.components.InformationTextbox address2Infobox;
        private System.Windows.Forms.GroupBox staffInfoGroupbox;
        private System.Windows.Forms.TableLayoutPanel staffTableLayout;
        private gui.components.InformationComboBox depInfobox;
        private gui.components.InformationComboBox roleInfobox;
        private gui.components.InformationTextbox passwordInfobox;
        private gui.components.InformationTextbox confirmInfobox;
        private gui.components.InformationRadio genderInfobox;
    }
}