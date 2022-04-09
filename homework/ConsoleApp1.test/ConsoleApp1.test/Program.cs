using System;

namespace ConsoleApp1.test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 50;

            for (int i = 2; n >= 50; i++)

            {
                bool state = false;
                for (int j = i; j <= n / 2; j++)
                {
                    if (i % j == 0)
                    {
                        state = true;

                    }
                }
                if (state == true)
                {
                    Console.WriteLine($"{i} sade eded deyil");
                }

                else
                {
                    Console.WriteLine($"{i}ne sade ne murekkebdir");
                }

            }

        }

    }

}   
            


        