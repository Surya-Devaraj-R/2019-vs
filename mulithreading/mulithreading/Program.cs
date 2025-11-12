using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace mulithreading
{
    class Program
    {
        static void Main(string[] args)
            {
                //creating a thread methon using the run method as it function to handle
                Thread newob1 = new Thread(new ThreadStart(run1));
            Thread newob2 = new Thread(new ThreadStart(run2));  

            newob1.Start();
            
            newob2.Start();
                Console.ReadKey();
            }

            public static void run1()
            {
                for (int i = 0; i <= 10; i++)
                {
                    Console.WriteLine("Thread1 is {0}", i);
                Thread.Sleep(500);
                }
            }

        public static void run2()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Thread2 is {0}", i);
                Thread.Sleep(500);
            }
        }



    }
}
