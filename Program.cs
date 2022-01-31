using System;

namespace chapter_11_objects
{
    class Program
    {
        static void Main(string[] args)
        { 


          
            while (true)
            { 
                   
               Console.WriteLine("enter 1 for question 1\nenter 2 for question 2\nenter 3 for question 3\nenter 4 for question 4\nenter 5 for question 5\nenter 6 for question 6\nenter 8 for question 7 and 8\nenter 10 for question 10\n enter 11 for question 11");
                var option = int.Parse(Console.ReadLine());
                if (option == 1)
                {
                      Num1.Answer();
                }
                if (option == 2)
                {
                      Num2.Answer(); 
                }
                if (option == 3)
                {
                        Num3.Answer(); 
                }
                if (option == 4)
                {
                      Num4.Answer();  
           
                }
                if (option == 5)
                {
                      Num5.Answer(); 
                }
                if (option == 6)
                {
                      Num6.Answer();
                }
                if (option == 8)
                {
                    num8.Answer();
                }
              if (option == 10)
              {
                  num10.Answer();

              }
              if (option == 11)
              {
                  num11.Answer();
              }
            }
           
           
           
          
              
        }
    }
}
