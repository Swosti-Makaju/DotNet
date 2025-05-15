using System;
using System.Windows.Forms;

namespace lab1login
{
    public partial class Form1 : Form
    {
        int loginAttempts = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (username == "admin" && password == "1234")
            {
                lblMessage.Text = "Login Successful!";
                lblMessage.ForeColor = System.Drawing.Color.Green;

                // Open Dashboard
                DashboardForm dashboard = new DashboardForm();
                dashboard.Show();

                this.Hide(); // Hide the login form
            }
            else
            {
                loginAttempts++;
                lblMessage.Text = "Invalid credentials.";
                lblMessage.ForeColor = System.Drawing.Color.Red;

                txtUsername.Clear();
                txtPassword.Clear();

                if (loginAttempts >= 3)
                {
                    btnLogin.Enabled = false;
                    lblMessage.Text = "Too many failed attempts. Login disabled.";
                }
            }
        }
    }
}
