using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgramming
{
    public class EvenOdd
    {
        public void CheckEvenOdd()
        {
            Console.WriteLine("Enter a number for check its Even or Odd ...");
            int num = Convert.ToInt16(Console.ReadLine());
            if(num % 2 == 0)
            {
                Console.WriteLine(num + " is Even Number...");
            }
            else
            {
                Console.WriteLine(num + " is Even Number...");
            }
        }
    }
}
