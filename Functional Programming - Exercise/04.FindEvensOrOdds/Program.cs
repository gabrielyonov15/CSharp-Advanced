namespace _04.FindEvensOrOdds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] bounds = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int lowerBound = bounds[0];
            int upperBound = bounds[1];
            string command = Console.ReadLine();
            Predicate<int> predicate;
            if (command == "even")
            {
                predicate = number => number % 2 == 0;
            }
            else 
            {
                predicate = number => number % 2 != 0;
            }
            List<int> result = new List<int>();
            for (int i = lowerBound; i <= upperBound; i++)
            {
                if (predicate(i))
                {
                    result.Add(i);
                }
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}