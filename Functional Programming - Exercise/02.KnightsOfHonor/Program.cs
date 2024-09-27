namespace _02.KnightsOfHonor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(' ');
            Action<string[]> printSirNames = namesCollection =>
            {
                foreach (var name in namesCollection)
                {
                    Console.WriteLine($"Sir {name}");
                }
            };
            printSirNames(names);
        }
    }
}