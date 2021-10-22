using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace hospital_management_system
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            // (Raymond) NOTE: I've been trying to setup a local database but C# refuses to comply, hence a server sided database was used
            // (Raymond) TODO: Update Initial Catalog to Actual Hospital Management Database
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-CGUHCGNF;Initial Catalog=SQLTutorial;Integrated Security=True");
            string query = "SELECT * FROM PatientDetails WHERE Email = '" + email_textbox.Text.Trim() + "' AND Password = '" + password_textbox.Text.Trim() + "'";

            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();

            sda.Fill(dt);

            if (dt.Rows.Count == 1)
            { 
                window main = new window();
                main.Show();
                this.Hide();
            } else
            {
                MessageBox.Show("Username/Password Error");
            }
        }
    }
}
