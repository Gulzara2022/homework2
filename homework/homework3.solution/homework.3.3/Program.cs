using System;

namespace homework._3._3
{
    internal class Program
    {
        static void Main(string[] args)
        {//verilmihs 9 reqemli ededin duz ortaya dushen 3 reqeminin reqemleri cemi//
            Console.Write("ededi daxil edin:  ");
            string num=Console.ReadLine();
            int a = Convert.ToInt32(num);
            bool isSuccess = a >= 100000000 && a <=1000000000000;
            if (!isSuccess)
            {
                Console.WriteLine("eded 9 reqemli deyil");
                return;
            }
            a = a / 1000;
            a = a % 1000;
            
            int remaind;
            int sum = 0;
            while (a>0)
            {
                remaind = a % 10;
                a=a / 10;   
                sum= sum + remaind;

               
            }
            Console.WriteLine(sum);


        }
    }
}
