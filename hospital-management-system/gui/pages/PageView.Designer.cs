
namespace hospital_management_system.gui.forms
{
    partial class PageView
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
            this.DisplayPreview = new hospital_management_system.gui.components.DisplayPreview();
            this.DisplayPanel = new hospital_management_system.gui.components.RoundedGroupbox();
            this.SuspendLayout();
            // 
            // DisplayPreview
            // 
            this.DisplayPreview.AutoSize = true;
            this.DisplayPreview.Column0 = 15F;
            this.DisplayPreview.Column1 = 70F;
            this.DisplayPreview.Column2 = 20F;
            this.DisplayPreview.Column3 = 10F;
            this.DisplayPreview.Label0 = "ID";
            this.DisplayPreview.Label1 = "Name";
            this.DisplayPreview.Label2 = "Status";
            this.DisplayPreview.Label3 = "";
            this.DisplayPreview.Location = new System.Drawing.Point(26, 100);
            this.DisplayPreview.Name = "DisplayPreview";
            this.DisplayPreview.Size = new System.Drawing.Size(537, 284);
            this.DisplayPreview.TabIndex = 1;
            // 
            // DisplayPanel
            // 
            this.DisplayPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DisplayPanel.LabelText = "{function}";
            this.DisplayPanel.Location = new System.Drawing.Point(12, 12);
            this.DisplayPanel.Name = "DisplayPanel";
            this.DisplayPanel.Size = new System.Drawing.Size(570, 696);
            this.DisplayPanel.TabIndex = 0;
            // 
            // PageView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(1080, 720);
            this.Controls.Add(this.DisplayPreview);
            this.Controls.Add(this.DisplayPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PageView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "dashboardForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public void InitializeCustomComponents()
        {
            this.DisplayPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DisplayPanel.AddControl(this.DisplayPreview);
            
        }

        private components.RoundedGroupbox DisplayPanel;
        private components.DisplayPreview DisplayPreview;
    }
}