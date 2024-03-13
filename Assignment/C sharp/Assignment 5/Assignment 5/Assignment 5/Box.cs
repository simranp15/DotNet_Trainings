using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    //-------------------Answer2-------------------
    class Box
    {

        public int Length;
        public int Breadth;
        public Box(int length, int breadth)
        {
            Length = length;
            Breadth = breadth;
        }
        public static Box operator +(Box b1, Box b2)
        {
            int newLength = b1.Length + b2.Length;
            int newBreadth = b1.Breadth + b2.Breadth;
            return new Box(newLength, newBreadth);
        }

    }
    // Creating Test class 

    public class Test
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of box1 :  ");
            int length1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the breadth of box1: ");
            int breadth1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the length of box2 :  ");
            int length2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the breadth of box2: ");
            int breadth2 = int.Parse(Console.ReadLine());

            Box b3 = new Box(0, 0);
            Box b1 = new Box(length1, breadth1);
            Box b2 = new Box(length2, breadth2);
            b3 = b1 + b2;

            Console.WriteLine($"the stored valaue of both boxes in BOX3 is: Length = {b3.Length} and Breadth = {b3.Breadth}");
            Console.Read();
        }
    }
}

    
