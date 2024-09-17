namespace _06.RecordUniqueNames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var uniqueNames = new HashSet<string>();
            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                uniqueNames.Add(name);
            }
            foreach (var name in uniqueNames)
            {
                Console.WriteLine(name);
            }
        }
    }
}