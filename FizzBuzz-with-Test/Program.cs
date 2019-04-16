using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz_with_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            FizzBuzz myFB = new FizzBuzz();
            myFB.Activate(); //no parameters, go with the default range for demonstration purposes

            Console.ReadKey();
        }

       
    }
}
