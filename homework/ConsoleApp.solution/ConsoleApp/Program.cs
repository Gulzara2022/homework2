using System;

namespace ConsoleApp
{
    internal class Program 
    {
        static void Main(string[] args)
        {
           Student s = new Student();
            s.Name = "Aqil";
            s.Surname = "Abbasov";
            Teacher t = new Teacher();
            t.Name = "Murad";
            t.Surname = "Quliyev";

            Console.WriteLine(s.GetFullName());
            Console.WriteLine(t.GetFullName());

            
        }
    }
}
