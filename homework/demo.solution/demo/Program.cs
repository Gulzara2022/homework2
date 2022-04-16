using System;

namespace demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 5) Her hansi bir 10000 den boyuk eded daxil et.

            //Bu ededin daxilde minimum 4 dene 0 varmi?
            //Eger varsa o zaman ekrana bu ededin tek reqemlerin cemini cixart.

            //Eger yoxdursa cut reqemlerin cemini cixart;//

            int a = 12000;            
            int sum = 0;
            //while (a>0)
            //{
            //    a = a % 10;

            { 
                if (true )
                {
                    while (a>0)
                    {   a = a % 10;
                        a=a / 100;
                        sum = sum + a;
                    }
                }
                Console.WriteLine("sum");

            }


        }
    }
}
