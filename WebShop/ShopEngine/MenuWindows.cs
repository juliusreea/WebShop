using System;
using System.Collections.Generic;
using WebShop.GoodsRepository;

namespace WebShop.ShopEngine
{
    public class MenuWindows
    {
        public void GeneralWindowViewONly()
        {
            Console.WriteLine("Since your balance is 0 view goods only");
            
        }
        public void GeneralWindow()
        {
            Cart cart = new Cart();
            Console.WriteLine("Please select");
            Console.WriteLine("View goods [1]");
            Console.WriteLine("Purchase goods [2]");
            Console.WriteLine("View shopping cart [3]");
            Console.WriteLine("Check out and send receipt [4]");
            Console.WriteLine("Exit [5]");
        }
        public void GoodsList()
        {
            Console.WriteLine("Please select list of good for display");
            Console.WriteLine("Display Meat List [1]");
            Console.WriteLine("Display Drink List [2]");
            Console.WriteLine("Display Vegetables List [3]");
            Console.WriteLine("Display Sweets List [4]");
            Console.WriteLine("Exit to main Menu [5]");
        }
    }
}
