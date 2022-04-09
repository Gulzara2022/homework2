using System;

namespace homework4
{
    internal class Program
    {
        static void Main(string[] args)
        { //region task 1//
          //            1) 1 - 1000 qeder CUT ederlerin icerisinde
          //reqemleri cemi 5 ile 7 arasinda olan en boyuk eded hansidir?
          //int a = 266;
          //for (int i = 2; i < 1000; i++)
          //{ 



            //}

            //}//region task 2//
            //2) 1 - 1000 qeder ederlerin icerisinden ele ededleri cap etki:
            //            hem polindrom olsun,
            //    hem ededin reqemleri daxilinde 3 olmasin
            //    hem ededin reqemleri cemi 10 dan boyuk olsun 
            int sum = 0;
            int n = 0;
            int r = 0;
            Console.Write("enter number: ");
            n = int.Parse(Console.ReadLine());
            while (n > 0)
            {
                r = n % 10;
                sum = (sum * 10) + r;
                n = n / 10;
            }
            if (sum == r)
            {
                Console.WriteLine("number is polindrom");
            }
            else
            {
                Console.WriteLine("number is not polindrom");
            }



        }

   








        }
    }

