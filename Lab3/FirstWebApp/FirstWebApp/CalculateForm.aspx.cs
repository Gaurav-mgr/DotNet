using System;

namespace FirstWebApp
{
    public partial class CalculateForm : System.Web.UI.Page
    {
        protected void btnMultiply_Click(object sender, EventArgs e)
        {
            int a = int.Parse(fnum.Text);
            int b = int.Parse(snum.Text);
            int mul = a * b;

            result.Text = "<h2>Multiplication: " + mul + "</h2>";
        }
    }
}