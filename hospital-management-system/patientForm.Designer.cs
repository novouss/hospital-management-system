
namespace hospital_management_system
{
    partial class patientForm
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
            this.overview_group = new System.Windows.Forms.GroupBox();
            this.overview_flowlayout = new System.Windows.Forms.FlowLayoutPanel();
            this.overview_group.SuspendLayout();
            this.SuspendLayout();
            // 
            // overview_group
            // 
            this.overview_group.Controls.Add(this.overview_flowlayout);
            this.overview_group.Dock = System.Windows.Forms.DockStyle.Fill;
            this.overview_group.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.overview_group.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(132)))), ((int)(((byte)(222)))));
            this.overview_group.Location = new System.Drawing.Point(0, 0);
            this.overview_group.Name = "overview_group";
            this.overview_group.Size = new System.Drawing.Size(1064, 576);
            this.overview_group.TabIndex = 5;
            this.overview_group.TabStop = false;
            this.overview_group.Text = "Patient Form";
            // 
            // overview_flowlayout
            // 
            this.overview_flowlayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.overview_flowlayout.Location = new System.Drawing.Point(3, 67);
            this.overview_flowlayout.Name = "overview_flowlayout";
            this.overview_flowlayout.Size = new System.Drawing.Size(1058, 506);
            this.overview_flowlayout.TabIndex = 1;
            // 
            // patientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 576);
            this.Controls.Add(this.overview_group);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "patientForm";
            this.Text = "patientForm";
            this.overview_group.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox overview_group;
        private System.Windows.Forms.FlowLayoutPanel overview_flowlayout;
    }
}