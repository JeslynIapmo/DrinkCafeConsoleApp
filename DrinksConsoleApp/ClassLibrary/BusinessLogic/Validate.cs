using System;
using System.Linq;

namespace DrinksConsoleApp
{
    public class Validate
    {
        // Drink Size
        public bool DrinkSize(string userInput)
        {
            if (!new[] { "small", "medium", "large"}.Any(current => userInput.Contains(current)))
            {
                Console.WriteLine("Please enter a valid size order. Let's that try again.");
                return true;
            }
            else
            {
                return false;
            }
        }

        // Flavor Order
        public bool FlavorOrder(string userInput)
        {
            if (!new[] { "mango", "guava", "coconut" }.Any(current => userInput.Contains(current)))
            {
                Console.WriteLine("Please enter a valid flavor option. Let's that try again.");
                return true;
            }
            else
            {
                return false;
            }
        }

        // Temperature Order
        public bool TempOrder(string userInput)
        {
            if (!new[] { "hot", "cold" }.Any(current => userInput.Contains(current)))
            {
                Console.WriteLine("Please enter a valid temperature choice. Let's that try again.");
                return true;
            }
            else
            {
                return false;
            }
        }

        // Sugar Option Y/N
        public bool SugarOption(string userInput)
        {
            if(!new[] { "y", "n"}.Any(current => userInput.Contains(current)))
            {
                Console.WriteLine("Please enter a valid 'yes' or 'no' option. Let's that try again.");
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
