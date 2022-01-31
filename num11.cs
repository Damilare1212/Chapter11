using System;

namespace chapter_11_objects
{
    class num11
    {
        public static void Answer()
        {
            Random rmd = new Random();
            string[] firstname = {"Ade","Warissi","Kunle","okocha","Portable","Adele"};
            string[] lastname = {"Charles","fred","Chambers","Lamba","Alfred","Shegzy"}; 
            string[] cities = {"Paris","Berlin","Moscow","Niarobi","Tokyo","Lagos"};  
          string[] laudatoryStories = {"Now I feel better.", "I managed to change.", "It made some miracle.", "I cant believe it, but now I am feeling great.", "You should try it, too. I am very satisfied."};  
          string[] LaudatoryPharases =  {"The product is excellent.", "This is a great product.", "I use this product constantly.", "This is the best product from this category."};

                Console.Write($"{LaudatoryPharases[rmd.Next(0,3)]}\t");
               Console.Write($"{laudatoryStories[rmd.Next(0,4)]}\t");
               Console.Write($"{lastname[rmd.Next(0,5)]}\t");
              Console.Write($"{firstname[rmd.Next(0,5)]}\t");
              Console.Write($"{cities[rmd.Next(0,5)]}\t");    
        }
    }
}