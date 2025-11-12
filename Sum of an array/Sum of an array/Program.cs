using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_an_array
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
            int sum = 0;
            for (int i = 0; i < length; i++)
            {
                //Console.WriteLine(arr[i]);
                sum = sum + arr[i];
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
