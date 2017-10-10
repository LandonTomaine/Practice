using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace ProjectEulerSolutions
{


    /// <summary>
    /// Largest prime factor
    /// Problem 3 
    /// The prime factors of 13195 are 5, 7, 13 and 29.
    /// What is the largest prime factor of the number 600851475143 ?
    /// </summary>
    public static class Problem3_Largest_Prime
    {
        /// <summary>
        /// Takes a given whole number and determines its greatest prime factor.
        /// </summary>
        /// <param name="number"></param>
        /// <returns>long</returns>
        static public long GetLargestPrimeFactor(long number)
        {
            // We start at 2 since this is the first prime number.
            //(A prime number can be divided evenly only by 1 or itself and it must be a whole number greater than 1.)
            long a = 2;

            // Set factor = number; the largest prime factor will start at the number itself and, if possible, will reduce to lower prime factors.
            long factor = number;


            // While 'a^2' is less than or equal to our current factor, continue the loop to check the conditions.
            // We do this because we know that our factor HAS to be less than the square root of the input number.
            // Example: 100; sqrt(101) = 10.049. The only possible combination of factors have to be 10 or less.
            // So once our loop crosses that threshold (a^2 > factor), we end the loop and return the factor because that's the answer.
            while (a * a <= factor)
            {
                // If our factor is divisible by 'a' (has a remainder of 0), set the input number to its current value divided by 'a'.
                // Example: 21; 21 % 2 = 1. 21 % 3 = 0. <--WINNER. So now 'factor' (21) / 'a' (3) == 7. Now we know that 7 is currently the
                // Greatest Common Factor of 21, which means our prime factor will either be 7 or less. In this case, it's 7 since 7 is a prime number.
                // The loop will continue until a^2 is > factor (7) but will never be able to divide 7 evenly, leaving us with 7 as our factor / answer.
                if (factor % a == 0)
                {
                    factor /= a;
                }

                // Else, we continue checking each number by incrementing 'a'.
                else
                {
                    a++;
                }
            }

            // Finally, we return the largest prime factor.
            return factor;
        }



    }
}
