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
            Console.WriteLine("Введите данные первого товара: Артикул, Название, Стоимость");
            Apple apple = new Apple()
            {                
                GoodsItem = Convert.ToInt32(Console.ReadLine()),
                GoodsName = Console.ReadLine(),
                GoodsPrice = Convert.ToDouble(Console.ReadLine()),
            };
            Console.WriteLine("Введите данные второго товара: Артикул, Название, Стоимость");
            Banana banana = new Banana()
            {
                GoodsItem = Convert.ToInt32(Console.ReadLine()),
                GoodsName = Console.ReadLine(),
                GoodsPrice = Convert.ToDouble(Console.ReadLine()),
            };
            Console.WriteLine("Введите данные третьего товара: Артикул, Название, Стоимость");            
            Orange orange = new Orange()
            {
                GoodsItem = Convert.ToInt32(Console.ReadLine()),
                GoodsName = Console.ReadLine(),
                GoodsPrice = Convert.ToDouble(Console.ReadLine()),
            };
            Console.WriteLine("Введите данные четвертого товара: Артикул, Название, Стоимость");
            Tomato tomato = new Tomato()
            {
                GoodsItem = Convert.ToInt32(Console.ReadLine()),
                GoodsName = Console.ReadLine(),
                GoodsPrice = Convert.ToDouble(Console.ReadLine()),
            };
            Console.WriteLine("Введите данные пятого товара: Артикул, Название, Стоимость");
            Mellow mellow = new Mellow()
            {
                GoodsItem = Convert.ToInt32(Console.ReadLine()),
                GoodsName = Console.ReadLine(),
                GoodsPrice = Convert.ToDouble(Console.ReadLine()),
            };

            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
                WriteIndented = true,
            };
            string jsonString1 = JsonSerializer.Serialize(apple, options);
            string jsonString2 = JsonSerializer.Serialize(banana, options);
            string jsonString3 = JsonSerializer.Serialize(orange, options);
            string jsonString4 = JsonSerializer.Serialize(tomato, options);
            string jsonString5 = JsonSerializer.Serialize(mellow, options);
            Console.WriteLine(jsonString1, jsonString2, jsonString3, jsonString4, jsonString5);

            string path = "Products.json";
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine(jsonString1, jsonString2, jsonString3, jsonString4, jsonString5);
            }
            Console.ReadKey();
        }
    }
    class Apple
    {
        public int GoodsItem { get; set; }
        public string GoodsName { get; set; }
        public double GoodsPrice { get; set; }
    }
    class Banana
    {
        public int GoodsItem { get; set; }
        public string GoodsName { get; set; }
        public double GoodsPrice { get; set; }
    }
    class Orange
    {
        public int GoodsItem { get; set; }
        public string GoodsName { get; set; }
        public double GoodsPrice { get; set; }
    }
    class Tomato
    {
        public int GoodsItem { get; set; }
        public string GoodsName { get; set; }
        public double GoodsPrice { get; set; }
    }
    class Mellow
    {
        public int GoodsItem { get; set; }
        public string GoodsName { get; set; }
        public double GoodsPrice { get; set; }
    }
}
