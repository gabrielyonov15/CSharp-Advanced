namespace _04.AddVAT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var prices = Console.ReadLine()
                                 .Split(", ")
                                 .Select(double.Parse);
            var pricesWithVAT = prices.Select(price => price * 1.20);
            foreach (var price in pricesWithVAT)
            {
                Console.WriteLine($"{price:F2}");
            }
        }
    }
}