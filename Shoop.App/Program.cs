//using Shoop.Core.Models;
//using System.ComponentModel.DataAnnotations;

//Product[] products = { };

//Console.WriteLine("1. Create product");
//Console.WriteLine("2. Show products");
//Console.WriteLine("0. Close");
//string request = Console.ReadLine();

//while (request != "0")
//{
//    switch (request)
//    {
//        case "1":
//            CreateProduct();
//            break;

//        case "2":
//            ShowProduct();
//            break;

//        default:
//            Console.WriteLine("Please add valid option");
//            break;
//    }

//    Console.WriteLine("1. Create product");
//    Console.WriteLine("2. Show products");
//    Console.WriteLine("0. Close");
//    request = Console.ReadLine();

//}

//void CreateProduct()
//{
//    Console.WriteLine("Please enter product name");
//    string Name = ValidateString(Console.ReadLine());
//    Console.WriteLine("Please enter product price");
//    double Price = double.Parse(Console.ReadLine());
//    Console.WriteLine("Please enter product category");
//    string Category = ValidateString(Console.ReadLine());
//    Console.WriteLine("Please enter product stock count");
//    int Stockcount = int.Parse(Console.ReadLine());

//    Product product = new Product(Name, Price, Category, Stockcount);
//    Array.Resize(ref products, products.Length + 1);
//    products[products.Length - 1] = product;

//    Console.WriteLine("Product created");

//}

//void ShowProduct()
//{
//    foreach (Product product in products)
//    {
//        Console.WriteLine(product.GetFullInfo());

//    }
//}

//string ValidateString(string data)
//{
//    while (string.IsNullOrWhiteSpace(data))
//    {
//        Console.WriteLine("Please enter a valid value");
//        data = Console.ReadLine();
//    }
//    return data;
//}

using Shoop.Service.Services.Implementations;

ProductService productService = new ProductService();

ShowMenu();
string request = Console.ReadLine();

while (request != "0")
{
    switch (request)
    {
        case "1":
            productService.CreateProduct();
            break;

        case "2":
            productService.ShowAllProducts();   
            break;
        case "3":
            productService.GetProductById();
            break;
        default:
            Console.WriteLine("Please add valid option");
            break;
    }
    ShowMenu();
    request = Console.ReadLine();
}


void ShowMenu()
{
    Console.WriteLine("1. Create product");
    Console.WriteLine("2. Show all products");
    Console.WriteLine("3. Show product by Id");
    Console.WriteLine("0. Close");
}





