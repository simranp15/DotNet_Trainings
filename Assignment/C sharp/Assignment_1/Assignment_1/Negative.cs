using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Negative
    
        {
        public void Check()
        {
            int num1;
            Console.WriteLine("enter a value: ");
            num1 = int.Parse(Console.ReadLine());
            if (num1 < 0)
            {
                Console.WriteLine("negative");

            }
            else
            {
                Console.WriteLine("positive");
            }
            Console.ReadLine();

        }
    }
}
    
