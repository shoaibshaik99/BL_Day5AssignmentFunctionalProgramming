using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL_Day5AssignmentFunctionalProgramming
{
    internal class Swap2Numbers
    {
        public static void swap()
        {
            Console.Write("Enter the first number: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            int temp;
            temp = n1;
            n1 = n2;
            n2 = temp;
            Console.WriteLine("After swapping:\nFirst number is {0}\nSecond number is {1}", n1, n2);
        }
    }
}
