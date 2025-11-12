using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace Emptab
{
    public partial class Linqcon : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)

        {

            DataContext dc = new DataContext(@"data source=SDR\SQLEXPRESS;initial catalog=Linqex;Integrated Security = true");
            Table<Albin> emp = dc.GetTable<Albin>();
            GridView1.DataSource = emp;
            GridView1.DataBind();

            var m = from em in emp where em.Age > 22 && em.Salary > 23000 select em;
            GridView2.DataSource = m;
            GridView2.DataBind();

            var m1 = from em in emp select new { Emp_name = em.Name, Emp_Age = em.Age };
            GridView3.DataSource = m1;
            GridView3.DataBind();

        }
    }
}