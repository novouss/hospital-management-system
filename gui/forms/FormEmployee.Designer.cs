
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
            this.staffGroupbox = new System.Windows.Forms.GroupBox();
            this.staffTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.TableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.addressGroupbox = new System.Windows.Forms.GroupBox();
            this.personalGroupbox = new System.Windows.Forms.GroupBox();
            this.FlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.saveBtn = new System.Windows.Forms.Button();
            this.modifyBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.statusInfobox = new hospital_management_system.gui.components.InformationCheckBox();
            this.departmentInfobox = new hospital_management_system.gui.components.InformationComboBox();
            this.roleInfobox = new hospital_management_system.gui.components.InformationComboBox();
            this.passwordInfobox = new hospital_management_system.gui.components.InformationTextbox();
            this.countryInfobox = new hospital_management_system.gui.components.InformationTextbox();
            this.zipcodeInfobox = new hospital_management_system.gui.components.InformationTextbox();
            this.provinceInfobox = new hospital_management_system.gui.components.InformationTextbox();
            this.cityInfobox = new hospital_management_system.gui.components.InformationTextbox();
            this.address2Infobox = new hospital_management_system.gui.components.InformationTextbox();
            this.address1Infobox = new hospital_management_system.gui.components.InformationTextbox();
            this.numberInfobox = new hospital_management_system.gui.components.InformationTextbox();
            this.emailInfobox = new hospital_management_system.gui.components.InformationTextbox();
            this.religionInfobox = new hospital_management_system.gui.components.InformationTextbox();
            this.genderInfobox = new hospital_management_system.gui.components.InformationRadio();
            this.birthdateInfobox = new hospital_management_system.gui.components.InformationDateTimePicker();
            this.lastnameInfobox = new hospital_management_system.gui.components.InformationTextbox();
            this.middlenameInfobox = new hospital_management_system.gui.components.InformationTextbox();
            this.firstnameInfobox = new hospital_management_system.gui.components.InformationTextbox();
            this.employeeForm.SuspendLayout();
            this.employeePanel.SuspendLayout();
            this.staffGroupbox.SuspendLayout();
            this.staffTableLayout.SuspendLayout();
            this.TableLayout.SuspendLayout();
            this.addressGroupbox.SuspendLayout();
            this.personalGroupbox.SuspendLayout();
            this.FlowLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // employeeForm
            // 
            this.employeeForm.AutoSize = true;
            this.employeeForm.BackColor = System.Drawing.Color.White;
            this.employeeForm.Controls.Add(this.employeePanel);
            this.employeeForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeeForm.Font = new System.Drawing.Font("Segoe UI", 36F);
            this.employeeForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(132)))), ((int)(((byte)(222)))));
            this.employeeForm.Location = new System.Drawing.Point(0, 0);
            this.employeeForm.Name = "employeeForm";
            this.employeeForm.Padding = new System.Windows.Forms.Padding(9, 3, 9, 3);
            this.employeeForm.Size = new System.Drawing.Size(1080, 636);
            this.employeeForm.TabIndex = 5;
            this.employeeForm.TabStop = false;
            this.employeeForm.Text = "{function}_employee";
            // 
            // employeePanel
            // 
            this.employeePanel.AutoScroll = true;
            this.employeePanel.Controls.Add(this.staffGroupbox);
            this.employeePanel.Controls.Add(this.TableLayout);
            this.employeePanel.Controls.Add(this.FlowLayout);
            this.employeePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeePanel.Location = new System.Drawing.Point(9, 67);
            this.employeePanel.Name = "employeePanel";
            this.employeePanel.Size = new System.Drawing.Size(1062, 566);
            this.employeePanel.TabIndex = 0;
            // 
            // staffGroupbox
            // 
            this.staffGroupbox.Controls.Add(this.staffTableLayout);
            this.staffGroupbox.Dock = System.Windows.Forms.DockStyle.Top;
            this.staffGroupbox.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.staffGroupbox.ForeColor = System.Drawing.Color.Black;
            this.staffGroupbox.Location = new System.Drawing.Point(0, 378);
            this.staffGroupbox.Name = "staffGroupbox";
            this.staffGroupbox.Size = new System.Drawing.Size(1062, 136);
            this.staffGroupbox.TabIndex = 0;
            this.staffGroupbox.TabStop = false;
            this.staffGroupbox.Text = "Staff Information";
            // 
            // staffTableLayout
            // 
            this.staffTableLayout.AutoScroll = true;
            this.staffTableLayout.ColumnCount = 2;
            this.staffTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.staffTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.staffTableLayout.Controls.Add(this.statusInfobox, 0, 1);
            this.staffTableLayout.Controls.Add(this.departmentInfobox, 0, 0);
            this.staffTableLayout.Controls.Add(this.roleInfobox, 1, 0);
            this.staffTableLayout.Controls.Add(this.passwordInfobox, 0, 1);
            this.staffTableLayout.Dock = System.Windows.Forms.DockStyle.Top;
            this.staffTableLayout.Location = new System.Drawing.Point(3, 39);
            this.staffTableLayout.Name = "staffTableLayout";
            this.staffTableLayout.RowCount = 2;
            this.staffTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.staffTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.staffTableLayout.Size = new System.Drawing.Size(1056, 90);
            this.staffTableLayout.TabIndex = 0;
            // 
            // TableLayout
            // 
            this.TableLayout.ColumnCount = 2;
            this.TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayout.Controls.Add(this.addressGroupbox, 1, 0);
            this.TableLayout.Controls.Add(this.personalGroupbox, 0, 0);
            this.TableLayout.Dock = System.Windows.Forms.DockStyle.Top;
            this.TableLayout.Location = new System.Drawing.Point(0, 0);
            this.TableLayout.Name = "TableLayout";
            this.TableLayout.RowCount = 1;
            this.TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 68.53933F));
            this.TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 378F));
            this.TableLayout.Size = new System.Drawing.Size(1062, 378);
            this.TableLayout.TabIndex = 0;
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
            this.addressGroupbox.Location = new System.Drawing.Point(534, 3);
            this.addressGroupbox.Name = "addressGroupbox";
            this.addressGroupbox.Size = new System.Drawing.Size(525, 372);
            this.addressGroupbox.TabIndex = 1;
            this.addressGroupbox.TabStop = false;
            this.addressGroupbox.Text = "Address Information";
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
            this.personalGroupbox.Size = new System.Drawing.Size(525, 372);
            this.personalGroupbox.TabIndex = 0;
            this.personalGroupbox.TabStop = false;
            this.personalGroupbox.Text = "Personal Information";
            // 
            // FlowLayout
            // 
            this.FlowLayout.AutoSize = true;
            this.FlowLayout.Controls.Add(this.saveBtn);
            this.FlowLayout.Controls.Add(this.modifyBtn);
            this.FlowLayout.Controls.Add(this.cancelBtn);
            this.FlowLayout.Controls.Add(this.deleteBtn);
            this.FlowLayout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FlowLayout.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.FlowLayout.Location = new System.Drawing.Point(0, 515);
            this.FlowLayout.Name = "FlowLayout";
            this.FlowLayout.Size = new System.Drawing.Size(1062, 51);
            this.FlowLayout.TabIndex = 5;
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
            // statusInfobox
            // 
            this.statusInfobox.BackColorActiveState = System.Drawing.Color.Empty;
            this.statusInfobox.BackColorButton = System.Drawing.Color.White;
            this.statusInfobox.BackColorInactiveState = System.Drawing.Color.Empty;
            this.statusInfobox.ColumnWidth0 = 145F;
            this.statusInfobox.Dock = System.Windows.Forms.DockStyle.Top;
            this.statusInfobox.ForeColorButton = System.Drawing.Color.White;
            this.statusInfobox.LabelButton = "";
            this.statusInfobox.LabelText = "Status";
            this.statusInfobox.Location = new System.Drawing.Point(531, 47);
            this.statusInfobox.Name = "statusInfobox";
            this.statusInfobox.Size = new System.Drawing.Size(522, 35);
            this.statusInfobox.Status = 0;
            this.statusInfobox.TabIndex = 9;
            // 
            // departmentInfobox
            // 
            this.departmentInfobox.ColumnWidth0 = 145F;
            this.departmentInfobox.ComboboxText = "";
            this.departmentInfobox.DataSource = null;
            this.departmentInfobox.DisplayMember = "";
            this.departmentInfobox.Dock = System.Windows.Forms.DockStyle.Top;
            this.departmentInfobox.LabelText = "Department ";
            this.departmentInfobox.Location = new System.Drawing.Point(3, 3);
            this.departmentInfobox.Name = "departmentInfobox";
            this.departmentInfobox.SelectedValue = null;
            this.departmentInfobox.Size = new System.Drawing.Size(522, 35);
            this.departmentInfobox.TabIndex = 0;
            this.departmentInfobox.ValueMemeber = "";
            // 
            // roleInfobox
            // 
            this.roleInfobox.ColumnWidth0 = 145F;
            this.roleInfobox.ComboboxText = "";
            this.roleInfobox.DataSource = null;
            this.roleInfobox.DisplayMember = "";
            this.roleInfobox.Dock = System.Windows.Forms.DockStyle.Top;
            this.roleInfobox.LabelText = "Role";
            this.roleInfobox.Location = new System.Drawing.Point(531, 3);
            this.roleInfobox.Name = "roleInfobox";
            this.roleInfobox.SelectedValue = null;
            this.roleInfobox.Size = new System.Drawing.Size(522, 35);
            this.roleInfobox.TabIndex = 1;
            this.roleInfobox.ValueMemeber = "";
            // 
            // passwordInfobox
            // 
            this.passwordInfobox.ColumnWidth0 = 145F;
            this.passwordInfobox.Dock = System.Windows.Forms.DockStyle.Top;
            this.passwordInfobox.LabelText = "Password";
            this.passwordInfobox.Location = new System.Drawing.Point(3, 47);
            this.passwordInfobox.Name = "passwordInfobox";
            this.passwordInfobox.Size = new System.Drawing.Size(522, 35);
            this.passwordInfobox.TabIndex = 2;
            this.passwordInfobox.TextboxPasswordChar = '*';
            this.passwordInfobox.TextboxText = "";
            // 
            // countryInfobox
            // 
            this.countryInfobox.ColumnWidth0 = 145F;
            this.countryInfobox.Dock = System.Windows.Forms.DockStyle.Top;
            this.countryInfobox.LabelText = "Country";
            this.countryInfobox.Location = new System.Drawing.Point(3, 214);
            this.countryInfobox.Name = "countryInfobox";
            this.countryInfobox.Size = new System.Drawing.Size(519, 35);
            this.countryInfobox.TabIndex = 35;
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
            this.zipcodeInfobox.Size = new System.Drawing.Size(519, 35);
            this.zipcodeInfobox.TabIndex = 34;
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
            this.provinceInfobox.Size = new System.Drawing.Size(519, 35);
            this.provinceInfobox.TabIndex = 33;
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
            this.cityInfobox.Size = new System.Drawing.Size(519, 35);
            this.cityInfobox.TabIndex = 32;
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
            this.address2Infobox.Size = new System.Drawing.Size(519, 35);
            this.address2Infobox.TabIndex = 31;
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
            this.address1Infobox.Size = new System.Drawing.Size(519, 35);
            this.address1Infobox.TabIndex = 17;
            this.address1Infobox.TextboxPasswordChar = '\0';
            this.address1Infobox.TextboxText = "";
            // 
            // numberInfobox
            // 
            this.numberInfobox.ColumnWidth0 = 145F;
            this.numberInfobox.Dock = System.Windows.Forms.DockStyle.Top;
            this.numberInfobox.LabelText = "Contact Number";
            this.numberInfobox.Location = new System.Drawing.Point(3, 319);
            this.numberInfobox.Name = "numberInfobox";
            this.numberInfobox.Size = new System.Drawing.Size(519, 35);
            this.numberInfobox.TabIndex = 12;
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
            this.emailInfobox.Size = new System.Drawing.Size(519, 35);
            this.emailInfobox.TabIndex = 10;
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
            this.religionInfobox.Size = new System.Drawing.Size(519, 35);
            this.religionInfobox.TabIndex = 9;
            this.religionInfobox.TextboxPasswordChar = '\0';
            this.religionInfobox.TextboxText = "";
            // 
            // genderInfobox
            // 
            this.genderInfobox.ColumnWidth0 = 145F;
            this.genderInfobox.Dock = System.Windows.Forms.DockStyle.Top;
            this.genderInfobox.ForeColor = System.Drawing.Color.Black;
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
            this.genderInfobox.Size = new System.Drawing.Size(519, 70);
            this.genderInfobox.TabIndex = 36;
            this.genderInfobox.TextboxEnabled = true;
            this.genderInfobox.TextboxText = "";
            // 
            // birthdateInfobox
            // 
            this.birthdateInfobox.ColumnWidth0 = 145F;
            this.birthdateInfobox.DateText = new System.DateTime(2021, 11, 29, 21, 16, 31, 560);
            this.birthdateInfobox.Dock = System.Windows.Forms.DockStyle.Top;
            this.birthdateInfobox.LabelText = "Birthdate";
            this.birthdateInfobox.Location = new System.Drawing.Point(3, 144);
            this.birthdateInfobox.Name = "birthdateInfobox";
            this.birthdateInfobox.Size = new System.Drawing.Size(519, 35);
            this.birthdateInfobox.TabIndex = 5;
            // 
            // lastnameInfobox
            // 
            this.lastnameInfobox.ColumnWidth0 = 145F;
            this.lastnameInfobox.Dock = System.Windows.Forms.DockStyle.Top;
            this.lastnameInfobox.LabelText = "Lastname";
            this.lastnameInfobox.Location = new System.Drawing.Point(3, 109);
            this.lastnameInfobox.Name = "lastnameInfobox";
            this.lastnameInfobox.Size = new System.Drawing.Size(519, 35);
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
            this.middlenameInfobox.Size = new System.Drawing.Size(519, 35);
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
            this.firstnameInfobox.Size = new System.Drawing.Size(519, 35);
            this.firstnameInfobox.TabIndex = 0;
            this.firstnameInfobox.TextboxPasswordChar = '\0';
            this.firstnameInfobox.TextboxText = "";
            // 
            // FormEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1080, 636);
            this.Controls.Add(this.employeeForm);
            this.Name = "FormEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.employeeForm.ResumeLayout(false);
            this.employeePanel.ResumeLayout(false);
            this.employeePanel.PerformLayout();
            this.staffGroupbox.ResumeLayout(false);
            this.staffTableLayout.ResumeLayout(false);
            this.TableLayout.ResumeLayout(false);
            this.addressGroupbox.ResumeLayout(false);
            this.personalGroupbox.ResumeLayout(false);
            this.FlowLayout.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox employeeForm;
        private System.Windows.Forms.Panel employeePanel;
        private System.Windows.Forms.TableLayoutPanel TableLayout;
        private System.Windows.Forms.GroupBox personalGroupbox;
        private gui.components.InformationTextbox firstnameInfobox;
        private gui.components.InformationTextbox numberInfobox;
        private gui.components.InformationTextbox emailInfobox;
        private gui.components.InformationTextbox religionInfobox;
        private gui.components.InformationDateTimePicker birthdateInfobox;
        private gui.components.InformationTextbox lastnameInfobox;
        private gui.components.InformationTextbox middlenameInfobox;
        private System.Windows.Forms.GroupBox addressGroupbox;
        private gui.components.InformationTextbox address1Infobox;
        private System.Windows.Forms.FlowLayoutPanel FlowLayout;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button modifyBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button deleteBtn;
        private gui.components.InformationTextbox countryInfobox;
        private gui.components.InformationTextbox zipcodeInfobox;
        private gui.components.InformationTextbox provinceInfobox;
        private gui.components.InformationTextbox cityInfobox;
        private gui.components.InformationTextbox address2Infobox;
        private System.Windows.Forms.GroupBox staffGroupbox;
        private System.Windows.Forms.TableLayoutPanel staffTableLayout;
        private gui.components.InformationComboBox departmentInfobox;
        private gui.components.InformationComboBox roleInfobox;
        private gui.components.InformationTextbox passwordInfobox;
        private gui.components.InformationRadio genderInfobox;
        private gui.components.InformationCheckBox statusInfobox;
    }
}