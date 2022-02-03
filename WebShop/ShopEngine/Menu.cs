using System;
using WebShop.GoodsRepository;

namespace WebShop.ShopEngine
{ 
    public class Menu
    {
        public decimal BuyerMoney;
        public Cart cart = new Cart(); 
        public MenuWindows windows = new();
        public bool doContinue = true;
        public Printer printer = new();
        public CartRepository cartList = new CartRepository();

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
                    if (!decimal.TryParse(userInput, out cartList.buyerMoney))
                    {
                        Console.WriteLine("Your input is incorrect, press any button to refresh");
                        Console.ReadKey();
                        break;

                    }
                    else if (cartList.buyerMoney <= 0)
                    {
                        Console.Clear();
                        Console.WriteLine("press any key to view all items");
                        windows.GeneralWindowViewONly();
                        printer.AllGoodsPrinter();
                        ReturnToMainMenu();
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        windows.GeneralWindow();
                        Console.WriteLine($"Your balance: {cartList.buyerMoney - cartList.totalSum}");

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
                                        cartList.AddMeatsToCart(meats, cartList);
                                        ReturnToMainMenu();
                                        break;
                                    case 2:
                                        Console.Clear();
                                        printer.DrinksPrinter();
                                        DrinksRepository drinks = new();
                                        cartList.AddDrinksToCart(drinks, cartList);
                                        ReturnToMainMenu();
                                        break;
                                    case 3:
                                        Console.Clear();
                                        printer.VegetablesPrinter();
                                        VegetablesRepository veggies = new();
                                        cartList.AddVegetableToCart(veggies, cartList);
                                        ReturnToMainMenu();
                                        break;
                                    case 4:
                                        Console.Clear();
                                        printer.SweetsPrinter();
                                        SweetsRepository sweets = new();
                                        cartList.AddSweetsToCart(sweets, cartList);
                                        ReturnToMainMenu();
                                        break;
                                }
                            }
                        }
                        else if (parsedValue1 == 3)
                        {
                            Console.Clear();
                            printer.ShoppingCartPrinter(cartList);
                            ReturnToMainMenu();
                        }
                        else if (parsedValue1 == 4)
                        {
                            Console.Clear();
                            printer.CheckOutPrinter(cartList);
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
