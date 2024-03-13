using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    //--------------------Answer4---------------------
    public interface IStudent
    {
        int StudentId { get; set; }
        string Name { get; set; }
        void ShowDetails();
    }
    class Dayscholar : IStudent
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public void ShowDetails()
        {
            Console.WriteLine($"Dayscholar: StudentID: {StudentId} and Name: {Name}");
        }

    }
    class Resident : IStudent
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public void ShowDetails()
        {
            Console.WriteLine($"Resident: StudentID: {StudentId} and Name: {Name}");
        }
    }
    class StudentTesting {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter StudentID and Name of DayScholar: ");
            Dayscholar daysc = new Dayscholar();
            daysc.StudentId = int.Parse(Console.ReadLine());
            daysc.Name = Console.ReadLine();
            daysc.ShowDetails();
            Console.WriteLine("Enter StudentID and Name of Resident: ");
            Resident resi = new Resident();
            resi.StudentId = int.Parse(Console.ReadLine());
            resi.Name = Console.ReadLine();
            resi.ShowDetails();

            Console.ReadKey();




}    }  }

