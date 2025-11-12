using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace mcvexp.Models
{
    public class Testcls
    {
        [Required(ErrorMessage ="Name is Required")]
        public string name { set; get; }

        [Range(18,60,ErrorMessage ="Enter Valid Age")]
        public int age { set; get; }

        [Required(ErrorMessage = "Address is Required")]
        public string address { set; get; }

        public string msg { set; get; }
    }
}