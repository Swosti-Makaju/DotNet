using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {
            if (txtusername.Text == "swosti" && txtpassword.Text == "123456")
            {
                {
                    login frm = new login();
                    frm.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("invalid username and password");
            }
        }

        private void cancle_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
