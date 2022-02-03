using System;
using System.Collections.Generic;
using System.IO;
namespace WebShop.ShopEngine
{
    public class FileService
    {
        public readonly string path = @"C:\Users\Dell\Documents\GitHub\WebShop\WebShop\CSVFIles\Check.txt";

        public List<string> cartList = new();

        public void FileWriteService(List<Cart> list, CartRepository cartRepository)
        {

            //File.AppendAllLines(path,);
            foreach (Cart item in list)
            {
                cartList.Add($"{item.Name}, Price: {item.Price}, Weight: {item.Weight}, Barcode; {item.Barcode}");
            }
            File.WriteAllLines(path, cartList);
            File.AppendAllText(path, $"Total amount :{cartRepository.totalSum}");
            File.AppendAllText(path, $"\nDate of purchase: {DateTime.Now}");
        }
    }
}
