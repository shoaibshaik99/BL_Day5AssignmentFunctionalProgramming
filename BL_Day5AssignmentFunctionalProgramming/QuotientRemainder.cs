using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL_Day5AssignmentFunctionalProgramming
{
    internal class QuotientRemainder
    {
        public static void Q_R()
        {
            Console.Write("Enter the dividend: ");
            int dividend = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the dividend: ");
            int divisor = Convert.ToInt32(Console.ReadLine());
            if (divisor == 0)
            {
                Console.WriteLine("Division with 0 is undefined");
                return;
            }
            Console.WriteLine("Quotient: " + (dividend / divisor) + ", Remainder: " + (dividend % divisor));
        }
    }
}
