namespace _02.SetsOfElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(input[0]);
            int m = int.Parse(input[1]);
            HashSet<int> firstSet = new HashSet<int>();
            HashSet<int> secondSet = new HashSet<int>();
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                firstSet.Add(number);
            }
            for (int i = 0; i < m; i++)
            {
                int number = int.Parse(Console.ReadLine());
                secondSet.Add(number);
            }
            List<int> commonElements = new List<int>();
            foreach (int number in firstSet)
            {
                if (secondSet.Contains(number))
                {
                    commonElements.Add(number); 
                }
            }
            Console.WriteLine(string.Join(" ", commonElements));
        }
    }
}