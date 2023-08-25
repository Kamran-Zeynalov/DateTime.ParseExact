using System.Globalization;

namespace Birthday
{
    internal class Program
    {
        static void Main(string[] args)
        {
        here:
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Enter your birtday");
            string? userBithday = Console.ReadLine();
            string date = "dd | MM | yyyy";
            try
            {
                var insert = DateTime.ParseExact(userBithday, date, null);
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e.Message);
                goto here;
            }


        }
    }
}