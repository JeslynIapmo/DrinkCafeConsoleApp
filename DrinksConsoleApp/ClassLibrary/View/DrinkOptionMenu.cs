using System;

namespace DrinksConsoleApp
{
    public class DrinkOptionMenu
    {
        public void Size()
        {
            Console.WriteLine("What size drink would you like?");
            Console.WriteLine("small");
            Console.WriteLine("medium");
            Console.WriteLine("large");
        }

        public void Temp()
        {
            Console.WriteLine("Great! Now would you like that hot or cold?");
            Console.WriteLine("hot");
            Console.WriteLine("cold");
        }

        public void SugarAmount()
        {
            Console.WriteLine("Okay, how much sugar?");
            Console.WriteLine("a little");
            Console.WriteLine("a lot");
        }

        public void CreamAmount()
        {
            Console.WriteLine("And how much cream?");
            Console.WriteLine("a splash");
            Console.WriteLine("a lot");
        }
    }
}
