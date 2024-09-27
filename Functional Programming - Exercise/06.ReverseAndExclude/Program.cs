namespace _06.ReverseAndExclude
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int n = int.Parse(Console.ReadLine());
            Predicate<int> isDivisibleByN = num => num % n == 0;
            List<int> filteredNumbers = numbers.Where(num => !isDivisibleByN(num)).ToList();
            filteredNumbers.Reverse();
            Console.WriteLine(string.Join(" ", filteredNumbers));
        }
    }
}