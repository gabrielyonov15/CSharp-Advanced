namespace _05.CountSymbols
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<char, int> charCounts = new Dictionary<char, int>();
            foreach (char character in input)
            {
                if (charCounts.ContainsKey(character))
                {
                    charCounts[character]++; 
                }
                else
                {
                    charCounts[character] = 1; 
                }
            }
            foreach (var kvp in charCounts.OrderBy(c => c.Key))
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value} time/s");
            }
        }
    }
}