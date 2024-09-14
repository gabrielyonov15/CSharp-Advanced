namespace _5.PrintEvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>(numbers);
            List<int> evenNumbers = new List<int>();
            while (queue.Count > 0)
            {
                int currentNumber = queue.Dequeue(); 
                if (currentNumber % 2 == 0)
                {
                    evenNumbers.Add(currentNumber); 
                }
            }
            Console.WriteLine(string.Join(", ", evenNumbers));
        }
    }
}