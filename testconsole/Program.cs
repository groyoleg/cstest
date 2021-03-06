using System;
using cstest.calc;

namespace cstest.testconsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int x=3;
            int y=4*x;
            Console.WriteLine("y + x = {0}", Calc.Sum(x,y));
        }

    }
}