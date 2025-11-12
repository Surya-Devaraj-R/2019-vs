using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class UserInsert
    {
        public int Sid { get; set; }
        public int Did { get; set; }
        [Required(ErrorMessage = "Enter your name")]
        public string Sname { get; set; }
        [Range(18, 60, ErrorMessage = "Enter your age")]
        public int Sage { get; set; }
        public string Sphoto { get; set; }
        public string msg { get; set; }
    }

    public class stClass
    {
        public int Sid { get; set; }
        public string statename { get; set; }
    }

    public class disClass
    {
        public int Did { get; set; }
        public int Sid { get; set; }
        public string Districtname { get; set; }
    }
}
