using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {

            void age()
            {
                int personAge;//Local Variable
                personAge = 25;
                Console.WriteLine(personAge);
            }

            string personName; //Global Variable
            personName = "Aman siddique";
            Console.WriteLine(personName);
            age();
        }
    }
}
