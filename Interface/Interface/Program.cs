using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eShop;

namespace Interface
{
    class Program
    {
        
        public class MyCollections
        {
            public delegate void Products(string name, int price);

            public void AddNewTshirts(string name, int price)
            {
                var tshirtsCollection = new List<TShirt>
                {
                    new TShirt(name, price) { Name = name, Price = price }
                };
            }
        }

        enum MyProducts
        {
            Tshirt = 1,
            Dress = 2,
            Rock = 3,
            Jeans = 4,
            Exit = 0
        }
        static void Main(string[] args)
        {
            int text;
            int priceOfProduct;

            do
            {
                Console.WriteLine("Please, pick any action from list below to add new product to the warehouse");
                Console.WriteLine("[1] - T-Shirt");
                Console.WriteLine("[2] - Dress");
                Console.WriteLine("[3] - Skirt");
                Console.WriteLine("[4] - Jeans");
                Console.WriteLine("[0] - Exit");
                Console.WriteLine();

                Int32.TryParse(Console.ReadLine(), out text);
                var text1 = (MyProducts)text;
                Console.WriteLine(text1);

                Console.WriteLine("Please, enter name of the " + text1 + ":");
                var nameOfProduct = Console.ReadLine();
                Console.WriteLine("Please, enter price for the " + nameOfProduct + ":");
                Int32.TryParse(Console.ReadLine(), out priceOfProduct);

                
                Console.ReadLine();
            }
            while (text != 0);

        }
    }
}
