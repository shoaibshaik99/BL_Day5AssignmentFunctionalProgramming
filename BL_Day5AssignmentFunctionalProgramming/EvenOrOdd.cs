using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL_Day5AssignmentFunctionalProgramming
{
    internal class EvenOrOdd
    {
        public static void EO()
        {
            Console.Write("Enter an integer to check if it is even or odd: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n%2 == 0)
            {
                Console.WriteLine(n + " is an even number");
            }
            else
            {
                Console.WriteLine(n + " is an odd number");
            }
            
        }
    }
}
