using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEulerSolutions
{

    /// <summary>
    /// Multiples of 3 and 5.
    /// Problem 1.
    /// If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
    /// Find the sum of all the multiples of 3 or 5 below 1000.
    /// </summary>
    public static class Problem1_Multiples_3_5_Sums_under_1000
    {
        /// <summary>
        /// Find the sum of all the multiples of 3 or 5 below 1000.
        /// </summary>
        /// <returns>int</returns>
        public static int Find_3_5_Sums_Under_1000()
        {
            // Set the initial sum to 0.
            int sum = 0;

            // Loop through every number under 1000, starting at 3 (any number x + 0 == x, so skip 0. We know 1 and 2 are not divisble by 3 or 5, so skip them as well.)
            for (int i = 3; i < 1000; i += 1)
            {
                // If the number is divisble by 3 OR 5, add it to the sum.
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }

            // Return the sum upon completing the loop.
            return sum;
        }

    }
}
