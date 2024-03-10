using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Square
    
        {
            static void Main(string[] args)
            {
                 Console.WriteLine("Enter a list of numbers :"); // don't give comma just give space
                string input = Console.ReadLine();

            // Convert input string into an array 
            int[] inputNumbers = input.Split(' ')
                .Select(int.Parse)
                .ToArray();
            var squaresGreaterThan20 = inputNumbers
                        .Select(number => number * number)
                        .Where(square => square > 20);

                Console.WriteLine("Squares greater than 20:");
                foreach (var square in squaresGreaterThan20)
                {
                    Console.WriteLine($" Square of the value is {square }, ");
                }

                Console.ReadLine();
            }
        }
    }



