using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pass_by_refference
{
    class Program
    {
        public void display(ref int x)
        {
            x = x + 10;
            Console.WriteLine(x);

        }
        static void Main(string[] args)
        {
            int x = 10;
            Program ob = new Program();
            ob.display(ref x);
            Console.WriteLine($"The original number is: {x}");
            Console.ReadLine();

        }
    }
}
