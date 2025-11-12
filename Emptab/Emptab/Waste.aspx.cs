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
    public partial class Waste : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                DataContext dc = new DataContext(@"data source=SDR\SQLEXPRESS;initial catalog=Linqex;Integrated Security = true");
                Table<Albin> empp = dc.GetTable<Albin>();
                GridView1.DataSource = empp;
                GridView1.DataBind();

                DropDownList1.DataSource = empp;
                DropDownList1.DataValueField = "id";
                DropDownList1.DataTextField = "Name";
                DropDownList1.DataBind();

            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedid = Convert.ToInt32(DropDownList1.SelectedValue);
            DataContext dc = new DataContext(@"data source=SDR\SQLEXPRESS;initial catalog=Linqex;Integrated Security=true");
            Table<Albin> empp = dc.GetTable<Albin>();
            var newemp = from em in empp where em.id == selectedid select em;
            GridView2.DataSource = newemp;
            GridView2.DataBind();
        }
    }
}