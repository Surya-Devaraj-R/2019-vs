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
    public partial class Profile : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(@"server=SDR\SQLEXPRESS;database=ASP_JUNE_Example;integrated security = true");
        protected void Page_Load(object sender, EventArgs e)
        {   

            if(!IsPostBack)
            {

                string qry = $"select * from Registration where id={Session["uid"]}";
                SqlCommand cmd = new SqlCommand(qry, conn);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                    TextBox1.Text = dr["Name"].ToString();
                    TextBox2.Text = dr["Age"].ToString();
                    TextBox3.Text = dr["Phone"].ToString();
                    TextBox4.Text = dr["Address"].ToString();
                    Image1.ImageUrl = dr["Photo"].ToString();
                }
                conn.Close();
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string qry = $"update Registration set Name = '{TextBox1.Text}', Age = '{TextBox2.Text}', Phone = '{TextBox3.Text}' where id={Session["uid"]}";
            SqlCommand cmd = new SqlCommand(qry, conn);
            conn.Open();
            int cnt = cmd.ExecuteNonQuery();
            conn.Close();
            if (cnt == 1)
            {
                Response.Redirect("LoginPage.aspx");
            }
        }
    }
}