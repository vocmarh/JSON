using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace JSON
{
    class Program
    {
        static void Main(string[] args)
        {
            string jsonString = "{\"goodsItem\":100,\"goodsName\":[\"Orange\", \"Apple\", \"Banana\", \"Ice cream\", \"Butter\"],\"goodsPrice\":100.20}";
            Goods goods = JsonSerializer.Deserialize<Goods>(jsonString);
            Goods goods1 = new Goods();
            {
                goodsItem = 100,
                goodsName = ""
            }
        }
    }
    class Goods
    {
        public int GoodsItem { get; set; }
        public string[] GoodsName { get; set; }
        public double GoodsPrice { get; set; }

    }
}
