using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1

    
    {
        class Multiplication
        {
            public void Mul()
            {
                int num1;
                Console.Write("enter a number :");
                num1 = Convert.ToInt32(Console.ReadLine());
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine($"multiple: {num1}");
                }
                Console.ReadLine();
            }
        }
    }


