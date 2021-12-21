
namespace experimental_hospital_management_system
{
    partial class FormSelection
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
            this.DisplayPreview = new experimental_hospital_management_system.gui.components.DisplayPreview();
            this.headerpanel = new System.Windows.Forms.Panel();
            this.headerlabel = new System.Windows.Forms.Label();
            this.headerpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // DisplayPreview
            // 
            this.DisplayPreview.AutoSize = true;
            this.DisplayPreview.BackColor = System.Drawing.Color.RoyalBlue;
            this.DisplayPreview.BackColorPanel = System.Drawing.Color.White;
            this.DisplayPreview.Column0 = 10F;
            this.DisplayPreview.Column1 = 70F;
            this.DisplayPreview.Column2 = 20F;
            this.DisplayPreview.Column3 = 10F;
            this.DisplayPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DisplayPreview.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayPreview.Label0 = "ID";
            this.DisplayPreview.Label1 = "Name";
            this.DisplayPreview.Label2 = "Status";
            this.DisplayPreview.Label3 = "";
            this.DisplayPreview.Location = new System.Drawing.Point(0, 45);
            this.DisplayPreview.Name = "DisplayPreview";
            this.DisplayPreview.Size = new System.Drawing.Size(434, 406);
            this.DisplayPreview.TabIndex = 1;
            // 
            // headerpanel
            // 
            this.headerpanel.BackColor = System.Drawing.Color.White;
            this.headerpanel.Controls.Add(this.headerlabel);
            this.headerpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerpanel.Location = new System.Drawing.Point(0, 0);
            this.headerpanel.Name = "headerpanel";
            this.headerpanel.Size = new System.Drawing.Size(434, 45);
            this.headerpanel.TabIndex = 0;
            // 
            // headerlabel
            // 
            this.headerlabel.AutoSize = true;
            this.headerlabel.BackColor = System.Drawing.Color.White;
            this.headerlabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.headerlabel.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.headerlabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.headerlabel.Location = new System.Drawing.Point(0, 0);
            this.headerlabel.Name = "headerlabel";
            this.headerlabel.Padding = new System.Windows.Forms.Padding(10, 5, 0, 0);
            this.headerlabel.Size = new System.Drawing.Size(107, 35);
            this.headerlabel.TabIndex = 1;
            this.headerlabel.Text = "Selection";
            // 
            // FormSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(434, 451);
            this.Controls.Add(this.DisplayPreview);
            this.Controls.Add(this.headerpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormSelection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.headerpanel.ResumeLayout(false);
            this.headerpanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel headerpanel;
        private System.Windows.Forms.Label headerlabel;
        private gui.components.DisplayPreview DisplayPreview;
    }
}