using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace linqwithgenericclass
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Class1> Employees = new List<Class1>();
            Employees.Add(new Class1 { Name = "Ajith", Age = 20, Salary = 24000 });
            Employees.Add(new Class1 { Name = "Surya", Age = 25, Salary = 25000 });
            Employees.Add(new Class1 { Name = "Hrx", Age = 24, Salary = 26000 });
            Employees.Add(new Class1 { Name = "Ajlbinith", Age = 40, Salary = 225000 });
            Employees.Add(new Class1 { Name = "Soman", Age = 30, Salary = 75000 });
            Employees.Add(new Class1 { Name = "Irshad", Age = 27, Salary = 25000 });
            Employees.Add(new Class1 { Name = "Asif", Age = 28, Salary = 25000 });
            Employees.Add(new Class1 { Name = "raviee", Age = 22, Salary = 25000 });
            Employees.Add(new Class1 { Name = "Marvan", Age = 23, Salary = 25000 });

            var match = from emp in Employees select emp;
            GridView1.DataSource = match;
            GridView1.DataBind();

            var qry = from emp in Employees where emp.Age > 22 && emp.Salary > 22000 select emp;
            GridView2.DataSource = qry;
            GridView2.DataBind();

            var epic = from emp in Employees select new { emp_name = emp.Name, emp_age = emp.Age };
            GridView3.DataSource = epic;
            GridView3.DataBind();

            var ages = from emp in Employees select new { emp_age = emp.Age };
            GridView4.DataSource = ages;
            GridView4.DataBind();

            var stu = (from emp in Employees select emp.Age).Min(); // this methn cannot be shown in grid view
            Response.Write(stu);

            var spe = from emp in Employees where emp.Name.StartsWith("A") && emp.Age > 26 select emp;
            GridView5.DataSource = spe;
            GridView5.DataBind();

            var ces = from emp in Employees where Testname(emp) && emp.Age > 25 select emp;
            GridView6.DataSource = ces;
            GridView6.DataBind();

            var chg = from emp in Employees orderby emp.Salary select emp;
            GridView7.DataSource = chg;
            GridView7.DataBind();

            var sumo = from emp in Employees orderby emp.Salary descending select emp;
            GridView8.DataSource = sumo;
            GridView8.DataBind();
        }
        static bool Testname(Class1 emp)
        {
            return emp.Name.StartsWith("A");
        }
    }
}