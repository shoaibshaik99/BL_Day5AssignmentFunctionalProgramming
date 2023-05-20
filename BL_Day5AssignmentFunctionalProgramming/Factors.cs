using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL_Day5AssignmentFunctionalProgramming
{
    internal class Factors
    {
        public static void PrimeFactors()
        {
            Console.WriteLine("Enter a positive integer greater than 2 (To find the prime factors): ");
            int n = Convert.ToInt32(Console.ReadLine()); //yet to handle exception
            int count = 0;
            if (n<2)
            {
                Console.WriteLine("Invalid input");
                return;
            }
            for (int i = 2; i /** i*/ <= n; i++)
            {
                int temp = 1;
                if (isPrime(i) && n%i == 0)
                {
                    count++;
                    Console.WriteLine("Prime factor number {0} is {1}",count,i);
                }
            }
        }
        public static bool isPrime(int n)
        {
            if (n <= 1)
            {
                //Console.WriteLine("Not prime");
                return false;
            }
            for (int i = 2; i * i <= n; i++)
            {
                if (n%i==0)
                {
                    //Console.WriteLine("Not prime");
                    return false;
                }
            }
            //Console.WriteLine("prime");
            return true;
        }
    }
}
