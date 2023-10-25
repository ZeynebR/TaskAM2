using Shoop.Core.Enums;
using Shoop.Core.Models;
using Shoop.Service.Extensions;
using Shoop.Service.Services.Interfaces;

namespace Shoop.Service.Services.Implementations
{
    public class ProductService : IProductService

    {
        Product[] products = { };
        public void CreateProduct()
        {
            Console.WriteLine("Please add product name");
            string Name=Console.ReadLine(); 
            Name= Name.ValidateString();    
            Console.WriteLine("Please add product price");
            double.TryParse(Console.ReadLine(), out double price);
            Console.WriteLine("Please choose product category");
            Console.WriteLine($"1. {CategoryType.Meat}");
            Console.WriteLine($"2. {CategoryType.Vegetables}");
            int.TryParse(Console.ReadLine(), out int categoryType);
            categoryType = categoryType.ValidateEnum();
            Console.WriteLine("Please add product stock count");
            int.TryParse(Console.ReadLine(), out int stockcount);
            Product product = new Product();
            product.Name = Name;
            product.Price=price;
            product.Category = (CategoryType)categoryType;
            product.StockCount = stockcount;
            Array.Resize(ref products, products.Length+1);
            products[products.Length-1] = product;
            Console.WriteLine("Product created");


        }

        public void ShowAllProducts()
        {
            foreach(Product product in products) 
            {
                Console.WriteLine(product);
            }

        }

        public void GetProductById()
        {
            Console.WriteLine("Please add Id");
            int id = int.Parse(Console.ReadLine());
            Product result=default;
            foreach (Product product in products)
            {
                if (product.Id == id)
                {
                    result = product;
                    break;
                }
                
            }

            if (result == null) 
            {
                Console.WriteLine($" Product with Id {id} is not found ");
            }
            else
                {
                Console.WriteLine( result);
            }
        }
    }
}
