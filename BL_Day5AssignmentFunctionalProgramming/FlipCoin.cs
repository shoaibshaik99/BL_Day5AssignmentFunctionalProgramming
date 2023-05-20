using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL_Day5AssignmentFunctionalProgramming
{
    internal class FlipCoin
    {
        public static void Flip ()
        {
            Console.WriteLine("Enter the number of times coin flips you want to perform");
            int n = Convert.ToInt32(Console.ReadLine());
            int headsCount = 0, tailsCount = 0;
            Random random = new Random();
            for (int i = 1; i <= n; i++)
            {
                if (random.NextDouble() > 0.5)
                {
                    headsCount++;
                }
                else
                {
                    tailsCount++;
                }
            }
            Console.WriteLine("For {0} flips", n);
            Console.WriteLine("Percentage of heads: " + ((double)headsCount / n) * 100 + "%");
            Console.WriteLine("Percentage of tails: " + ((double)tailsCount / n) * 100 + "%");
        }
    }
}
