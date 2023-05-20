namespace BL_Day5AssignmentFunctionalProgramming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select a program to run");
            Console.WriteLine("1.Flip a coin\n2.Check Leap Year\n3.Power of 2\n4.Nth Harmonic\n5.Prime factors of a number\n" + 
                "6.Quotient and Remainder\n7.Swapping the numbers\n8.Check even or odd\n9.Check vowel or consonent\n10.Largest among 3 numebers");
            int programNum = Convert.ToInt32(Console.ReadLine());
            switch (programNum)
            {
                case 1:
                    FlipCoin.Flip();
                    break;
                case 2:
                    LeapYear.CheckLeapYear();
                    break;
                case 3:
                    PowerOf2.TwoPower();
                    break;
                case 4:
                    HarmonicNum.HarmonicNumber();
                    break;
                case 5:
                    //Console.WriteLine("Enter num to check prime: ");
                    //int n = Convert.ToInt32(Console.ReadLine());
                    //Factors.isPrime(n);
                    Factors.PrimeFactors();
                    break;
                 case 6:
                    QuotientRemainder.Q_R();
                    break;
                case 7:
                    Swap2Numbers.swap();
                    break;
                case 8:
                    EvenOrOdd.EO();
                    break;
                case 9:
                    VowelOrConsonent.VC();
                    break;
                case 10:
                    LargestOfThree.Largest();
                    break;
                default:
                    Console.WriteLine("Improper input, prgram ends here");
                    break; 
            }
        }
    }
}