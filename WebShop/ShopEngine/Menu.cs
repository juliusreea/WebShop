using System;
using WebShop.GoodsRepository;

namespace WebShop.ShopEngine
{ 
    public class Menu
    {
        public Cart cart = new Cart(); 
        public MenuWindows windows = new();
        public bool doContinue = true;
        public Printer printer = new();
        public CartRepository cartRepository = new CartRepository();

        public void ShopInterface()
        {
            while (doContinue)
            {
                Console.Clear();
                Console.WriteLine("Welcome to webshop \nPlease enter your amount before proceeding further");
                string userInput = Console.ReadLine();
                bool menuTrue = true;
                while (menuTrue)
                {
                    if (!decimal.TryParse(userInput, out cartRepository.buyerMoney))
                    {
                        Console.WriteLine("Your input is incorrect, press any button to refresh");
                        Console.ReadKey();
                        break;

                    }
                    else if (cartRepository.buyerMoney <= 0)
                    {
                        Console.Clear();
                        windows.GeneralWindowViewONly();
                        printer.AllGoodsPrinter();
                        ReturnToMainMenu();
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        windows.GeneralWindow();
                        Console.WriteLine($"Your balance: {cartRepository.buyerMoney - cartRepository.totalSum}");

                        string menuInput = Console.ReadLine().Trim();
                        int parsedValue1;
                        if (!int.TryParse(menuInput, out parsedValue1) || parsedValue1 < 1 || parsedValue1 > 6)
                        {
                            Console.WriteLine("Your input is incorrect, press any key to refresh");
                            Console.ReadKey();
                        }
                        if (parsedValue1 == 1)
                        {
                            Console.Clear();
                            printer.AllGoodsPrinter();
                           
                            ReturnToMainMenu();
                        }
                        else if (parsedValue1 == 2)
                        {
                            Console.Clear();
                            windows.GoodsList();
                            
                            string menuInput1 = Console.ReadLine();
                            int parsedValue2;
                            if (Int32.TryParse(menuInput1, out parsedValue2))
                            {
                                switch (parsedValue2)
                                {
                                    case 1:
                                        Console.Clear();
                                        printer.MeatPrinter();
                                        MeatRepository meats = new();
                                        cartRepository.AddMeatsToCart(meats, cartRepository);
                                        ReturnToMainMenu();
                                        break;
                                    case 2:
                                        Console.Clear();
                                        printer.DrinksPrinter();
                                        DrinksRepository drinks = new();
                                        cartRepository.AddDrinksToCart(drinks, cartRepository);
                                        ReturnToMainMenu();
                                        break;
                                    case 3:
                                        Console.Clear();
                                        printer.VegetablesPrinter();
                                        VegetablesRepository veggies = new();
                                        cartRepository.AddVegetableToCart(veggies, cartRepository);
                                        ReturnToMainMenu();
                                        break;
                                    case 4:
                                        Console.Clear();
                                        printer.SweetsPrinter();
                                        SweetsRepository sweets = new();
                                        cartRepository.AddSweetsToCart(sweets, cartRepository);
                                        ReturnToMainMenu();
                                        break;
                                }
                            }
                        }
                        else if (parsedValue1 == 3)
                        {
                            Console.Clear();
                            printer.ShoppingCartPrinter(cartRepository);
                            ReturnToMainMenu();
                        }
                        else if (parsedValue1 == 4)
                        {
                            Console.Clear();
                            printer.CheckOutPrinter(cartRepository);
                            Console.WriteLine("enter your email if you want check sent");
                            string emailAddress = Console.ReadLine();
                            MailingService mailingService = new MailingService();
                            mailingService.CreateTestMessage(emailAddress);
                            Console.WriteLine("Mail sent");
                            ReturnToMainMenu();
                        }
                        else if(parsedValue1 == 5)
                        {
                            Environment.Exit(0);
                           
                        }
                        else
                        {
                            Console.WriteLine("input incorrect");
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
