using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("int min = -2");
            Console.WriteLine("int max = 2");

            Console.WriteLine("long min = -9");
            Console.WriteLine("long max = 9");

            Console.WriteLine("double min = -1.738");
            Console.WriteLine("double max = 1.7308");

            string a = "Sadiq";
            string b = "Aman";

            Console.WriteLine("string min = " + (a.CompareTo(b) < 0 ? a : b));
            Console.WriteLine("string max = " + (a.CompareTo(b) > 0 ? a : b));
        }
    }
}
