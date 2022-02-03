using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebShop.GoodsRepository;

namespace WebShop.ShopEngine
{
    public class CartRepository 
    {
        public decimal buyerMoney;
        public List<Cart> CartList { get; set; }
        public decimal totalSum;
        public Cart cart = new Cart();
        
        public CartRepository()
        {
            CartList = new List<Cart>();
        }

        public void ParseMeatToCart(Meat meat)
        {
            Cart cart = new Cart();
            cart.Name = meat.Name;
            cart.Price = meat.Price;
            //cart.Sum = meat.Protein;
            cart.Barcode = meat.Barcode;
            cart.Weight = meat.Weight;
            cart.Index  = meat.Index;
            CartList.Add(cart);
        }
        public void ParseSweetsToCart(Sweets sweet)
        {
            Cart cart = new Cart();
            cart.Name = sweet.Name;
            cart.Price = sweet.Price;
            //cart.Sum = sweet.Carbohydrates;
            cart.Barcode = sweet.Barcode;
            cart.Weight = sweet.Weight;
            cart.Index = sweet.Index;
            CartList.Add(cart);
        }
        public void ParseVegetablesToCart(Vegetables veggie)
        {
            Cart cart = new Cart();
            cart.Name = veggie.Name;
            //cart.Fibers = veggie.Fibers;
            cart.Price = veggie.Price;
            cart.Barcode = veggie.Barcode;
            cart.Weight = veggie.Weight;
            cart.Index = veggie.Index;
            CartList.Add(cart);
        }
        public void ParseDrinksToCart(Drinks drink)
        {
            Cart cart = new Cart();
            cart.Name = drink.Name;
            cart.Price = drink.Price;
            //cart.Sum = drink.Liters;
            cart.Barcode = drink.Barcode;
            cart.Weight = drink.Weight;
            cart.Index = drink.Index;
            CartList.Add(cart);
        }

        
        public void AddVegetableToCart(VegetablesRepository veggies, CartRepository cartrepo)
        {
            bool doContinue = true;
            while (doContinue)
            {
                Console.WriteLine("Please enter number of vegetable you want to add to your cart");
                string input = Console.ReadLine();
                if (!Int32.TryParse(input, out int parsedValue) || parsedValue < 1|| parsedValue > 5)
                {
                    Console.WriteLine("Your input is incorrect please press any key to refresh");
                    Console.ReadKey();
                }
                else
                {
                    if ((buyerMoney - totalSum) >= veggies.LoadVegetables()[parsedValue - 1].Price)
                    {
                        cartrepo.ParseVegetablesToCart(veggies.LoadVegetables()[parsedValue - 1]);
                        totalSum += veggies.LoadVegetables()[parsedValue - 1].Price;
                        Console.WriteLine($"{veggies.LoadVegetables()[parsedValue - 1].Name} added to cart");
                        Console.WriteLine($"your balance is {buyerMoney - totalSum}");
                    }
                    else
                    {
                        Console.WriteLine("sorry you dont have enough money to add this item");
                    }
                        
                }
               Console.WriteLine("Will you need to add any more vegetables? y/n");
                string answer = Console.ReadLine().Trim().ToLower();
                if(answer == "y")
                {
                    doContinue = true;
                }
                else if(answer == "n")
                {
                    doContinue= false;
                }
                else
                {
                    Console.WriteLine("input is incorrect");
                    Console.ReadKey();
                    doContinue = true;
                    
                }
            }
        }
        public void AddMeatsToCart(MeatRepository meats, CartRepository cartrepo)
        {
            bool doContinue = true;
            while (doContinue)
            {
                Console.WriteLine("Please enter number of meat you want to add to your cart");
                string input = Console.ReadLine();
                if (!Int32.TryParse(input, out int parsedValue) || parsedValue < 1 || parsedValue > 5)
                {
                    Console.WriteLine("Your input is incorrect please press any key to refresh");
                    Console.ReadKey();
                }
                else
                {
                    if ((buyerMoney-totalSum) > meats.LoadMeats()[parsedValue - 1].Price)
                    {

                        cartrepo.ParseMeatToCart(meats.LoadMeats()[parsedValue - 1]);
                        totalSum += meats.LoadMeats()[parsedValue - 1].Price;
                        Console.WriteLine($"{meats.LoadMeats()[parsedValue - 1].Name} added to cart");
                        Console.WriteLine($"your balance is {buyerMoney - totalSum}");
                    }
                    else
                    {
                        Console.WriteLine("sorry you dont have enough money to add this item");
                    }
                }
                Console.WriteLine("Will you need to add any more meat? y/n");
                string answer = Console.ReadLine().Trim().ToLower();
                if (answer == "y")
                {
                    doContinue = true;
                }
                else if (answer == "n")
                {
                    doContinue = false;
                }
                else
                {
                    Console.WriteLine("input is incorrect");
                    doContinue = true;
                    Console.ReadKey();
                }
            }
        }
        public void AddSweetsToCart(SweetsRepository sweets, CartRepository cartrepo)
        {
            bool doContinue = true;
            while (doContinue)
            {
                Console.WriteLine("Please enter number of sweet you want to add to your cart");
                string input = Console.ReadLine();
                if (!Int32.TryParse(input, out int parsedValue) || parsedValue < 1 || parsedValue > 5)
                {
                    Console.WriteLine("Your input is incorrect please press any key to refresh");
                    Console.ReadKey();
                }
                else
                {
                    if ((buyerMoney - totalSum) > sweets.LoadSweets()[parsedValue - 1].Price)
                    {
                        cartrepo.ParseSweetsToCart(sweets.LoadSweets()[parsedValue - 1]);
                        totalSum += sweets.LoadSweets()[parsedValue - 1].Price;
                        Console.WriteLine($"{sweets.LoadSweets()[parsedValue - 1].Name} added to cart");
                        Console.WriteLine($"your balance is {buyerMoney - totalSum}");
                    }
                    else
                    {
                        Console.WriteLine("sorry you dont have enough money to add this item");
                    }
                        
                }
                Console.WriteLine("Will you need to add any more sweets? y/n");
                string answer = Console.ReadLine().Trim().ToLower();
                if (answer == "y")
                {
                    doContinue = true;
                }
                else if (answer == "n")
                {
                    doContinue = false;
                }
                else
                {
                    Console.WriteLine("input is incorrect");
                    doContinue = true;
                    Console.ReadKey();
                }
            }
        }
        public void AddDrinksToCart(DrinksRepository drinks, CartRepository cartrepo)
        {
            bool doContinue = true;
            while (doContinue)
            {
                Console.WriteLine($"your balance is {buyerMoney - totalSum}");

                Console.WriteLine("Please enter number of drink you want to add to your cart");

                string input = Console.ReadLine();
                if (!Int32.TryParse(input, out int parsedValue) || parsedValue < 1 || parsedValue > 5)
                {
                    Console.WriteLine("Your input is incorrect please press any key to refresh");
                    Console.ReadKey();
                    doContinue = true;
                }
                else
                {
                    if ((buyerMoney - totalSum) > drinks.LoadDrinks()[parsedValue - 1].Price)
                    {
                        cartrepo.ParseDrinksToCart(drinks.LoadDrinks()[parsedValue - 1]);
                        totalSum += drinks.LoadDrinks()[parsedValue - 1].Price;
                        Console.WriteLine($"{drinks.LoadDrinks()[parsedValue - 1].Name} added to cart");
                        Console.WriteLine($"your balance is {buyerMoney - totalSum}");
                    }
                    else
                    {
                        Console.WriteLine("sorry you dont have enough money to add this item");
                    } 
                }
                Console.WriteLine("Will you need to add any more drinks? y/n");
                string answer = Console.ReadLine().Trim().ToLower();
                if (answer == "y")
                {
                    doContinue = true;
                }
                else if (answer == "n")
                {
                    doContinue = false;
                }
                else
                {
                    Console.WriteLine("input is incorrect");
                    doContinue = true;
                    Console.ReadKey();
                }
            }
        }
        public void ShoppingCartPrinter()
        {
            foreach (var item in CartList)
            {
                Console.WriteLine($"{item.Name},Barcode: {item.Barcode},Weight: {item.Weight},Price: {item.Price}");
            }
            Console.WriteLine($"-----total amount of goods {totalSum}----");
        }
        public void CheckOutPrinter()
        {
            foreach (var item in CartList)
            {
                Console.WriteLine($"{item.Name},Barcode: {item.Barcode},Weight: {item.Weight},Price: {item.Price}");
            }
            Console.WriteLine($"-----total amount of goods {totalSum}----");
            FileService fileService = new FileService();
            fileService.FileWriteService(CartList);
            Console.WriteLine("Check has been printed");
        }
    }
}
