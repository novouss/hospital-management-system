
namespace hospital_management_system.gui.forms
{
    partial class FormBillings
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
            this.statusPanel = new System.Windows.Forms.Panel();
            this.statusLabel = new System.Windows.Forms.Label();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.labChargeTextBox = new System.Windows.Forms.TextBox();
            this.labChargeLabel = new System.Windows.Forms.Label();
            this.billingPanel = new System.Windows.Forms.Panel();
            this.buttonFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.saveBtn = new System.Windows.Forms.Button();
            this.modifyBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.billingGroup = new System.Windows.Forms.GroupBox();
            this.billingTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.regRoomNumberLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.registrationNumberlabel = new System.Windows.Forms.Label();
            this.registrationTextBox = new System.Windows.Forms.TextBox();
            this.roomNumberLabel = new System.Windows.Forms.Label();
            this.roomNumberTextBox = new System.Windows.Forms.TextBox();
            this.depLabLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.depChargePanel = new System.Windows.Forms.Label();
            this.depChargeTextBox = new System.Windows.Forms.TextBox();
            this.addressContactLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.contactNumberTextBox = new System.Windows.Forms.TextBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.contactNumberLabel = new System.Windows.Forms.Label();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.totalPanel = new System.Windows.Forms.Panel();
            this.totalLabel = new System.Windows.Forms.Label();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.namePanel = new System.Windows.Forms.Panel();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextbox = new System.Windows.Forms.TextBox();
            this.billingForm = new System.Windows.Forms.GroupBox();
            this.resultGroup = new System.Windows.Forms.GroupBox();
            this.resultTextgroup = new System.Windows.Forms.RichTextBox();
            this.statusPanel.SuspendLayout();
            this.billingPanel.SuspendLayout();
            this.buttonFlowLayout.SuspendLayout();
            this.billingGroup.SuspendLayout();
            this.billingTableLayout.SuspendLayout();
            this.regRoomNumberLayoutPanel.SuspendLayout();
            this.depLabLayoutPanel.SuspendLayout();
            this.addressContactLayoutPanel.SuspendLayout();
            this.totalPanel.SuspendLayout();
            this.namePanel.SuspendLayout();
            this.billingForm.SuspendLayout();
            this.resultGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusPanel
            // 
            this.statusPanel.Controls.Add(this.statusLabel);
            this.statusPanel.Controls.Add(this.statusComboBox);
            this.statusPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statusPanel.Location = new System.Drawing.Point(4, 216);
            this.statusPanel.Margin = new System.Windows.Forms.Padding(4);
            this.statusPanel.Name = "statusPanel";
            this.statusPanel.Size = new System.Drawing.Size(661, 98);
            this.statusPanel.TabIndex = 23;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.statusLabel.Location = new System.Drawing.Point(0, 0);
            this.statusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(65, 28);
            this.statusLabel.TabIndex = 9;
            this.statusLabel.Text = "Status";
            // 
            // statusComboBox
            // 
            this.statusComboBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Items.AddRange(new object[] {
            "Inpatient",
            "Outpatient",
            "Checkup",
            "Follow-up Checkup"});
            this.statusComboBox.Location = new System.Drawing.Point(3, 47);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(653, 36);
            this.statusComboBox.TabIndex = 10;
            // 
            // labChargeTextBox
            // 
            this.labChargeTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labChargeTextBox.Location = new System.Drawing.Point(333, 49);
            this.labChargeTextBox.Name = "labChargeTextBox";
            this.labChargeTextBox.Size = new System.Drawing.Size(324, 34);
            this.labChargeTextBox.TabIndex = 7;
            // 
            // labChargeLabel
            // 
            this.labChargeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labChargeLabel.AutoSize = true;
            this.labChargeLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labChargeLabel.Location = new System.Drawing.Point(4, 0);
            this.labChargeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labChargeLabel.Name = "labChargeLabel";
            this.labChargeLabel.Size = new System.Drawing.Size(322, 28);
            this.labChargeLabel.TabIndex = 3;
            this.labChargeLabel.Text = "Laboratory Charge";
            // 
            // billingPanel
            // 
            this.billingPanel.AutoScroll = true;
            this.billingPanel.Controls.Add(this.resultGroup);
            this.billingPanel.Controls.Add(this.buttonFlowLayout);
            this.billingPanel.Controls.Add(this.billingGroup);
            this.billingPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.billingPanel.Location = new System.Drawing.Point(12, 84);
            this.billingPanel.Margin = new System.Windows.Forms.Padding(4);
            this.billingPanel.Name = "billingPanel";
            this.billingPanel.Size = new System.Drawing.Size(1347, 617);
            this.billingPanel.TabIndex = 3;
            // 
            // buttonFlowLayout
            // 
            this.buttonFlowLayout.Controls.Add(this.saveBtn);
            this.buttonFlowLayout.Controls.Add(this.modifyBtn);
            this.buttonFlowLayout.Controls.Add(this.cancelBtn);
            this.buttonFlowLayout.Controls.Add(this.deleteBtn);
            this.buttonFlowLayout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonFlowLayout.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.buttonFlowLayout.Location = new System.Drawing.Point(0, 554);
            this.buttonFlowLayout.Margin = new System.Windows.Forms.Padding(4);
            this.buttonFlowLayout.Name = "buttonFlowLayout";
            this.buttonFlowLayout.Size = new System.Drawing.Size(1347, 63);
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
            this.saveBtn.Location = new System.Drawing.Point(1099, 4);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(4);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(244, 55);
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
            this.modifyBtn.Location = new System.Drawing.Point(847, 4);
            this.modifyBtn.Margin = new System.Windows.Forms.Padding(4);
            this.modifyBtn.Name = "modifyBtn";
            this.modifyBtn.Size = new System.Drawing.Size(244, 55);
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
            this.cancelBtn.Location = new System.Drawing.Point(595, 4);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(4);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(244, 55);
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
            this.deleteBtn.Location = new System.Drawing.Point(343, 4);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(4);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(244, 55);
            this.deleteBtn.TabIndex = 5;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = false;
            // 
            // billingGroup
            // 
            this.billingGroup.BackColor = System.Drawing.SystemColors.Control;
            this.billingGroup.Controls.Add(this.billingTableLayout);
            this.billingGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.billingGroup.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.billingGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(132)))), ((int)(((byte)(222)))));
            this.billingGroup.Location = new System.Drawing.Point(0, 0);
            this.billingGroup.Margin = new System.Windows.Forms.Padding(4);
            this.billingGroup.Name = "billingGroup";
            this.billingGroup.Padding = new System.Windows.Forms.Padding(4);
            this.billingGroup.Size = new System.Drawing.Size(1347, 370);
            this.billingGroup.TabIndex = 1;
            this.billingGroup.TabStop = false;
            this.billingGroup.Text = "Billing Details";
            // 
            // billingTableLayout
            // 
            this.billingTableLayout.ColumnCount = 2;
            this.billingTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.billingTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.billingTableLayout.Controls.Add(this.regRoomNumberLayoutPanel, 1, 1);
            this.billingTableLayout.Controls.Add(this.statusPanel, 0, 2);
            this.billingTableLayout.Controls.Add(this.depLabLayoutPanel, 0, 1);
            this.billingTableLayout.Controls.Add(this.addressContactLayoutPanel, 1, 0);
            this.billingTableLayout.Controls.Add(this.totalPanel, 1, 2);
            this.billingTableLayout.Controls.Add(this.namePanel, 0, 0);
            this.billingTableLayout.Dock = System.Windows.Forms.DockStyle.Top;
            this.billingTableLayout.Location = new System.Drawing.Point(4, 49);
            this.billingTableLayout.Margin = new System.Windows.Forms.Padding(4);
            this.billingTableLayout.Name = "billingTableLayout";
            this.billingTableLayout.RowCount = 3;
            this.billingTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.billingTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.billingTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.billingTableLayout.Size = new System.Drawing.Size(1339, 318);
            this.billingTableLayout.TabIndex = 0;
            // 
            // regRoomNumberLayoutPanel
            // 
            this.regRoomNumberLayoutPanel.ColumnCount = 2;
            this.regRoomNumberLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.regRoomNumberLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.regRoomNumberLayoutPanel.Controls.Add(this.registrationNumberlabel, 0, 0);
            this.regRoomNumberLayoutPanel.Controls.Add(this.registrationTextBox, 0, 1);
            this.regRoomNumberLayoutPanel.Controls.Add(this.roomNumberLabel, 1, 0);
            this.regRoomNumberLayoutPanel.Controls.Add(this.roomNumberTextBox, 0, 1);
            this.regRoomNumberLayoutPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.regRoomNumberLayoutPanel.Location = new System.Drawing.Point(673, 111);
            this.regRoomNumberLayoutPanel.Margin = new System.Windows.Forms.Padding(4);
            this.regRoomNumberLayoutPanel.Name = "regRoomNumberLayoutPanel";
            this.regRoomNumberLayoutPanel.RowCount = 2;
            this.regRoomNumberLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.54099F));
            this.regRoomNumberLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.45901F));
            this.regRoomNumberLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.regRoomNumberLayoutPanel.Size = new System.Drawing.Size(662, 97);
            this.regRoomNumberLayoutPanel.TabIndex = 24;
            // 
            // registrationNumberlabel
            // 
            this.registrationNumberlabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.registrationNumberlabel.AutoSize = true;
            this.registrationNumberlabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.registrationNumberlabel.Location = new System.Drawing.Point(4, 0);
            this.registrationNumberlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.registrationNumberlabel.Name = "registrationNumberlabel";
            this.registrationNumberlabel.Size = new System.Drawing.Size(323, 28);
            this.registrationNumberlabel.TabIndex = 3;
            this.registrationNumberlabel.Text = "Registration Number";
            // 
            // registrationTextBox
            // 
            this.registrationTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.registrationTextBox.Location = new System.Drawing.Point(334, 49);
            this.registrationTextBox.Name = "registrationTextBox";
            this.registrationTextBox.Size = new System.Drawing.Size(324, 34);
            this.registrationTextBox.TabIndex = 7;
            // 
            // roomNumberLabel
            // 
            this.roomNumberLabel.AutoSize = true;
            this.roomNumberLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.roomNumberLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.roomNumberLabel.Location = new System.Drawing.Point(335, 0);
            this.roomNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.roomNumberLabel.Name = "roomNumberLabel";
            this.roomNumberLabel.Size = new System.Drawing.Size(323, 28);
            this.roomNumberLabel.TabIndex = 1;
            this.roomNumberLabel.Text = "Room Number";
            // 
            // roomNumberTextBox
            // 
            this.roomNumberTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.roomNumberTextBox.Location = new System.Drawing.Point(3, 49);
            this.roomNumberTextBox.Name = "roomNumberTextBox";
            this.roomNumberTextBox.Size = new System.Drawing.Size(324, 34);
            this.roomNumberTextBox.TabIndex = 8;
            // 
            // depLabLayoutPanel
            // 
            this.depLabLayoutPanel.ColumnCount = 2;
            this.depLabLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.depLabLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.depLabLayoutPanel.Controls.Add(this.labChargeLabel, 0, 0);
            this.depLabLayoutPanel.Controls.Add(this.labChargeTextBox, 0, 1);
            this.depLabLayoutPanel.Controls.Add(this.depChargePanel, 1, 0);
            this.depLabLayoutPanel.Controls.Add(this.depChargeTextBox, 0, 1);
            this.depLabLayoutPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.depLabLayoutPanel.Location = new System.Drawing.Point(4, 111);
            this.depLabLayoutPanel.Margin = new System.Windows.Forms.Padding(4);
            this.depLabLayoutPanel.Name = "depLabLayoutPanel";
            this.depLabLayoutPanel.RowCount = 2;
            this.depLabLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.54099F));
            this.depLabLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.45901F));
            this.depLabLayoutPanel.Size = new System.Drawing.Size(661, 97);
            this.depLabLayoutPanel.TabIndex = 21;
            // 
            // depChargePanel
            // 
            this.depChargePanel.AutoSize = true;
            this.depChargePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.depChargePanel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.depChargePanel.Location = new System.Drawing.Point(334, 0);
            this.depChargePanel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.depChargePanel.Name = "depChargePanel";
            this.depChargePanel.Size = new System.Drawing.Size(323, 28);
            this.depChargePanel.TabIndex = 1;
            this.depChargePanel.Text = "Department Charge";
            // 
            // depChargeTextBox
            // 
            this.depChargeTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.depChargeTextBox.Location = new System.Drawing.Point(3, 49);
            this.depChargeTextBox.Name = "depChargeTextBox";
            this.depChargeTextBox.Size = new System.Drawing.Size(324, 34);
            this.depChargeTextBox.TabIndex = 8;
            // 
            // addressContactLayoutPanel
            // 
            this.addressContactLayoutPanel.ColumnCount = 2;
            this.addressContactLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.70997F));
            this.addressContactLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.29003F));
            this.addressContactLayoutPanel.Controls.Add(this.contactNumberTextBox, 1, 1);
            this.addressContactLayoutPanel.Controls.Add(this.addressLabel, 0, 0);
            this.addressContactLayoutPanel.Controls.Add(this.contactNumberLabel, 1, 0);
            this.addressContactLayoutPanel.Controls.Add(this.addressTextBox, 0, 1);
            this.addressContactLayoutPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.addressContactLayoutPanel.Location = new System.Drawing.Point(673, 5);
            this.addressContactLayoutPanel.Margin = new System.Windows.Forms.Padding(4);
            this.addressContactLayoutPanel.Name = "addressContactLayoutPanel";
            this.addressContactLayoutPanel.RowCount = 2;
            this.addressContactLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36F));
            this.addressContactLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64F));
            this.addressContactLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.addressContactLayoutPanel.Size = new System.Drawing.Size(662, 97);
            this.addressContactLayoutPanel.TabIndex = 20;
            // 
            // contactNumberTextBox
            // 
            this.contactNumberTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.contactNumberTextBox.Location = new System.Drawing.Point(437, 37);
            this.contactNumberTextBox.Name = "contactNumberTextBox";
            this.contactNumberTextBox.Size = new System.Drawing.Size(222, 34);
            this.contactNumberTextBox.TabIndex = 11;
            // 
            // addressLabel
            // 
            this.addressLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.addressLabel.Location = new System.Drawing.Point(4, 0);
            this.addressLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(426, 28);
            this.addressLabel.TabIndex = 3;
            this.addressLabel.Text = "Address";
            // 
            // contactNumberLabel
            // 
            this.contactNumberLabel.AutoSize = true;
            this.contactNumberLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.contactNumberLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.contactNumberLabel.Location = new System.Drawing.Point(438, 0);
            this.contactNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.contactNumberLabel.Name = "contactNumberLabel";
            this.contactNumberLabel.Size = new System.Drawing.Size(220, 28);
            this.contactNumberLabel.TabIndex = 1;
            this.contactNumberLabel.Text = "Contact Number";
            // 
            // addressTextBox
            // 
            this.addressTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.addressTextBox.Location = new System.Drawing.Point(3, 37);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(428, 34);
            this.addressTextBox.TabIndex = 8;
            // 
            // totalPanel
            // 
            this.totalPanel.Controls.Add(this.totalLabel);
            this.totalPanel.Controls.Add(this.totalTextBox);
            this.totalPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.totalPanel.Location = new System.Drawing.Point(673, 216);
            this.totalPanel.Margin = new System.Windows.Forms.Padding(4);
            this.totalPanel.Name = "totalPanel";
            this.totalPanel.Size = new System.Drawing.Size(662, 98);
            this.totalPanel.TabIndex = 18;
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.totalLabel.Location = new System.Drawing.Point(4, 0);
            this.totalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(54, 28);
            this.totalLabel.TabIndex = 8;
            this.totalLabel.Text = "Total";
            // 
            // totalTextBox
            // 
            this.totalTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.totalTextBox.Location = new System.Drawing.Point(3, 47);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.Size = new System.Drawing.Size(653, 34);
            this.totalTextBox.TabIndex = 7;
            // 
            // namePanel
            // 
            this.namePanel.Controls.Add(this.nameLabel);
            this.namePanel.Controls.Add(this.nameTextbox);
            this.namePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.namePanel.Location = new System.Drawing.Point(4, 4);
            this.namePanel.Margin = new System.Windows.Forms.Padding(4);
            this.namePanel.Name = "namePanel";
            this.namePanel.Size = new System.Drawing.Size(661, 98);
            this.namePanel.TabIndex = 0;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.nameLabel.Location = new System.Drawing.Point(4, 6);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(100, 28);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Full Name";
            // 
            // nameTextbox
            // 
            this.nameTextbox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.nameTextbox.Location = new System.Drawing.Point(5, 38);
            this.nameTextbox.Name = "nameTextbox";
            this.nameTextbox.Size = new System.Drawing.Size(653, 34);
            this.nameTextbox.TabIndex = 5;
            // 
            // billingForm
            // 
            this.billingForm.AutoSize = true;
            this.billingForm.Controls.Add(this.billingPanel);
            this.billingForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.billingForm.Font = new System.Drawing.Font("Segoe UI", 36F);
            this.billingForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(132)))), ((int)(((byte)(222)))));
            this.billingForm.Location = new System.Drawing.Point(0, 0);
            this.billingForm.Margin = new System.Windows.Forms.Padding(4);
            this.billingForm.Name = "billingForm";
            this.billingForm.Padding = new System.Windows.Forms.Padding(12, 4, 12, 4);
            this.billingForm.Size = new System.Drawing.Size(1371, 705);
            this.billingForm.TabIndex = 13;
            this.billingForm.TabStop = false;
            this.billingForm.Text = "{function}_appointment";
            // 
            // resultGroup
            // 
            this.resultGroup.Controls.Add(this.resultTextgroup);
            this.resultGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.resultGroup.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.resultGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(132)))), ((int)(((byte)(222)))));
            this.resultGroup.Location = new System.Drawing.Point(0, 370);
            this.resultGroup.Margin = new System.Windows.Forms.Padding(4);
            this.resultGroup.Name = "resultGroup";
            this.resultGroup.Padding = new System.Windows.Forms.Padding(4);
            this.resultGroup.Size = new System.Drawing.Size(1347, 136);
            this.resultGroup.TabIndex = 7;
            this.resultGroup.TabStop = false;
            this.resultGroup.Text = "Laboratory Results";
            // 
            // resultTextgroup
            // 
            this.resultTextgroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.resultTextgroup.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.resultTextgroup.Location = new System.Drawing.Point(4, 49);
            this.resultTextgroup.Margin = new System.Windows.Forms.Padding(4);
            this.resultTextgroup.Name = "resultTextgroup";
            this.resultTextgroup.Size = new System.Drawing.Size(1339, 79);
            this.resultTextgroup.TabIndex = 1;
            this.resultTextgroup.Text = "";
            // 
            // FormBillings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 705);
            this.Controls.Add(this.billingForm);
            this.Name = "FormBillings";
            this.Text = "Form1";
            this.statusPanel.ResumeLayout(false);
            this.statusPanel.PerformLayout();
            this.billingPanel.ResumeLayout(false);
            this.buttonFlowLayout.ResumeLayout(false);
            this.billingGroup.ResumeLayout(false);
            this.billingTableLayout.ResumeLayout(false);
            this.regRoomNumberLayoutPanel.ResumeLayout(false);
            this.regRoomNumberLayoutPanel.PerformLayout();
            this.depLabLayoutPanel.ResumeLayout(false);
            this.depLabLayoutPanel.PerformLayout();
            this.addressContactLayoutPanel.ResumeLayout(false);
            this.addressContactLayoutPanel.PerformLayout();
            this.totalPanel.ResumeLayout(false);
            this.totalPanel.PerformLayout();
            this.namePanel.ResumeLayout(false);
            this.namePanel.PerformLayout();
            this.billingForm.ResumeLayout(false);
            this.resultGroup.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel statusPanel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.TextBox labChargeTextBox;
        private System.Windows.Forms.Label labChargeLabel;
        private System.Windows.Forms.Panel billingPanel;
        private System.Windows.Forms.FlowLayoutPanel buttonFlowLayout;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button modifyBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.GroupBox billingGroup;
        private System.Windows.Forms.TableLayoutPanel billingTableLayout;
        private System.Windows.Forms.TableLayoutPanel regRoomNumberLayoutPanel;
        private System.Windows.Forms.Label registrationNumberlabel;
        private System.Windows.Forms.TextBox registrationTextBox;
        private System.Windows.Forms.Label roomNumberLabel;
        private System.Windows.Forms.TextBox roomNumberTextBox;
        private System.Windows.Forms.TableLayoutPanel depLabLayoutPanel;
        private System.Windows.Forms.Label depChargePanel;
        private System.Windows.Forms.TextBox depChargeTextBox;
        private System.Windows.Forms.TableLayoutPanel addressContactLayoutPanel;
        private System.Windows.Forms.TextBox contactNumberTextBox;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label contactNumberLabel;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Panel totalPanel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.Panel namePanel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextbox;
        private System.Windows.Forms.GroupBox billingForm;
        private System.Windows.Forms.GroupBox resultGroup;
        private System.Windows.Forms.RichTextBox resultTextgroup;
    }
}