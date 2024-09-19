namespace _07.TheV_Logger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, HashSet<string>> followers = new Dictionary<string, HashSet<string>>();
            Dictionary<string, int> followingCount = new Dictionary<string, int>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Statistics")
                {
                    break;
                }
                string[] parts = input.Split(' ');
                if (parts[1] == "joined")
                {
                    string vloggerName = parts[0];
                    if (!followers.ContainsKey(vloggerName))
                    {
                        followers[vloggerName] = new HashSet<string>();
                        followingCount[vloggerName] = 0;
                    }
                }
                else
                if (parts[1] == "followed")
                {
                    string follower = parts[0];
                    string followed = parts[2];
                    if (followers.ContainsKey(follower) && followers.ContainsKey(followed) && follower != followed)
                    {
                        if (!followers[followed].Contains(follower))
                        {
                            followers[followed].Add(follower);
                            followingCount[follower]++;
                        }
                    }
                }
            }
            Console.WriteLine($"The V-Logger has a total of {followers.Count} vloggers in its logs.");
            var sortedVloggers = followers
                .OrderByDescending(v => v.Value.Count)
                .ThenBy(v => followingCount[v.Key])
                .ToList();
            var mostFamous = sortedVloggers[0];
            Console.WriteLine($"1. {mostFamous.Key} : {mostFamous.Value.Count} followers, {followingCount[mostFamous.Key]} following");
            foreach (var follower in mostFamous.Value.OrderBy(f => f))
            {
                Console.WriteLine($"*  {follower}");
            }
            for (int i = 1; i < sortedVloggers.Count; i++)
            {
                var vlogger = sortedVloggers[i];
                Console.WriteLine($"{i + 1}. {vlogger.Key} : {vlogger.Value.Count} followers, {followingCount[vlogger.Key]} following");
            }
        }
    }
}