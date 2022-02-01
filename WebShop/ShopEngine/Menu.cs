using System;


namespace WebShop.ShopEngine
{ 
    public class Menu
    {
        public Cart cart = new Cart(); 
        public MenuWindows windows = new();
        public bool doContinue = true;
        public Printer printer = new();
        public void ShopInterface()
        {
            
            while (doContinue)
            {
                Console.WriteLine("Welcome to webshop \nPlease enter your amount before proceeding further");
                string userInput = Console.ReadLine();
                decimal parsedValue;
                if (!decimal.TryParse(userInput, out parsedValue))
                {
                    Console.WriteLine("Your input is incorrect, please enter correct amount");
                }
                if (parsedValue <= 0)
                {
                    Console.Clear();
                    Console.WriteLine("You'll be able only to view goods");
                    windows.GeneralWindowViewONly();
                }
                else
                {
                    Console.Clear();
                    windows.GeneralWindow();
                    //Console.WriteLine("Please select");
                    //Console.WriteLine("View goods [1]");
                    //Console.WriteLine("Purchase goods [2]");
                    //Console.WriteLine("View shopping cart [3]");
                    //Console.WriteLine("Check out [4]");
                    //Console.WriteLine("Send receipt [5]");

                    string menuInput = Console.ReadLine().Trim();
                    int parsedValue1;
                    if (!Int32.TryParse(menuInput, out parsedValue1) || parsedValue1 < 1 || parsedValue1 > 5)
                    {
                        Console.WriteLine("Your input is incorrect, please try again");
                    }

                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Please select list of good for display");
                        Console.WriteLine("Display Meat List [1]");
                        Console.WriteLine("Display Drink List [2]");
                        Console.WriteLine("Display Vegetables List [3]");
                        Console.WriteLine("Display Sweets List [4]");

                        string menuInput1 = Console.ReadLine();
                        int parsedValue2;
                        if (Int32.TryParse(menuInput1, out parsedValue2))
                        {
                            switch (parsedValue2)
                            {
                                case 1:
                                    Console.Clear();
                                    printer.MeatPrinter();
                                    cart.CartAddingDeviceMeat();
                                    ReturnToMainMenu();
                                    break;
                                case 2:
                                    Console.Clear();
                                    printer.DrinksPrinter();
                                    cart.CartAddingDeviceDrinks();
                                    ReturnToMainMenu();
                                    break;
                                case 3:
                                    Console.Clear();
                                    printer.VegetablesPrinter();
                                    cart.CartAddingDeviceVegetables();
                                    ReturnToMainMenu();
                                    break;
                                case 4:
                                    Console.Clear();
                                    printer.SweetsPrinter();
                                    cart.CartAddingDeviceSweets();
                                    ReturnToMainMenu();
                                    break;
                            }
                            
                        }
                        else 
                        {
                            Console.WriteLine("Your input is incorrect, please try again");
                        }
                    }
                }
            }
            
        }
        public void ReturnToMainMenu()
        {
            Console.WriteLine("Press any key to return to main menu");
            string input = Console.ReadLine();

        }
    }
}
