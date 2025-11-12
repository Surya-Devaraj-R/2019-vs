using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_to_print_5_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enterarray length:");
            int length = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[length];
            Console.WriteLine("Enter Array Elements:");
            for (int i = 0; i < length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("The Array is:");
            for(int i = 0; i <length; i++)
            {
                Console.WriteLine(arr[i]);
            }Console.ReadKey();
        }
    }
}
