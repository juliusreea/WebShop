using System;
using WebShop.ShopEngine;

namespace WebShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer printer = new();
            printer.VegetablesPrinter();
            Menu menu = new();
            menu.ShopInterface();
        }
    }
}
