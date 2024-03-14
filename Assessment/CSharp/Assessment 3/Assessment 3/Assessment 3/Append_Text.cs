using System;
using System.IO;
using System.Text;

namespace Assessment_3
{
    class Append_Text
    {
        static void Main()
        {   // Initialize  file name
            string fileName = "Mytext"; 

            try
            {

                if (File.Exists(fileName))
                {
                    File.Delete(fileName);
                }
                Console.Write("\n\nAppend some text to an existing file:\n");
                using (StreamWriter fileStr = File.CreateText(fileName))
                {
                    fileStr.WriteLine("Hello Good morning to  all Infinite Employees");
                }

                //Before AppendingText
                using (StreamReader sr = File.OpenText(fileName))
                {
                    string s = "";
                    Console.WriteLine("Initial Statement is:");
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                    Console.WriteLine();
                }
                using (StreamWriter file = new StreamWriter("Mytext", true))
                {
                    Console.Write("Enter the AppendingText: ");
                    string AppendingText = Console.ReadLine();
                    file.WriteLine(AppendingText);
                }

                // After AppendingText
                using (StreamReader sr = File.OpenText(fileName))
                {
                    string s = "";
                    Console.WriteLine("After appending the text statement is :");
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                    Console.WriteLine(); 
                }
            }
            catch (Exception MyExcep)
            {
                Console.WriteLine(MyExcep.ToString()); 

            }
                Console.Read();
            }

        }
    }


