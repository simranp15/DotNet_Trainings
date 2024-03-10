using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concession
{
    public  class TicketConcession
    {
        //total fare amount
        private const int TotalFare = 500;

        public void CalculateConcession(int age, string name)
        {
            if (age <= 5)
            {
                Console.WriteLine($"For Children - Free Ticket for {name}, Age: {age}");
            }
            else if (age > 60)
            {
                double discountedFare = 0.3 * TotalFare; // 30%  for senior citizens
                Console.WriteLine($"Senior Citizen - Fare: {discountedFare}, Name: {name}, Age: {age}");
            }
            else
            {
                Console.WriteLine($"Ticket Booked - Fare: {TotalFare}, Name: {name}, Age: {age}");
                Console.ReadLine();


            }
        }
    }
}
