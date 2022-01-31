using System;

namespace chapter_11_objects
{
    class num8
    {
        public static void Answer()
        {
           String name = "cater";
            for(int i = 0; i < 10; i++)
            {
                cat cat = new cat(name + Sequence.NextValue(),"Black");

                cat.SayMiu();
               
            }
           
        }
      
    }
}