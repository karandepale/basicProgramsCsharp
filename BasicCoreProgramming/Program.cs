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

            // find greatest number amongst 3 numbers
            LargestNumber obj4 = new LargestNumber();
            obj4.LargestAmongThree();

            // Compute Quotient and Reminder
            QuotientRemainder obj5 = new QuotientRemainder();
            obj5.findQuAndReminder();

            // Calculate Factor 
            Factor obj6 = new Factor();
            obj6.CalculateFactor();

        }
    }
}
