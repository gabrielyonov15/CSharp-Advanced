namespace _02.BasicQueueOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int N = input[0];
            int S = input[1];
            int X = input[2];
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>();
            for (int i = 0; i < N; i++)
            {
                queue.Enqueue(numbers[i]);
            }
            for (int i = 0; i < S; i++)
            {
                if (queue.Count > 0)
                {
                    queue.Dequeue();
                }
            }
            if (queue.Contains(X))
            {
                Console.WriteLine("true");
            }
            else
            {
                if (queue.Count > 0)
                {
                    Console.WriteLine(queue.Min());
                }
                else
                {
                    Console.WriteLine(0);
                }
            }
        }
    }
}