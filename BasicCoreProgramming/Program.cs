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
            SwapTwoNum obj1 = new SwapTwoNum();
            obj1.Swap();

            // Check Even Odd
            EvenOdd obj2 = new EvenOdd();
            obj2.CheckEvenOdd();

            // Check alphabet is vovel or constant
            VovelConstant obj3 = new VovelConstant();
            obj3.CheckVovelConstant();
        }
    }
}
