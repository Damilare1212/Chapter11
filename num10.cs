using System;

namespace chapter_11_objects
{
    class num10
    {
        public static void Answer()
        {
            int result = 0;
            Console.Write("Enter numbers: ");
            string inputNumbers = Console.ReadLine();
            string[] splitNumbers = inputNumbers.Split(' ');            

            for (int i = 0; i < splitNumbers.Length; i++)
            {
                 int x = int.Parse(splitNumbers[i]);
                 result+=x;
            }
                

            Console.WriteLine("Result is: {0}", result);
        }
    }
}