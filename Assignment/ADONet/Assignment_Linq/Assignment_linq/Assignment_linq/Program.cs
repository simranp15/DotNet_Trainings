using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Assignment_linq
{
    public class Employee
    {
        static void Main(string[] args)
        {
            DataTable employeeDataTable = Employee.GetTable();
            //Employee.DisplayData(employeeDataTable);

            //Console.WriteLine("Employees who joined before 1/1/2015:-");
            //DisplayEmployeesJoinedBefore(employeeDataTable);


            // Console.WriteLine("Employees whose date of birth is after 1/1/1990:-");
            //DisplayEmployeesDOBAfter(employeeDataTable);


            //Console.WriteLine("Employees with designations 'Consultant' and 'Associate':-:");
            // DisplayEmployeesByDesignation(employeeDataTable);


            //Console.WriteLine(" Total number of employees:-");
            //DisplayTotalEmployees(employeeDataTable);

            //Console.WriteLine(" Total number of employees belonging to 'Chennai:-");
            //DisplayEmployeesInCity(employeeDataTable, "Chennai");

            //Console.WriteLine("Highest employee ID");
            //DisplayHighestEmployeeID(employeeDataTable);

            // Console.WriteLine("Total number of employees joined after 1/1/2015:-");
            // DisplayEmployeesJoinedAfter(employeeDataTable, new DateTime(2015, 1, 1));

            // Console.WriteLine("Total number of employees whose designation is not 'Associate:-");
            // DisplayEmployeesNotAssociate(employeeDataTable);

            //Console.WriteLine(" Total number of employees based on city :-");
            //DisplayTotalEmployeesByCity(employeeDataTable);

            //Console.WriteLine("Total number of employees based on City and Title:-");
            //DisplayTotalEmployeesByCityAndTitle(employeeDataTable);

            Console.WriteLine("Total number of employee who is youngest in the list");
            DisplayTotalYoungestEmployees(employeeDataTable);

            Console.ReadLine();


        }

        public static DataTable GetTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("EmployeeID", typeof(int));
            dt.Columns.Add("FirstName", typeof(string));
            dt.Columns.Add("LastName", typeof(string));
            dt.Columns.Add("Title", typeof(string));
            dt.Columns.Add("Dob", typeof(DateTime));
            dt.Columns.Add("Doj", typeof(DateTime));
            dt.Columns.Add("City", typeof(string));
            dt.Rows.Add(1001, "Malcolm", "Daruwalla", "Manager", new DateTime(1984, 11, 16), new DateTime(2011, 8, 6), "Mumbai");
            dt.Rows.Add(1002, "Asdin", "Dhalla", "AsstManager", new DateTime(1984, 8, 20), new DateTime(2012, 7, 7), "Mumbai");
            dt.Rows.Add(1003, "Madhavi", "Oza", "Consultant", new DateTime(1987, 11, 14), new DateTime(2015, 12, 4), "Pune");
            dt.Rows.Add(1004, "Saba", "Shaikh", "SE", new DateTime(1990, 6, 3), new DateTime(2016, 2, 2), "Pune");
            dt.Rows.Add(1005, "Nazia", "Shaikh", "SE", new DateTime(1991, 8, 3), new DateTime(2016, 2, 2), "Mumbai");
            dt.Rows.Add(1006, "Amit", "Pathak", "Consultant", new DateTime(1989, 11, 7), new DateTime(2014, 8, 8), "Chennai");
            dt.Rows.Add(1007, "Vijay", "Natrajan", "Consultant", new DateTime(1989, 12, 2), new DateTime(2015, 1, 6), "Mumbai");
            dt.Rows.Add(1008, "Rahul", "Dubey", "Associate", new DateTime(1993, 11, 11), new DateTime(2014, 6, 11), "Chennai");
            dt.Rows.Add(1009, "Suresh", "Mistry", "Associate", new DateTime(1992, 8, 12), new DateTime(2014, 3, 12), "Chennai");
            dt.Rows.Add(1010, "Sumit", "Shah", "Manager", new DateTime(1991, 12, 4), new DateTime(2016, 2, 1), "Pune");

            return dt;
        }
        // For just Displauy the Employee Table----------------------
        public static void DisplayData(DataTable dt)
        {
            foreach (DataRow row in dt.Rows)
            {
                Console.WriteLine($"EmployeeID: {row["EmployeeID"]}, FullName: {row["FirstName"]} {row["LastName"]}, Title: {row["Title"]}, DOB: {((DateTime)row["Dob"]).ToString("dd/MM/yyyy")}, DOJ: {((DateTime)row["Doj"]).ToString("dd/MM/yyyy")}, City: {row["City"]}");
            }

        }
        //1. Display a list of all the employee who have joined before 1/1/2015------------------------------------------------------------------------
        public static void DisplayEmployeesJoinedBefore(DataTable dt)
        {
            DateTime Before_date = new DateTime(2015, 1, 1);

            var Joined_before = dt.AsEnumerable().Where(row => ((DateTime)row["Doj"]).Date < Before_date.Date);
            foreach (DataRow row in Joined_before)
            {
                Console.WriteLine($"EmployeeID: {row["EmployeeID"]}, FullName: {row["FirstName"]} {row["LastName"]}, Title: {row["Title"]}, DOB: {((DateTime)row["Dob"]).ToString("dd/MM/yyyy")}, DOJ: {((DateTime)row["Doj"]).ToString("dd/MM/yyyy")}, City: {row["City"]}");
            }
        }
        //2. Display a list of all the employee whose date of birth is after 1/1/1990-----------------------------------------------------------------
        public static void DisplayEmployeesDOBAfter(DataTable dt)
        {
            DateTime Dob_After = new DateTime(1990, 1, 1);
            var Dob_after = dt.AsEnumerable().Where(row => ((DateTime)row["Dob"]).Date > Dob_After.Date);
            foreach (DataRow row in Dob_after)
            {
                Console.WriteLine($"EmployeeID: {row["EmployeeID"]}, FullName: {row["FirstName"]} {row["LastName"]}, Title: {row["Title"]}, DOB: {((DateTime)row["Dob"]).ToString("dd/MM/yyyy")}, DOJ: {((DateTime)row["Doj"]).ToString("dd/MM/yyyy")}, City: {row["City"]}");
            }
        }
       // 3. Display a list of all the employee whose designation is Consultant and Associate-------------------------------------------
        public static void DisplayEmployeesByDesignation(DataTable dt)
        {
            string[] designations = { "Consultant", "Associate" }; // Define the designations here
            var CA = dt.AsEnumerable().Where(row => designations.Contains(row["Title"].ToString()));
            foreach (DataRow row in CA)
            {
                Console.WriteLine($"EmployeeID: {row["EmployeeID"]}, FullName: {row["FirstName"]} {row["LastName"]}, Title: {row["Title"]}, DOB: {((DateTime)row["Dob"]).ToString("dd/MM/yyyy")}, DOJ: {((DateTime)row["Doj"]).ToString("dd/MM/yyyy")}, City: {row["City"]}");
            }
        }
        //4. Display total number of employees-----------------------------------------------------
        public static void DisplayTotalEmployees(DataTable dt)
        {
            int totalEmployees = dt.Rows.Count;
            Console.WriteLine($"Total number of employees: {totalEmployees}");
        }
       // 5. Display total number of employees belonging to “Chennai”-------------------------------------------------------------
        public static void DisplayEmployeesInCity(DataTable dt, string city)
        {
            int employeesInCity = dt.AsEnumerable().Count(row => row.Field<string>("City") == city);
            Console.WriteLine($"Total number of employees in {city}: {employeesInCity}");
        }
      //  6. Display highest employee id from the list------------------------------------------------------------------------
        public static void DisplayHighestEmployeeID(DataTable dt)
        {
            var highestEmployeeID = dt.AsEnumerable().Max(row => row.Field<int>("EmployeeID"));
            Console.WriteLine($"Highest Employee ID: {highestEmployeeID}");
        }
        //7. Display total number of employee who have joined after 1/1/2015.-----------------------------------------------------
        public static void DisplayEmployeesJoinedAfter(DataTable dt, DateTime afterDate)
        {
            int employeesJoinedAfter = dt.AsEnumerable().Count(row => row.Field<DateTime>("Doj") > afterDate);
            Console.WriteLine($"Total number of employees joined after {afterDate.ToShortDateString()}: {employeesJoinedAfter}");
        }
    // 8. Display total number of employee whose designation is not “Associate”------------------------------------
        public static void DisplayEmployeesNotAssociate(DataTable dt)
        {
            int employeesNotAssociate = dt.AsEnumerable().Count(row => row.Field<string>("Title") != "Associate");
            Console.WriteLine($"Total number of employees whose designation is not 'Associate': {employeesNotAssociate}");
        }
        //9.Display total number of employee based on City-------------------
        public static void DisplayTotalEmployeesByCity(DataTable dt)
        {
            var employeesByCity = dt.AsEnumerable()  .GroupBy(row => row.Field<string>("City"))  .Select(group => new
                {      City = group.First()["City"],
                       TotalEmployees = group.Count()
                   });
            foreach (var group in employeesByCity)
            {
                Console.WriteLine($"Total number of employee based  in {group.City}: {group.TotalEmployees}");
            }
        }
        //  10. Display total number of employee based on city and title--------------------------------
        public static void DisplayTotalEmployeesByCityAndTitle(DataTable dt)
        {
            var employeesByCityAndTitle = dt.AsEnumerable().GroupBy(row => new { City = row.Field<string>("City"), Title = row.Field<string>("Title") }).Select(group => new
            {
                City = group.First()["City"],
                Title = group.First()["Title"],
                TotalEmployees = group.Count()
            });
            foreach (var group in employeesByCityAndTitle)
            {
                Console.WriteLine($"Total number of employee  in {group.City} with {group.Title} title is : {group.TotalEmployees}");
            }
        }
        //  11. Display total number of employee who is youngest in the list-----------------------------------------------------------
        public static void DisplayTotalYoungestEmployees(DataTable dt)
        {
            var youngestDOB = dt.AsEnumerable().Min(row => row.Field<DateTime>("Dob"));
            var youngestEmployeesCount = dt.AsEnumerable().Count(row => row.Field<DateTime>("Dob") == youngestDOB);
            Console.WriteLine($"Total Number of employees with the youngest age: {youngestEmployeesCount}");
        }
    }
}
