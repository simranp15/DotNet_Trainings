using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Assessment_1
{
    class Program
    {
        public static SqlConnection con = null;
        public static SqlCommand cmd;
        public static SqlDataReader dr;

        static void Main(string[] args)
        {
           InsertEmployee_details();
            Display_Employeedetails();
            Console.ReadKey();

        }

        public static SqlConnection GetConnection()
        {
            con = new SqlConnection("data source=ICS-LT-FL7J8G3/SQLEXPRESS ;initial catalog=Employeemanagement;" +
                "integrated security=true");
            con.Open();
            return con;
        }
        public static void InsertEmployee_details()
        { 
             con = GetConnection();

            int Empsal,Empno;
            string Empname, Emptype;
            try { 
          
                Console.WriteLine("Enter Emp NO");
                Empno = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Emp Name");
                Empname = Console.ReadLine();
                Console.WriteLine("Enter Emp salary");
                Empsal = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Emp type");
                Emptype = Console.ReadLine();


                cmd = new SqlCommand("Add_EmployeeDetails", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Empname", Empname);
                cmd.Parameters.AddWithValue("@Empsal", Empsal);
                cmd.Parameters.AddWithValue("@Emptype", Emptype);
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    Console.WriteLine("Employee inserted successfully.");
                }
                else
                {
                    Console.WriteLine("Failed to insert employee.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Some Sql error Occured...: " + ex.Message);
            }
        }
        //4---Display all employee rows
        public static void Display_Employeedetails()
        {
            con = GetConnection();
            cmd = new SqlCommand("select * from Employee_Details", con);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Console.WriteLine("Employee Number : " + dr[0]);
                Console.WriteLine("Employee Name : " + dr[1]);
                Console.WriteLine("Employee Salary : " + dr[2]);
                Console.WriteLine("Employee Type : " + dr[3]);
            }
        }
    }
}