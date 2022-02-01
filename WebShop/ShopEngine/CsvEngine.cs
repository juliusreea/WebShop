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
            string path = @"C:\Users\Dell\Documents\GitHub\WebShop\WebShop\CSVFIles\Drinks.csv";

            List<string> lines = new List<string>();

            lines = File.ReadAllLines(path).ToList();

            List<Drinks> drinks = new();

            foreach(var line in lines)
            {
                string[] drinkLine = line.Split(',');
                Drinks drinkData = new();
                drinkData.Name = drinkLine[0];
                drinkData.Liters = Convert.ToDouble(drinkLine[1], CultureInfo.InvariantCulture);
                drinkData.Price = Convert.ToDecimal(drinkLine[2], CultureInfo.InvariantCulture);
                drinkData.Barcode = drinkLine[3];
                drinkData.Weight = Convert.ToDouble(drinkLine[4], CultureInfo.InvariantCulture);
                drinkData.Index = int.Parse(drinkLine[5]);
                drinks.Add(drinkData);
            }
            return drinks;
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
            string path = @"C:\Users\Dell\Documents\GitHub\WebShop\WebShop\CSVFIles\Sweets.csv";

            List<string> lines = new List<string>();

            lines = File.ReadAllLines(path).ToList();

            List<Sweets> sweets = new();

            foreach (var line in lines)
            {
                string[] sweetsLine = line.Split(',');
                Sweets sweetsData = new();
                sweetsData.Name = sweetsLine[0];
                sweetsData.Carbohydrates = Convert.ToDouble(sweetsLine[1], CultureInfo.InvariantCulture);
                sweetsData.Price = Convert.ToDecimal(sweetsLine[2], CultureInfo.InvariantCulture);
                sweetsData.Barcode = sweetsLine[3];
                sweetsData.Weight = Convert.ToDouble(sweetsLine[4], CultureInfo.InvariantCulture);
                sweetsData.Index = int.Parse(sweetsLine[5]);
                sweets.Add(sweetsData);
            }
            return sweets;
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
                string[] meatLine = line.Split(";") ;
                Meat meatData = new();
                meatData.Name = meatLine[0];
                meatData.Protein = Convert.ToDouble(meatLine[1], CultureInfo.InvariantCulture);
                meatData.Price = Convert.ToDecimal(meatLine[2], CultureInfo.InvariantCulture);
                meatData.Barcode = meatLine[3];
                meatData.Weight = Convert.ToDouble(meatLine[4], CultureInfo.InvariantCulture);
                meatData.Index = int.Parse(meatLine[5]);
                meats.Add(meatData);

            }
            return meats;
        }
    }
}
