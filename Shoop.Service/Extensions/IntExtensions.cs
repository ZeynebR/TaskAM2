namespace Shoop.Service.Extensions
{
    public static class IntExtensions
    {
        public static int ValidateEnum(this int data)
        {
            while (data != 1 && data !=2) 
            {
                Console.WriteLine("Category type must be 1 or 2 ");
                int.TryParse(Console.ReadLine(), out data);
            }
            return data;
        }
    }
}
