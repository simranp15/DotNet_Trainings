using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Student_grade
    

        {
           private int RollNo;
            private String Name;
            private String Class;
            private  int Semester;
             private String Branch;
             int[] Marks = new int[5];
             int sum = 0;
             int average;

            //static void Main()

            //{

            //    Student_grade sg = new Student_grade(55, "Simran", "Btech", 4, "ECE");

            //    sg.InputData();
            //    sg.Average();
            //    sg.Result();  
            //    sg.DisplayResult();
            //    Console.Read();

            //}

            public Student_grade(int RollNo, String Name, String Class, int Semester, String Branch)

            {

                this.RollNo = RollNo;
                this.Name = Name;
                this.Class = Class;
                this.Semester = Semester;
                this.Branch = Branch;

            }

        public void InputData()

        {

            Console.WriteLine("Enter the marks of five subject: ");

            for (int i = 0; i < Marks.Length; i++)

            {
                Console.Write($"subject {i + 1}: ");
                Marks[i] = Convert.ToInt32(Console.ReadLine());
            }

            foreach (int mark in Marks)
            {
                sum += mark;
                if (mark < 35)

                {

                    Console.Write("Failed");

                    return;

                }

            }
        }
            

            public void Average()

            {

                for (int i = 0; i < Marks.Length; i++)

                {

                    sum = sum + Marks[i];

                }

            average = sum / Marks.Length;

            }

            public void Result()

            {

            if (average < 50)

                Console.WriteLine("Failed");

            else 

                    Console.WriteLine("Passed");

            }

            public void DisplayResult()

            {

                Console.WriteLine($"Roll Number: {RollNo}");
                Console.WriteLine($"Name: {Name}");
                Console.WriteLine($"Class: {Class}");
                Console.WriteLine($"Semester: {Semester}");
                Console.WriteLine($"Brnach: {Branch}");
                Console.WriteLine("---------------Marks------------");

                for (int i = 0; i < Marks.Length; i++)

                {
                  Console.WriteLine($"Marks of Subject {i}: {Marks[i]}");

                }

                Console.WriteLine(":::RESULT:::");

                Result();

            }


        }



    }


