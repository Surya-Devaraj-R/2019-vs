using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace linkexmple
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        
        {
            try
            {


                SqlConnection con = new SqlConnection(@"data source =SDR\SQLEXPRESS;initial catalog=Linqex;integrated security=true");
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter("select * from Employee", con);
                da.Fill(ds,"EmpTab");

                //select all employee

                //var m = from emp in ds.Tables["EmpTab"].AsEnumerable() select emp;
                //GridView1.DataSource = m.AsDataView();
                //GridView1.DataBind();

                //EnumerableRowCollection<DataRow> m = from emp in ds.Tables["EmpTab"].AsEnumerable() where emp.Field<long>("Salary") > 22000 select emp;
                //EnumerableRowCollection<DataRow> m1 = from emp in ds.Tables["EmpTab"].AsEnumerable() where emp.Field<int>("") > 22000 select emp;

                //GridView1.DataSource = m.AsDataView();
                //GridView1.DataBind();

                EnumerableRowCollection<DataRow> dr = ds.Tables["EmpTab"].AsEnumerable();
                var m = from emp in dr where emp.Field<long>("Salary") > 21000 select new {emp_name = emp.Field<string>("Name"), emp_age = emp.Field<int>("Age") };
                GridView1.DataSource = m;
                GridView1.DataBind();

             

            }

            catch (Exception es)

            {


                
            }
        }
    }
}