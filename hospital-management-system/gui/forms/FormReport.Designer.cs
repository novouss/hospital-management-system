namespace hospital_management_system.gui.forms
{
    partial class formReport
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
            this.labIdInfobox = new hospital_management_system.gui.components.InformationComboBox();
            this.empIdInfobox = new hospital_management_system.gui.components.InformationComboBox();
            this.deptIdInfobox = new hospital_management_system.gui.components.InformationComboBox();
            this.registrataionIdInfobox = new hospital_management_system.gui.components.InformationComboBox();
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
            this.appointmentPanel.Controls.Add(this.labIdInfobox);
            this.appointmentPanel.Controls.Add(this.empIdInfobox);
            this.appointmentPanel.Controls.Add(this.deptIdInfobox);
            this.appointmentPanel.Controls.Add(this.registrataionIdInfobox);
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
            this.resultInfobox.TabIndex = 10;
            this.resultInfobox.TextboxPasswordChar = '\0';
            this.resultInfobox.TextboxText = "";
            // 
            // labIdInfobox
            // 
            this.labIdInfobox.ColumnWidth0 = 200F;
            this.labIdInfobox.ComboboxText = "";
            this.labIdInfobox.DataSource = null;
            this.labIdInfobox.DisplayMember = "";
            this.labIdInfobox.Dock = System.Windows.Forms.DockStyle.Top;
            this.labIdInfobox.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.labIdInfobox.LabelText = "Laboratory ID";
            this.labIdInfobox.Location = new System.Drawing.Point(0, 105);
            this.labIdInfobox.Margin = new System.Windows.Forms.Padding(2);
            this.labIdInfobox.Name = "labIdInfobox";
            this.labIdInfobox.SelectedValue = null;
            this.labIdInfobox.Size = new System.Drawing.Size(482, 35);
            this.labIdInfobox.TabIndex = 9;
            this.labIdInfobox.ValueMemeber = "";
            // 
            // empIdInfobox
            // 
            this.empIdInfobox.ColumnWidth0 = 200F;
            this.empIdInfobox.ComboboxText = "";
            this.empIdInfobox.DataSource = null;
            this.empIdInfobox.DisplayMember = "";
            this.empIdInfobox.Dock = System.Windows.Forms.DockStyle.Top;
            this.empIdInfobox.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.empIdInfobox.LabelText = "Employee ID";
            this.empIdInfobox.Location = new System.Drawing.Point(0, 70);
            this.empIdInfobox.Margin = new System.Windows.Forms.Padding(2);
            this.empIdInfobox.Name = "empIdInfobox";
            this.empIdInfobox.SelectedValue = null;
            this.empIdInfobox.Size = new System.Drawing.Size(482, 35);
            this.empIdInfobox.TabIndex = 8;
            this.empIdInfobox.ValueMemeber = "";
            // 
            // deptIdInfobox
            // 
            this.deptIdInfobox.ColumnWidth0 = 200F;
            this.deptIdInfobox.ComboboxText = "";
            this.deptIdInfobox.DataSource = null;
            this.deptIdInfobox.DisplayMember = "";
            this.deptIdInfobox.Dock = System.Windows.Forms.DockStyle.Top;
            this.deptIdInfobox.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.deptIdInfobox.LabelText = "Department ID";
            this.deptIdInfobox.Location = new System.Drawing.Point(0, 35);
            this.deptIdInfobox.Margin = new System.Windows.Forms.Padding(2);
            this.deptIdInfobox.Name = "deptIdInfobox";
            this.deptIdInfobox.SelectedValue = null;
            this.deptIdInfobox.Size = new System.Drawing.Size(482, 35);
            this.deptIdInfobox.TabIndex = 13;
            this.deptIdInfobox.ValueMemeber = "";
            // 
            // registrataionIdInfobox
            // 
            this.registrataionIdInfobox.ColumnWidth0 = 200F;
            this.registrataionIdInfobox.ComboboxText = "";
            this.registrataionIdInfobox.DataSource = null;
            this.registrataionIdInfobox.DisplayMember = "";
            this.registrataionIdInfobox.Dock = System.Windows.Forms.DockStyle.Top;
            this.registrataionIdInfobox.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.registrataionIdInfobox.LabelText = "Registration ID";
            this.registrataionIdInfobox.Location = new System.Drawing.Point(0, 0);
            this.registrataionIdInfobox.Margin = new System.Windows.Forms.Padding(2);
            this.registrataionIdInfobox.Name = "registrataionIdInfobox";
            this.registrataionIdInfobox.SelectedValue = null;
            this.registrataionIdInfobox.Size = new System.Drawing.Size(482, 35);
            this.registrataionIdInfobox.TabIndex = 7;
            this.registrataionIdInfobox.ValueMemeber = "";
            //this.registrataionIdInfobox.Load += new System.EventHandler(this.registrataionIdInfobox_Load);
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
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.White;
            this.cancelBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cancelBtn.FlatAppearance.BorderSize = 0;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cancelBtn.ForeColor = System.Drawing.Color.Black;
            this.cancelBtn.Location = new System.Drawing.Point(131, 3);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(112, 45);
            this.cancelBtn.TabIndex = 4;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = false;
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
            // 
            // formReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 535);
            this.Controls.Add(this.reportForm);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "formReport";
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
        private components.InformationComboBox registrataionIdInfobox;
        private components.InformationComboBox labIdInfobox;
        private components.InformationComboBox empIdInfobox;
        private components.InformationTextbox resultInfobox;
        private components.InformationComboBox deptIdInfobox;
    }
}