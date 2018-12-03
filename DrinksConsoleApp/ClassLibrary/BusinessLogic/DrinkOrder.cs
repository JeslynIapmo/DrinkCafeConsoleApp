using System;

namespace DrinksConsoleApp
{
    public class DrinkOrder
    {
        UserMenu userMenu = new UserMenu();
        DrinkOption drinkOption = new DrinkOption();
        Validate validate = new Validate();
        Juice juice = new Juice();

        public void JuiceOrder()
        {
            // asking & taking size order
            drinkOption.Size();
            string sizeChoice = Console.ReadLine();

            // checking for valid size input
            if (validate.isUserOrderValid(sizeChoice))
            {
                //re-asking question if invalid
                drinkOption.Size();
                string userInput = Console.ReadLine();
                sizeChoice = userInput;
            }

            // asking & taking flavor order
            juice.Flavor();
            string flavorChoice = Console.ReadLine();

            // checking for valid size input
            if (validate.isUserOrderValid(flavorChoice))
            {
                //re-asking question if invalid
                juice.Flavor();
                string userInput = Console.ReadLine();
                flavorChoice = userInput;
            }

            // final order message
            Console.WriteLine("Wonderful. Here's your juice order:");
            Console.WriteLine($"A {sizeChoice} {flavorChoice} juice for $3.25.");

            // asking for second order
            userMenu.AnotherOrder();
        }

        public void TeaOrder()
        {
            drinkOption.Size();
            string sizeChoice = Console.ReadLine();

            if (validate.isUserOrderValid(sizeChoice))
            {
                drinkOption.Size();
                string userInput = Console.ReadLine();
                sizeChoice = userInput;
            }

            drinkOption.Temp();
            string tempChoice = Console.ReadLine();

            if (validate.isUserOrderValid(tempChoice))
            {
                drinkOption.Temp();
                string userInput = Console.ReadLine();
                tempChoice = userInput;

            }

            Console.WriteLine("Would you like sugar for .50 more? 'y' or 'n'?");
            string sugarOption = Console.ReadLine();

            if (sugarOption == "y")
            {
                drinkOption.SugarAmount();
                string sugarChoice = Console.ReadLine();

                Console.WriteLine("Wonderful. Here's your tea order:");
                Console.WriteLine($"A {tempChoice} tea with {sugarChoice} sugar for $1.75.");
                userMenu.AnotherOrder();
            }
            else
            {
                Console.WriteLine("Wonderful. Here's your tea order:");
                Console.WriteLine($"A {tempChoice} tea with no sugar for $1.25.");
                userMenu.AnotherOrder();
            }
        }

        public void CoffeeOrder()
        {
            drinkOption.Size();
            string sizeChoice = Console.ReadLine();

            if (validate.isUserOrderValid(sizeChoice))
            {
                drinkOption.Size();
                string userInput = Console.ReadLine();
                sizeChoice = userInput;
            }

            drinkOption.Temp();
            string tempChoice = Console.ReadLine();

            if (validate.isUserOrderValid(tempChoice))
            {
                drinkOption.Temp();
                string userInput = Console.ReadLine();
                tempChoice = userInput;
            }

            userMenu.CoffeeExtras();
            string coffeeAddInChoice = Console.ReadLine();

            switch (coffeeAddInChoice)
            {
                case "a":
                    drinkOption.CreamAmount();
                    string creamChoice = Console.ReadLine();
                    Console.WriteLine("Wonderful. Here's your coffee order:");
                    Console.WriteLine($"A {sizeChoice} {tempChoice} coffee with {creamChoice} cream and no sugar for $3.00.");
                    userMenu.AnotherOrder();
                    break;
                case "b":
                    drinkOption.SugarAmount();
                    string sugarChoice = Console.ReadLine();
                    Console.WriteLine("Wonderful. Here's your coffee order:");
                    Console.WriteLine($"A {sizeChoice} {tempChoice} coffee with {sugarChoice} sugar and no cream for $2.75.");
                    userMenu.AnotherOrder();
                    break;
                case "c":
                    drinkOption.CreamAmount();
                    string creamSelected = Console.ReadLine();
                    drinkOption.SugarAmount();
                    string sugarSelectd = Console.ReadLine();
                    Console.WriteLine("Wonderful. Here's your coffee order:");
                    Console.WriteLine($"A {sizeChoice} {tempChoice} coffee with {creamSelected} cream and {sugarSelectd} sugar for $3.50.");
                    userMenu.AnotherOrder();
                    break;
                case "d":
                    Console.WriteLine("Wonderful. Here's your coffee order:");
                    Console.WriteLine($"A {sizeChoice} {tempChoice} coffee with no cream or sugar for $2.25.");
                    userMenu.AnotherOrder();
                    break;
                default:
                    Console.WriteLine("Whoops, you need to enter a correct menu letter. For this insolence, now we have to start over.");
                    break;
            }
        }
    }
}
