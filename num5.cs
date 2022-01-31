using System;

namespace chapter_11_objects
{
    class Num5
    {
       public static void Answer()
       {
           Console.WriteLine("Enter first side");
           double SideA = int.Parse(Console.ReadLine());
           Console.WriteLine("enter the second side ");
           double SideB = int.Parse(Console.ReadLine()); 

            double result = Math.Pow(SideA,2);
            double result2 = Math.Pow(SideB,2);
            double result3  =  result + result2;

            double FinalResult = Math.Sqrt(result3);

            Console.WriteLine($" the hypoteneous of the right angle triangle is {FinalResult}");

            
       } 
    }
}