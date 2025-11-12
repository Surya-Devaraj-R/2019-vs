using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindrome_test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your number to check if it is palindrome");
            int number = Convert.ToInt32(Console.ReadLine());
            int number_before = number;
            int rev = 0;
            while (number > 0)
            {
                int rem = number % 10;
                rev = rev * 10 + rem;
                number = number / 10;

            }

            Console.WriteLine($"The reverse of givenm number : {rev}");

            if (number_before == rev)
            {
                Console.WriteLine($"The reverse of given number is palindrom");
            }
            else
            {
                Console.WriteLine($"The reverse of given number is not palindrom");
            }

            Console.ReadKey();
        }
    }
}
