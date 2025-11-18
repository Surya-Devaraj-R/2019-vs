using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using NewMVCWebAPIEntityFramework;

namespace NewMVCWebAPIEntityFramework.Controllers
{
    public class StudentMarksController : Controller
    {
        private MVCEnitityFramewordEntities db = new MVCEnitityFramewordEntities();

        // GET: StudentMarks
        public ActionResult Index()
        {
            IEnumerable<StudentMark> students = null;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:55656/api/API/");
                var responseTask = client.GetAsync("getstudent");
                responseTask.Wait();
                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<IList<StudentMark>>();
                    readTask.Wait();
                    students = readTask.Result;
                }
                else
                {
                    students = Enumerable.Empty<StudentMark>();
                }
            }
            return View(students);
        }

        // GET: StudentMarks/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            StudentMark student = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:55656/api/API/");
                var responseTask = client.GetAsync($"getstudentid/{id}");
                responseTask.Wait();
                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<StudentMark>();
                    readTask.Wait();
                    student = readTask.Result;
                }
                else
                {
                    student = new StudentMark();
                }
            }

            return View(student);
        }

        // GET: StudentMarks/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StudentMarks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,Name,Age,Mark")] StudentMark stu)
        {
            if (ModelState.IsValid)
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://localhost:55656/api/API/");
                    var responceTask = client.PostAsJsonAsync("addstudent", stu);
                    responceTask.Wait();
                    var result = responceTask.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        return View(stu);
                    }
                }
               
            }

            return View(stu);
        }

        // GET: StudentMarks/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudentMark studentMark = db.StudentMarks.Find(id);
            if (studentMark == null)
            {
                return HttpNotFound();
            }
            return View(studentMark);
        }

        // POST: StudentMarks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,Name,Age,Mark")] StudentMark stu)
        {
            if (ModelState.IsValid)
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://localhost:55656/api/API/");
                    var responceTAsk = client.PostAsJsonAsync("updatestudent", stu);
                    responceTAsk.Wait();
                    var result = responceTAsk.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        return RedirectToAction("Index");
                    }    
                    else
                    {
                        return View(stu);
                    }
                }
                
            }
            return View(stu);
        }

        // GET: StudentMarks/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudentMark studentMark = db.StudentMarks.Find(id);
            if (studentMark == null)
            {
                return HttpNotFound();
            }
            return View(studentMark);
        }

        // POST: StudentMarks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
           
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://localhost:55656/api/API/");
                    var responceTask = client.DeleteAsync($"deletestudent/{id}");
                    responceTask.Wait();
                    var result = responceTask.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        return View();
                    }
                }
            
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
