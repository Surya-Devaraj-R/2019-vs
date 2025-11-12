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
    public partial class Commandlinefiled : System.Web.UI.Page
    {

        SqlConnection conn = new SqlConnection(@"server=SDR\SQLEXPRESS;database=ASP_JUNE_Example;integrated security = true");
        protected void Page_Load(object sender, EventArgs e)
         
        {
           if (!IsPostBack)
                {

                gridview();

                }
            
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

        protected void GridView1_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {

            GridViewRow gs = GridView1.Rows[e.NewSelectedIndex];
            Label1.Text = gs.Cells[2].Text;
            Label2.Text = gs.Cells[3].Text;
            Label3.Text = gs.Cells[4].Text;           
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int getid = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value);
            string qry = $"delete from Registration where ID = {getid}";
            SqlCommand sq = new SqlCommand(qry, conn);
            conn.Open();
            int i = sq.ExecuteNonQuery();
            conn.Close();
            if(i==1)
            {
                gridview();
            }
            
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            gridview();

        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            gridview();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int i = e.RowIndex;
            int getid = Convert.ToInt32(GridView1.DataKeys[i].Value);
            TextBox txtage = (TextBox) GridView1.Rows[i].Cells[5].Controls [0];
            TextBox txtaddr = (TextBox)GridView1.Rows[i].Cells[6].Controls [0];
            string qry = $"update Registration set Age = {txtage.Text},Address ='{txtaddr.Text}' where ID = {getid}";
            SqlCommand cmd = new SqlCommand(qry, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            GridView1.EditIndex = -1;
            gridview();

        }
    }
}