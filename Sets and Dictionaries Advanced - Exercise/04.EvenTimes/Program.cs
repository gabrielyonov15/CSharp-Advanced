namespace _04.EvenTimes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<int, int> numberCounts = new Dictionary<int, int>();
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (numberCounts.ContainsKey(number))
                {
                    numberCounts[number]++; 
                }
                else
                {
                    numberCounts[number] = 1; 
                }
            }
            foreach (var kvp in numberCounts)
            {
                if (kvp.Value % 2 == 0)
                {
                    Console.WriteLine(kvp.Key);
                    break;
                }
            }
        }
    }
}