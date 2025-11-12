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
    public partial class UserList : System.Web.UI.Page
    {

        SqlConnection conn = new SqlConnection(@"server=SDR\SQLEXPRESS;database=ASP_JUNE_Example;integrated security = true");
        protected void Page_Load(object sender, EventArgs e)

        {
            if(!IsPostBack)
            {
                string s = "select ID,Name from Registration";
                SqlDataAdapter da = new SqlDataAdapter(s, conn);
                DataSet ds = new DataSet();
                da.Fill(ds);
                DropDownList1.DataSource = ds;
                DropDownList1.DataTextField = "Name";
                DropDownList1.DataValueField = "ID";
                DropDownList1.DataBind();

                
            }
            
            
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

            Label1.Text = DropDownList1.SelectedItem.Text;
            Label2.Text = DropDownList1.SelectedItem.Value;
            string r = $"select * from Registration where id = {DropDownList1.SelectedItem.Value}";
            SqlDataAdapter da = new SqlDataAdapter(r, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string r = "select * from Registration";
            SqlDataAdapter da = new SqlDataAdapter(r, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string b= "select * from Registration";
            SqlDataAdapter da = new SqlDataAdapter(b, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            DataList1.DataSource = ds;
            DataList1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}