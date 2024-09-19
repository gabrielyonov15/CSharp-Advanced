namespace _10.ForceBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> forceSides = new Dictionary<string, List<string>>();
            Dictionary<string, string> userSideMap = new Dictionary<string, string>();
            string input;
            while ((input = Console.ReadLine()) != "Lumpawaroo")
            {
                if (input.Contains(" | "))
                {
                    var parts = input.Split(" | ");
                    string forceSide = parts[0];
                    string forceUser = parts[1];
                    if (!userSideMap.ContainsKey(forceUser))
                    {
                        if (!forceSides.ContainsKey(forceSide))
                        {
                            forceSides[forceSide] = new List<string>();
                        }
                        forceSides[forceSide].Add(forceUser);
                        userSideMap[forceUser] = forceSide;
                    }
                }
                else 
                if (input.Contains(" -> "))
                {
                    var parts = input.Split(" -> ");
                    string forceUser = parts[0];
                    string forceSide = parts[1];
                    if (userSideMap.ContainsKey(forceUser))
                    {
                        string oldSide = userSideMap[forceUser];
                        forceSides[oldSide].Remove(forceUser);
                    }
                    if (!forceSides.ContainsKey(forceSide))
                    {
                        forceSides[forceSide] = new List<string>();
                    }
                    forceSides[forceSide].Add(forceUser);
                    userSideMap[forceUser] = forceSide;
                    Console.WriteLine($"{forceUser} joins the {forceSide} side!");
                }
            }
            foreach (var side in forceSides.Where(s => s.Value.Count > 0) .OrderByDescending(s => s.Value.Count) .ThenBy(s => s.Key)) 
            {
                Console.WriteLine($"Side: {side.Key}, Members: {side.Value.Count}");
                foreach (var user in side.Value.OrderBy(u => u)) 
                {
                    Console.WriteLine($"! {user}");
                }
            }
        }
    }
}