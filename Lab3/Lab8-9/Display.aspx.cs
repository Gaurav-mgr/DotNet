using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstWebApp
{
    public partial class Display : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string roll = Request.QueryString["roll"];
            string name = Request.QueryString["name"];
            string email = Request.QueryString["email"];
            string gender = Request.QueryString["gender"];
            string program = Request.QueryString["program"];
            string shift = Request.QueryString["shift"];

            result.Text = $"<p><b>Roll:</b> {roll}<br/><b>Name:</b> {name}<br/><b>Email:</b> {email}</br><b>Gender:</b> {gender}</br><b>Program:</b> {program}</br><b>Shift:</b> {shift}</b></p>";
        }
    }
}