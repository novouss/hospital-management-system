
namespace experimental_hospital_management_system
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
            this.billingDetails = new System.Windows.Forms.GroupBox();
            this.buttonFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.saveBtn = new System.Windows.Forms.Button();
            this.modifyBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.totalInfobox = new experimental_hospital_management_system.gui.components.InformationTextbox();
            this.depInfobox = new experimental_hospital_management_system.gui.components.InformationTextbox();
            this.labInfobox = new experimental_hospital_management_system.gui.components.InformationTextbox();
            this.roomInfobox = new experimental_hospital_management_system.gui.components.InformationTextbox();
            this.statusInfobox = new experimental_hospital_management_system.gui.components.InformationCheckBox();
            this.regButtonbox = new experimental_hospital_management_system.gui.components.InformationButtonbox();
            this.billingForm.SuspendLayout();
            this.billingPanel.SuspendLayout();
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
            this.billingForm.Size = new System.Drawing.Size(509, 524);
            this.billingForm.TabIndex = 5;
            this.billingForm.TabStop = false;
            this.billingForm.Text = "{function}_billing";
            // 
            // billingPanel
            // 
            this.billingPanel.AutoScroll = true;
            this.billingPanel.Controls.Add(this.billingDetails);
            this.billingPanel.Controls.Add(this.buttonFlowLayout);
            this.billingPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.billingPanel.Location = new System.Drawing.Point(9, 67);
            this.billingPanel.Name = "billingPanel";
            this.billingPanel.Size = new System.Drawing.Size(491, 454);
            this.billingPanel.TabIndex = 3;
            // 
            // billingDetails
            // 
            this.billingDetails.Controls.Add(this.totalInfobox);
            this.billingDetails.Controls.Add(this.depInfobox);
            this.billingDetails.Controls.Add(this.labInfobox);
            this.billingDetails.Controls.Add(this.roomInfobox);
            this.billingDetails.Controls.Add(this.statusInfobox);
            this.billingDetails.Controls.Add(this.regButtonbox);
            this.billingDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.billingDetails.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.billingDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(132)))), ((int)(((byte)(222)))));
            this.billingDetails.Location = new System.Drawing.Point(0, 0);
            this.billingDetails.Name = "billingDetails";
            this.billingDetails.Size = new System.Drawing.Size(491, 403);
            this.billingDetails.TabIndex = 16;
            this.billingDetails.TabStop = false;
            this.billingDetails.Text = "Billing Details";
            // 
            // buttonFlowLayout
            // 
            this.buttonFlowLayout.Controls.Add(this.saveBtn);
            this.buttonFlowLayout.Controls.Add(this.modifyBtn);
            this.buttonFlowLayout.Controls.Add(this.cancelBtn);
            this.buttonFlowLayout.Controls.Add(this.deleteBtn);
            this.buttonFlowLayout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonFlowLayout.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.buttonFlowLayout.Location = new System.Drawing.Point(0, 403);
            this.buttonFlowLayout.Name = "buttonFlowLayout";
            this.buttonFlowLayout.Size = new System.Drawing.Size(491, 51);
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
            this.saveBtn.Location = new System.Drawing.Point(376, 3);
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
            this.modifyBtn.Location = new System.Drawing.Point(258, 3);
            this.modifyBtn.Name = "modifyBtn";
            this.modifyBtn.Size = new System.Drawing.Size(112, 45);
            this.modifyBtn.TabIndex = 7;
            this.modifyBtn.Text = "Modify";
            this.modifyBtn.UseVisualStyleBackColor = false;
            this.modifyBtn.Click += new System.EventHandler(this.modifyBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(138)))), ((int)(((byte)(222)))));
            this.cancelBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cancelBtn.FlatAppearance.BorderSize = 0;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cancelBtn.ForeColor = System.Drawing.Color.White;
            this.cancelBtn.Location = new System.Drawing.Point(140, 3);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(112, 45);
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
            this.deleteBtn.Location = new System.Drawing.Point(22, 3);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(112, 45);
            this.deleteBtn.TabIndex = 5;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // totalInfobox
            // 
            this.totalInfobox.ColumnWidth0 = 200F;
            this.totalInfobox.Dock = System.Windows.Forms.DockStyle.Top;
            this.totalInfobox.Enabled = false;
            this.totalInfobox.LabelText = "Total";
            this.totalInfobox.Location = new System.Drawing.Point(3, 214);
            this.totalInfobox.Name = "totalInfobox";
            this.totalInfobox.Size = new System.Drawing.Size(485, 35);
            this.totalInfobox.TabIndex = 6;
            this.totalInfobox.TextboxPasswordChar = '\0';
            this.totalInfobox.TextboxText = "";
            // 
            // depInfobox
            // 
            this.depInfobox.ColumnWidth0 = 200F;
            this.depInfobox.Dock = System.Windows.Forms.DockStyle.Top;
            this.depInfobox.Enabled = false;
            this.depInfobox.LabelText = "Department Charge";
            this.depInfobox.Location = new System.Drawing.Point(3, 179);
            this.depInfobox.Name = "depInfobox";
            this.depInfobox.Size = new System.Drawing.Size(485, 35);
            this.depInfobox.TabIndex = 5;
            this.depInfobox.TextboxPasswordChar = '\0';
            this.depInfobox.TextboxText = "";
            // 
            // labInfobox
            // 
            this.labInfobox.ColumnWidth0 = 200F;
            this.labInfobox.Dock = System.Windows.Forms.DockStyle.Top;
            this.labInfobox.Enabled = false;
            this.labInfobox.LabelText = "Laboratory Charge";
            this.labInfobox.Location = new System.Drawing.Point(3, 144);
            this.labInfobox.Name = "labInfobox";
            this.labInfobox.Size = new System.Drawing.Size(485, 35);
            this.labInfobox.TabIndex = 4;
            this.labInfobox.TextboxPasswordChar = '\0';
            this.labInfobox.TextboxText = "";
            // 
            // roomInfobox
            // 
            this.roomInfobox.ColumnWidth0 = 200F;
            this.roomInfobox.Dock = System.Windows.Forms.DockStyle.Top;
            this.roomInfobox.Enabled = false;
            this.roomInfobox.LabelText = "Room Charge";
            this.roomInfobox.Location = new System.Drawing.Point(3, 109);
            this.roomInfobox.Name = "roomInfobox";
            this.roomInfobox.Size = new System.Drawing.Size(485, 35);
            this.roomInfobox.TabIndex = 3;
            this.roomInfobox.TextboxPasswordChar = '\0';
            this.roomInfobox.TextboxText = "";
            // 
            // statusInfobox
            // 
            this.statusInfobox.BackColorActiveState = System.Drawing.Color.Empty;
            this.statusInfobox.BackColorButton = System.Drawing.Color.White;
            this.statusInfobox.BackColorInactiveState = System.Drawing.Color.Empty;
            this.statusInfobox.ColumnWidth0 = 200F;
            this.statusInfobox.Dock = System.Windows.Forms.DockStyle.Top;
            this.statusInfobox.ForeColorButton = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(132)))), ((int)(((byte)(222)))));
            this.statusInfobox.LabelButton = "";
            this.statusInfobox.LabelText = "Status";
            this.statusInfobox.Location = new System.Drawing.Point(3, 74);
            this.statusInfobox.Name = "statusInfobox";
            this.statusInfobox.Size = new System.Drawing.Size(485, 35);
            this.statusInfobox.Status = 0;
            this.statusInfobox.TabIndex = 8;
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
            this.regButtonbox.Location = new System.Drawing.Point(3, 39);
            this.regButtonbox.Margin = new System.Windows.Forms.Padding(0);
            this.regButtonbox.Name = "regButtonbox";
            this.regButtonbox.Size = new System.Drawing.Size(485, 35);
            this.regButtonbox.TabIndex = 15;
            this.regButtonbox.TextLabel1 = "Select Registration";
            this.regButtonbox.TextMainButton = "Choose";
            this.regButtonbox.TextSubButton = "View Registration";
            this.regButtonbox.Value = null;
            this.regButtonbox.VisibleMainButton = true;
            this.regButtonbox.VisibleSubButton = true;
            // 
            // FormBilling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(509, 524);
            this.Controls.Add(this.billingForm);
            this.Name = "FormBilling";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.billingForm.ResumeLayout(false);
            this.billingPanel.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox billingDetails;
        private gui.components.InformationTextbox totalInfobox;
        private gui.components.InformationTextbox depInfobox;
        private gui.components.InformationTextbox labInfobox;
        private gui.components.InformationTextbox roomInfobox;
        private gui.components.InformationCheckBox statusInfobox;
        private gui.components.InformationButtonbox regButtonbox;
        private System.Windows.Forms.Button modifyBtn;
    }
}