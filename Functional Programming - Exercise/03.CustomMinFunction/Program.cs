namespace _03.CustomMinFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Func<int[], int> findMin = nums => nums.Min();
            Console.WriteLine(findMin(numbers));
        }
    }
}