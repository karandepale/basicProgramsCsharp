using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgramming
{
    public class PowerOf2
    {
        public void CalculatePowerOF2()
        {
            Console.Write("Enter the value of N: ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n >= 0 && n < 31)
            {
                Console.WriteLine("Powers of 2:");
                PrintPowersOf2(n);
            }
            else
            {
                Console.WriteLine("Invalid input. N should be between 0 and 30.");
            }
        }

        static void PrintPowersOf2(int n)
        {
            for (int i = 0; i <= n; i++)
            {
                int power = (int)Math.Pow(2, i);
                Console.WriteLine($"2^{i} = {power}");
            }
        }
    }
    }

