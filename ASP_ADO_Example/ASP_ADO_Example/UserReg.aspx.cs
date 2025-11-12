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
    public partial class UserReg : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(@"server=SDR\SQLEXPRESS;database=ASP_JUNE_Example;integrated security = true");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string query = $"insert into [User] values('{TextBox1.Text}',{TextBox2.Text},'{TextBox3.Text}')";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            int row = cmd.ExecuteNonQuery();
            conn.Close();
            if (row == 1)
            {
                Label1.Text = "Successfully Added!!!";
            }
        }
    }
}