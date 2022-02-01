using System;


namespace WebShop.ShopEngine
{ 
    public class Menu
    {
        public MenuWindows windows = new();
        public void ShopInterface()
        {
            
            Console.WriteLine("Welcome to webshop \nPlease enter your amount before proceeding further");
            string userInput = Console.ReadLine();
            int parsedValue;
            if (!Int32.TryParse(userInput, out parsedValue))
            {
                Console.WriteLine("Your input is incorrect, please enter correct amount");
            }
            else if (parsedValue <= 0)
            {
                Console.Clear();
                Console.WriteLine("You'll be able only to view goods");
                windows.GeneralWindowViewONly();
            }
            else
            {
                Console.Clear();
                windows.GeneralWindow();
                Console.WriteLine("Please select");
                Console.WriteLine("View goods [1]");
                Console.WriteLine("Purchase goods [2]");
                Console.WriteLine("View shopping cart [3]");
                Console.WriteLine("Check out [4]");
                Console.WriteLine("Send receipt [5]");

                string menuInput = Console.ReadLine().Trim();
                int parsedValue1;
                if (!Int32.TryParse(userInput, out parsedValue1) || parsedValue1 < 1 || parsedValue1 > 5)
                {
                    Console.WriteLine("Your input is incorrect, please try again");
                }
                
                else
                {
                    Console.WriteLine("Please select list of good for display");
                    Console.WriteLine("Display Meat List [1]");
                    Console.WriteLine("Display Drink List [2]");
                    Console.WriteLine("Display Vegetables List [3]");
                    Console.WriteLine("Display Sweets List [4]");

                    string menuInput1 = Console.ReadLine().Trim();
                    int parsedValue2;
                    if (!Int32.TryParse(userInput, out parsedValue2) || parsedValue2 < 1 || parsedValue2 > 4)
                    {
                        Console.WriteLine("Your input is incorrect, please try again");
                    }
                    else
                    {
                        switch (parsedValue2)
                        {
                            case 1:
                                Console.WriteLine("Show Meat list ");
                                Printer printer = new();
                                printer.MeatPrinter();
                                break;
                            case 2:
                                Console.WriteLine("Show list ");
                                Printer printer1 = new();
                                printer1.DrinksPrinter();
                                break;
                            case 3:
                                Console.WriteLine("Show list ");
                                Printer printer2 = new();
                                printer2.VegetablesPrinter();
                                break;
                            case 4:
                                Console.WriteLine("Show list ");
                                Printer printer3 = new();
                                printer3.SweetsPrinter();
                                break;
                        }
                    }
                }
            }
        }
    }
}
