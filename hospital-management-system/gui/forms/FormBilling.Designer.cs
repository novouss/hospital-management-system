
namespace hospital_management_system
{
    partial class FormBilling
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
            this.billingForm = new System.Windows.Forms.GroupBox();
            this.billingPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.billingDetails = new System.Windows.Forms.GroupBox();
            this.totalInfobox = new hospital_management_system.gui.components.InformationTextbox();
            this.depInfobox = new hospital_management_system.gui.components.InformationTextbox();
            this.labInfobox = new hospital_management_system.gui.components.InformationTextbox();
            this.roomInfobox = new hospital_management_system.gui.components.InformationTextbox();
            this.statusInfobox = new hospital_management_system.gui.components.InformationComboBox();
            this.regIdInfobox = new hospital_management_system.gui.components.InformationTextbox();
            this.billIdInfobox = new hospital_management_system.gui.components.InformationTextbox();
            this.patientBilling = new System.Windows.Forms.GroupBox();
            this.buttonFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.saveBtn = new System.Windows.Forms.Button();
            this.modifyBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.billingForm.SuspendLayout();
            this.billingPanel.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.billingDetails.SuspendLayout();
            this.buttonFlowLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // billingForm
            // 
            this.billingForm.AutoSize = true;
            this.billingForm.BackColor = System.Drawing.Color.White;
            this.billingForm.Controls.Add(this.billingPanel);
            this.billingForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.billingForm.Font = new System.Drawing.Font("Segoe UI", 36F);
            this.billingForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(132)))), ((int)(((byte)(222)))));
            this.billingForm.Location = new System.Drawing.Point(0, 0);
            this.billingForm.Name = "billingForm";
            this.billingForm.Padding = new System.Windows.Forms.Padding(9, 3, 9, 3);
            this.billingForm.Size = new System.Drawing.Size(1080, 628);
            this.billingForm.TabIndex = 5;
            this.billingForm.TabStop = false;
            this.billingForm.Text = "{function}_billing";
            // 
            // billingPanel
            // 
            this.billingPanel.AutoScroll = true;
            this.billingPanel.Controls.Add(this.tableLayoutPanel3);
            this.billingPanel.Controls.Add(this.buttonFlowLayout);
            this.billingPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.billingPanel.Location = new System.Drawing.Point(9, 67);
            this.billingPanel.Name = "billingPanel";
            this.billingPanel.Size = new System.Drawing.Size(1062, 558);
            this.billingPanel.TabIndex = 3;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.billingDetails, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.patientBilling, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1062, 295);
            this.tableLayoutPanel3.TabIndex = 17;
            // 
            // billingDetails
            // 
            this.billingDetails.Controls.Add(this.totalInfobox);
            this.billingDetails.Controls.Add(this.depInfobox);
            this.billingDetails.Controls.Add(this.labInfobox);
            this.billingDetails.Controls.Add(this.roomInfobox);
            this.billingDetails.Controls.Add(this.statusInfobox);
            this.billingDetails.Controls.Add(this.regIdInfobox);
            this.billingDetails.Controls.Add(this.billIdInfobox);
            this.billingDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.billingDetails.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.billingDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(132)))), ((int)(((byte)(222)))));
            this.billingDetails.Location = new System.Drawing.Point(3, 3);
            this.billingDetails.Name = "billingDetails";
            this.billingDetails.Size = new System.Drawing.Size(525, 289);
            this.billingDetails.TabIndex = 15;
            this.billingDetails.TabStop = false;
            this.billingDetails.Text = "Billing Details";
            // 
            // totalInfobox
            // 
            this.totalInfobox.ColumnWidth0 = 170F;
            this.totalInfobox.Dock = System.Windows.Forms.DockStyle.Top;
            this.totalInfobox.LabelText = "Total";
            this.totalInfobox.Location = new System.Drawing.Point(3, 249);
            this.totalInfobox.Name = "totalInfobox";
            this.totalInfobox.Size = new System.Drawing.Size(519, 35);
            this.totalInfobox.TabIndex = 6;
            this.totalInfobox.TextboxPasswordChar = '\0';
            this.totalInfobox.TextboxText = "";
            // 
            // depInfobox
            // 
            this.depInfobox.ColumnWidth0 = 170F;
            this.depInfobox.Dock = System.Windows.Forms.DockStyle.Top;
            this.depInfobox.LabelText = "Department Charge";
            this.depInfobox.Location = new System.Drawing.Point(3, 214);
            this.depInfobox.Name = "depInfobox";
            this.depInfobox.Size = new System.Drawing.Size(519, 35);
            this.depInfobox.TabIndex = 5;
            this.depInfobox.TextboxPasswordChar = '\0';
            this.depInfobox.TextboxText = "";
            // 
            // labInfobox
            // 
            this.labInfobox.ColumnWidth0 = 170F;
            this.labInfobox.Dock = System.Windows.Forms.DockStyle.Top;
            this.labInfobox.LabelText = "Laboratory Charge";
            this.labInfobox.Location = new System.Drawing.Point(3, 179);
            this.labInfobox.Name = "labInfobox";
            this.labInfobox.Size = new System.Drawing.Size(519, 35);
            this.labInfobox.TabIndex = 4;
            this.labInfobox.TextboxPasswordChar = '\0';
            this.labInfobox.TextboxText = "";
            // 
            // roomInfobox
            // 
            this.roomInfobox.ColumnWidth0 = 170F;
            this.roomInfobox.Dock = System.Windows.Forms.DockStyle.Top;
            this.roomInfobox.LabelText = "Room Charge";
            this.roomInfobox.Location = new System.Drawing.Point(3, 144);
            this.roomInfobox.Name = "roomInfobox";
            this.roomInfobox.Size = new System.Drawing.Size(519, 35);
            this.roomInfobox.TabIndex = 3;
            this.roomInfobox.TextboxPasswordChar = '\0';
            this.roomInfobox.TextboxText = "";
            // 
            // statusInfobox
            // 
            this.statusInfobox.ColumnWidth0 = 170F;
            this.statusInfobox.ComboboxText = "";
            this.statusInfobox.DataSource = null;
            this.statusInfobox.DisplayMember = "";
            this.statusInfobox.Dock = System.Windows.Forms.DockStyle.Top;
            this.statusInfobox.LabelText = "Status";
            this.statusInfobox.Location = new System.Drawing.Point(3, 109);
            this.statusInfobox.Name = "statusInfobox";
            this.statusInfobox.SelectedValue = null;
            this.statusInfobox.Size = new System.Drawing.Size(519, 35);
            this.statusInfobox.TabIndex = 2;
            this.statusInfobox.ValueMemeber = "";
            // 
            // regIdInfobox
            // 
            this.regIdInfobox.ColumnWidth0 = 170F;
            this.regIdInfobox.Dock = System.Windows.Forms.DockStyle.Top;
            this.regIdInfobox.LabelText = "Registration Number";
            this.regIdInfobox.Location = new System.Drawing.Point(3, 74);
            this.regIdInfobox.Name = "regIdInfobox";
            this.regIdInfobox.Size = new System.Drawing.Size(519, 35);
            this.regIdInfobox.TabIndex = 1;
            this.regIdInfobox.TextboxPasswordChar = '\0';
            this.regIdInfobox.TextboxText = "";
            // 
            // billIdInfobox
            // 
            this.billIdInfobox.ColumnWidth0 = 170F;
            this.billIdInfobox.Dock = System.Windows.Forms.DockStyle.Top;
            this.billIdInfobox.LabelText = "Billing ID";
            this.billIdInfobox.Location = new System.Drawing.Point(3, 39);
            this.billIdInfobox.Name = "billIdInfobox";
            this.billIdInfobox.Size = new System.Drawing.Size(519, 35);
            this.billIdInfobox.TabIndex = 0;
            this.billIdInfobox.TextboxPasswordChar = '\0';
            this.billIdInfobox.TextboxText = "";
            // 
            // patientBilling
            // 
            this.patientBilling.Dock = System.Windows.Forms.DockStyle.Fill;
            this.patientBilling.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.patientBilling.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(132)))), ((int)(((byte)(222)))));
            this.patientBilling.Location = new System.Drawing.Point(534, 3);
            this.patientBilling.Name = "patientBilling";
            this.patientBilling.Size = new System.Drawing.Size(525, 289);
            this.patientBilling.TabIndex = 16;
            this.patientBilling.TabStop = false;
            this.patientBilling.Text = "Patient Details";
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
            // FormBilling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1080, 628);
            this.Controls.Add(this.billingForm);
            this.Name = "FormBilling";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.billingForm.ResumeLayout(false);
            this.billingPanel.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.billingDetails.ResumeLayout(false);
            this.buttonFlowLayout.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox billingForm;
        private System.Windows.Forms.Panel billingPanel;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.FlowLayoutPanel buttonFlowLayout;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button modifyBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.GroupBox billingDetails;
        private System.Windows.Forms.GroupBox patientBilling;
        private gui.components.InformationTextbox billIdInfobox;
        private gui.components.InformationTextbox regIdInfobox;
        private gui.components.InformationComboBox statusInfobox;
        private gui.components.InformationTextbox totalInfobox;
        private gui.components.InformationTextbox depInfobox;
        private gui.components.InformationTextbox labInfobox;
        private gui.components.InformationTextbox roomInfobox;
    }
}