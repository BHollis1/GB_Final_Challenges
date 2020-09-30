using System;

namespace KomodoCafeMenu_Console
{

    class ProgramUI
    {


        // Method that runs/starts the application
        public void Run()
        {
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
                    "3) Delete menu item \n" +
                    "4) Exit");
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
                        DeleteMenuItem();
                        break;
                    case "4":
                        keepRunning = false;
                        Console.WriteLine("Goodbye");
                        break;
                    default:
                        Console.WriteLine("Please enter 1,2,3 or 4");
                        break;
                }
                Console.WriteLine("Please press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }

        private void AddMenuItem()
        {
            MenuItems newContent = new MenuItems();

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

            //Console.WriteLine("What is the price of the meal?");
            //string floatAsString = Console.ReadLine();
            //newContent.ListOfIngredients = float.Equals(floatAsString);
        }

        private void ShowAllItems()
        { 

        }

        private void DeleteMenuItem()
        {

        }
    }
}
