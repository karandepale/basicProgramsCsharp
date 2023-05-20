using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgramming
{
    public class HarmonicNumber
    {
        public void FindHarmonicNumber()
        {
            Console.Write("Enter the value of N: ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n != 0)
            {
                double harmonicNumber = ComputeHarmonicNumber(n);
                Console.WriteLine($"The {n}th Harmonic Number is: {harmonicNumber}");
            }
            else
            {
                Console.WriteLine("Invalid input. N should be a non-zero value.");
            }
        }

        static double ComputeHarmonicNumber(int n)
        {
            double harmonicNumber = 0.0;

            for (int i = 1; i <= n; i++)
            {
                harmonicNumber += 1.0 / i;
            }

            return harmonicNumber;
        }
    }
    }

