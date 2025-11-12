using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class main
    {
        public void view()
        {
            Console.WriteLine("Hulk");
        }

    }
    
    class A:main
    {
        public void display()
        {
            Console.WriteLine("HeMan");
        }
    }
    class B:A
    {
        public void salsa()
        {
            Console.WriteLine("Ironman");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            B obj = new B();
            obj.view();    
            obj.display();  
            obj.salsa();

            Console.ReadKey();
        } 


        
        
    }
}
