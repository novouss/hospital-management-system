
namespace hospital_management_system.gui.forms
{
    partial class FormTreatments
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
            this.clearBtnTreatments = new System.Windows.Forms.Button();
            this.backBtnTreatments = new System.Windows.Forms.Button();
            this.patientDetailsGroup = new System.Windows.Forms.GroupBox();
            this.findingsCommentsPanel = new System.Windows.Forms.Panel();
            this.saveBtnTreatments = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.findingsCommentsLabel = new System.Windows.Forms.Label();
            this.infoPanel = new System.Windows.Forms.TableLayoutPanel();
            this.labNoPanel = new System.Windows.Forms.Panel();
            this.labNoTextbox = new System.Windows.Forms.TextBox();
            this.labNoLabel = new System.Windows.Forms.Label();
            this.roomNoPanel = new System.Windows.Forms.Panel();
            this.roomNoTextbox = new System.Windows.Forms.TextBox();
            this.roomNoLabel = new System.Windows.Forms.Label();
            this.empIdPanel = new System.Windows.Forms.Panel();
            this.empIdTextbox = new System.Windows.Forms.TextBox();
            this.empIdLabel = new System.Windows.Forms.Label();
            this.reportIdPanel = new System.Windows.Forms.Panel();
            this.reportIdTextbox = new System.Windows.Forms.TextBox();
            this.reportIdLabel = new System.Windows.Forms.Label();
            this.viewForm = new System.Windows.Forms.GroupBox();
            this.patientDetailsGroup.SuspendLayout();
            this.findingsCommentsPanel.SuspendLayout();
            this.infoPanel.SuspendLayout();
            this.labNoPanel.SuspendLayout();
            this.roomNoPanel.SuspendLayout();
            this.empIdPanel.SuspendLayout();
            this.reportIdPanel.SuspendLayout();
            this.viewForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // clearBtnTreatments
            // 
            this.clearBtnTreatments.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clearBtnTreatments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(132)))), ((int)(((byte)(222)))));
            this.clearBtnTreatments.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(132)))), ((int)(((byte)(222)))));
            this.clearBtnTreatments.FlatAppearance.BorderSize = 0;
            this.clearBtnTreatments.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(132)))), ((int)(((byte)(222)))));
            this.clearBtnTreatments.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.clearBtnTreatments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearBtnTreatments.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.clearBtnTreatments.ForeColor = System.Drawing.Color.White;
            this.clearBtnTreatments.Location = new System.Drawing.Point(1060, 515);
            this.clearBtnTreatments.Margin = new System.Windows.Forms.Padding(4);
            this.clearBtnTreatments.Name = "clearBtnTreatments";
            this.clearBtnTreatments.Size = new System.Drawing.Size(168, 55);
            this.clearBtnTreatments.TabIndex = 9;
            this.clearBtnTreatments.Text = "Clear";
            this.clearBtnTreatments.UseVisualStyleBackColor = false;
            this.clearBtnTreatments.Click += new System.EventHandler(this.clearBtnTreatments_Click);
            // 
            // backBtnTreatments
            // 
            this.backBtnTreatments.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.backBtnTreatments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(132)))), ((int)(((byte)(222)))));
            this.backBtnTreatments.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(132)))), ((int)(((byte)(222)))));
            this.backBtnTreatments.FlatAppearance.BorderSize = 0;
            this.backBtnTreatments.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(132)))), ((int)(((byte)(222)))));
            this.backBtnTreatments.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.backBtnTreatments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtnTreatments.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.backBtnTreatments.ForeColor = System.Drawing.Color.White;
            this.backBtnTreatments.Location = new System.Drawing.Point(884, 515);
            this.backBtnTreatments.Margin = new System.Windows.Forms.Padding(4);
            this.backBtnTreatments.Name = "backBtnTreatments";
            this.backBtnTreatments.Size = new System.Drawing.Size(168, 55);
            this.backBtnTreatments.TabIndex = 7;
            this.backBtnTreatments.Text = "Back";
            this.backBtnTreatments.UseVisualStyleBackColor = false;
            this.backBtnTreatments.Click += new System.EventHandler(this.backBtnTreatments_Click);
            // 
            // patientDetailsGroup
            // 
            this.patientDetailsGroup.BackColor = System.Drawing.Color.White;
            this.patientDetailsGroup.Controls.Add(this.findingsCommentsPanel);
            this.patientDetailsGroup.Controls.Add(this.infoPanel);
            this.patientDetailsGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.patientDetailsGroup.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.patientDetailsGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(132)))), ((int)(((byte)(222)))));
            this.patientDetailsGroup.Location = new System.Drawing.Point(12, 84);
            this.patientDetailsGroup.Margin = new System.Windows.Forms.Padding(4);
            this.patientDetailsGroup.Name = "patientDetailsGroup";
            this.patientDetailsGroup.Padding = new System.Windows.Forms.Padding(4);
            this.patientDetailsGroup.Size = new System.Drawing.Size(1416, 798);
            this.patientDetailsGroup.TabIndex = 1;
            this.patientDetailsGroup.TabStop = false;
            this.patientDetailsGroup.Text = "Patient Details";
            // 
            // findingsCommentsPanel
            // 
            this.findingsCommentsPanel.Controls.Add(this.clearBtnTreatments);
            this.findingsCommentsPanel.Controls.Add(this.saveBtnTreatments);
            this.findingsCommentsPanel.Controls.Add(this.backBtnTreatments);
            this.findingsCommentsPanel.Controls.Add(this.textBox2);
            this.findingsCommentsPanel.Controls.Add(this.label1);
            this.findingsCommentsPanel.Controls.Add(this.textBox1);
            this.findingsCommentsPanel.Controls.Add(this.findingsCommentsLabel);
            this.findingsCommentsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.findingsCommentsPanel.Location = new System.Drawing.Point(4, 202);
            this.findingsCommentsPanel.Margin = new System.Windows.Forms.Padding(4);
            this.findingsCommentsPanel.Name = "findingsCommentsPanel";
            this.findingsCommentsPanel.Size = new System.Drawing.Size(1408, 592);
            this.findingsCommentsPanel.TabIndex = 4;
            this.findingsCommentsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.findingsCommentsPanel_Paint);
            // 
            // saveBtnTreatments
            // 
            this.saveBtnTreatments.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.saveBtnTreatments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(132)))), ((int)(((byte)(222)))));
            this.saveBtnTreatments.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(132)))), ((int)(((byte)(222)))));
            this.saveBtnTreatments.FlatAppearance.BorderSize = 0;
            this.saveBtnTreatments.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(132)))), ((int)(((byte)(222)))));
            this.saveBtnTreatments.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.saveBtnTreatments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtnTreatments.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.saveBtnTreatments.ForeColor = System.Drawing.Color.White;
            this.saveBtnTreatments.Location = new System.Drawing.Point(1236, 516);
            this.saveBtnTreatments.Margin = new System.Windows.Forms.Padding(4);
            this.saveBtnTreatments.Name = "saveBtnTreatments";
            this.saveBtnTreatments.Size = new System.Drawing.Size(168, 55);
            this.saveBtnTreatments.TabIndex = 8;
            this.saveBtnTreatments.Text = "Save";
            this.saveBtnTreatments.UseVisualStyleBackColor = false;
            this.saveBtnTreatments.Click += new System.EventHandler(this.saveBtnTreatments_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBox2.Location = new System.Drawing.Point(5, 289);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(1400, 200);
            this.textBox2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.Location = new System.Drawing.Point(8, 258);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "Prescribe Medicine";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBox1.Location = new System.Drawing.Point(5, 38);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1400, 200);
            this.textBox1.TabIndex = 4;
            // 
            // findingsCommentsLabel
            // 
            this.findingsCommentsLabel.AutoSize = true;
            this.findingsCommentsLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.findingsCommentsLabel.Location = new System.Drawing.Point(5, 7);
            this.findingsCommentsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.findingsCommentsLabel.Name = "findingsCommentsLabel";
            this.findingsCommentsLabel.Size = new System.Drawing.Size(198, 28);
            this.findingsCommentsLabel.TabIndex = 3;
            this.findingsCommentsLabel.Text = "Findings / Comments";
            // 
            // infoPanel
            // 
            this.infoPanel.ColumnCount = 2;
            this.infoPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.infoPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.infoPanel.Controls.Add(this.labNoPanel, 1, 1);
            this.infoPanel.Controls.Add(this.roomNoPanel, 0, 1);
            this.infoPanel.Controls.Add(this.empIdPanel, 1, 0);
            this.infoPanel.Controls.Add(this.reportIdPanel, 0, 0);
            this.infoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.infoPanel.Location = new System.Drawing.Point(4, 49);
            this.infoPanel.Margin = new System.Windows.Forms.Padding(4);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.RowCount = 2;
            this.infoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.infoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.infoPanel.Size = new System.Drawing.Size(1408, 153);
            this.infoPanel.TabIndex = 0;
            // 
            // labNoPanel
            // 
            this.labNoPanel.Controls.Add(this.labNoTextbox);
            this.labNoPanel.Controls.Add(this.labNoLabel);
            this.labNoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labNoPanel.Location = new System.Drawing.Point(707, 79);
            this.labNoPanel.Margin = new System.Windows.Forms.Padding(4);
            this.labNoPanel.Name = "labNoPanel";
            this.labNoPanel.Size = new System.Drawing.Size(697, 70);
            this.labNoPanel.TabIndex = 4;
            // 
            // labNoTextbox
            // 
            this.labNoTextbox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labNoTextbox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labNoTextbox.Location = new System.Drawing.Point(0, 36);
            this.labNoTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.labNoTextbox.Name = "labNoTextbox";
            this.labNoTextbox.Size = new System.Drawing.Size(697, 34);
            this.labNoTextbox.TabIndex = 5;
            // 
            // labNoLabel
            // 
            this.labNoLabel.AutoSize = true;
            this.labNoLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labNoLabel.Location = new System.Drawing.Point(4, 7);
            this.labNoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labNoLabel.Name = "labNoLabel";
            this.labNoLabel.Size = new System.Drawing.Size(79, 28);
            this.labNoLabel.TabIndex = 4;
            this.labNoLabel.Text = "Lab No.";
            // 
            // roomNoPanel
            // 
            this.roomNoPanel.Controls.Add(this.roomNoTextbox);
            this.roomNoPanel.Controls.Add(this.roomNoLabel);
            this.roomNoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roomNoPanel.Location = new System.Drawing.Point(4, 79);
            this.roomNoPanel.Margin = new System.Windows.Forms.Padding(4);
            this.roomNoPanel.Name = "roomNoPanel";
            this.roomNoPanel.Size = new System.Drawing.Size(695, 70);
            this.roomNoPanel.TabIndex = 3;
            // 
            // roomNoTextbox
            // 
            this.roomNoTextbox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.roomNoTextbox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.roomNoTextbox.Location = new System.Drawing.Point(0, 36);
            this.roomNoTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.roomNoTextbox.Name = "roomNoTextbox";
            this.roomNoTextbox.Size = new System.Drawing.Size(695, 34);
            this.roomNoTextbox.TabIndex = 4;
            // 
            // roomNoLabel
            // 
            this.roomNoLabel.AutoSize = true;
            this.roomNoLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.roomNoLabel.Location = new System.Drawing.Point(4, 7);
            this.roomNoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.roomNoLabel.Name = "roomNoLabel";
            this.roomNoLabel.Size = new System.Drawing.Size(100, 28);
            this.roomNoLabel.TabIndex = 3;
            this.roomNoLabel.Text = "Room No.";
            // 
            // empIdPanel
            // 
            this.empIdPanel.Controls.Add(this.empIdTextbox);
            this.empIdPanel.Controls.Add(this.empIdLabel);
            this.empIdPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.empIdPanel.Location = new System.Drawing.Point(707, 4);
            this.empIdPanel.Margin = new System.Windows.Forms.Padding(4);
            this.empIdPanel.Name = "empIdPanel";
            this.empIdPanel.Size = new System.Drawing.Size(697, 67);
            this.empIdPanel.TabIndex = 1;
            // 
            // empIdTextbox
            // 
            this.empIdTextbox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.empIdTextbox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.empIdTextbox.Location = new System.Drawing.Point(0, 33);
            this.empIdTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.empIdTextbox.Name = "empIdTextbox";
            this.empIdTextbox.Size = new System.Drawing.Size(697, 34);
            this.empIdTextbox.TabIndex = 2;
            // 
            // empIdLabel
            // 
            this.empIdLabel.AutoSize = true;
            this.empIdLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.empIdLabel.Location = new System.Drawing.Point(4, 7);
            this.empIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.empIdLabel.Name = "empIdLabel";
            this.empIdLabel.Size = new System.Drawing.Size(122, 28);
            this.empIdLabel.TabIndex = 1;
            this.empIdLabel.Text = "Employee ID";
            // 
            // reportIdPanel
            // 
            this.reportIdPanel.Controls.Add(this.reportIdTextbox);
            this.reportIdPanel.Controls.Add(this.reportIdLabel);
            this.reportIdPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportIdPanel.Location = new System.Drawing.Point(4, 4);
            this.reportIdPanel.Margin = new System.Windows.Forms.Padding(4);
            this.reportIdPanel.Name = "reportIdPanel";
            this.reportIdPanel.Size = new System.Drawing.Size(695, 67);
            this.reportIdPanel.TabIndex = 0;
            // 
            // reportIdTextbox
            // 
            this.reportIdTextbox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.reportIdTextbox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.reportIdTextbox.Location = new System.Drawing.Point(0, 33);
            this.reportIdTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.reportIdTextbox.Name = "reportIdTextbox";
            this.reportIdTextbox.Size = new System.Drawing.Size(695, 34);
            this.reportIdTextbox.TabIndex = 1;
            // 
            // reportIdLabel
            // 
            this.reportIdLabel.AutoSize = true;
            this.reportIdLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.reportIdLabel.Location = new System.Drawing.Point(4, 7);
            this.reportIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.reportIdLabel.Name = "reportIdLabel";
            this.reportIdLabel.Size = new System.Drawing.Size(95, 28);
            this.reportIdLabel.TabIndex = 0;
            this.reportIdLabel.Text = "Report ID";
            // 
            // viewForm
            // 
            this.viewForm.AutoSize = true;
            this.viewForm.Controls.Add(this.patientDetailsGroup);
            this.viewForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewForm.Font = new System.Drawing.Font("Segoe UI", 36F);
            this.viewForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(132)))), ((int)(((byte)(222)))));
            this.viewForm.Location = new System.Drawing.Point(0, 0);
            this.viewForm.Margin = new System.Windows.Forms.Padding(4);
            this.viewForm.Name = "viewForm";
            this.viewForm.Padding = new System.Windows.Forms.Padding(12, 4, 12, 4);
            this.viewForm.Size = new System.Drawing.Size(1440, 886);
            this.viewForm.TabIndex = 8;
            this.viewForm.TabStop = false;
            this.viewForm.Text = "{function}_patient";
            // 
            // FormTreatments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 886);
            this.Controls.Add(this.viewForm);
            this.Name = "FormTreatments";
            this.Text = "FormTreatments";
            this.patientDetailsGroup.ResumeLayout(false);
            this.findingsCommentsPanel.ResumeLayout(false);
            this.findingsCommentsPanel.PerformLayout();
            this.infoPanel.ResumeLayout(false);
            this.labNoPanel.ResumeLayout(false);
            this.labNoPanel.PerformLayout();
            this.roomNoPanel.ResumeLayout(false);
            this.roomNoPanel.PerformLayout();
            this.empIdPanel.ResumeLayout(false);
            this.empIdPanel.PerformLayout();
            this.reportIdPanel.ResumeLayout(false);
            this.reportIdPanel.PerformLayout();
            this.viewForm.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button clearBtnTreatments;
        private System.Windows.Forms.Button backBtnTreatments;
        private System.Windows.Forms.GroupBox patientDetailsGroup;
        private System.Windows.Forms.Panel findingsCommentsPanel;
        private System.Windows.Forms.Button saveBtnTreatments;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label findingsCommentsLabel;
        private System.Windows.Forms.TableLayoutPanel infoPanel;
        private System.Windows.Forms.Panel labNoPanel;
        private System.Windows.Forms.TextBox labNoTextbox;
        private System.Windows.Forms.Label labNoLabel;
        private System.Windows.Forms.Panel roomNoPanel;
        private System.Windows.Forms.TextBox roomNoTextbox;
        private System.Windows.Forms.Label roomNoLabel;
        private System.Windows.Forms.Panel empIdPanel;
        private System.Windows.Forms.TextBox empIdTextbox;
        private System.Windows.Forms.Label empIdLabel;
        private System.Windows.Forms.Panel reportIdPanel;
        private System.Windows.Forms.TextBox reportIdTextbox;
        private System.Windows.Forms.Label reportIdLabel;
        private System.Windows.Forms.GroupBox viewForm;
    }
}