using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    //-----------------Answer3--------------------
    class Employee

    {
        public int EmpId;
        public string EmpName;
        public float Salary;

        public Employee(int EmpId, string EmpName, float Salary)
        {
            this.EmpId = EmpId;
            this.EmpName = EmpName;
            this.Salary = Salary;
        }
    }
    class ParttimeEmployee : Employee
    {
        int wages;
        public ParttimeEmployee(int EmpId, string EmpName, float salary, int wages) : base(EmpId, EmpName, salary) // dereived  class constructor 
        {
            this.wages = wages;
        }
        
       
       public static void Main(string[] args)
        {

            Console.WriteLine("Enter EmployeeID, Name, Salary and Wages: ");

            int Id = int.Parse(Console.ReadLine());
            string name = Console.ReadLine();
            float sal = int.Parse(Console.ReadLine());
            int wages = int.Parse(Console.ReadLine());

            // base class through constructor
            ParttimeEmployee ptemp = new ParttimeEmployee(Id, name, sal, wages);

            Console.WriteLine($"Employee ID: {ptemp.EmpId}");
            Console.WriteLine($"Employee Name: {ptemp.EmpName}");
            Console.WriteLine($"Employee Salary: {ptemp.Salary}");
            Console.WriteLine($"Employee Wages: {ptemp.wages}");
            Console.WriteLine($"Employee ID: {ptemp.EmpId}, Employee Name: {ptemp.EmpName}, Employee Salary: {ptemp.Salary}, Employee Wages: {ptemp.wages}");
          
            Console.Read();
        }
    }
}



    

