using System;
using System.Collections.Generic;
using System.Linq;

namespace Homework09.console
{
    class Program
    {
        static void Main(string[] args)
        {
            var hw9 = new Homework09();
            var getAllProducts = hw9.GetAllProducts();
            var productInCart = new List<IProduct>();
            var balance = 0.00;
            var start = "start";
            // var key = "start";
            do
            {
                Console.WriteLine("Products in your cart are");
                productInCart = hw9.GetProductsInCart().ToList();

                if (productInCart.Any())
                {
                    for (int i = 0; i < productInCart.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}.{productInCart[i].Name}\t{productInCart[i].Price,2:N}");
                    }
                }
                else { Console.WriteLine("none"); }

                Console.WriteLine("---");
                Console.WriteLine($"Total amount: {balance,2:N} baht");
                Console.Write("Please input a product key: ");

                start = Console.ReadLine();

                if (getAllProducts.Any(it => it.SKU == start))
                {
                    var product = getAllProducts.FirstOrDefault(it => it.SKU == start);
                    hw9.AddProductToCart(product);
                    balance += product.Price;
                }
                else if (string.IsNullOrEmpty(start))
                {
                    Console.WriteLine("Thank you.");
                }
                else
                {
                    Console.WriteLine("This product is not exist.");
                }

            }
            while (!string.IsNullOrEmpty(start));



        }
    }
}
// foreach (var listP in getAllProducts)
// {
//     Console.WriteLine($"{listP.SKU} , {listP.Name} , {listP.Price,2:N}");
// }
// Console.WriteLine(new string('=', 30));
// hw9.setDefaultCart();