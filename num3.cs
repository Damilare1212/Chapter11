using System;

namespace chapter_11_objects
{
    class Num3
    {
         public  static void Answer()
       {
           Console.WriteLine("enter");

            Console.Write("Enter year: ");
            int year = Int32.Parse(Console.ReadLine());
            Console.Write("Enter month: ");
            int month = Int32.Parse(Console.ReadLine());
            Console.Write("Enter day: ");
            int day = Int32.Parse(Console.ReadLine());
            
            DateTime dateValue = new DateTime(year, month, day);
            Console.WriteLine(dateValue.ToString("ddd"));
       } 
    }
}