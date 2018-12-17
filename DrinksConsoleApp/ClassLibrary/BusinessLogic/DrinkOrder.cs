using System;
using DrinksConsoleApp.ClassLibrary.Models;

namespace DrinksConsoleApp
{
    public class DrinkOrder
    {
        UserMenu userMenu = new UserMenu();
        DrinkOptionMenu drinkOptionMenu = new DrinkOptionMenu();
        JuiceMenu juiceMenu = new JuiceMenu();
        Validate validate = new Validate();

        public void JuiceOrder()
        {
            Juice juice = new Juice();

            // asking & taking size order
            drinkOptionMenu.Size();
            string sizeChoiceInput = Console.ReadLine();

            // checking for valid size input
            if (validate.DrinkSize(sizeChoiceInput))
            {
                //re-asking question if invalid
                drinkOptionMenu.Size();
                string userInput = Console.ReadLine();
                juice.DrinkSize = userInput;

            } else
            {
                juice.DrinkSize = sizeChoiceInput;

            }

            // asking & taking flavor order
            juiceMenu.Flavor();
            string flavorChoiceInput = Console.ReadLine();

            // checking for valid flavor input
            if (validate.FlavorOrder(flavorChoiceInput))
            {
                //re-asking question if invalid
                juiceMenu.Flavor();
                string userInput = Console.ReadLine();
                juice.Flavor = userInput;
            } else
            {
                juice.Flavor = flavorChoiceInput;
            }

            // final order message
            Console.WriteLine("Wonderful. Here's your juice order:");
            Console.WriteLine($"A {juice.DrinkSize} {juice.Flavor} juice for $3.25.");

            // asking for second order
            userMenu.AnotherOrder();
        }

        public void TeaOrder()
        {
            Tea tea = new Tea();

            // asking & taking size order
            drinkOptionMenu.Size();
            string sizeChoiceInput = Console.ReadLine();

            // checking for valid size input
            if (validate.DrinkSize(sizeChoiceInput))
            {
                // if invalid, asking again
                drinkOptionMenu.Size();
                string userInput = Console.ReadLine();
                tea.DrinkSize = userInput;
            } else
            {
                tea.DrinkSize = sizeChoiceInput;
            }

            // asking & taking temperature order
            drinkOptionMenu.Temp();
            string tempChoiceInput = Console.ReadLine();

            // validating temperature order
            if (validate.TempOrder(tempChoiceInput))
            {
                // if invalid, asking again
                drinkOptionMenu.Temp();
                string userInput = Console.ReadLine();
                tea.Temperature = userInput;
            } else
            {
                tea.Temperature = tempChoiceInput;
            }

            Console.WriteLine("Would you like sugar for .50 more? 'y' or 'n'?");
            string sugarOptionInput = Console.ReadLine();

            // validating sugar option
            if (validate.SugarOption(sugarOptionInput))
            {
                // if invalid, asking again
                Console.WriteLine("Would you like sugar for .50 more? 'y' or 'n'?");
                string userInput = Console.ReadLine();
                if (userInput == "y")
                {
                    tea.SugarOption = true;
                } else
                {
                    tea.SugarOption = false;
                }
            }

            if (tea.SugarOption == true)
            {
                drinkOptionMenu.SugarAmount();
                string sugarChoiceInput = Console.ReadLine();
                tea.SugarAmount = sugarChoiceInput;

                Console.WriteLine("Wonderful. Here's your tea order:");
                Console.WriteLine($"A {tea.DrinkSize}, {tea.Temperature}, tea with {tea.SugarAmount} sugar for $1.75.");
                userMenu.AnotherOrder();
            }
            else
            {
                Console.WriteLine("Wonderful. Here's your tea order:");
                Console.WriteLine($"A {tea.DrinkSize}, {tea.Temperature}, tea with no sugar for $1.25.");
                userMenu.AnotherOrder();
            }
        }

        public void CoffeeOrder()
        {
            Coffee coffee = new Coffee();

            drinkOptionMenu.Size();
            string sizeChoiceInput = Console.ReadLine();

            if (validate.DrinkSize(sizeChoiceInput))
            {
                drinkOptionMenu.Size();
                string userInput = Console.ReadLine();
                coffee.DrinkSize = userInput;
            } else
            {
                coffee.DrinkSize = sizeChoiceInput;
            }

            drinkOptionMenu.Temp();
            string tempChoiceInput = Console.ReadLine();
            
            if (validate.TempOrder(tempChoiceInput))
            {
                drinkOptionMenu.Temp();
                string userInput = Console.ReadLine();
                coffee.Temperature = userInput;
            } else
            {
                coffee.Temperature = tempChoiceInput;
            }

            userMenu.CoffeeExtras();
            string coffeeAddInChoice = Console.ReadLine();

            switch (coffeeAddInChoice)
            {
                case "a": // cream only
                    drinkOptionMenu.CreamAmount();
                    string creamChoiceInput = Console.ReadLine();
                    coffee.CreamAmount = creamChoiceInput;
                    // final total
                    Console.WriteLine("Wonderful. Here's your coffee order:");
                    Console.WriteLine($"A {coffee.DrinkSize}, {coffee.Temperature}, coffee with {coffee.CreamAmount} cream and no sugar for $3.00.");
                    userMenu.AnotherOrder();
                    break;
                case "b": // sugar only
                    drinkOptionMenu.SugarAmount();
                    string sugarChoiceInput = Console.ReadLine();
                    coffee.SugarAmount = sugarChoiceInput;
                    // final total
                    Console.WriteLine("Wonderful. Here's your coffee order:");
                    Console.WriteLine($"A {coffee.DrinkSize}, {coffee.Temperature}, coffee with {coffee.SugarAmount} sugar and no cream for $2.75.");
                    userMenu.AnotherOrder();
                    break;
                case "c":  // cream and sugar
                    // cream order
                    drinkOptionMenu.CreamAmount();
                    string creamSelectedInput = Console.ReadLine();
                    coffee.CreamAmount = creamSelectedInput;
                    // sugar order
                    drinkOptionMenu.SugarAmount();
                    string sugarSelectdInput = Console.ReadLine();
                    coffee.SugarAmount = sugarSelectdInput;
                    // final total
                    Console.WriteLine("Wonderful. Here's your coffee order:");
                    Console.WriteLine($"A {coffee.DrinkSize}, {coffee.Temperature}, coffee with {coffee.CreamAmount} cream and {coffee.SugarAmount} sugar for $3.50.");
                    userMenu.AnotherOrder();
                    break;
                case "d": // no cream or sugar
                    Console.WriteLine("Wonderful. Here's your coffee order:");
                    Console.WriteLine($"A {coffee.DrinkSize}, {coffee.Temperature}, coffee with no cream or sugar for $2.25.");
                    userMenu.AnotherOrder();
                    break;
                default:
                    Console.WriteLine("Whoops, you need to enter a correct menu letter. For this insolence, now we have to start over.");
                    break;
            }
        }
    }
}
