﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class Count_letter

    {
       

        static int CountOccurrences(string input, char target)
        {
            int count = 0;
            foreach (char letter in input)
            {
                if (char.ToUpper(letter) == char.ToUpper(target))
                {
                    count++;
                }
            }
            return count;
        }
        static void Main()
        {
            Console.Write("Enter a string: ");
            string inputString = Console.ReadLine();

            Console.Write("Enter the letter to count: ");
            char letterToCount = Console.ReadKey().KeyChar;

            int count = CountOccurrences(inputString, letterToCount);

            Console.WriteLine($"\n'{letterToCount}' appears {count} times in the given string.");
            Console.Read();
        }

    } 
    }


