using System;

namespace homework3.solution3
{
    internal class Program
    {
        static void Main(string[] args)
        {

         
#region Task 1
            //Console.WriteLine("4 reqemli eded daxil edin");
            //int num = int.Parse(Console.ReadLine()); //Eded
            //int Sum = 0; //Ededlerin cemi yigilan yer
            //int a; //herbir reqemin tapilib set olundugu vareble

            //if (num > 999 && num < 10000)
            //{
            //    while (num > 0)
            //    {
            //        a = num % 10;
            //        Sum = Sum + a;
            //        num = num / 10;
            //    }
            //    Console.WriteLine("Cem Budur:" + Sum);
            //}
            //else
            //{
            //    Console.WriteLine("Eded 4 reqemli deyil");
            //}
            #endregion

            #region Task 2
            //Console.WriteLine("6-reqemli ededi daxil edin:");
            //int num = int.Parse(Console.ReadLine());
            //int Sum = 0;
            //int a;

            //if (num > 99999 && num < 1000000)
            //{
            //    num = num / 1000;
            //    while (num > 0)
            //    {
            //        a = num % 10;
            //        Sum = Sum + a;
            //        num = num / 10;
            //    }
            //    Console.WriteLine("6 reqemli ededin ilk uc reqeminin cemi budur:" + Sum);
            //}
            //else
            //{
            //    Console.WriteLine("Eded 6 reqemli deil!");
            //}

            #endregion

            #region Task 3  
            //Console.WriteLine("9-reqemli ededi daxil edin:");
            //int num = int.Parse(Console.ReadLine());
            //int Sum = 0;
            //int a;
            //int b = 0; //dongusayi

            //if (num > 99999999 && num < 1000000000)
            //{

            //    num = num / 1000;
            //    while (num > 0 && b < 3)
            //    {
            //        a = num % 10;
            //        Sum = Sum + a;
            //        num = num / 10;
            //        b++;
            //    }
            //    Console.WriteLine("9 reqemli ededin ortadaki uc reqeminin cemi budur:" + Sum);
            //}
            //else
            //{
            //    Console.WriteLine("Eded 9 reqemli deil!");
            //}
            #endregion

            #region Task 4
            //Console.WriteLine("5 reqemli eded daxil edin");
            //int num = int.Parse(Console.ReadLine());
            //int Sum = 0;
            //int a;
            //int b;
            //int kvadrat;

            //if (num > 9999 && num < 100000)
            //{
            //    //34443
            //    a = num % 10;
            //    Sum = Sum + a;
            //    num = num / 10000;
            //    b = num % 10;
            //    Sum = Sum + b;

            //    kvadrat = Sum * Sum;
            //    Console.WriteLine("Kvadrat budur:" + kvadrat);
            //}
            //else
            //{
            //    Console.WriteLine("Eded 5 reqemli deyil");
            //}
            #endregion

            #region Task 5
            //Console.WriteLine("6 reqemli eded daxil edin");
            //int num = int.Parse(Console.ReadLine());
            //int last;
            //int num2 = 0;

            //if (num > 99999 && num < 1000000)
            //{
            //    num2 = num / 100000;
            //    last = num2 % 10;
            //    num = num * 10 + last;
            //    Console.WriteLine("Netice budur" + num);
            //}
            //else
            //{
            //    Console.WriteLine("Eded 6 reqemli deyil");
            //}
            #endregion

            #region Task 6
            // int reverse = 0; //reverse (cevirmek)
            // int a;
            // int b;
            // int reverse2 = 0;
            // Console.WriteLine("8 reqemli eded daxil et");
            // int num = int.Parse(Console.ReadLine());
            //if(num > 9999999 && num < 100000000)
            // {
            //     num = num / 10;
            //     while (num != 0)
            //     {
            //         a = num % 10;
            //         reverse = reverse * 10 + a;
            //         num /= 10;

            //     }
            //     reverse = reverse / 10;
            //     while (reverse != 0)
            //     {
            //         b = reverse % 10;
            //         reverse2 = reverse2 * 10 + b;
            //         reverse /= 10;

            //     }
            //     Console.WriteLine("Result is this:" + reverse2);
            // }
            // else
            // {
            //     Console.WriteLine("Eded 8 reqemli deyil!");
            // }
            #endregion

            #region Task 7
            //int reverse = 8; //reverse (cevirmek)
            //int a;
            //Console.WriteLine("4reqemli eded daxil et");
            //int num = int.Parse(Console.ReadLine());
            //while (num != 0)
            //{
            //    a = num % 10;
            //    reverse = reverse * 10 + a;
            //    num /= 10;
            //}
            //reverse = reverse * 10 + 8;

            //Console.WriteLine("Result is this:" + reverse);
            #endregion

            #region Task 8
            ////Verilmis ededdin axirdan 3-cu reqemi ile sonuncu reqeminin cemini tap  
            //int eded1;
            //int eded2;
            //int ededcem;
            //Console.WriteLine("Eded daxil et:");
            //int num = int.Parse(Console.ReadLine());
            //eded1 = num % 10;
            //num = num / 100;
            //eded2 = num % 10;
            //ededcem = eded1 + eded2;
            //Console.WriteLine("Result is this:" + ededcem);
            #endregion

            #region Task9
            //9 reqemli ededdin tek yerde dayananlardan bir eded duzlet: 132346389=12439
            //l1:
            //    int a = 132346389;
            //    if (a < 100000000 || a >= 1000000000)
            //    {
            //        Console.WriteLine("9 reqemli deyil");
            //        goto l1;

            //    }
            //    int newNum = 0;
            //    int count = 0;

            //    while (a > 0)
            //    {
            //        int quvvet = (int)Math.Pow(10, count);


            //        newNum = newNum + (a % 10) * quvvet;
            //        a = a / 100;
            //        count++;

            //    }
            //    Console.WriteLine(newNum);

            #endregion

            #region Task10

            /*10) 9 reqemli ededdi tek yerde dayananlardan bir eded duzlet,
          sonra cut yerde dayanlarinda bir eded duzlet,
          sonra onlari topla*/

            //Console.Write("Ededi daxil edin: ");
            //string read = Console.ReadLine();
            //int num = Convert.ToInt32(read);

            //bool isSuccess = num >= 100000000 && num < 1000000000;
            //if (!isSuccess)
            //{
            //    Console.WriteLine($"{num} ededi 9 reqemli deyil");
            //    return;
            //}
            //int oddNum = num;
            //int evenNum = num;
            //int sumOddEven;
            //int remainder;
            //int newNum = 0;
            //int counter = 1;

            //while (oddNum > 0)
            //{
            //    remainder = oddNum % 10;
            //    oddNum = (oddNum - remainder) / 10;
            //    if (counter % 2 != 0)
            //    {
            //        newNum = newNum * 10 + remainder;
            //    }
            //    counter++;
            //}
            //while (newNum > 0)
            //{
            //    remainder = newNum % 10;
            //    newNum = (newNum - remainder) / 10;
            //    oddNum = oddNum * 10 + remainder;
            //}
            //while (evenNum > 0)
            //{
            //    remainder = evenNum % 10;
            //    evenNum = (evenNum - remainder) / 10;
            //    if (counter % 2 != 0)
            //    {
            //        newNum = newNum * 10 + remainder;
            //    }
            //    counter++;
            //}
            //while (newNum > 0)
            //{
            //    remainder = newNum % 10;
            //    newNum = (newNum - remainder) / 10;
            //    evenNum = evenNum * 10 + remainder;
            //}
            //sumOddEven = oddNum + evenNum;
            //Console.WriteLine($"{oddNum} + {evenNum} = {sumOddEven}");

            #endregion

            #region Task11
            //*11) 8 reqemli ededin reqemlerini iki -iki qruplashdir.
            //Qruplarin cemini tap.Alinan cavabin axirina 99 artir.
            //Sonra cavabin ozunden onun 18 % ni cix; */

            //Console.Write("Ededi daxil edin: ");
            //string read = Console.ReadLine();
            //int num = Convert.ToInt32(read);

            //bool isSuccess = num >= 10000000 && num < 100000000;
            //if (!isSuccess)
            //{
            //    Console.WriteLine("Eded 8 reqemli deyil");
            //    return;
            //}
            //int remainder;
            //int sumLast99;
            //int sumPer18;
            //int sum = 0;

            //while (num > 0)
            //{
            //    remainder = num % 100;
            //    num = num / 100;
            //    sum = sum + remainder;
            //}
            //Console.WriteLine($"iki-iki qruplasmis ededlerin toplami: {sum}");
            //sumLast99 = sum * 100 + 99;
            //Console.WriteLine($"Ededin sonuna 99 yazilmasi: {sumLast99}");
            //sumPer18 = sumLast99 / 100 * 18;
            //Console.WriteLine($"{sumLast99} ededinin 18 faizi: {sumPer18}");
            //sum = sumLast99 - sumPer18;
            //Console.WriteLine($"{sumLast99} - {sumPer18} = {sum}");

            #endregion

            #region Task12
            /*12) 2 dene 5 reqemli eded daxil et.
    I ededin reqemleri ceminin usutne
    II ededin reqemleri hasilini gel.
    Neticenin axirina I ededin en axiinci reqemini artir.*/


            //Console.Write("Ededi daxil edin: ");
            //string read1 = Console.ReadLine();
            //int num1 = Convert.ToInt32(read1);
            //Console.Write("Ededi daxil edin: ");
            //string read2 = Console.ReadLine();
            //int num2 = Convert.ToInt32(read2);

            //bool isSuccess = num1 >= 10000 && num1 < 100000 && num2 >= 10000 && num2 < 100000;
            //if (!isSuccess)
            //{
            //    Console.WriteLine("Daxil edilen eded 5 reqemli deyil");
            //    return;
            //}
            //int number = num1 % 10;
            //int remainder;
            //int sumMul;
            //int sum = 0;
            //int mul = 1;

            //while (num1 > 0)
            //{
            //    remainder = num1 % 10;
            //    num1 = (num1 - remainder) / 10;
            //    sum = sum + remainder;
            //}
            //while (num2 > 0)
            //{
            //    remainder = num2 % 10;
            //    num2 = (num2 - remainder) / 10;
            //    mul = mul * remainder;
            //}
            //sumMul = sum + mul;
            //Console.WriteLine($"{sum} + {mul} = {sumMul}");
            //sumMul = sumMul * 10 + number;
            //Console.WriteLine(sumMul);



            #endregion

            #region Task13
            /*13) 3 dene 5 reqemli eded var.
    Her bir  ededin ilk ve son reqemlerininden
    1 eded duzlet. Alinan neticeleri topla
    Yekunda alian cavabin 50%-ni hemin ededin uzerine gel*/

            //Console.Write("I ededi daxil edin: ");
            //string read1 = Console.ReadLine();
            //int num1 = Convert.ToInt32(read1);
            //Console.Write("II ededi daxil edin: ");
            //string read2 = Console.ReadLine();
            //int num2 = Convert.ToInt32(read2);
            //Console.Write("III ededi daxil edin: ");
            //string read3 = Console.ReadLine();
            //int num3 = Convert.ToInt32(read3);

            //int newNum1;
            //int newNum2;
            //int newNum3;
            //int sum;

            //bool isSuccess = (num1 >= 10000 && num1 < 100000 &&

            //    num2 >= 10000 && num2 < 100000 && num3 >= 10000 && num3 < 100000);
            //if (!isSuccess)
            //{
            //    Console.WriteLine("Daxil edilen ededlerden bir veya bir necesi 5 reqemli deyil.");
            //    return;
            //}

            //newNum1 = (num1 / 10000) * 10 + (num1 % 10);
            //newNum2 = (num2 / 10000) * 10 + (num2 % 10);
            //newNum3 = (num3 / 10000) * 10 + (num3 % 10);
            //sum = newNum1 + newNum2 + newNum3;

            //Console.WriteLine(newNum1);
            //Console.WriteLine(newNum2);
            //Console.WriteLine(newNum3);
            //Console.WriteLine($"{newNum1} + {newNum2} + {newNum3} = {sum}");
            //Console.WriteLine($"{sum} + {sum / 100 * 50} = {sum + (sum / 100 * 50)}");




            #endregion

            #region Task14
            //Console.Write("I Ededi daxil edin: ");
            //string read1 = Console.ReadLine();
            //int num1 = Convert.ToInt32(read1);
            //Console.Write("II Ededi daxil edin: ");
            //string read2 = Console.ReadLine();
            //int num2 = Convert.ToInt32(read2);
            //Console.Write("III Ededi daxil edin: ");
            //string read3 = Console.ReadLine();
            //int num3 = Convert.ToInt32(read3);
            //Console.Write("IV Ededi daxil edin: ");
            //string read4 = Console.ReadLine();
            //int num4 = Convert.ToInt32(read4);

            //bool isSuccess = (num1 >= 100000 && num1 < 1000000 && num2 >= 100000 && num2 < 1000000 &&
            //    num3 >= 100000 && num3 < 1000000 && num4 >= 1000000 && num4 < 10000000);
            //if (!isSuccess)
            //{
            //    Console.WriteLine("I, II ve III eded 6 reqemli IV eded 7 reqemli olmalidir.");
            //    return;
            //}
            //int sum;
            //int remainder;
            //int first3Num4;
            //int newNum = 1;

            //num1 = num1 / 1000;
            //num2 = num2 / 1000;
            //num3 = num3 / 1000;
            //Console.WriteLine("--------------------------------");

            //sum = num1 + num2 + num3 + (num4 % 10000);
            //Console.WriteLine($"{num1} + {num2} + {num3} + {num4 % 10000} = {sum}");

            //first3Num4 = num4 / 10000;
            //while (first3Num4 > 0)
            //{
            //    remainder = first3Num4 % 10;
            //    first3Num4 = first3Num4 / 10;
            //    newNum = newNum * remainder;
            //}
            //Console.WriteLine("--------------------------------");
            //sum = sum - newNum;
            //Console.WriteLine($"{num1 + num2 + num3 + (num4 % 10000)} - {newNum} = {sum}");
            //Console.WriteLine("--------------------------------");
            //sum = sum / 100 * 60;
            //Console.WriteLine($"neticenin 60 faizi: {sum}");
            //Console.WriteLine("--------------------------------");
            //sum = sum * 100 + 60;
            //Console.WriteLine($"neticenin sonuna 60 artirilmasi: {sum}");
            //Console.WriteLine("--------------------------------");
            //sum = sum - (sum / 100 * 18);
            //Console.WriteLine($"neticeden 18 faizin cixilmasi: {sum}");



            #endregion

            #region Task15
            //Console.Write("(eded 3 reqemden ibaret olmalidir)I Ededi daxil edin:");
            //string read1 = Console.ReadLine();
            //int num1 = Convert.ToInt32(read1);
            //Console.Write("(eded 3 reqemden ibaret olmalidir)II Ededi daxil edin:");
            //string read2 = Console.ReadLine();
            //int num2 = Convert.ToInt32(read2);
            //Console.Write("(eded 6 reqemden ibaret olmalidir)III Ededi daxil edin:");
            //string read3 = Console.ReadLine();
            //int num3 = Convert.ToInt32(read3);
            //Console.Write("(eded 6 reqemden ibaret olmalidir)IV Ededi daxil edin:");
            //string read4 = Console.ReadLine();
            //int num4 = Convert.ToInt32(read4);
            //Console.Write("(eded 7 reqemden ibaret olmalidir)V Ededi daxil edin:");
            //string read5 = Console.ReadLine();
            //int num5 = Convert.ToInt32(read5);

            //bool isSuccess = (num1 >= 100 && num1 < 1000 && num2 >= 100 && num2 < 1000 && num3 >= 100000 && num3 < 1000000 &&
            //    num4 >= 100000 && num4 < 1000000 && num5 >= 1000000 && num5 < 10000000);
            //if (!isSuccess)
            //{
            //    Console.WriteLine("Ededlerin bir veya bir necesinin sayi duzgun daxil edilmeyib. ");
            //}

            //int sumDdigits3;
            //int stickDigits3;
            //int sumDigits6;
            //int digit7last5;
            //int sumDigit7revers;
            //int remainder;
            //int newNum;
            //int counter = 1;

            //sumDdigits3 = num1 + num2;
            //Console.WriteLine($"3 reqemli ededlerin cemi: {num1} + {num2} = {sumDdigits3}");
            //Console.WriteLine($"3 reqemli ededlerin ceminin sondan 2 reqeminin kvadrati: " +
            //    $"{sumDdigits3 % 100} * {sumDdigits3 % 100} = {(sumDdigits3 % 100) * (sumDdigits3 % 100)}");
            //sumDdigits3 = (sumDdigits3 % 100) * (sumDdigits3 % 100);
            //stickDigits3 = num1 * 1000 + num2;
            //Console.WriteLine($"3 reqemli ededlerin bir birine yapismasi: {stickDigits3}");
            //Console.WriteLine($"3 reqemli ededlerin ceminin sondan 2 ededinin kvadrati ile 3reqemli ededlerin bir birine yapismasinin cemi: " +
            //    $"{sumDdigits3} + {stickDigits3} = {sumDdigits3 + stickDigits3}");
            //sumDdigits3 = sumDdigits3 + stickDigits3;
            //digit7last5 = num5 % 100000;
            //Console.WriteLine($"alinan cavabdan 7 reqemli ededin son 5 reqemini cix: {sumDdigits3} - {digit7last5} = {sumDdigits3 - digit7last5}");
            //sumDdigits3 = sumDdigits3 - digit7last5;
            //Console.WriteLine($"alinan cavabin uzerine 6 reqemli ededlerin ceminden son 3 reqemini gel {num3} + {num4} = {num3 + num4}-----{(num3 + num4) % 1000}");
            //sumDigits6 = (num3 + num4) % 1000;
            //Console.WriteLine($"{sumDdigits3} + {sumDigits6} = {sumDdigits3 + sumDigits6}");
            //sumDdigits3 = sumDdigits3 + sumDigits6;
            //sumDigit7revers = 0;
            //newNum = num5;
            //while (newNum > 0)
            //{
            //    remainder = newNum % 10;
            //    newNum = (newNum - remainder) / 10;
            //    sumDigit7revers = sumDigit7revers + remainder;
            //}
            //newNum = sumDigit7revers;
            //sumDigit7revers = 0;
            //while (newNum > 0)
            //{
            //    remainder = newNum % 10;
            //    newNum = (newNum - remainder) / 10;
            //    sumDigit7revers = sumDigit7revers * 10 + remainder;
            //}
            //Console.WriteLine($"7 reqemli ededin: {num5} ededleri ceminin tersine yazilmis formasi: {sumDigit7revers}");
            //Console.WriteLine($"neticenin uzerine 7 reqemli ededin ededleri ceminin tersine yazilmis formasini gel: " +
            //    $"{sumDdigits3} + {sumDigit7revers} = {sumDdigits3 + sumDigit7revers}");
            //sumDdigits3 = sumDdigits3 + sumDigit7revers;
            //sumDdigits3 = sumDdigits3 * 100 + 11;
            //Console.WriteLine($"cavabin axirina 11 artirilmasi: {sumDdigits3}");

            //while (num5 > 0)
            //{
            //    remainder = num5 % 10;
            //    num5 = (num5 - remainder) / 10;
            //    if (counter % 2 != 0)
            //    {
            //        newNum = newNum * 10 + remainder;
            //    }
            //    counter++;
            //}
            //while (newNum > 0)
            //{
            //    remainder = newNum % 10;
            //    newNum = (newNum - remainder) / 10;
            //    num5 = num5 * 10 + remainder;
            //}
            //Console.WriteLine($"neticeden 7 reqemli ededin tek yerde dayanan reqemlerinden alinan ededi cix: {sumDdigits3} - {num5} = {sumDdigits3 - num5}");
            //sumDdigits3 = sumDdigits3 - num5;
            //newNum = sumDdigits3 % 10;
            //sumDdigits3 /= 10;
            //sumDdigits3 = sumDdigits3 * 100 + 88;
            //sumDdigits3 = sumDdigits3 * 10 + newNum;
            //Console.WriteLine($"neticenin axirdan II reqemi ile axirinci reqemin arasina 88 elave et: {sumDdigits3}");




            #endregion
        }
    }
}
