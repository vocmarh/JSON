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
            //Сериализация метода
            Goods goods = new Goods() 
            { 
                GoodsItem = new int[] {Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()) }, 
                GoodsName = new string[] {Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), Console.ReadLine()}, 
                GoodsPrice = new double[] {Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine())} 
            };
            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
                WriteIndented = true,                
            };
            string jsonString = JsonSerializer.Serialize(goods, options);
            Console.WriteLine(jsonString);

            string path = "Products.json";
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine(jsonString);                
            }

            //Десериализуем Product.json
            string jsonString1 = File.ReadAllText("Products.json");
            Goods goods1 = JsonSerializer.Deserialize<Goods>(jsonString1);                      

            //Определение самой дорогой стоимости в массиве
            double maxGoodsPrice = goods.GoodsPrice.Max();
            int maxIndex = Array.IndexOf(goods.GoodsPrice, maxGoodsPrice);
            

            string a = goods.GoodsName[maxIndex];
            Console.WriteLine("Название самого дорогого товара: {0}", a);

            
            Console.ReadKey();
        }
    }
    class Goods
    {
        public int[] GoodsItem { get; set; }
        public string[] GoodsName { get; set; }
        public double[] GoodsPrice { get; set; }    

    }
}
