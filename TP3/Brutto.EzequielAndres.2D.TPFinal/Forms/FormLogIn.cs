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
            if (txtUsername.Text == "asd" && txtPassword.Text == "123")
            {
                MessageBox.Show("Has ingresado con éxito");
                Thread.Sleep(1000);
                this.Close();
            }
            else
            {
                DialogResult result = MessageBox.Show("Usuario no válido.\n¿Desea reintentar?", "ERROR", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    this.Close();
                }
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "asd";
            txtPassword.Text = "123";
        }
    }
}
