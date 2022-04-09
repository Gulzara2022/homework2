using System;

namespace homework3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //) verilmihs 6 reqemli ededin ilk 3 denesinin reqemleri cemi tap: example: 123600= 1+2+3//
            Console.Write("ededi daxil edin: ");
            string num = Console.ReadLine();
            
            int a = Convert.ToInt32(num);
            bool dogrudursa = a >= 100000 && a < 1000000;
            if (!dogrudursa )
            {
                Console.WriteLine("eded 6 reqemli deyil");
                return;
            }
            a = (a - (a % 1000)) / 1000;
            int remaind;
            int sum=0;  
            while (a>0) 
            {
                remaind = a % 10;
                a=a / 10;
                sum=sum + remaind;

            }
            Console.WriteLine(sum);
        }
    }
}
