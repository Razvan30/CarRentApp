using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username, password;
            username = tbUsername.Text.Trim();
            password = tbPassword.Text.Trim();

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Fill username field");
                tbUsername.Focus();
            }
            else
            {

                if (string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Fill password field");
                    tbUsername.Focus();
                }
                else
                {
                    // check if user with this password exists and is active

                    var mainForm = new MainForm();
                    mainForm.Show();
                    this.Hide();
                }
            }

        }
    }
}
