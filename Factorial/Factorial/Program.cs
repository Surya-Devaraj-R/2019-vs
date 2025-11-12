using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your number:");
            int num = Convert.ToInt32(Console.ReadLine());
            int fact = 1;


            for (int i = 1; i <= num; i++)

            {
                fact *= i;
            }
            Console.WriteLine(fact);


            Console.ReadKey();
        }
    }
}
