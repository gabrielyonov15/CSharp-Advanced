namespace _08.Ranking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> contests = new Dictionary<string, string>();
            Dictionary<string, Dictionary<string, int>> userPoints = new Dictionary<string, Dictionary<string, int>>();
            string input;
            while ((input = Console.ReadLine()) != "end of contests")
            {
                string[] contestData = input.Split(':');
                string contestName = contestData[0];
                string contestPassword = contestData[1];
                if (!contests.ContainsKey(contestName))
                {
                    contests[contestName] = contestPassword;
                }
            }
            while ((input = Console.ReadLine()) != "end of submissions")
            {
                string[] submissionData = input.Split("=>");
                string contestName = submissionData[0];
                string contestPassword = submissionData[1];
                string username = submissionData[2];
                int points = int.Parse(submissionData[3]);
                if (contests.ContainsKey(contestName) && contests[contestName] == contestPassword)
                {
                    if (!userPoints.ContainsKey(username))
                    {
                        userPoints[username] = new Dictionary<string, int>();
                    }
                    if (!userPoints[username].ContainsKey(contestName) || userPoints[username][contestName] < points)
                    {
                        userPoints[username][contestName] = points;
                    }
                }
            }
            var bestUser = userPoints
                .Select(u => new { Username = u.Key, TotalPoints = u.Value.Values.Sum() })
                .OrderByDescending(u => u.TotalPoints)
                .First();
            Console.WriteLine($"Best candidate is {bestUser.Username} with total {bestUser.TotalPoints} points.");
            Console.WriteLine("Ranking:");
            foreach (var user in userPoints.OrderBy(u => u.Key))
            {
                Console.WriteLine(user.Key);
                foreach (var contest in user.Value.OrderByDescending(c => c.Value))
                {
                    Console.WriteLine($"#  {contest.Key} -> {contest.Value}");
                }
            }
        }
    }
}