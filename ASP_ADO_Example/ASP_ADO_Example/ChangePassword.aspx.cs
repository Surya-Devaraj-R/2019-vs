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
    public partial class ChangePassword : System.Web.UI.Page
    {

        SqlConnection conn = new SqlConnection(@"server=SDR\SQLEXPRESS;database=ASP_JUNE_Example;integrated security = true");
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //string currentPassword = TextBox1.Text;
            //string newPassword = TextBox2.Text;
            //conn.Open();

            string qry = $"select Password from Registration where id={Session["uid"]}";
            SqlCommand Cmd1 = new SqlCommand(qry, conn);
            conn.Open();
            string oldpwd = Cmd1.ExecuteScalar().ToString();
            conn.Close();

            if (oldpwd == TextBox1.Text)
            {
                string qry1 = $"update Registration set Password = '{TextBox2.Text}' where id={Session["uid"]}";
                SqlCommand cmd = new SqlCommand(qry1, conn);
                conn.Open();
                int cnt1 = cmd.ExecuteNonQuery();
                conn.Close();
                if (cnt1 == 1)
                {
                    Response.Redirect("LoginPage.aspx");
                }

                else
                {
                    Label1.Text="Password is not correct";
                }
            }

            else
            {
                Label1.Text = "Inavild Old password";
            }

           
                
        
        }
    }
}