using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Length
    
        {

            public void Len()
            {
                Console.Write("enter a word :");
                string ip = Console.ReadLine();
                int ln = ip.Length;
                Console.WriteLine($"length {ln}");
                string word1, word2;
                Console.Write("enter word 1: ");
                word1 = Console.ReadLine();
                Console.Write("enter word 2: ");
                word2 = Console.ReadLine();
                if (string.Equals(word1, word2, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("are saame");
                }
                else
                {
                    Console.WriteLine("are not same");
                }
            }
        }
    }


