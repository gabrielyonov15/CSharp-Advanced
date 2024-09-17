namespace _01.CountSameValuesInArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine()
                                              .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                                              .Select(double.Parse)
                                              .ToArray();
            Dictionary<double, int> occurrences = new Dictionary<double, int>();
            foreach (var number in numbers)
            {
                if (occurrences.ContainsKey(number))
                {
                    occurrences[number]++;
                }
                else
                {
                    occurrences[number] = 1;
                }
            }
            foreach (var kvp in occurrences)
            {
                Console.WriteLine($"{kvp.Key} - {kvp.Value} times");
            }
        }
    }
}