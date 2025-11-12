using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Task_1_Curd
{
    public partial class cmf : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"server=SDR\SQLEXPRESS;database=ASP_Test;integrated security = true");
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                gridview();

            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string query = $"INSERT INTO Student (Student_Name, Age, Class, Address, Contact) VALUES ('{TextBox2.Text}', '{TextBox6.Text}', '{TextBox3.Text}', '{TextBox4.Text}', '{TextBox5.Text}')";

            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            int row = cmd.ExecuteNonQuery();
            con.Close();
            if (row == 1)
            {
                Label1.Text = "Successfully Added!!!";
            }
            gridview();
        }

        public void gridview()
        {
            string r = "select * from Student";
            SqlDataAdapter da = new SqlDataAdapter(r, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }

        protected void GridView1_RowCancelingEdit1(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            gridview();
        }

        protected void GridView1_RowDeleting1(object sender, GridViewDeleteEventArgs e)
        {
            int getid = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value);
            string qry = $"delete from Student where Student_ID = {getid}";
            SqlCommand sq = new SqlCommand(qry, con);
            con.Open();
            int i = sq.ExecuteNonQuery();
            con.Close();
            if (i == 1)
            {
                gridview();
            }


        }

        protected void GridView1_RowUpdating1(object sender, GridViewUpdateEventArgs e)
        {

            int i = e.RowIndex;
            int getid = Convert.ToInt32(GridView1.DataKeys[i].Value);
            TextBox txtage = (TextBox)GridView1.Rows[i].Cells[5].Controls[0];
            TextBox txtaddr = (TextBox)GridView1.Rows[i].Cells[7].Controls[0];
            string qry = $"update Student set Age = {txtage.Text},Address ='{txtaddr.Text}' where Student_ID = {getid}";
            SqlCommand cmd = new SqlCommand(qry, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            GridView1.EditIndex = -1;
            gridview();

        }

        protected void GridView1_RowEditing1(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            gridview();

        }

        protected void GridView1_SelectedIndexChanging1(object sender, GridViewSelectEventArgs e)
        {

            GridViewRow gs = GridView1.Rows[e.NewSelectedIndex];
            Label2.Text = gs.Cells[4].Text;
            Label3.Text = gs.Cells[5].Text;

        }
    }

}