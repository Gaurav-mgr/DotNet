using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstWebApp
{
    public partial class Validation1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            Session["roll"] = txtroll.Text;
            Session["name"] = txtname.Text;
            Session["sem"] = txtsem.Text;
        }

        protected void btnDisplay_Click(object sender, EventArgs e)
        {
            string roll = Session["roll"].ToString();
            string name = Session["name"].ToString();
            string sem = Session["sem"].ToString();
            details.Text = $"<p><b>Roll:</b> {roll} <br/> <b>Name:</b> {name} <br/> <b>Semester:</b> {sem}</p>";
        }
    }
}