namespace _01.SortEvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                                  .Split(", ")
                                  .Select(int.Parse);
            var sortedEvens = numbers.Where(x => x % 2 == 0)
                                     .OrderBy(x => x)
                                     .ToArray();
            Console.WriteLine(string.Join(", ", sortedEvens));
        }
    }
}