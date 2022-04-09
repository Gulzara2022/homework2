using System;

namespace homework3
{
    internal class Program
    {
        static void Main(string[] args)
        //task1 verilmish 4 reqemli ededin reqemlerinin cemini tap//
        {
            Console.Write("eded daxil edin: ");
            string num=Console.ReadLine();
            int a=Convert.ToInt32(num);
            if (a >= 1000 && a < 10000)
            {
                int qaliq;
                int cem = 0;
                while (a>0 )
                {
                    qaliq = a% 10;
                    a=(a-qaliq)/10;
                    cem = cem + qaliq;
                }
                Console.WriteLine(cem);
            }
            else
            {
                Console.WriteLine("eded 4 reqemli deyil");
            }
           

            //task2  verilmihs 6 reqemli ededin ilk 3 denesinin reqemleri cemi tap: example: 123600= 1+2+3//

            //int a = 657890;
            //int b = a % 1000;
            //int c =( a - b)/1000;
            //int d = c % 10;
            //int e = (c - d) / 10;
            //int f = e % 10;
            //int g = (e-f) / 10;
            //int cem = d + f + g;


            //Console.WriteLine(cem);

            //task3 verilmihs 9 reqemli ededin duz ortaya dushen 3 reqeminin reqemleri cemi//
            //int a = 785432194;
            //int b = a%1000;
            //int c = (a - b) / 1000;
            //int d = c % 10;
            //int e = (c - d) / 10;
            //int f = e % 10;
            //int g = (e - f) / 10;
            //int h = g % 10;
            //int cem = h + f + d;
            //Console.WriteLine(cem);

            //task4 verilmihs 5 reqemli ilk ve son reqemlerinin ceminin kvadrati//
            //int a = 95876;
            //int b = a % 10;
            //int c = a / 10000;
            //int d = (b+c)*(b+c);
            //Console.WriteLine(d);

            //task5  verilmihs 6 reqemli ededin 1 ci reqemini hemin ededin axirina at.//
            //int a = 987654;
            //int c = (a - (a % 100000)) / 100000;
            //int d = (a * 10) + c;
            //Console.WriteLine(d);

            //task6 verilmihs 8 reqemli ededin ilk I ve axirinci reqemlerini legv et//
            //int a = 87654321;
            //int b = a%10;


            //task7 verilmihs 4 reqemli ededin tersine duzub axirina ve evveline 8 artir//
            

            

































































































        }
    }
}        




