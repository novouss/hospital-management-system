
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
            this.modifiedOnInfobox = new hospital_management_system.gui.components.InformationDateTimePicker();
            this.createdOnInfobox = new hospital_management_system.gui.components.InformationDateTimePicker();
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
            this.reportForm.Controls.Add(this.appointmentPanel);
            this.reportForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportForm.Font = new System.Drawing.Font("Segoe UI", 36F);
            this.reportForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(132)))), ((int)(((byte)(222)))));
            this.reportForm.Location = new System.Drawing.Point(0, 0);
            this.reportForm.Margin = new System.Windows.Forms.Padding(4);
            this.reportForm.Name = "reportForm";
            this.reportForm.Padding = new System.Windows.Forms.Padding(12, 4, 12, 4);
            this.reportForm.Size = new System.Drawing.Size(667, 658);
            this.reportForm.TabIndex = 9;
            this.reportForm.TabStop = false;
            this.reportForm.Text = "{function}_report";
            // 
            // appointmentPanel
            // 
            this.appointmentPanel.AutoScroll = true;
            this.appointmentPanel.Controls.Add(this.modifiedOnInfobox);
            this.appointmentPanel.Controls.Add(this.createdOnInfobox);
            this.appointmentPanel.Controls.Add(this.resultInfobox);
            this.appointmentPanel.Controls.Add(this.labIdInfobox);
            this.appointmentPanel.Controls.Add(this.empIdInfobox);
            this.appointmentPanel.Controls.Add(this.deptIdInfobox);
            this.appointmentPanel.Controls.Add(this.registrataionIdInfobox);
            this.appointmentPanel.Controls.Add(this.buttonFlowLayout);
            this.appointmentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.appointmentPanel.Location = new System.Drawing.Point(12, 84);
            this.appointmentPanel.Margin = new System.Windows.Forms.Padding(4);
            this.appointmentPanel.Name = "appointmentPanel";
            this.appointmentPanel.Size = new System.Drawing.Size(643, 570);
            this.appointmentPanel.TabIndex = 3;
            // 
            // modifiedOnInfobox
            // 
            this.modifiedOnInfobox.ColumnWidth0 = 200F;
            this.modifiedOnInfobox.Dock = System.Windows.Forms.DockStyle.Top;
            this.modifiedOnInfobox.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.modifiedOnInfobox.LabelText = "Modified On";
            this.modifiedOnInfobox.Location = new System.Drawing.Point(0, 258);
            this.modifiedOnInfobox.Name = "modifiedOnInfobox";
            this.modifiedOnInfobox.Size = new System.Drawing.Size(643, 43);
            this.modifiedOnInfobox.TabIndex = 12;
            // 
            // createdOnInfobox
            // 
            this.createdOnInfobox.ColumnWidth0 = 200F;
            this.createdOnInfobox.Dock = System.Windows.Forms.DockStyle.Top;
            this.createdOnInfobox.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.createdOnInfobox.LabelText = "Created On";
            this.createdOnInfobox.Location = new System.Drawing.Point(0, 215);
            this.createdOnInfobox.Name = "createdOnInfobox";
            this.createdOnInfobox.Size = new System.Drawing.Size(643, 43);
            this.createdOnInfobox.TabIndex = 11;
            // 
            // resultInfobox
            // 
            this.resultInfobox.ColumnWidth0 = 200F;
            this.resultInfobox.Dock = System.Windows.Forms.DockStyle.Top;
            this.resultInfobox.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.resultInfobox.LabelText = "Result";
            this.resultInfobox.Location = new System.Drawing.Point(0, 172);
            this.resultInfobox.Name = "resultInfobox";
            this.resultInfobox.Size = new System.Drawing.Size(643, 43);
            this.resultInfobox.TabIndex = 10;
            this.resultInfobox.TextboxText = "";
            // 
            // labIdInfobox
            // 
            this.labIdInfobox.ColumnWidth0 = 200F;
            this.labIdInfobox.Dock = System.Windows.Forms.DockStyle.Top;
            this.labIdInfobox.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.labIdInfobox.LabelText = "Laboratory ID";
            this.labIdInfobox.Location = new System.Drawing.Point(0, 129);
            this.labIdInfobox.Name = "labIdInfobox";
            this.labIdInfobox.Size = new System.Drawing.Size(643, 43);
            this.labIdInfobox.TabIndex = 9;
            // 
            // empIdInfobox
            // 
            this.empIdInfobox.ColumnWidth0 = 200F;
            this.empIdInfobox.Dock = System.Windows.Forms.DockStyle.Top;
            this.empIdInfobox.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.empIdInfobox.LabelText = "Employee ID";
            this.empIdInfobox.Location = new System.Drawing.Point(0, 86);
            this.empIdInfobox.Name = "empIdInfobox";
            this.empIdInfobox.Size = new System.Drawing.Size(643, 43);
            this.empIdInfobox.TabIndex = 8;
            // 
            // deptIdInfobox
            // 
            this.deptIdInfobox.ColumnWidth0 = 200F;
            this.deptIdInfobox.Dock = System.Windows.Forms.DockStyle.Top;
            this.deptIdInfobox.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.deptIdInfobox.LabelText = "Department ID";
            this.deptIdInfobox.Location = new System.Drawing.Point(0, 43);
            this.deptIdInfobox.Name = "deptIdInfobox";
            this.deptIdInfobox.Size = new System.Drawing.Size(643, 43);
            this.deptIdInfobox.TabIndex = 13;
            // 
            // registrataionIdInfobox
            // 
            this.registrataionIdInfobox.ColumnWidth0 = 200F;
            this.registrataionIdInfobox.Dock = System.Windows.Forms.DockStyle.Top;
            this.registrataionIdInfobox.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.registrataionIdInfobox.LabelText = "Registration ID";
            this.registrataionIdInfobox.Location = new System.Drawing.Point(0, 0);
            this.registrataionIdInfobox.Name = "registrataionIdInfobox";
            this.registrataionIdInfobox.Size = new System.Drawing.Size(643, 43);
            this.registrataionIdInfobox.TabIndex = 7;
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
            this.buttonFlowLayout.Margin = new System.Windows.Forms.Padding(4);
            this.buttonFlowLayout.Name = "buttonFlowLayout";
            this.buttonFlowLayout.Size = new System.Drawing.Size(643, 63);
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
            this.saveBtn.Location = new System.Drawing.Point(489, 4);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(4);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(150, 55);
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
            this.modifyBtn.Location = new System.Drawing.Point(331, 4);
            this.modifyBtn.Margin = new System.Windows.Forms.Padding(4);
            this.modifyBtn.Name = "modifyBtn";
            this.modifyBtn.Size = new System.Drawing.Size(150, 55);
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
            this.cancelBtn.Location = new System.Drawing.Point(173, 4);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(4);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(150, 55);
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
            this.deleteBtn.Location = new System.Drawing.Point(15, 4);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(4);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(150, 55);
            this.deleteBtn.TabIndex = 5;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = false;
            // 
            // formReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 658);
            this.Controls.Add(this.reportForm);
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
        private components.InformationDateTimePicker modifiedOnInfobox;
        private components.InformationDateTimePicker createdOnInfobox;
        private components.InformationComboBox deptIdInfobox;
    }
}