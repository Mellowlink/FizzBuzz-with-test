using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz_with_Test
{
    public class FizzBuzz
    {
        public void Activate(int start = 1, int end = 100)
        {
            //perform the loop here instead of in Main to allow optional loop length
            for (int i = start; i <= end; i++)
            {
                Console.WriteLine(PrintVal(i));
            }
        }

        public string PrintVal(int val)
        {
            //separate this for easy testing
            string result;
            
            if (val % 5 == 0 && val % 3 == 0)
            {
                result = "Fizz Buzz";
            }
            else if (val % 5 == 0)
            {
                result = "Buzz";
            }
            else if (val % 3 == 0)
            {
                result = "Fizz";
            }
            else
            {
                result = val.ToString();
            }

            return result;
        }
    }
}
