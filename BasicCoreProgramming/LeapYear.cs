using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgramming
{
    public class LeapYear
    {
        public void CheckLeapYear()
        {
            Console.Write("Enter a year: ");
            int year = Convert.ToInt32(Console.ReadLine());

            if (year >= 1000 && year <= 9999)
            {
                bool isLeapYear = IsLeapYear(year);
                if (isLeapYear)
                    Console.WriteLine($"{year} is a leap year.");
                else
                    Console.WriteLine($"{year} is not a leap year.");
            }
            else
            {
                Console.WriteLine("Invalid input. Year should be a four-digit number.");
            }
        }

        static bool IsLeapYear(int year)
        {
            // Leap year is divisible by 4 but not divisible by 100, except if it's divisible by 400.
            return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        }
    }
    }

