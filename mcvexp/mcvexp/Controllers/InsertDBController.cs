using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mcvexp.Models;

namespace mcvexp.Controllers
{
    public class InsertDBController : Controller
    {
        mvcdemoEntities mvcdemo = new mvcdemoEntities();
        // GET: InsertDB
        public ActionResult Page_load()
        {
            return View();
        }
        public ActionResult insert_submit(Testcls obj)
        {
            if (ModelState.IsValid)
            {
                mvcdemo.sp_insert(obj.name, obj.age, obj.address);
                obj.msg = "Insetion successfull";
                return View("Page_load",obj);
            }
            else
            {
                obj.msg = "Insertion Failed";
                return View("Page_load",obj);
            }
            
        }
    }
}