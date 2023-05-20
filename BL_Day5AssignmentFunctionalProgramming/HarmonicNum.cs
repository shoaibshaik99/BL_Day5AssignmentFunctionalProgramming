using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL_Day5AssignmentFunctionalProgramming
{
    internal class HarmonicNum
    {
        public static void HarmonicNumber()
        {
            Console.WriteLine("Enter the number of harmonic that you desire to find: ");
            int n = Convert.ToInt32(Console.ReadLine());
            double sum = 0;
            for (int i = 1; i <= n;i++)
            {
                if (i!=n)
                {
                    Console.Write("1/{0} + ",i);
                }
                else if (i == n)
                {
                    Console.Write("1/{0}", i);
                }
                sum = sum + 1 / ((double)i);
            }
            Console.WriteLine("\nNth harmonic value is " + sum);
        }
    }
}
