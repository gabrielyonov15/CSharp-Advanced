namespace _11.TriFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> names = Console.ReadLine().Split().ToList();
            string result = FindName(names, n, IsSumGreaterThanOrEqual);
            Console.WriteLine(result);
        }
        static string FindName(List<string> names, int n, Func<string, int, bool> criteria)
        {
            foreach (var name in names)
            {
                if (criteria(name, n))
                {
                    return name; 
                }
            }
            return null;
        }
        static bool IsSumGreaterThanOrEqual(string name, int n)
        {
            int sum = name.Sum(c => (int)c); 
            return sum >= n; 
        }
    }
}