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
    public partial class WebForm2 : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(@"server=SDR\SQLEXPRESS;database=ASP_JUNE_Example;integrated security = true");
        protected void Page_Load(object sender, EventArgs e)
        {
           
            gridview();

        }

        public void gridview()
        {
            string s = "select * from Registration";
            SqlDataAdapter da = new SqlDataAdapter(s, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }

        protected void LinkButton1_Command(object sender, CommandEventArgs e)
        {
            Label1.Text = e.CommandArgument.ToString();
            string a = "DELETE FROM Registration WHERE id = "+ e.CommandArgument.ToString();
            SqlCommand cmd = new SqlCommand(a, conn);
            conn.Open();
            int i = cmd.ExecuteNonQuery();
            conn.Close();

            if (i == 1)

            {
                gridview();
            }
                                


        }
    }
}