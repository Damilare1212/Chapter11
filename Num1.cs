using System;

namespace chapter_11_objects
{
    class Num1
    {
       public static void Answer()
       {
                    Console.WriteLine("enter a year");
                  int year = int.Parse(Console.ReadLine());

              //    if (years % 4 == 0 || years % 100 == 0 || years % 400 == 0)
              //    {
              //        Console.WriteLine("it is a leap year");
              //    } 
              //    else
              //    {
              //        Console.WriteLine("it is not leap year");
              //    }

              //    Console.WriteLine(DateTime.Now);

                if (DateTime.IsLeapYear(year))
                {
                  Console.WriteLine($"{year} is a leap year");
                }
                else 
                {
                    Console.WriteLine($"{year} is not a leap year");
                }

      
       } 
    }
}