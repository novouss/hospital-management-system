
namespace experimental_hospital_management_system
{
    partial class FormLogin
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
            this.picturebox = new System.Windows.Forms.PictureBox();
            this.loginpanel = new System.Windows.Forms.Panel();
            this.loginbtn = new System.Windows.Forms.Button();
            this.passwordInfobox = new experimental_hospital_management_system.gui.components.InformationTextbox();
            this.emailInfobox = new experimental_hospital_management_system.gui.components.InformationTextbox();
            this.employeelabel = new System.Windows.Forms.Label();
            this.sidepanel = new System.Windows.Forms.Panel();
            this.headerpanel = new System.Windows.Forms.Panel();
            this.closebtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox)).BeginInit();
            this.loginpanel.SuspendLayout();
            this.sidepanel.SuspendLayout();
            this.headerpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // picturebox
            // 
            this.picturebox.Image = global::experimental_hospital_management_system.Properties.Resources.banner;
            this.picturebox.Location = new System.Drawing.Point(12, 291);
            this.picturebox.Name = "picturebox";
            this.picturebox.Size = new System.Drawing.Size(516, 90);
            this.picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturebox.TabIndex = 0;
            this.picturebox.TabStop = false;
            // 
            // loginpanel
            // 
            this.loginpanel.Controls.Add(this.loginbtn);
            this.loginpanel.Controls.Add(this.passwordInfobox);
            this.loginpanel.Controls.Add(this.emailInfobox);
            this.loginpanel.Controls.Add(this.employeelabel);
            this.loginpanel.Location = new System.Drawing.Point(16, 265);
            this.loginpanel.Name = "loginpanel";
            this.loginpanel.Size = new System.Drawing.Size(444, 190);
            this.loginpanel.TabIndex = 5;
            // 
            // loginbtn
            // 
            this.loginbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(138)))), ((int)(((byte)(222)))));
            this.loginbtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.loginbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(132)))), ((int)(((byte)(222)))));
            this.loginbtn.FlatAppearance.BorderSize = 0;
            this.loginbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(132)))), ((int)(((byte)(222)))));
            this.loginbtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.loginbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginbtn.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.loginbtn.ForeColor = System.Drawing.Color.White;
            this.loginbtn.Location = new System.Drawing.Point(0, 151);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(444, 39);
            this.loginbtn.TabIndex = 5;
            this.loginbtn.Text = "Login";
            this.loginbtn.UseVisualStyleBackColor = false;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // passwordInfobox
            // 
            this.passwordInfobox.BackColor = System.Drawing.Color.White;
            this.passwordInfobox.ColumnWidth0 = 168F;
            this.passwordInfobox.Dock = System.Windows.Forms.DockStyle.Top;
            this.passwordInfobox.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.passwordInfobox.LabelText = "Password";
            this.passwordInfobox.Location = new System.Drawing.Point(0, 110);
            this.passwordInfobox.Name = "passwordInfobox";
            this.passwordInfobox.Size = new System.Drawing.Size(444, 35);
            this.passwordInfobox.TabIndex = 3;
            this.passwordInfobox.TextboxPasswordChar = '*';
            this.passwordInfobox.TextboxText = "";
            // 
            // emailInfobox
            // 
            this.emailInfobox.BackColor = System.Drawing.Color.White;
            this.emailInfobox.ColumnWidth0 = 168F;
            this.emailInfobox.Dock = System.Windows.Forms.DockStyle.Top;
            this.emailInfobox.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.emailInfobox.LabelText = "Email Address";
            this.emailInfobox.Location = new System.Drawing.Point(0, 75);
            this.emailInfobox.Name = "emailInfobox";
            this.emailInfobox.Size = new System.Drawing.Size(444, 35);
            this.emailInfobox.TabIndex = 2;
            this.emailInfobox.TextboxPasswordChar = '\0';
            this.emailInfobox.TextboxText = "";
            // 
            // employeelabel
            // 
            this.employeelabel.AutoSize = true;
            this.employeelabel.BackColor = System.Drawing.Color.Transparent;
            this.employeelabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.employeelabel.Font = new System.Drawing.Font("Segoe UI", 23.75F);
            this.employeelabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(132)))), ((int)(((byte)(222)))));
            this.employeelabel.Location = new System.Drawing.Point(0, 0);
            this.employeelabel.Name = "employeelabel";
            this.employeelabel.Padding = new System.Windows.Forms.Padding(10, 20, 0, 10);
            this.employeelabel.Size = new System.Drawing.Size(109, 75);
            this.employeelabel.TabIndex = 1;
            this.employeelabel.Text = "Login";
            // 
            // sidepanel
            // 
            this.sidepanel.BackColor = System.Drawing.Color.White;
            this.sidepanel.Controls.Add(this.headerpanel);
            this.sidepanel.Controls.Add(this.loginpanel);
            this.sidepanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.sidepanel.Location = new System.Drawing.Point(808, 0);
            this.sidepanel.Name = "sidepanel";
            this.sidepanel.Size = new System.Drawing.Size(472, 720);
            this.sidepanel.TabIndex = 6;
            // 
            // headerpanel
            // 
            this.headerpanel.Controls.Add(this.closebtn);
            this.headerpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerpanel.Location = new System.Drawing.Point(0, 0);
            this.headerpanel.Name = "headerpanel";
            this.headerpanel.Size = new System.Drawing.Size(472, 45);
            this.headerpanel.TabIndex = 6;
            // 
            // closebtn
            // 
            this.closebtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.closebtn.FlatAppearance.BorderSize = 0;
            this.closebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.closebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closebtn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closebtn.Location = new System.Drawing.Point(427, 0);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(45, 45);
            this.closebtn.TabIndex = 7;
            this.closebtn.Text = "ꭓ";
            this.closebtn.UseVisualStyleBackColor = true;
            this.closebtn.Click += new System.EventHandler(this.closebtn_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(132)))), ((int)(((byte)(222)))));
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.sidepanel);
            this.Controls.Add(this.picturebox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.headerpanel_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.picturebox)).EndInit();
            this.loginpanel.ResumeLayout(false);
            this.loginpanel.PerformLayout();
            this.sidepanel.ResumeLayout(false);
            this.headerpanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picturebox;
        private System.Windows.Forms.Label employeelabel;
        private gui.components.InformationTextbox passwordInfobox;
        private gui.components.InformationTextbox emailInfobox;
        private System.Windows.Forms.Panel loginpanel;
        private System.Windows.Forms.Button loginbtn;
        private System.Windows.Forms.Panel sidepanel;
        private System.Windows.Forms.Panel headerpanel;
        private System.Windows.Forms.Button closebtn;
    }
}