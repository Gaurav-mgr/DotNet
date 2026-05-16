using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstWebApp
{
    public partial class RegistrationForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_Click(object sender, EventArgs e)
        {
            string roll = txtroll.Text;
            string name = txtname.Text;
            string email = txtemail.Text;
            string gender = male.Checked?"Male":female.Checked?"female":"Not Selected";

            string program = "Not Selected";
            if (bca.Checked) program = "BCA";
            if (bsc.Checked) program = "BSC";
            if (bscsit.Checked) program = "BSCSIT";

            string shift = ddlist.SelectedItem.Value;

            Response.Redirect("Display.aspx?roll=" + roll + "&name=" + name + "&email=" + email + "&gender=" + gender + "&program=" + program + "&shift=" + shift);
        }
    }
}