namespace _07.PredicateForNames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> names = Console.ReadLine().Split().ToList();
            Predicate<string> isShorterOrEqual = name => name.Length <= n;
            foreach (var name in names.Where(name => isShorterOrEqual(name)))
            {
                Console.WriteLine(name);
            }
        }
    }
}