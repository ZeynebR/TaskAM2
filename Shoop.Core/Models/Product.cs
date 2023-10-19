namespace Shoop.Core.Models
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Category { get; set; }
        public int StockCount { get; set; }

        public Product(string name, double price, string category, int stockcount)
        {
            this.Name = name;
            this.Price = price;
            this.Category = category;
            this.StockCount = stockcount;
        }



        public string GetFullInfo()
        {
            return $"Name: {Name} Price: {Price} Category {Category} StockCount {StockCount}";
        }
    }


}
