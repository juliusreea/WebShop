using System;
using System.Collections.Generic;
using WebShop.GoodsRepository;

namespace WebShop.ShopEngine
{
    public class MenuWindows
    {
        public void GeneralWindowViewONly()
        {
            Console.WriteLine("Please select");
            Console.WriteLine("View goods [1]");
            Console.WriteLine("View shopping cart [2]");
            Console.WriteLine("Check out [3]");
            Console.WriteLine("Send receipt [4]");
        }
        public void GeneralWindow()
        {
            Console.WriteLine("Please select");
            Console.WriteLine("View goods [1]");
            Console.WriteLine("Purchase goods [2]");
            Console.WriteLine("View shopping cart [3]");
            Console.WriteLine("Check out [4]");
            Console.WriteLine("Send receipt [5]");
        }
        
    }
}
