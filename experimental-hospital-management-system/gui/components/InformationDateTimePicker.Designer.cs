
namespace experimental_hospital_management_system.gui.components
{
    partial class InformationDateTimePicker
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
            this.Label = new System.Windows.Forms.Label();
            this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.TableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // TableLayout
            // 
            this.TableLayout.ColumnCount = 2;
            this.TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 165F));
            this.TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayout.Controls.Add(this.Label, 0, 0);
            this.TableLayout.Controls.Add(this.DateTimePicker, 1, 0);
            this.TableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayout.Location = new System.Drawing.Point(0, 0);
            this.TableLayout.Name = "TableLayout";
            this.TableLayout.RowCount = 1;
            this.TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.TableLayout.Size = new System.Drawing.Size(726, 35);
            this.TableLayout.TabIndex = 1;
            // 
            // Label
            // 
            this.Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Label.Location = new System.Drawing.Point(3, 0);
            this.Label.Name = "Label";
            this.Label.Padding = new System.Windows.Forms.Padding(7, 7, 0, 7);
            this.Label.Size = new System.Drawing.Size(159, 40);
            this.Label.TabIndex = 0;
            this.Label.Text = "label1";
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.Dock = System.Windows.Forms.DockStyle.Top;
            this.DateTimePicker.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimePicker.Location = new System.Drawing.Point(168, 3);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(555, 29);
            this.DateTimePicker.TabIndex = 1;
            // 
            // InformationDateTimePicker
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.TableLayout);
            this.Name = "InformationDateTimePicker";
            this.Size = new System.Drawing.Size(726, 35);
            this.TableLayout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TableLayout;
        private System.Windows.Forms.Label Label;
        public System.Windows.Forms.DateTimePicker DateTimePicker;
    }
}
