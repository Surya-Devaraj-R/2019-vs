using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NewMVCWebAPIEntityFramework.Controllers
{
    public class APIController : ApiController
    {
        // GET: api/API
        MVCEnitityFramewordEntities db = new MVCEnitityFramewordEntities();
        [HttpGet]
        [Route("api/API/getstudent")]
        public IHttpActionResult Get()
        {
            return Ok(db.StudentMarks.ToList());
        }

      

        // GET: api/API/5
        [HttpGet]
        [Route("api/API/getstudentid/{id}")]
        public IHttpActionResult Get(int id)
        {
            StudentMark std = db.StudentMarks.Find(id);
            if (std == null)
            {
                return NotFound();
            }
            return Ok(std);
        }

        [HttpPost]
        [Route("api/API/updatestudent")]
        public IHttpActionResult edit(StudentMark studentMark)
        {
            if(ModelState.IsValid)
            {
                db.Entry(studentMark).State = EntityState.Modified;
                db.SaveChanges();
                return Ok(200);
            }
            return BadRequest();
        }

        // POST: api/API
        [HttpPost]
        [Route("api/API/addstudent")]
        public IHttpActionResult Post(StudentMark studentMark)
        {
            if (ModelState.IsValid)
            {
                db.StudentMarks.Add(studentMark);
                db.SaveChanges();
                return Ok(200);
            }
            else
            {
                return BadRequest();
            }
        }

        // PUT: api/API/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/API/5
        [HttpDelete]
        [Route("api/API/deletestudent/{id}")]
        public IHttpActionResult Delete(int id)
        {
            StudentMark std = db.StudentMarks.Find(id);

            if (std == null)
            {
                return NotFound();
            }

            db.StudentMarks.Remove(std);
            db.SaveChanges();

            return Ok(std);
        }
    }
}
