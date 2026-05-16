using System;
using System.Web.UI.WebControls;

namespace FirstWebApp
{
    public partial class Validation2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void cv1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            string pass = args.Value ?? string.Empty;
            if(pass.Length <= 5)
            {
                args.IsValid = false;
            }
            else
            {
                args.IsValid = true;
            }
        }

        protected void btnSub_Click(object sender, EventArgs e)
        {
            string name = txtname.Text;
            string email = txtemail.Text;
            string pass = cv1.IsValid?"Valid Password":"Invalid Password";
            string age = txtage.Text;

            details.Text = $"<p><b>Name:</b> {name}<br /><b>Email:</b> {email}<br/><b>Password:</b> {pass}<br/><b>Age:</b> {age}</p>";
        }
    }
}