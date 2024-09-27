namespace _02.SumNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                                  .Split(", ")
                                  .Select(int.Parse)
                                  .ToArray();
            int count = numbers.Length;
            int sum = numbers.Sum();
            Console.WriteLine(count);
            Console.WriteLine(sum);
        }
    }
}