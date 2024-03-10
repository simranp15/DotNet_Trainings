using System;
using Concession;

namespace Assignment04cket
{
    class Program
    {
        static void Main(string[] args)
        {


            TicketConcession tc = new TicketConcession();
                

            Console.Write("Enter passenger name: ");
            string name = Console.ReadLine();

            Console.Write("Enter passenger age: ");
            int age = int.Parse(Console.ReadLine());
            tc.CalculateConcession(age,name);

            
            

            Console.ReadLine();
        }
    }
}
