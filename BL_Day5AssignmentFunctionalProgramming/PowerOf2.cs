using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL_Day5AssignmentFunctionalProgramming
{
    internal class PowerOf2
    {
        public static void TwoPower()
        {
            Console.WriteLine("Enter a number (0<=Number<31), to calculate the 2 power table:");
            int n = Convert.ToInt32(Console.ReadLine());
            int power2 = 1;
            if (0<=n && n<31)
            {
                for (int i = 0; i <= n; i++)
                {
                    Console.WriteLine("2 power {0}:{1}", i, power2);
                    power2 = 2 * power2;
                }
            }
            else
            {
                ; Console.WriteLine("Input not in range, exiting the program");
            }
;        }
    }
}
