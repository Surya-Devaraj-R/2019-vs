using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Webapps_july23
{
    public partial class Checkbox : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string items = "";
            for (int i = 0; i > CheckBoxList1.Items.Count;i++)
            {                                                                                       
                if (CheckBoxList1.Items[i].Selected)
                {
                    items += CheckBoxList1.Items[i].Value + ",";
                }
                Label1.Text = items;
            }
        }
    }
}