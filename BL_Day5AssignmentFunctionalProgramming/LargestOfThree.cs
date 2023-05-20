using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL_Day5AssignmentFunctionalProgramming
{
    internal class LargestOfThree
    {
        public static void Largest()
        {
            Console.Write("Enter the first number: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the third number: ");
            int n3 = Convert.ToInt32(Console.ReadLine());

            int largest;
            if (n1 > n2)
            {
                largest = n1;
            }
            else
            {
                largest = n2;
            }

            if (n3> largest)
            {
                largest = n3;
            }
            Console.WriteLine("Largest number among these 3 numbers is: " + largest);
        }
    }
}
