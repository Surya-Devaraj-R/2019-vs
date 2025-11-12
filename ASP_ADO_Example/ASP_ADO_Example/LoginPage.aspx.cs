using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace ASP_ADO_Example
{
    public partial class LoginPage : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(@"server=SDR\SQLEXPRESS;database=ASP_JUNE_Example;integrated security = true");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            string query = $"select count(ID) from Registration where UserName = '{TextBox2.Text}' and Password = '{TextBox1.Text}'";

            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            string row = cmd.ExecuteScalar().ToString();
            conn.Close();

            if (row == "1")
            {
                string query1 = $"select ID from Registration where UserName = '{TextBox2.Text}' and Password = '{TextBox1.Text}'";

                SqlCommand cmd1 = new SqlCommand(query1, conn);
                conn.Open();
                String userid = cmd1.ExecuteScalar().ToString();
                conn.Close();
                Session["uid"] = userid;
                //Label1.Text = "The Login is succesfull";
                Response.Redirect("Profile.aspx");

            }

            else
            {
                Label1.Text = "Error>> User Name or Password is Wrong";
            }

     
           
        }
    }
}