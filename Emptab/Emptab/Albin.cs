using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace Emptab
{
    [Table(Name = "Employee")]
    public class Albin
    {
        
        [Column(IsPrimaryKey = true)]
        public int id { set; get; }

        [Column]
        public string Name { set; get; }

        [Column]
        public int Age { set; get; }

        [Column]
        public long Salary { set; get; }

    }
}