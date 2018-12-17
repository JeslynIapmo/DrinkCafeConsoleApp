using System;

namespace DrinksConsoleApp
{
    public class UserMenu
    {
        public void MainDrinkMenu()
        {
            Console.WriteLine("What would you like to order?");
            Console.WriteLine("juice for $3.25");
            Console.WriteLine("tea for $1.25");
            Console.WriteLine("coffee for $2.25");
            Console.WriteLine();
            Console.WriteLine("Or enter 'cancel' if you would like to cancel your order.");
        }

        public void AnotherOrder()
        {
            Console.WriteLine("Would you like to do order another drink? 'y' or 'n'?");
            string orderChoice = Console.ReadLine();

            if (orderChoice == "y")
            {
               bool isUserStillOrdering = true;
            }
            else if (orderChoice == "n")
            {
                Console.WriteLine("Thank you for stopping by!");
                Console.ReadKey(true);
                Console.WriteLine("You can probably close this window now?");
                Console.ReadKey(true);
                Console.WriteLine("Well since you're still here, press any button to return to the menu for another order.");
                Console.ReadKey(true);
            }
            else
            {
                Console.WriteLine("Please enter a valid menu option.");
            }
        }

        public void CoffeeExtras()
        {
            Console.WriteLine("How about your add-ons? Enter the letter.");
            Console.WriteLine("a: with cream, no sugar for .75 more");
            Console.WriteLine("b: no cream, but with sugar for .50 more");
            Console.WriteLine("c: with cream and sugar for 1.15 more");
            Console.WriteLine("d: no cream or sugar");
            Console.WriteLine();

        }
    }
}
