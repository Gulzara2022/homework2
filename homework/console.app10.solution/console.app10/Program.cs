using System;

namespace console.app10
{
    internal class Program
    {
        static void Main(string[] args)
        {    Console.Write("C daxil et:");

            string cstr = Console.ReadLine();
            double c = Convert.ToDouble(cstr);
            double f = 9 * c / 5 + 32;
            Console.WriteLine($"{c}C={f}F");
            
               
            }
        }
    }
