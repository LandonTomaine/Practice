using System;

namespace ProjectEulerSolutions
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sum of Multiples of 3 and 5 under 1000. -- Begin.
            Console.WriteLine("********** Sum of Multiples of 3 and 5 under 1000. **********");
            Console.WriteLine("\t\t\t" + Problem1_Multiples_3_5_Sums_under_1000.Find_3_5_Sums_Under_1000());
            Console.WriteLine("********** Sum of Multiples of 3 and 5 under 1000. **********");
            // Sum of Multiples of 3 and 5 under 1000. -- End

            Console.WriteLine("\n\n");

            // Sum of Even Fibonacci Numbers 4 million or less. -- Begin.
            Console.WriteLine("********** Sum of Even Fibonacci Numbers that are 4 Million or Less. **********");
            Console.WriteLine("\t\t\t" + Problem2_Even_Fib_Sums_4Mil_Less.Result_Even_Fib_Sums_4Mil_Less());
            Console.WriteLine("********** Sum of Even Fibonacci Numbers that are 4 Million or Less. **********");
            // Sum of Even Fibonacci Numbers 4 million or less. -- End.

            Console.WriteLine("\n\n");

            // Largest Prime of a Number. -- Begin.
            Console.WriteLine("********** Largest Prime of a Number (600851475143). **********");
            Console.WriteLine("\t\t\t" + Problem3_Largest_Prime.GetLargestPrimeFactor(600851475143));
            Console.WriteLine("********** Largest Prime of a Number (600851475143). **********");
            // Largest Prime of a Number. -- End.


           




            // Prevent closure.
            Console.WriteLine("\n\nProgram finished.");
            Console.ReadLine();

        }
    }
}
