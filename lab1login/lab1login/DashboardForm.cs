using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1login
{
    public partial class DashboardForm: Form
    {
        public DashboardForm()
        {
            InitializeComponent();
            this.FormClosed += DashboardForm_FormClosed;
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {

        }
        private void DashboardForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    }
}
