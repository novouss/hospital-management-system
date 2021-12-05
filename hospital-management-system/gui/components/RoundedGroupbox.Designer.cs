
namespace hospital_management_system.gui.components
{
    partial class RoundedGroupbox
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.roundedPanels1 = new hospital_management_system.gui.components.RoundedPanels();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.roundedPanels1.SuspendLayout();
            this.SuspendLayout();
            // 
            // roundedPanels1
            // 
            this.roundedPanels1.BackColor = System.Drawing.Color.White;
            this.roundedPanels1.Controls.Add(this.panel1);
            this.roundedPanels1.Controls.Add(this.label1);
            this.roundedPanels1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundedPanels1.ForeColor = System.Drawing.Color.Black;
            this.roundedPanels1.Location = new System.Drawing.Point(0, 0);
            this.roundedPanels1.Name = "roundedPanels1";
            this.roundedPanels1.Size = new System.Drawing.Size(507, 362);
            this.roundedPanels1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 85);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(7);
            this.panel1.Size = new System.Drawing.Size(507, 277);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 36F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(132)))), ((int)(((byte)(222)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10);
            this.label1.Size = new System.Drawing.Size(131, 85);
            this.label1.TabIndex = 0;
            this.label1.Text = "Text";
            // 
            // RoundedGroupbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.roundedPanels1);
            this.Name = "RoundedGroupbox";
            this.Size = new System.Drawing.Size(507, 362);
            this.roundedPanels1.ResumeLayout(false);
            this.roundedPanels1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private RoundedPanels roundedPanels1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}
