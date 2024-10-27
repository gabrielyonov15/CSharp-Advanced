namespace _01.BallGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var strengths = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var accuracies = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int totalGoals = 0;
            while (strengths.Count > 0 && accuracies.Count > 0)
            {
                int strength = strengths.Last();
                int accuracy = accuracies.First();
                int sum = strength + accuracy;
                if (sum == 100) 
                {
                    totalGoals++;
                    strengths.RemoveAt(strengths.Count - 1); 
                    accuracies.RemoveAt(0); 
                }
                else
                if (sum < 100) 
                {
                    if (strength < accuracy) 
                    {
                        strengths.RemoveAt(strengths.Count - 1); 
                    }
                    else 
                    if (strength > accuracy) 
                    {
                        accuracies.RemoveAt(0); 
                    }
                    else 
                    {
                        strengths[strengths.Count - 1] = strength + accuracy;
                        accuracies.RemoveAt(0);
                    }
                }
                else 
                {
                    strengths[strengths.Count - 1] -= 10; 
                    accuracies.Add(accuracies[0]);
                    accuracies.RemoveAt(0);
                }
            }
            if (totalGoals == 3)
            {
                Console.WriteLine("Paul scored a hat-trick!");
            }
            else 
            if (totalGoals == 0)
            {
                Console.WriteLine("Paul failed to score a single goal.");
            }
            else 
            if (totalGoals > 3)
            {
                Console.WriteLine("Paul performed remarkably well!");
            }
            else
            {
                Console.WriteLine("Paul failed to make a hat-trick.");
            }
            if (totalGoals > 0)
            {
                Console.WriteLine($"Goals scored: {totalGoals}");
            }
            if (strengths.Count > 0)
            {
                strengths.Reverse();
                Console.WriteLine($"Strength values left: {string.Join(", ", strengths)}");
            }
            if (accuracies.Count > 0)
            {
                Console.WriteLine($"Accuracy values left: {string.Join(", ", accuracies)}");
            }
        }
    }
}