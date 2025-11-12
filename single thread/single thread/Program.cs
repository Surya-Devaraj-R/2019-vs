using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace single_thread
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating a thread methon using the run method as it function to handle
            Thread newob = new Thread(new ThreadStart(run));
            newob.Start();
            Console.ReadKey();
        }

        public static void run()
        {
            for (int i = 0; i <=10; i++)
            {
                Console.WriteLine("Thread is {0}", i);
            }
        }

    }
}
