using System;

namespace DrinksConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            UserMenu userMenu = new UserMenu();
            DrinkOrder drinkOrder = new DrinkOrder();

            bool isUserStillOrdering = true;
            while (isUserStillOrdering)
            {
                Console.WriteLine("Welcome to the Console Cafe!");
                Console.WriteLine();
                userMenu.MainDrinkMenu();
                string s = Console.ReadLine();

                if (s == "cancel")
                {
                    isUserStillOrdering = false;

                }
                else if (s == "juice")
                {
                    drinkOrder.JuiceOrder();
                }
                else if (s == "tea")
                {
                    drinkOrder.TeaOrder();

                }
                else if (s == "coffee")
                {
                    drinkOrder.CoffeeOrder();
                }
                else
                {
                    Console.WriteLine("Please enter a valid menu item.");
                    Console.WriteLine();
                }
            }
        }
    }
}
