using System;

namespace YourNamespace
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblSuccess.Text = "";
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                lblSuccess.Text = "Registration Successful!";
            }
        }
    }
}
