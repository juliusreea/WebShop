using System;
using System.Collections.Generic;
using WebShop.ShopEngine;
using WebShop.GoodsRepository;

namespace WebShop.ShopEngine
{
    public class Cart:Good
    {

        public Cart(string name, double sum, decimal price, int barcode, double weight) : base(name, barcode, price)
        {

        }

        public List<Cart> ShoppingCart { get; set; }


        public Cart()
        {
        }
        public decimal sum;
        public void CartAddingDeviceVegetables(string menuInput)
        {
            bool doContinue = true;
            if (doContinue)
            {
                Console.WriteLine("Please type number what products you want to add to your cart");
                menuInput = Console.ReadLine().Trim();
                int parsedValue;
                if (!Int32.TryParse(menuInput, out parsedValue) || parsedValue < 1 || parsedValue > 4)
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
                        if (parsedValue == item.Barcode)
                        {
                            newCart.Add(repo.LoadVegetables()[parsedValue].Name);
                            sum += repo.LoadVegetables()[parsedValue].Price;
                        }
                    }
                }
            }
        }
    }
}
