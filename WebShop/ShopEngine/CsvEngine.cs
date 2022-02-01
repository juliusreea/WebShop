using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Globalization;

namespace WebShop.ShopEngine
{
    public class CsvEngine
    {
        
        public List<Drinks> CsvReadFileDrinks()
        {
            string path = @"Users/juliusvaigauskas/projects/drinks.txt";

            List<string> lines = new List<string>();

            lines = File.ReadAllLines(path).ToList();

            List<Drinks> drinks = new();

            foreach(var line in lines)
            {
                string[] drinkLine = line.Split(',');
                drinks.Add(ParseDrinksIntoParameters(drinkLine));
            }
            return drinks;
        }
        public Drinks ParseDrinksIntoParameters(string[] drinkLine)
        {
            Drinks drinkData = new();
            drinkData.Name = drinkLine[0];
            drinkData.Liters = double.Parse(drinkLine[1]);
            drinkData.Price = decimal.Parse(drinkLine[2]);
            drinkData.Barcode = drinkLine[3];
            drinkData.Weight = double.Parse(drinkLine[4]);

            return drinkData;
        }

        /// Vegetables/// Vegetables/// Vegetables/// Vegetables/// Vegetables/// Vegetables/// Vegetables

        public List<Vegetables> CsvReadFileVegetables()
        {
            string path = @"C:\Users\Dell\Documents\GitHub\WebShop\WebShop\CSVFIles\Vegetables.csv";

            List<string> lines = new ();

            lines = File.ReadAllLines(path).ToList();
            
            List<Vegetables> vegetables = new();

            foreach (var line in lines)
            {
                string[] vegetableLine = line.Split(";");
                Vegetables vegetabelData = new();
                vegetabelData.Name = vegetableLine[0];
                vegetabelData.Fibers = Convert.ToDouble(vegetableLine[1], CultureInfo.InvariantCulture);
                vegetabelData.Price = Convert.ToDecimal(vegetableLine[2], CultureInfo.InvariantCulture);
                vegetabelData.Barcode = vegetableLine[3];
                vegetabelData.Weight = Convert.ToDouble(vegetableLine[4], CultureInfo.InvariantCulture);
                vegetabelData.Index = int.Parse(vegetableLine[5]);
                vegetables.Add(vegetabelData);
            }
            return vegetables;
        }

        /// Sweets/// Sweets/// Sweets/// Sweets/// Sweets/// Sweets/// Sweets/// Sweets/// Sweets

        public List<Sweets> CsvReadFileSweets()
        {
            string path = @"Users/juliusvaigauskas/projects/sweets.txt";

            List<string> lines = new List<string>();

            lines = File.ReadAllLines(path).ToList();

            List<Sweets> sweets = new();

            foreach (var line in lines)
            {
                string[] sweetsLine = line.Split(',');
                sweets.Add(ParseSweetsIntoParameters(sweetsLine));
            }
            return sweets;
        }
        public Sweets ParseSweetsIntoParameters(string[] sweetsLine)
        {
            Sweets sweetsData = new();
            sweetsData.Name = sweetsLine[0];
            sweetsData.Carbohydrates = double.Parse(sweetsLine[1]);
            sweetsData.Price = decimal.Parse(sweetsLine[2]);
            sweetsData.Barcode = sweetsLine[3];
            sweetsData.Weight = double.Parse(sweetsLine[4]);

            return sweetsData;
        }



        /// Meat/// Meat/// Meat/// Meat/// Meat/// Meat/// Meat/// Meat/// Meat/// Meat



        public List<Meat> CsvReadFileMeat()
        {
            string path = @"C:\Users\Dell\Documents\GitHub\WebShop\WebShop\CSVFIles\Meat.csv";

            List<string> lines = new List<string>();

            lines = File.ReadAllLines(path).ToList();

            List<Meat> meats = new();

            foreach (var line in lines)
            {
                string[] meatLine = line.Split(',');
                meats.Add(ParseMeatIntoParameters(meatLine));
            }
            return meats;
        }
        public Meat ParseMeatIntoParameters(string[] meatLine)
        {
            Meat meatData = new();
            meatData.Name = meatLine[0];
            meatData.Protein = double.Parse(meatLine[1]);
            meatData.Price = decimal.Parse(meatLine[2]);
            meatData.Barcode = meatLine[3];
            meatData.Weight = double.Parse(meatLine[4]);
            meatData.Index = int.Parse(meatLine[5]);

            return meatData;
        }
    }
}
