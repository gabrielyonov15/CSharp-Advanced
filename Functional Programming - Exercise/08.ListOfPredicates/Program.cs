namespace _08.ListOfPredicates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int end = int.Parse(Console.ReadLine());
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Func<int[], int, IEnumerable<int>> divisibleNumbersByCollection = (numbers, end) =>
            {
                List<int> validNumbers = new List<int>();
                for (int i = 1; i <= end; i++)
                {
                    if (numbers.All(x => i % x == 0))
                    {
                        validNumbers.Add(i);
                    }
                }
                return validNumbers;
            };
            Console.WriteLine(string.Join(" ", divisibleNumbersByCollection(numbers, end)));
        }
    }
}