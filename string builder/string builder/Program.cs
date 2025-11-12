using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_builder
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder obj = new StringBuilder();
            obj.Append("I am");
            obj.Append(" Batman");
            Console.WriteLine(obj);
        }
    }
}
