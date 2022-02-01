using System;
using System.Collections.Generic;
using WebShop.ShopEngine;
using WebShop.GoodsRepository;

namespace WebShop.ShopEngine
{
    public class Cart : Good
    {

        //public Cart(string name, double sum, decimal price, int barcode, double weight) : base(name, barcode, price)
        //{

        //}

        public List<Cart> ShoppingCart { get; set; }


        public Cart()
        {
        }
        public decimal sum;
        public void CartAddingDeviceVegetables()
        {
            bool doContinue = true;
            while (doContinue)
            {
                Console.WriteLine("Please type number of product you want to add to your cart");
                string menuInput = Console.ReadLine().Trim();
                int parsedValue;
                if (!Int32.TryParse(menuInput, out parsedValue) || parsedValue < 1 || parsedValue > 5)
                {
                    Console.WriteLine("Your input is incorrect, please try again");
                    doContinue = true;
                }
                else
                {
                    List<Vegetables> veggies = new();
                    List<string> newCart = new();
                    VegetablesRepository repo = new();

                    foreach (var item in veggies)
                    {
                        if (parsedValue == item.Index)
                        {
                            newCart.Add(repo.LoadVegetables()[parsedValue].Name);
                            sum += repo.LoadVegetables()[parsedValue].Price;
                        }
                    }
                    Console.WriteLine("Do you want to add any more products? y/n");
                    string input = Console.ReadLine().Trim().ToLower();
                    if (input == "y")
                        doContinue = true;
                    else if (input == "n")
                    {
                        doContinue = false;
                    }
                }
            }

        }
        public void CartAddingDeviceDrinks()
        {
            bool doContinue = true;
            while (doContinue)
            {
                Console.WriteLine("Please type number of product you want to add to your cart");
                string menuInput = Console.ReadLine().Trim();
                int parsedValue;
                if (!Int32.TryParse(menuInput, out parsedValue) || parsedValue < 1 || parsedValue > 5)
                {
                    Console.WriteLine("Your input is incorrect, please try again");
                    doContinue = true;
                }
                else
                {
                    List<Drinks> drinks = new();
                    List<string> newCart = new();
                    DrinksRepository repo = new();

                    foreach (var item in drinks)
                    {
                        if (parsedValue == item.Index)
                        {
                            newCart.Add(repo.LoadDrinks()[parsedValue].Name);
                            sum += repo.LoadDrinks()[parsedValue].Price;
                        }
                    }
                    Console.WriteLine("Do you want to add any more products? y/n");
                    string input = Console.ReadLine().Trim().ToLower();
                    if (input == "y")
                        doContinue = true;
                    else if (input == "n")
                    {
                        doContinue = false;
                    }
                }
            }

        }
        public void CartAddingDeviceSweets()
        {
            bool doContinue = true;
            while (doContinue)
            {
                Console.WriteLine("Please type number of product you want to add to your cart");
                string menuInput = Console.ReadLine().Trim();
                int parsedValue;
                if (!Int32.TryParse(menuInput, out parsedValue) || parsedValue < 1 || parsedValue > 5)
                {
                    Console.WriteLine("Your input is incorrect, please try again");
                    doContinue = true;
                }
                else
                {
                    List<Sweets> sweets = new();
                    List<string> newCart = new();
                    SweetsRepository repo = new();

                    foreach (var item in sweets)
                    {
                        if (parsedValue == item.Index)
                        {
                            newCart.Add(repo.LoadSweets()[parsedValue].Name);
                            sum += repo.LoadSweets()[parsedValue].Price;
                        }
                    }
                    Console.WriteLine("Do you want to add any more products? y/n");
                    string input = Console.ReadLine().Trim().ToLower();
                    if (input == "y")
                        doContinue = true;
                    else if (input == "n")
                    {
                        doContinue = false;
                    }
                }
            }
        }
        public void CartAddingDeviceMeat()
        {
            bool doContinue = true;
            while (doContinue)
            {
                Console.WriteLine("Please type number of product you want to add to your cart");
                string menuInput = Console.ReadLine().Trim();
                int parsedValue;
                if (!Int32.TryParse(menuInput, out parsedValue) || parsedValue < 1 || parsedValue > 5)
                {
                    Console.WriteLine("Your input is incorrect, please try again");
                    doContinue = true;
                }
                else
                {
                    List<Meat> meats = new();
                    List<string> newCart = new();
                    MeatRepository repo = new();

                    foreach (var item in meats)
                    {
                        if (parsedValue == item.Index)
                        {
                            newCart.Add(repo.LoadMeats()[parsedValue].Name);
                            sum += repo.LoadMeats()[parsedValue].Price;
                        }
                    }
                    Console.WriteLine("Do you want to add any more products? y/n");
                    string input = Console.ReadLine().Trim().ToLower();
                    if (input == "y")
                        doContinue = true;
                    else if (input == "n")
                    {
                        doContinue = false;
                    }
                }
            }
        }
    }
}
