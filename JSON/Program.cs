using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Encodings.Web;
using System.Text.Unicode;
using System.IO;

namespace JSON
{
    class Program
    {
        static void Main(string[] args)
        {
            Goods goods = new Goods() 
            { 
                GoodsItem = 100, 
                GoodsName = new string[] { "банан", "апельсин", "яблоко", "масло", "творог" }, 
                GoodsPrice = 100.10 
            };
            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
                WriteIndented = true,                
            };
            string jsonString1 = JsonSerializer.Serialize(goods, options);
            Console.WriteLine(jsonString1);

            string path = "Products.json";
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine(jsonString1);                
            }
            Console.ReadKey();
        }
    }
    class Goods
    {
        public int GoodsItem { get; set; }
        public string[] GoodsName { get; set; }
        public double GoodsPrice { get; set; }    

    }
}
