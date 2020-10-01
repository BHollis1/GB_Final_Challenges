using System;
using System.Collections.Generic;

namespace KomodoCafeMenu_Console
{

    class ChallengeOne_ProgramUI
    {
        private ChallengeOne_MenuRepository _menuRepo = new ChallengeOne_MenuRepository();


        // Method that runs/starts the application
        public void Run()
        {
            SeedContentList();
            Menu();
        }

        // Menu
        private void Menu()
        {

            bool keepRunning = true;
            while (keepRunning)
            {


                //Display options to user
                Console.WriteLine("Hello. Please enter the number of the optiion you'd like to select: \n" +
                    "1) Add new menu item \n" +
                    "2) Show all menu item \n" +
                    "3) Display menu by item name \n" +
                    "4) Delete menu item \n" +
                    "5) Exit");
                //Get user's input
                string userInput = Console.ReadLine();
                //Evaluate user's input and act 
                switch (userInput)
                {
                    case "1":
                        AddMenuItem();
                        break;
                    case "2":
                        ShowAllItems();
                        break;
                    case "3":
                        DisplayMenuByName();
                        break;
                    case "4":
                        DeleteMenuItem();
                        break;
                    case "5":
                        keepRunning = false;
                        Console.WriteLine("Goodbye");
                        break;
                    default:
                        Console.WriteLine("Please enter 1,2,3,4 or 5");
                        break;
                }
                Console.WriteLine("Please press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }

        private void AddMenuItem()
        {
            Console.Clear();
            ChallengeOne_MenuItems newContent = new ChallengeOne_MenuItems();

            //MealNum
            Console.WriteLine("Enter the number for the meal:");
            string numberAsString = Console.ReadLine();
            newContent.MealNumber = int.Parse(numberAsString);

            //MealName
            Console.WriteLine("Enter the name of the meal:");
            newContent.MealName = Console.ReadLine();

            //MealDesc
            Console.WriteLine("Enter the description of the meal:");
            newContent.MealDescription = Console.ReadLine();

            //ListOfIng
            Console.WriteLine("Enter an ingredient from the meal:");
            newContent.ListOfIngredients = Console.ReadLine();

            //MealPrice
            Console.WriteLine("Enter a meal price:");
            string decimalAsString = Console.ReadLine();
            newContent.MealPrice = decimal.Parse(decimalAsString);

            
        }

        private void ShowAllItems()
        {
            Console.Clear();
            List<ChallengeOne_MenuItems> listOfItems = _menuRepo.GetMenuItems();

            foreach(ChallengeOne_MenuItems content in listOfItems)
            {
                Console.WriteLine($" MealName: {content.MealName}");
            }
        }

        private void DisplayMenuByName()
        {
            Console.Clear();
            Console.WriteLine("Enter the name of the menu item you would like to see:");
            string mealName = Console.ReadLine();
            ChallengeOne_MenuItems content = _menuRepo.GetMenuItemsByName(mealName);

            if(content != null)
            {
                Console.WriteLine($" MealNumber: {content.MealNumber}\n" +
                    $" MealName: {content.MealName}\n" +
                    $"MealDescription: {content.MealDescription}\n" +
                    $" ListOfIngredients: {content.ListOfIngredients}\n" +
                    $" MealPrice: {content.MealPrice}\n");
            }
            else
            {
                Console.WriteLine("I couldn't find an item by that name");
            }
        }

        private void DeleteMenuItem()
        {
           

            ShowAllItems();
            Console.WriteLine("Enter the name of the item you would like to remove:");
            string input = Console.ReadLine();
            bool wasDeleted = _menuRepo.DeleteMenuItemFromList(input);
            if (wasDeleted)
            {
                Console.WriteLine("Item successfully deleted");
            }
            else
            {
                Console.WriteLine("Item could not be deleted.");
            }


        }
        private void SeedContentList()
        {
            ChallengeOne_MenuItems hamburger = new ChallengeOne_MenuItems(1, "Hamburger", "100% Angus Beef", "lettuce, mayo, onion, cheese, bacon, tomato, pickle", 6);
            ChallengeOne_MenuItems chiliCheeseFries = new ChallengeOne_MenuItems(2, "Chili Cheese Fries", "Fries smothered in chili and cheese", "French Fries, homemade chili, Sharp Cheddar cheese", 5);
            ChallengeOne_MenuItems milkshake = new ChallengeOne_MenuItems(3, "Strawberry Milkshake", "strawberry ice cream with loads of strawberry pieces", "Strawberry Ice Cream, Strawberries, Milk, Sugar", 4);

            _menuRepo.AddNewMenuItems(hamburger);
            _menuRepo.AddNewMenuItems(chiliCheeseFries);
            _menuRepo.AddNewMenuItems(milkshake);

        }
       


        
            
            
    }
    
}
