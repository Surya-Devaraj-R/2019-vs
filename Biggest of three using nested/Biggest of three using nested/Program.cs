using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biggest_of_three_using_nested
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your fNumber: ");
            int fNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your sNumber: ");
            int snumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your tNumber: ");
            int tnumber = Convert.ToInt32(Console.ReadLine());
            //int biggest;

            if (fNumber>snumber)
            {
                if (fNumber>tnumber)
                {
                    Console.WriteLine($"{fNumber}is Biggest");
                }

                else
                {
                    Console.WriteLine($"{tnumber}is Biggest");
                }
            }

            else
            {
                if (snumber> tnumber)
                {
                    Console.WriteLine($"{snumber} is biggest");
                }
                else
                {
                    Console.WriteLine($"{tnumber} is biggest");
                }
            }

            Console.ReadKey();


        }
    }
}
