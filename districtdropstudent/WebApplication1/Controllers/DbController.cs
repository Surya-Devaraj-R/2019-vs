using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class DbController : Controller
    {
        student_tablemvcEntities1 dbobj = new student_tablemvcEntities1();
        StateDistrict sdobj = new StateDistrict();

        public ActionResult Insert_PageLoad()
        {
            List<stClass> stList = sdobj.selectStates();
            ViewBag.SelStates = new SelectList(stList, "Sid", "statename");
            return View();
        }

        // Load district based on selected state
        private List<SelectListItem> GetDistrictByStateId(int stateId)
        {
            var getDistrict = sdobj.selectDistrict(stateId);
            var districtByState = getDistrict.Select(a =>
                new SelectListItem() { Value = a.Did.ToString(), Text = a.Districtname }).ToList();
            return districtByState;
        }

        // Passing the district by json query
        public JsonResult GetDistrict(int stateId)
        {
            var districts = sdobj.selectDistrict(stateId);
            var items = districts.Select(a => new { Value = a.Did, Text = a.Districtname }).ToList();
            return Json(items, JsonRequestBehavior.AllowGet);
        }

        // Insert controller
        public ActionResult Insert_Click(UserInsert user, FormCollection form, HttpPostedFileBase file)
        {
            if (ModelState.IsValid)
            {
                if (file != null && file.ContentLength > 0)
                {
                    string fname = Path.GetFileName(file.FileName);
                    var s = Server.MapPath("~/Photos");
                    string path = Path.Combine(s, fname);
                    file.SaveAs(path);

                    var fullpath = Path.Combine("\\Photos", fname);
                    user.Sphoto = fullpath;
                }
                List<stClass> stList = sdobj.selectStates();
                int selectedId = Convert.ToInt32(form["sId"]);
                stClass selectedItem = stList.FirstOrDefault(c => c.Sid == selectedId);
                user.Sid = selectedItem?.Sid ?? 0;
                ViewBag.SelStates = new SelectList(stList, "Sid", "statename");
                int did = Convert.ToInt32(form["DistrictId"]);
                user.Did = did;

                dbobj.sp_insert_student(user.Sid, user.Did, user.Sname, user.Sage, user.Sphoto);
                user.msg = "Registration Successfully!!";
                return View("Insert_PageLoad", user);
            }
            else
            {
                List<stClass> stList = sdobj.selectStates();
                ViewBag.SelStates = new SelectList(stList, "Sid", "statename");
                return View("Insert_PageLoad", user);
            }
        }
    }
}
