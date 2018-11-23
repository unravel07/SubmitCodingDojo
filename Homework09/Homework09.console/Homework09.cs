using System.Collections.Generic;
using System.IO;
using Homework.ConsoleApp;

namespace Homework09.console
{
    public class Homework09 : IHomework09
    {
        private List<Product> cartList = new List<Product>();
        private string part = @"C:\Users\Mick\Desktop\homework\SubmitCodingDojo\Homework09\Homework09.console\Product.csv";
        public void AddProductToCart(IProduct product)
        {
            cartList.Add(new Product
            {
                SKU = product.SKU,
                Name = product.Name,
                Price = product.Price
            });

        }
        public IEnumerable<IProduct> GetAllProducts()
        {
            var productList = new List<Product>();
            using (var reader = new StreamReader(part))
            {
                while (!reader.EndOfStream)
                {
                    var getReadCsv = reader.ReadLine();
                    var dataList = getReadCsv.Split(',');

                    var aProduct = new Product();
                    aProduct.SKU = dataList[0];
                    aProduct.Name = dataList[1];
                    aProduct.Price = double.Parse(dataList[2]);

                    productList.Add(aProduct);
                }
            }
            return productList;
        }

        public IEnumerable<IProduct> GetProductsInCart()
        {
            return cartList;
        }
        
    }
}