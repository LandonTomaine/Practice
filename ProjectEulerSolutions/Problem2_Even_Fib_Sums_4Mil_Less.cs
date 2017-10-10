﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEulerSolutions
{

    /// <summary>
    /// Even Fibonacci numbers.
    /// Problem 2.
    /// Each new term in the Fibonacci sequence is generated by adding the previous two terms.By starting with 1 and 2, the first 10 terms will be:
    /// 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...
    /// By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms.
    /// </summary>
    public static class Problem2_Even_Fib_Sums_4Mil_Less
    {

        /// <summary>
        /// Returns the sum of all Fibonacci Numbers that are equal to at most 4,000,000.
        /// </summary>
        /// <returns></returns>
        public static long Result_Even_Fib_Sums_4Mil_Less()
        {
            // Set the initial sum to 0.
            int sum = 0;

            // Create a list of integers to hold the Fibonacci Numbers.
            List<int> fibs = new List<int>();

            // The first 2 Fibonacci Numbers are always 1 and 2, so set those now.
            fibs.Add(1);
            fibs.Add(2);

            // We know 1, the first Fibonacci Number, is not even.
            // We know 2, however, is even. Add this to the sum.
            sum += 2;

            // Start at index 2 since we already have the first 2 Fibonacci Numbers ([0] and [1]).
            // Check to make sure the newest Fibonacci Number is less than or equal to 4,000,000 before proceeding, as per the problem definition.
            for (int i = 2; fibs[i - 2] + fibs[i - 1] <= 4000000; i++)
            {
                // Add the next Fibonacci Number to the List by adding the previous two Fibonacci Numbers together.
                fibs.Add(fibs[i - 2] + fibs[i - 1]);

                // As per the problem, if a Fibonacci Number is even, add it to the sum.
                if (fibs[i] % 2 == 0)
                {
                    sum += fibs[i];
                }
            }

            // Return the final sum.
            return sum;
        }

    }
}
