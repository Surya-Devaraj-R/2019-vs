using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LinqeX
{
    public partial class linq1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //string[] arr = { "Apple", "Red", "Orange", "Yellow", "Blue" };

            ////below shows just the words with less than 4 letters
            ////var all = from s in arr where s.Length < 4 select s;

            ////below shows the words bigin with a letter
            //var all = from s in arr where s.StartsWith("B") select s;

            //foreach(string r in all)
            //{
            //    Response.Write(r + "<br>");
            //}

            
            int[] num = { 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 21, 15, 16 };

            var a = from s in num where s % 2 == 0 select s;

            foreach (int c in a )
            {
                Response.Write(c + "<br>");
            }
        }
    }
}