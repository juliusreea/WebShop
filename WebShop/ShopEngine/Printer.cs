using System;
using System.Collections.Generic;
using WebShop.GoodsRepository;
using WebShop.ShopEngine;

namespace WebShop.ShopEngine
{
    public class Printer
    {
        public CartRepository cartList;
        public void DrinksPrinter()
        {
            var drinks = new DrinksRepository();
            var drinkList = drinks.LoadDrinks();
            foreach(var drink in drinkList)
            {
                Console.WriteLine($"[{drink.Index}] {drink.Name}, Volume: {drink.Liters}, Price: {drink.Price}, Barcode: {drink.Barcode}, Weight: {drink.Weight}");
            }
        }
        public void SweetsPrinter()
        {
            var sweets = new SweetsRepository();
            var sweetsList = sweets.LoadSweets();
            foreach (var sweet in sweetsList)
            {
                Console.WriteLine($"[{sweet.Index}] {sweet.Name}, Amount of Sugars: {sweet.Carbohydrates}, Price: {sweet.Price}, Barcode: {sweet.Barcode}, Weight: {sweet.Weight}");
            }
        }
        public void VegetablesPrinter()
        {
            var vegetable = new VegetablesRepository();
            var veggieList = vegetable.LoadVegetables();
            foreach (var veggie in veggieList)
            {
                Console.WriteLine($"[{veggie.Index}] {veggie.Name}, Fibers: {veggie.Fibers}, Price: {veggie.Price}, Barcode: {veggie.Barcode}, Weight: {veggie.Weight}");
            }
        }
        public void MeatPrinter()
        {
            var meats = new MeatRepository();
            var meatList = meats.LoadMeats();
            foreach (var meat in meatList)
            {
                Console.WriteLine($"[{meat.Index}] {meat.Name}, Proteins: {meat.Protein}, Price: {meat.Price}, Barcode: {meat.Barcode}, Weight: {meat.Weight}");
            }
        }
        
        
        public void AllGoodsPrinter()
        {
            Console.WriteLine("-----Drink List-----");
            DrinksPrinter();
            Console.WriteLine("-----Sweets List-----");
            SweetsPrinter();
            Console.WriteLine("-----Vegetables List-----");
            VegetablesPrinter();
            Console.WriteLine("-----Meat List-----");
            MeatPrinter();
        }
        //public void ShoppingCartPrinter()
        //{
        //    foreach (var item in cartList.CartList)
        //    {
        //        Console.WriteLine($"{item.Name},Barcode: {item.Barcode},Weight: {item.Weight},Price: {item.Price}");
        //    }
        //    Console.WriteLine($"-----total amount of goods {cartList.totalSum}----");
        //    Console.WriteLine("");
        //}
    }
}
