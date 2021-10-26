
namespace hospital_management_system.gui.forms
{
    partial class loginForm
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
            this.emailTextbox = new System.Windows.Forms.TextBox();
            this.loginPanel = new System.Windows.Forms.Panel();
            this.loginBtn = new System.Windows.Forms.Button();
            this.passwordText = new System.Windows.Forms.Label();
            this.emailText = new System.Windows.Forms.Label();
            this.passwordTextbox = new System.Windows.Forms.TextBox();
            this.titleText = new System.Windows.Forms.Label();
            this.loginPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // emailTextbox
            // 
            this.emailTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.emailTextbox.Font = new System.Drawing.Font("Segoe UI", 21F);
            this.emailTextbox.Location = new System.Drawing.Point(292, 281);
            this.emailTextbox.Name = "emailTextbox";
            this.emailTextbox.Size = new System.Drawing.Size(465, 45);
            this.emailTextbox.TabIndex = 0;
            // 
            // loginPanel
            // 
            this.loginPanel.Controls.Add(this.titleText);
            this.loginPanel.Controls.Add(this.loginBtn);
            this.loginPanel.Controls.Add(this.passwordText);
            this.loginPanel.Controls.Add(this.emailText);
            this.loginPanel.Controls.Add(this.passwordTextbox);
            this.loginPanel.Controls.Add(this.emailTextbox);
            this.loginPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginPanel.Location = new System.Drawing.Point(0, 0);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(1048, 645);
            this.loginPanel.TabIndex = 2;
            // 
            // loginBtn
            // 
            this.loginBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(132)))), ((int)(((byte)(222)))));
            this.loginBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(132)))), ((int)(((byte)(222)))));
            this.loginBtn.FlatAppearance.BorderSize = 0;
            this.loginBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(132)))), ((int)(((byte)(222)))));
            this.loginBtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.ForeColor = System.Drawing.Color.White;
            this.loginBtn.Location = new System.Drawing.Point(292, 414);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(465, 45);
            this.loginBtn.TabIndex = 2;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // passwordText
            // 
            this.passwordText.AutoSize = true;
            this.passwordText.Location = new System.Drawing.Point(288, 334);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(76, 21);
            this.passwordText.TabIndex = 2;
            this.passwordText.Text = "Password";
            // 
            // emailText
            // 
            this.emailText.AutoSize = true;
            this.emailText.Location = new System.Drawing.Point(288, 257);
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(108, 21);
            this.emailText.TabIndex = 1;
            this.emailText.Text = "Email Address";
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordTextbox.Font = new System.Drawing.Font("Segoe UI", 21F);
            this.passwordTextbox.Location = new System.Drawing.Point(292, 358);
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.PasswordChar = '*';
            this.passwordTextbox.Size = new System.Drawing.Size(465, 45);
            this.passwordTextbox.TabIndex = 1;
            // 
            // titleText
            // 
            this.titleText.AutoSize = true;
            this.titleText.Font = new System.Drawing.Font("Segoe UI", 36F);
            this.titleText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(132)))), ((int)(((byte)(222)))));
            this.titleText.Location = new System.Drawing.Point(281, 192);
            this.titleText.Name = "titleText";
            this.titleText.Size = new System.Drawing.Size(146, 65);
            this.titleText.TabIndex = 4;
            this.titleText.Text = "Login";
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 645);
            this.Controls.Add(this.loginPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "loginForm";
            this.Text = "patientForm";
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox emailTextbox;
        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.TextBox passwordTextbox;
        private System.Windows.Forms.Label passwordText;
        private System.Windows.Forms.Label emailText;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Label titleText;
    }
}