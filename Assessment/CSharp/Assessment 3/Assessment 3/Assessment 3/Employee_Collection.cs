using System;
using System.Collections.Generic;
using System.Linq;


namespace Assessment_3
{
    class Employee_Collection
    { 
            public int EmployeeID { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Title { get; set; }
            public DateTime DOB { get; set; }
            public DateTime DOJ { get; set; }
            public string City { get; set; }
        }
    class Employee_Program
        {
            static void Main()
            {
                //--------------EmployeeCollectionList--------------------------
                List<Employee_Collection> empList = new List<Employee_Collection>
            {
                
            new Employee_Collection { EmployeeID = 1001, FirstName = "Malcolm", LastName = "Daruwalla", Title = "Manager", DOB = DateTime.Parse("1984-11-16"), DOJ = DateTime.Parse("2011-06-08"), City = "Mumbai" },
            new Employee_Collection { EmployeeID = 1002, FirstName = "Asdin", LastName = "Dhalla", Title = "AsstManager", DOB = DateTime.Parse("1984-08-20"), DOJ = DateTime.Parse("2012-07-07"), City = "Mumbai" },
            new Employee_Collection { EmployeeID = 1003, FirstName = "Madhavi", LastName = "Oza", Title = "Consultant", DOB = DateTime.Parse("1987-11-14"), DOJ = DateTime.Parse("2015-04-12"), City = "Pune" },
            new Employee_Collection { EmployeeID = 1004, FirstName = "Saba", LastName = "Shaikh", Title = "SE", DOB = DateTime.Parse("1990-06-03"), DOJ = DateTime.Parse("2016-02-02"), City = "Pune" },
            new Employee_Collection { EmployeeID = 1005, FirstName = "Nazia", LastName = "Shaikh", Title = "SE", DOB = DateTime.Parse("1991-03-08"), DOJ = DateTime.Parse("2016-02-02"), City = "Mumbai" },
            new Employee_Collection { EmployeeID = 1006, FirstName = "Amit", LastName = "Pathak", Title = "Consultant", DOB = DateTime.Parse("1989-11-07"), DOJ = DateTime.Parse("2014-08-08"), City = "Chennai" },
            new Employee_Collection { EmployeeID = 1007, FirstName = "Vijay", LastName = "Natrajan", Title = "Consultant", DOB = DateTime.Parse("1989-12-02"), DOJ = DateTime.Parse("2015-06-01"), City = "Mumbai" },
            new Employee_Collection { EmployeeID = 1008, FirstName = "Rahul", LastName = "Dubey", Title = "Associate", DOB = DateTime.Parse("1993-11-11"), DOJ = DateTime.Parse("2014-11-06"), City = "Chennai" },
            new Employee_Collection { EmployeeID = 1009, FirstName = "Suresh", LastName = "Mistry", Title = "Associate", DOB = DateTime.Parse("1992-08-12"), DOJ = DateTime.Parse("2014-12-03"), City = "Chennai" },
            new Employee_Collection { EmployeeID = 1010, FirstName = "Sumit", LastName = "Shah", Title = "Manager", DOB = DateTime.Parse("1991-04-12"), DOJ = DateTime.Parse("2016-01-02"), City = "Pune" }
        };

            //-----------Using Linq query----------------------------------------
            //----------a) Display  detail of all the employee----------------------------------------
            Console.WriteLine("Details of all employees:");
                foreach (var emp in empList)
                {
                    Console.WriteLine($"{emp.EmployeeID} - {emp.FirstName} {emp.LastName}, {emp.Title}, DOB: {emp.DOB.ToShortDateString()}, DOJ: {emp.DOJ.ToShortDateString()}, City: {emp.City}");
                }

                //---------------------------- b) Display details of employees whose location is not Mumbai----------------------------------
                var nonMumbaiEmployees = empList.Where(emp => emp.City != "Mumbai");
                Console.WriteLine("\nEmployees not in Mumbai:");
                foreach (var emp in nonMumbaiEmployees)
                {
                    Console.WriteLine($"{emp.FirstName} {emp.LastName}, City: {emp.City}");
                }

                //------------------------ c)Display details of employees whose title is AsstManager---------------------------------------
                var asstManagers = empList.Where(emp => emp.Title == "AsstManager");
                Console.WriteLine("\nAsstManagers:");
                foreach (var emp in asstManagers)
                {
                    Console.WriteLine($"{emp.FirstName} {emp.LastName}, Title: {emp.Title}");
                }

                //------------------------ d) Display details of employees whose Last Name starts with S----------------------------------------
                var lastNameStartsWithS = empList.Where(emp => emp.LastName.StartsWith("S"));
                Console.WriteLine("\nEmployees with Last Name starting with S:");
                foreach (var emp in lastNameStartsWithS)
                {
                    Console.WriteLine($"{emp.FirstName} {emp.LastName}");
                }
            Console.Read();
            }
        }
    }


