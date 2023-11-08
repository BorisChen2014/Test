using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 123;
            int b = 456;
            var c = Func2(a, b);
            Console.WriteLine("Hello");
        }

        private static int Func2(int a,int b)
        {
            return a * b;
        }
    }
}
