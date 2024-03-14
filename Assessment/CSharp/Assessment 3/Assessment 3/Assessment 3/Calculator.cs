using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_3
{      
        // Delegate for Operation
        delegate int CalculatorDelegate(int a, int b);
        class Calculator
      { 
          static void Main(string[] args)
            {
                Console.WriteLine("Select an operation:");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.Write("Enter your Operation_Name (1/2/3): ");

                int Operation_Preference = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter the first integer value: ");
                int value1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter the second integer value: ");
                int value2 = Convert.ToInt32(Console.ReadLine());

                // Create delegate instances
                CalculatorDelegate addDelegate = Addition;
                CalculatorDelegate subtractDelegate = Subtraction;
                CalculatorDelegate multiplyDelegate = Multiplication;

                int result = 0;

                switch (Operation_Preference)
                {
                    case 1:
                        result = addDelegate(value1, value2);
                        Console.WriteLine($"Result of addition: {result}");
                        break;
                    case 2:
                        result = subtractDelegate(value1, value2);
                        Console.WriteLine($"Result of subtraction: {result}");
                        break;
                    case 3:
                        result = multiplyDelegate(value1, value2);
                        Console.WriteLine($"Result of multiplication: {result}");
                        break;
                    default:
                        Console.WriteLine("Invalid Operation_Name. Select between the prefrence 1, 2, or 3.");
                        break;
                }

                Console.Read();
            }

            // Methods for arithmetic operations
            static int Addition(int a, int b) => a + b;
            static int Subtraction(int a, int b) => a - b;
            static int Multiplication(int a, int b) => a * b;
        }
    }

   
