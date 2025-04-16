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
            string x, y;
            x = Console.ReadLine();
            y = Console.ReadLine();
            int a = int.Parse(x);
            int b = int.Parse(y);
            int SUM = a + b;
            Console.WriteLine("Sum = " + SUM);
        }
    }
}
