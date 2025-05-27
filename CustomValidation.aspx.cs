using System;
using System.Text.RegularExpressions;

namespace UsernameValidationApp
{
    public partial class CustomValidation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblMessage.Text = "";
        }

        protected void cvUsername_ServerValidate(object source, System.Web.UI.WebControls.ServerValidateEventArgs args)
        {
            // Only letters and numbers are allowed
            string pattern = @"^[a-zA-Z0-9]+$";
            args.IsValid = Regex.IsMatch(args.Value, pattern);
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                lblMessage.ForeColor = System.Drawing.Color.Green;
                lblMessage.Text = "Username is valid. Success!";
            }
            else
            {
                lblMessage.ForeColor = System.Drawing.Color.Red;
                lblMessage.Text = "Validation failed. Please correct the errors.";
            }
        }
    }
}
