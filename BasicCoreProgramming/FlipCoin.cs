using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgramming
{
    public class FlipCoin
    {
        public void PrintPercentage()
        {
            Console.Write("Enter the number of times to flip the coin: ");
            int numberOfFlips = Convert.ToInt32(Console.ReadLine());

            if (numberOfFlips > 0)
            {
                int headsCount = 0;
                int tailsCount = 0;

                Random random = new Random();

                for (int i = 0; i < numberOfFlips; i++)
                {
                    double randomValue = random.NextDouble();

                    if (randomValue < 0.5)
                        headsCount++;
                    else
                        tailsCount++;
                }

                double headsPercentage = (headsCount * 100.0) / numberOfFlips;
                double tailsPercentage = (tailsCount * 100.0) / numberOfFlips;

                Console.WriteLine($"Heads: {headsPercentage}%");
                Console.WriteLine($"Tails: {tailsPercentage}%");
            }
            else
            {
                Console.WriteLine("Invalid input. Number of flips should be a positive integer.");
            }
        }
    }
}

