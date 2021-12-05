
namespace hospital_management_system.gui.components
{
    partial class PreviewCards
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
            this.text = new System.Windows.Forms.Label();
            this.counter = new System.Windows.Forms.Label();
            this.roundedPanels1.SuspendLayout();
            this.SuspendLayout();
            // 
            // roundedPanels1
            // 
            this.roundedPanels1.BackColor = System.Drawing.Color.White;
            this.roundedPanels1.Controls.Add(this.text);
            this.roundedPanels1.Controls.Add(this.counter);
            this.roundedPanels1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundedPanels1.ForeColor = System.Drawing.Color.Black;
            this.roundedPanels1.Location = new System.Drawing.Point(0, 0);
            this.roundedPanels1.Name = "roundedPanels1";
            this.roundedPanels1.Size = new System.Drawing.Size(181, 110);
            this.roundedPanels1.TabIndex = 0;
            // 
            // text
            // 
            this.text.AutoSize = true;
            this.text.BackColor = System.Drawing.Color.Transparent;
            this.text.Dock = System.Windows.Forms.DockStyle.Top;
            this.text.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.text.Location = new System.Drawing.Point(0, 72);
            this.text.Name = "text";
            this.text.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.text.Size = new System.Drawing.Size(55, 21);
            this.text.TabIndex = 1;
            this.text.Text = "text";
            // 
            // counter
            // 
            this.counter.AutoSize = true;
            this.counter.BackColor = System.Drawing.Color.Transparent;
            this.counter.Dock = System.Windows.Forms.DockStyle.Top;
            this.counter.Font = new System.Drawing.Font("Segoe UI", 34F);
            this.counter.Location = new System.Drawing.Point(0, 0);
            this.counter.Name = "counter";
            this.counter.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.counter.Size = new System.Drawing.Size(137, 72);
            this.counter.TabIndex = 0;
            this.counter.Text = "1337";
            // 
            // PreviewCards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.roundedPanels1);
            this.Name = "PreviewCards";
            this.Size = new System.Drawing.Size(181, 110);
            this.roundedPanels1.ResumeLayout(false);
            this.roundedPanels1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private RoundedPanels roundedPanels1;
        private System.Windows.Forms.Label text;
        private System.Windows.Forms.Label counter;
    }
}
