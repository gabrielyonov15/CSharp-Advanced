namespace _09.SoftUniExamResults
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> userScores = new Dictionary<string, int>();
            Dictionary<string, int> languageSubmissions = new Dictionary<string, int>();
            string input;
            while ((input = Console.ReadLine()) != "exam finished")
            {
                string[] parts = input.Split('-');
                if (parts[1] == "banned")
                {
                    string username = parts[0];
                    if (userScores.ContainsKey(username))
                    {
                        userScores.Remove(username);
                    }
                }
                else
                {
                    string username = parts[0];
                    string language = parts[1];
                    int points = int.Parse(parts[2]);
                    if (!languageSubmissions.ContainsKey(language))
                    {
                        languageSubmissions[language] = 0;
                    }
                    languageSubmissions[language]++;
                    if (!userScores.ContainsKey(username))
                    {
                        userScores[username] = points;
                    }
                    else 
                    if (userScores[username] < points)
                    {
                        userScores[username] = points;
                    }
                }
            }
            Console.WriteLine("Results:");
            foreach (var user in userScores.OrderByDescending(u => u.Value).ThenBy(u => u.Key))
            {
                Console.WriteLine($"{user.Key} | {user.Value}");
            }
            Console.WriteLine("Submissions:");
            foreach (var language in languageSubmissions.OrderByDescending(l => l.Value).ThenBy(l => l.Key))
            {
                Console.WriteLine($"{language.Key} - {language.Value}");
            }
        }
    }
}