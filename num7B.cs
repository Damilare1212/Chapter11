using System;
namespace chapter_11_objects
{
    public class Sequence
    {
        private static int currentValue = 0;

        private Sequence()
        {
            
        }

        public static int NextValue()
        {
            currentValue++;
            return currentValue;
        }
    }
}