
namespace experimental_hospital_management_system.gui.components
{
    partial class InformationButtonbox
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
            this.TableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.SubButton = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.MainButton = new System.Windows.Forms.Button();
            this.TableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // TableLayout
            // 
            this.TableLayout.ColumnCount = 3;
            this.TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 193F));
            this.TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 193F));
            this.TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayout.Controls.Add(this.SubButton, 0, 0);
            this.TableLayout.Controls.Add(this.Label1, 0, 0);
            this.TableLayout.Controls.Add(this.MainButton, 1, 0);
            this.TableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayout.Location = new System.Drawing.Point(0, 0);
            this.TableLayout.Name = "TableLayout";
            this.TableLayout.RowCount = 1;
            this.TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.TableLayout.Size = new System.Drawing.Size(726, 35);
            this.TableLayout.TabIndex = 2;
            // 
            // SubButton
            // 
            this.SubButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SubButton.FlatAppearance.BorderSize = 0;
            this.SubButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubButton.Location = new System.Drawing.Point(196, 3);
            this.SubButton.Name = "SubButton";
            this.SubButton.Size = new System.Drawing.Size(187, 34);
            this.SubButton.TabIndex = 1;
            this.SubButton.Text = "button1";
            this.SubButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SubButton.UseVisualStyleBackColor = true;
            // 
            // Label1
            // 
            this.Label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Label1.Location = new System.Drawing.Point(3, 0);
            this.Label1.Name = "Label1";
            this.Label1.Padding = new System.Windows.Forms.Padding(7, 0, 0, 7);
            this.Label1.Size = new System.Drawing.Size(187, 40);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "label1";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainButton
            // 
            this.MainButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainButton.FlatAppearance.BorderSize = 0;
            this.MainButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MainButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainButton.Location = new System.Drawing.Point(389, 3);
            this.MainButton.Name = "MainButton";
            this.MainButton.Size = new System.Drawing.Size(334, 34);
            this.MainButton.TabIndex = 2;
            this.MainButton.Text = "button1";
            this.MainButton.UseVisualStyleBackColor = true;
            // 
            // InformationButtonbox
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.TableLayout);
            this.Name = "InformationButtonbox";
            this.Size = new System.Drawing.Size(726, 35);
            this.TableLayout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TableLayout;
        private System.Windows.Forms.Button MainButton;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Button SubButton;
    }
}
