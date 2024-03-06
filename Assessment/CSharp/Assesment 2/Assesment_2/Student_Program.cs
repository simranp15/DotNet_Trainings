using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment_2
{
    public abstract class Student
{

    public string Name { get; set; }
    public int Student_Id { get; set; }
    public double Grade { get; set; }
    public abstract bool IsPassed(double grade);
}

          // Subclass for Undergraduate students
public class Undergraduate : Student
{
    public override bool IsPassed(double grade)
    {

        // If the grade is above 70.0, return passed  true; otherwise, return passed false
        return grade >= 70.0;
    }
}
public class Graduate : Student
{
    public override bool IsPassed(double grade)
    {
        // If the grade is above 80.0, return passed true; otherwise, return passed false
        return grade >= 80.0;
    }
}

class Student_Program
{
      static void Main()
        {
            // Example for both  
            var undergradStudent = new Undergraduate
            {
                Name = "Shrija",
                Student_Id = 295,
                Grade = 50.0
            };

         var gradStudent = new Graduate
    {
        Name = "Simran",
        Student_Id = 456,
        Grade = 85.0
    };

             Console.WriteLine($"{undergradStudent.Name} passed: {undergradStudent.IsPassed(undergradStudent.Grade)}");
            Console.WriteLine($"{gradStudent.Name} passed: {gradStudent.IsPassed(gradStudent.Grade)}");

            Console.Read();
        }
}
}

