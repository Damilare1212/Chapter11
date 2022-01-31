using System;
namespace chapter_11_objects
{
    public class cat
    {
        public string Name {get;set;}
        public string Colour {get;set;}
    


        public cat (string name, string colour)
        {
            Name = name;
            Colour  = colour;
        
        }

        public void SayMiu()
        {
            Console.WriteLine($"Miua, {Name}");
        }
    }

}  
