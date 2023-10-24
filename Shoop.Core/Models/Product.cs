using Shoop.Core.Enums;

namespace Shoop.Core.Models
{
    public class Product
    {

        private static int _id;
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public CategoryType Category { get; set; }
        public int StockCount { get; set; }


        public Product()
        {
            _id++;
            Id = _id;
        }

        public override string ToString()
        {
            return $"Id: {Id} Name {Name} Price {Price} Category {Category} Stock Count: {StockCount}";
        }


    }


}
