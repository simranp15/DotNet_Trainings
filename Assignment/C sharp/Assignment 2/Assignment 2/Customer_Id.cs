using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Customer_Id
    {

        private static int CustomerID;
        private static string Name;
        private static int Age;
        private static int PhoneNo;
        private static string City;

        public Customer_Id()
        {
        }
        public Customer_Id(int CustId, string name, int age, int Phno, string city)
        {
            CustomerID = CustId;
            Name = name;
            Age = age;
            PhoneNo = Phno;
            City = city;
        }

        static void DisplayCustomer_Id()
        {
            Console.WriteLine($"Customer Id: {CustomerID}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Phone Number: {PhoneNo}");
            Console.WriteLine($"City: {City}");

        }
        public static void Customer_info()
        {
            Console.WriteLine("Create static method");
        }

        ~Customer_Id()       // ~ for destructor
        {
            Console.WriteLine("object destroy");
            Console.Read();
        }

        public static void Main()
        {
            Customer_Id cstidt1 = new Customer_Id();
            Customer_Id cstid2 = new Customer_Id(15, "Simran", 22, 91293, "Kushinagar");
            DisplayCustomer_Id();
            Console.Read();


        }
    }
}

