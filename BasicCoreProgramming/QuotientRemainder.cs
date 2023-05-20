using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgramming
{
    public class QuotientRemainder
    {
        public void findQuAndReminder()
        {
            Console.Write("Enter the dividend: ");
            int dividend = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the divisor: ");
            int divisor = Convert.ToInt32(Console.ReadLine());

            int quotient, remainder;

            ComputeQuotientAndRemainder(dividend, divisor, out quotient, out remainder);

            Console.WriteLine($"Quotient: {quotient}");
            Console.WriteLine($"Remainder: {remainder}");
        }

        static void ComputeQuotientAndRemainder(int dividend, int divisor, out int quotient, out int remainder)
        {
            quotient = dividend / divisor;
            remainder = dividend % divisor;
        }
    }
    }

