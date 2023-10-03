namespace hospital_management_system
{
    partial class FormReport
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
            this.reportForm = new System.Windows.Forms.GroupBox();
            this.appointmentPanel = new System.Windows.Forms.Panel();
            this.resultInfobox = new hospital_management_system.gui.components.InformationTextbox();
            this.labButtonbox = new hospital_management_system.gui.components.InformationButtonbox();
            this.employeeButtonbox = new hospital_management_system.gui.components.InformationButtonbox();
            this.departmentCombobox = new hospital_management_system.gui.components.InformationComboBox();
            this.regButtonbox = new hospital_management_system.gui.components.InformationButtonbox();
            this.buttonFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.saveBtn = new System.Windows.Forms.Button();
            this.modifyBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.reportForm.SuspendLayout();
            this.appointmentPanel.SuspendLayout();
            this.buttonFlowLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportForm
            // 
            this.reportForm.AutoSize = true;
            this.reportForm.BackColor = System.Drawing.Color.White;
            this.reportForm.Controls.Add(this.appointmentPanel);
            this.reportForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportForm.Font = new System.Drawing.Font("Segoe UI", 36F);
            this.reportForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(132)))), ((int)(((byte)(222)))));
            this.reportForm.Location = new System.Drawing.Point(0, 0);
            this.reportForm.Name = "reportForm";
            this.reportForm.Padding = new System.Windows.Forms.Padding(9, 3, 9, 3);
            this.reportForm.Size = new System.Drawing.Size(500, 535);
            this.reportForm.TabIndex = 9;
            this.reportForm.TabStop = false;
            this.reportForm.Text = "{function}_report";
            // 
            // appointmentPanel
            // 
            this.appointmentPanel.AutoScroll = true;
            this.appointmentPanel.Controls.Add(this.resultInfobox);
            this.appointmentPanel.Controls.Add(this.labButtonbox);
            this.appointmentPanel.Controls.Add(this.employeeButtonbox);
            this.appointmentPanel.Controls.Add(this.departmentCombobox);
            this.appointmentPanel.Controls.Add(this.regButtonbox);
            this.appointmentPanel.Controls.Add(this.buttonFlowLayout);
            this.appointmentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.appointmentPanel.Location = new System.Drawing.Point(9, 67);
            this.appointmentPanel.Name = "appointmentPanel";
            this.appointmentPanel.Size = new System.Drawing.Size(482, 465);
            this.appointmentPanel.TabIndex = 3;
            // 
            // resultInfobox
            // 
            this.resultInfobox.ColumnWidth0 = 200F;
            this.resultInfobox.Dock = System.Windows.Forms.DockStyle.Top;
            this.resultInfobox.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.resultInfobox.LabelText = "Result";
            this.resultInfobox.Location = new System.Drawing.Point(0, 140);
            this.resultInfobox.Margin = new System.Windows.Forms.Padding(2);
            this.resultInfobox.Name = "resultInfobox";
            this.resultInfobox.Size = new System.Drawing.Size(482, 35);
            this.resultInfobox.TabIndex = 18;
            this.resultInfobox.TextboxPasswordChar = '\0';
            this.resultInfobox.TextboxText = "";
            // 
            // labButtonbox
            // 
            this.labButtonbox.BackColorMainButton = System.Drawing.Color.RoyalBlue;
            this.labButtonbox.BackColorSubButton = System.Drawing.Color.RoyalBlue;
            this.labButtonbox.ColumnWidth0 = 200F;
            this.labButtonbox.ColumnWidth1 = 193F;
            this.labButtonbox.Dock = System.Windows.Forms.DockStyle.Top;
            this.labButtonbox.EnabledMainButton = true;
            this.labButtonbox.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.labButtonbox.ForeColorMainButton = System.Drawing.Color.White;
            this.labButtonbox.ForeColorSubButton = System.Drawing.Color.White;
            this.labButtonbox.Location = new System.Drawing.Point(0, 105);
            this.labButtonbox.Margin = new System.Windows.Forms.Padding(0);
            this.labButtonbox.Name = "labButtonbox";
            this.labButtonbox.Size = new System.Drawing.Size(482, 35);
            this.labButtonbox.TabIndex = 17;
            this.labButtonbox.TextLabel1 = "Select Laboratory";
            this.labButtonbox.TextMainButton = "Choose";
            this.labButtonbox.TextSubButton = "View Laboratory";
            this.labButtonbox.Value = null;
            this.labButtonbox.VisibleMainButton = true;
            this.labButtonbox.VisibleSubButton = true;
            // 
            // employeeButtonbox
            // 
            this.employeeButtonbox.BackColorMainButton = System.Drawing.Color.RoyalBlue;
            this.employeeButtonbox.BackColorSubButton = System.Drawing.Color.RoyalBlue;
            this.employeeButtonbox.ColumnWidth0 = 200F;
            this.employeeButtonbox.ColumnWidth1 = 193F;
            this.employeeButtonbox.Dock = System.Windows.Forms.DockStyle.Top;
            this.employeeButtonbox.EnabledMainButton = true;
            this.employeeButtonbox.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.employeeButtonbox.ForeColorMainButton = System.Drawing.Color.White;
            this.employeeButtonbox.ForeColorSubButton = System.Drawing.Color.White;
            this.employeeButtonbox.Location = new System.Drawing.Point(0, 70);
            this.employeeButtonbox.Margin = new System.Windows.Forms.Padding(0);
            this.employeeButtonbox.Name = "employeeButtonbox";
            this.employeeButtonbox.Size = new System.Drawing.Size(482, 35);
            this.employeeButtonbox.TabIndex = 16;
            this.employeeButtonbox.TextLabel1 = "Select Employee";
            this.employeeButtonbox.TextMainButton = "Choose";
            this.employeeButtonbox.TextSubButton = "View Employee";
            this.employeeButtonbox.Value = null;
            this.employeeButtonbox.VisibleMainButton = true;
            this.employeeButtonbox.VisibleSubButton = true;
            // 
            // departmentCombobox
            // 
            this.departmentCombobox.ColumnWidth0 = 200F;
            this.departmentCombobox.ComboboxText = "";
            this.departmentCombobox.DataSource = null;
            this.departmentCombobox.DisplayMember = "";
            this.departmentCombobox.Dock = System.Windows.Forms.DockStyle.Top;
            this.departmentCombobox.LabelText = "Select Department";
            this.departmentCombobox.Location = new System.Drawing.Point(0, 35);
            this.departmentCombobox.Name = "departmentCombobox";
            this.departmentCombobox.SelectedValue = null;
            this.departmentCombobox.Size = new System.Drawing.Size(482, 35);
            this.departmentCombobox.TabIndex = 19;
            this.departmentCombobox.ValueMemeber = "";
            // 
            // regButtonbox
            // 
            this.regButtonbox.BackColorMainButton = System.Drawing.Color.RoyalBlue;
            this.regButtonbox.BackColorSubButton = System.Drawing.Color.RoyalBlue;
            this.regButtonbox.ColumnWidth0 = 200F;
            this.regButtonbox.ColumnWidth1 = 193F;
            this.regButtonbox.Dock = System.Windows.Forms.DockStyle.Top;
            this.regButtonbox.EnabledMainButton = true;
            this.regButtonbox.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.regButtonbox.ForeColorMainButton = System.Drawing.Color.White;
            this.regButtonbox.ForeColorSubButton = System.Drawing.Color.White;
            this.regButtonbox.Location = new System.Drawing.Point(0, 0);
            this.regButtonbox.Margin = new System.Windows.Forms.Padding(0);
            this.regButtonbox.Name = "regButtonbox";
            this.regButtonbox.Size = new System.Drawing.Size(482, 35);
            this.regButtonbox.TabIndex = 14;
            this.regButtonbox.TextLabel1 = "Select Registration";
            this.regButtonbox.TextMainButton = "Choose";
            this.regButtonbox.TextSubButton = "View Registration";
            this.regButtonbox.Value = null;
            this.regButtonbox.VisibleMainButton = true;
            this.regButtonbox.VisibleSubButton = true;
            // 
            // buttonFlowLayout
            // 
            this.buttonFlowLayout.Controls.Add(this.saveBtn);
            this.buttonFlowLayout.Controls.Add(this.modifyBtn);
            this.buttonFlowLayout.Controls.Add(this.cancelBtn);
            this.buttonFlowLayout.Controls.Add(this.deleteBtn);
            this.buttonFlowLayout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonFlowLayout.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.buttonFlowLayout.Location = new System.Drawing.Point(0, 414);
            this.buttonFlowLayout.Name = "buttonFlowLayout";
            this.buttonFlowLayout.Size = new System.Drawing.Size(482, 51);
            this.buttonFlowLayout.TabIndex = 5;
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(132)))), ((int)(((byte)(222)))));
            this.saveBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(132)))), ((int)(((byte)(222)))));
            this.saveBtn.FlatAppearance.BorderSize = 0;
            this.saveBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(132)))), ((int)(((byte)(222)))));
            this.saveBtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.Location = new System.Drawing.Point(367, 3);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(112, 45);
            this.saveBtn.TabIndex = 3;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = false;
            // 
            // modifyBtn
            // 
            this.modifyBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(132)))), ((int)(((byte)(222)))));
            this.modifyBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(132)))), ((int)(((byte)(222)))));
            this.modifyBtn.FlatAppearance.BorderSize = 0;
            this.modifyBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(132)))), ((int)(((byte)(222)))));
            this.modifyBtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.modifyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modifyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.modifyBtn.ForeColor = System.Drawing.Color.White;
            this.modifyBtn.Location = new System.Drawing.Point(249, 3);
            this.modifyBtn.Name = "modifyBtn";
            this.modifyBtn.Size = new System.Drawing.Size(112, 45);
            this.modifyBtn.TabIndex = 6;
            this.modifyBtn.Text = "Modify";
            this.modifyBtn.UseVisualStyleBackColor = false;
            this.modifyBtn.Click += new System.EventHandler(this.modifyBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(132)))), ((int)(((byte)(222)))));
            this.cancelBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cancelBtn.FlatAppearance.BorderSize = 0;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cancelBtn.ForeColor = System.Drawing.Color.White;
            this.cancelBtn.Location = new System.Drawing.Point(131, 3);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(112, 45);
            this.cancelBtn.TabIndex = 4;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.deleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.deleteBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.deleteBtn.FlatAppearance.BorderSize = 0;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.deleteBtn.ForeColor = System.Drawing.Color.White;
            this.deleteBtn.Location = new System.Drawing.Point(13, 3);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(112, 45);
            this.deleteBtn.TabIndex = 5;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // FormReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 535);
            this.Controls.Add(this.reportForm);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormReport";
            this.reportForm.ResumeLayout(false);
            this.appointmentPanel.ResumeLayout(false);
            this.buttonFlowLayout.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox reportForm;
        private System.Windows.Forms.Panel appointmentPanel;
        private System.Windows.Forms.FlowLayoutPanel buttonFlowLayout;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button modifyBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button deleteBtn;
        private gui.components.InformationTextbox resultInfobox;
        private gui.components.InformationButtonbox labButtonbox;
        private gui.components.InformationButtonbox employeeButtonbox;
        private gui.components.InformationButtonbox regButtonbox;
        private gui.components.InformationComboBox departmentCombobox;
    }
}