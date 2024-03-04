using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Two_Integer
    
        {
            public void Equal()
            {
                int a;
                int b;
                Console.Write("enter a value of a:");
                a = int.Parse(Console.ReadLine());
                Console.Write("enter a value of b :");
                b = int.Parse(Console.ReadLine());
                if (a == b)
                {

                    Console.WriteLine("equal");
                }
                else
                {
                    Console.WriteLine("not equal");
                }
            }
        }
    }

