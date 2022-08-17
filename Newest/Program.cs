using System;
using System.Linq;

namespace Newest
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 15;
            int b = 20;

            Console.WriteLine(a + " " + b);

            a = a + b;
            b = a - b;
            a = a - b; 

            Console.WriteLine(a + " " + b); 
        }
    }
}
