
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
            this.viewGroup = new System.Windows.Forms.GroupBox();
            this.search_panel = new System.Windows.Forms.Panel();
            this.search_btn = new System.Windows.Forms.Button();
            this.search_textbox = new System.Windows.Forms.TextBox();
            this.viewGroup.SuspendLayout();
            this.search_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // viewGroup
            // 
            this.viewGroup.Controls.Add(this.search_panel);
            this.viewGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewGroup.Font = new System.Drawing.Font("Segoe UI", 36F);
            this.viewGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(132)))), ((int)(((byte)(222)))));
            this.viewGroup.Location = new System.Drawing.Point(0, 0);
            this.viewGroup.Name = "viewGroup";
            this.viewGroup.Size = new System.Drawing.Size(1080, 720);
            this.viewGroup.TabIndex = 4;
            this.viewGroup.TabStop = false;
            this.viewGroup.Text = "{page_name}";
            // 
            // search_panel
            // 
            this.search_panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.search_panel.BackColor = System.Drawing.Color.White;
            this.search_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.search_panel.Controls.Add(this.search_btn);
            this.search_panel.Controls.Add(this.search_textbox);
            this.search_panel.Location = new System.Drawing.Point(12, 70);
            this.search_panel.MinimumSize = new System.Drawing.Size(350, 2);
            this.search_panel.Name = "search_panel";
            this.search_panel.Size = new System.Drawing.Size(536, 38);
            this.search_panel.TabIndex = 6;
            // 
            // search_btn
            // 
            this.search_btn.BackColor = System.Drawing.Color.White;
            this.search_btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.search_btn.FlatAppearance.BorderSize = 0;
            this.search_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.search_btn.ForeColor = System.Drawing.Color.Black;
            this.search_btn.Location = new System.Drawing.Point(441, 0);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(93, 36);
            this.search_btn.TabIndex = 7;
            this.search_btn.Text = "Search";
            this.search_btn.UseVisualStyleBackColor = false;
            // 
            // search_textbox
            // 
            this.search_textbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.search_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.search_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_textbox.Location = new System.Drawing.Point(3, 9);
            this.search_textbox.Name = "search_textbox";
            this.search_textbox.Size = new System.Drawing.Size(432, 19);
            this.search_textbox.TabIndex = 0;
            // 
            // PageView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 720);
            this.Controls.Add(this.viewGroup);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PageView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "dashboardForm";
            this.viewGroup.ResumeLayout(false);
            this.search_panel.ResumeLayout(false);
            this.search_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox viewGroup;
        private System.Windows.Forms.Panel search_panel;
        private System.Windows.Forms.TextBox search_textbox;
        private System.Windows.Forms.Button search_btn;
    }
}