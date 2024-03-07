using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class String
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your First Name:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter your Last Name:");
            string lastName = Console.ReadLine();

            Display(firstName, lastName);
        }


        static void Display(string firstName, string lastName)
        {
            Console.WriteLine($"First Name: {firstName.ToUpper()}");
            Console.WriteLine($"Last Name: {lastName.ToUpper()}");

            Console.Read();
        }

        }
    }
    
