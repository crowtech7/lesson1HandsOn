using System;

namespace lesson1HandsOn
{
    class Program
    {
        static void Main(string[] args)
        {
           bool isSunny = true;
           var wear = "Wear sunglasses!";
           var dontWear = "You don't need to wear sunglasses.";

           if (isSunny)
            {
                Console.WriteLine(wear);
            }
            else
            {
                Console.WriteLine(dontWear);
            }

        }
    }
}
