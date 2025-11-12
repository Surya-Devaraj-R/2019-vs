using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;

namespace EmailValidation
{
    public partial class validator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string input = TextBox1.Text; // Assuming TextBox1 is your input control
            string pattern = @"^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,6}$"; // email regex pattern

            if (Regex.IsMatch(input, pattern))
            {
                // Valid input, proceed with further processing
                Label1.Text = "Valid email address.";
                Label1.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                // Invalid input, show error message
                Label1.Text = "Please enter a valid email address.";
                Label1.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}