using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the row:");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the col:");
            int col = Convert.ToInt32(Console.ReadLine());

            int[,] arr = new int[row, col];

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)

                {
                    Console.WriteLine($"Enter element at({ i},{ j}):");
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("\nThe 2D array is:");

            // Print the array
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }   Console.ReadKey();
        }
    }
}
