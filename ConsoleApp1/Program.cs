using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string path = "Products.txt";
            using (StreamWriter sw = new StreamWriter(path))
            {
                string[] array = new string[5];
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = Console.ReadLine();
                    sw.WriteLine(array[i]);
                }                
            }                        
            Console.ReadKey();
        }
    }
}
