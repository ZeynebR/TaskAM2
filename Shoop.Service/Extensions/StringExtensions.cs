namespace Shoop.Service.Extensions
{
    public static class StringExtensions
    {
        public static string ValidateString(this string data)
        {
            while(string.IsNullOrWhiteSpace(data)) 
            {
                Console.WriteLine("Please add valid data");
                data = Console.ReadLine();   
            }
            return data;    
        }
    }
}
