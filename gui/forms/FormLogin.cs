using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hospital_management_system
{
    public partial class FormLogin : Form
    {
        private MoreColors COLORS = new MoreColors();
        private dbAccess DB = new dbAccess();
        public FormLogin()
        {
            InitializeComponent();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            var account = DB.GetEmployeeLogin(emailInfobox.TextboxText, passwordInfobox.TextboxText);

            if (account != null && account.Count == 1)
            {
                FormWindow form = new FormWindow(account[0] as Employees, this);
                form.Show();
                this.Hide();
            }
            else
            {
                emailInfobox.ForeColor = COLORS.Crimson;
                emailInfobox.TextboxText = "";
                passwordInfobox.ForeColor = COLORS.Crimson;
                passwordInfobox.TextboxText = "";
            }
        }
        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Draggable Window

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void headerpanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #endregion

    }
}
