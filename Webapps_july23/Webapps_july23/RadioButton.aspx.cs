using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Webapps_july23
{
    public partial class RadioButton : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = RadioButtonList1.SelectedItem.Text;
            Label2.Text = RadioButtonList1.SelectedItem.Value;
        }

        protected void Button2_Click(object sender, EventArgs e)
        
                       {
                Label3.Text = ListBox1.SelectedItem.Text;
                Label4.Text = ListBox1.SelectedItem.Value;
            
            


         }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    
}