using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgramming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world... ");

            // Swap Two numbers 
            SwapTwoNum obj = new SwapTwoNum();
            obj.Swap();

            // Check Even Odd
            EvenOdd obj1 = new EvenOdd();
            obj1.CheckEvenOdd();
        }
    }
}
