using System;

namespace chapter_11_objects
{
     class Num6
    {
        public static void Answer()
        {
            Console.WriteLine("enter first side");
            var a = int.Parse(Console.ReadLine());
             Console.WriteLine("enter first side");
            var b = int.Parse(Console.ReadLine());
             Console.WriteLine("enter first side");
            var c = int.Parse(Console.ReadLine());  
            Console.WriteLine("enter the height");
            double h = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the angle");
            double angle = int.Parse(Console.ReadLine());

            var p = a + b + c / 2;
            double areea = p * (p - a) * (p -b) * (p-c);
            double area = Math.Sqrt(areea);
            Console.WriteLine($"the area of the three sides = {area}");


            double altitude = a * h / 2;
            Console.WriteLine($"the area and the altiude = {altitude}");

            double ang = a * b;

            double anng = ang * Math.Sin(angle);
            Console.WriteLine($"the angle between the two sides in degree = {anng}");


        }
    }
}