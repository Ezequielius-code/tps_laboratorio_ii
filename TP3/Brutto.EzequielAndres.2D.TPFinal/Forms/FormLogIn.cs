using ClassesLibrary;
using ClassesLibrary.Exceptions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class FormLogIn : Form
    {
        public FormLogIn()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txtUsername.Text;
                string password = txtPassword.Text;

                if (UsersManager.CheckUser(username, password))
                {
                    MessageBox.Show("Welcome " + username);
                    Thread.Sleep(1000);
                    this.Close();
                }
            }
            catch (InvalidUserException ex)
            {
                ExLogger.CatchLog(ex);
                DialogResult result = MessageBox.Show(ex.Message, "ACCESS DENIED", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                if (result == DialogResult.No)
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                ExLogger.CatchLog(ex);
                MessageBox.Show("Unable to begin the app.", "FATAL SYSTEM ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "test123";
            txtPassword.Text = "asd123";
        }
    }
}
