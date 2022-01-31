using System;

namespace chapter_11_objects
{
    class Num2
    {
       public static void Answer()
       {
           Console.WriteLine(" 10 Random numbers between 100 to 200");

           Random rmd = new Random();
           for (int i = 0; i<10; i++)
           {
               int num = rmd.Next(100,201);
              Console.Write($"{num} "); 
           }
       } 
    }
}