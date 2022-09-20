using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            // Create an int Array and populate numbers 1-10
            int[] oneToTen = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            /* Create two Lists of type int.
             * Name one List "evens"
             * Name the other List "odds"
             */

            List<int> evens = new List<int>();
            List<int> odds = new List<int>();

            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */

            foreach (int item in oneToTen)
            {
                if (item % 2 == 0)
                {
                    evens.Add(item);
                }
                else
                {
                    odds.Add(item);
                }
            }

            /* Now using foreach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
             */
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Even numbers: ");
            foreach (int item in evens)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Odd numbers: ");
            foreach (int item in odds)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("--------------------------------------------------");
        }
    }
}
