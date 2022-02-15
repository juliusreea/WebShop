using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WebShop.ShopEngine
{
    public static class GenericFileReader
    {

        public static List<T> LoadFromFileText<T>(string path) where T : class, new()
        {
            var lines = File.ReadAllLines(path).ToList();
            List<T> output = new List<T>();
            T entry = new();
            var cols = entry.GetType().GetProperties();

            if(lines.Count < 2)
            {
                throw new IndexOutOfRangeException("file is empty or data is missing");
            }

            var headers = lines[0].Split(';'); 

            //lines.RemoveAt(0);

            foreach (var row in lines)
            {
                entry = new T();

                string[] value = row.Split(';');

                for(int i = 0; i < value.Length; i++)
                {
                    foreach(var col in cols)
                    {
                        if(col.Name == value[i])
                        {
                            col.SetValue(entry, Convert.ChangeType(value[i], col.PropertyType));
                        }
                    }
                }
                output.Add(entry);
            }
            return output;
        }
    }
}
