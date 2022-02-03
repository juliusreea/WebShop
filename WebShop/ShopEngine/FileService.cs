using System;
using System.Collections.Generic;
using System.IO;
namespace WebShop.ShopEngine
{
    public class FileService
    {
        public readonly string path = @"C:\Users\Dell\Documents\GitHub\WebShop\WebShop\CSVFIles\CartList.txt";

        public List<string> cartList = new();
        public CartRepository cartRepository;

        public void FileWriteService(List<Cart> list)
        {

            //File.AppendAllLines(path,);
            foreach (Cart item in list)
            {
                cartList.Add($"{item.Name}, {item.Price}, {item.Weight}, {item.Barcode}");
            }
            File.WriteAllLines(path, cartList);
            File.AppendAllText(path, $"Date of purchase: {DateTime.Now}");
        }
    }
}
