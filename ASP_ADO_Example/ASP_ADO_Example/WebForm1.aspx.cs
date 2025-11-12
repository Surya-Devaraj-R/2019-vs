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
   
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(@"server=SDR\SQLEXPRESS;database=ASP_JUNE_Example;integrated security = true");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string path = "~/Photos/" + FileUpload1.FileName;
            FileUpload1.SaveAs(MapPath(path));

            string qal = "";

            for(int i=0; i < CheckBoxList1.Items.Count; i ++ )
            {
                if (CheckBoxList1.Items[i].Selected)
                {
                    qal += CheckBoxList1.Items[i].Text + ",";
                }              
            }

            string query = $" INSERT INTO Registration VALUES ('{TextBox1.Text}', {TextBox2.Text}, '{TextBox3.Text}', '{TextBox4.Text}', '{TextBox5.Text}','{RadioButtonList1.SelectedItem.Value}','{DropDownList1.SelectedItem.Value}','{qal}','{path}','{TextBox6.Text}','{TextBox7.Text}')";


            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            int row = cmd.ExecuteNonQuery();
            conn.Close();
            if (row == 1)
            {
                Label1.Text = "Successfully Added!!!";
            }

        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}