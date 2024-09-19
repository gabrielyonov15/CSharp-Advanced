namespace _06.Wardrobe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" -> ");
                string color = input[0];
                string[] clothes = input[1].Split(',');
                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe[color] = new Dictionary<string, int>();
                }
                foreach (string cloth in clothes)
                {
                    if (!wardrobe[color].ContainsKey(cloth))
                    {
                        wardrobe[color][cloth] = 0;
                    }
                    wardrobe[color][cloth]++;
                }
            }
            string[] searchInput = Console.ReadLine().Split();
            string searchColor = searchInput[0];
            string searchClothing = searchInput[1];
            foreach (var colorEntry in wardrobe)
            {
                Console.WriteLine($"{colorEntry.Key} clothes:");

                foreach (var clothEntry in colorEntry.Value)
                {
                    if (colorEntry.Key == searchColor && clothEntry.Key == searchClothing)
                    {
                        Console.WriteLine($"* {clothEntry.Key} - {clothEntry.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {clothEntry.Key} - {clothEntry.Value}");
                    }
                }
            }
        }
    }
}