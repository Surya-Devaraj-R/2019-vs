using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Star_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your limit");
            int limit = Convert.ToInt32(Console.ReadLine());
            char letter='A';

            for (int i = 1; i <= limit; i++)
                
            {
                

                for(int j =1; j<=i ;j--)
                {
                    
                    Console.Write(letter + " ");
                    letter ++;
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
