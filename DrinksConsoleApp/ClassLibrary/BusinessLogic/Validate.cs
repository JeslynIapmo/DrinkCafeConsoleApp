using System;
using System.Linq;

namespace DrinksConsoleApp
{
    public class Validate
    {
        public bool isUserOrderValid(string userInput)
        {
            if (!new[] { "small", "medium", "large", "hot", "cold", "a little", "a lot", "little", "lot", "splash", "mango", "guava", "coconut" }.Any(current => userInput.Contains(current)))
            {
                Console.WriteLine("Please enter a valid option. Let's that try again.");
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
