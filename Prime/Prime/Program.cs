using System;

namespace Prime
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.Write("Enter a number: ");
            //int inputNumber = Convert.ToInt32(Console.ReadLine());
            //int totalDivisor = 0;

            //for (int currentDiv = 1; currentDiv <= inputNumber; currentDiv++)
            //{
            //    if (inputNumber % currentDiv == 0)
            //    {
            //        totalDivisor ++;
            //    }
            //}

            //if (totalDivisor == 2)
            //    Console.WriteLine(inputNumber + " is a Prime Number.");
            //else
            //    Console.WriteLine(inputNumber + " is Not a Prime Number.");

            //Console.ReadKey();
            Console.Write("Enter a number: ");
            int inputNumber = Convert.ToInt32(Console.ReadLine());
            int flag = 0;
            for(int i =2;i<inputNumber;i++)
            {
                if (inputNumber % i ==0)
                {
                    flag = 1;
                    break;
                }

            }
            if (flag == 0)
            {
                Console.WriteLine(inputNumber + " is a Prime Number.");
            }
            else
            {
                Console.WriteLine(inputNumber + " is Not a Prime Number.");
            }

            Console.ReadKey();

        }
    }
}
