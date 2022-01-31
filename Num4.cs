using System;

namespace chapter_11_objects
{
    class Num4
    {
      public  static void Answer()
       {

        decimal time = Environment.TickCount;
        decimal seconds = time / 1440;
        decimal minute  = seconds / 60;
        decimal hour =  minute / 60;
        decimal days = hour / 24;
        
       
        Console.WriteLine($"the seconds which have passed away is {seconds}");
       Console.WriteLine($"the minute which have passed away is {minute}");
       Console.WriteLine($"the hour which have passed away is {hour}");
       Console.WriteLine($"the days which have passed away is {days}"); 

        


            
       } 
    }
}