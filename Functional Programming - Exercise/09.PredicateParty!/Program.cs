using System.Linq;

namespace _09.PredicateParty_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> guests = Console.ReadLine().Split().ToList();
            string command;
            while ((command = Console.ReadLine()) != "Party!")
            {
                ProcessCommand(guests, command);
            }
            PrintGuests(guests);
        }
        static void ProcessCommand(List<string> guests, string command)
        {
            string[] parts = command.Split();
            string action = parts[0];
            string criteria = parts[1];
            if (action == "Remove")
            {
                RemoveGuests(guests, criteria, parts);
            }
            else 
            if (action == "Double")
            {
                DoubleGuests(guests, criteria, parts);
            }
        }
        static void RemoveGuests(List<string> guests, string criteria, string[] parts)
        {
            Func<string, bool> filter;
            if (criteria == "StartsWith")
            {
                string prefix = parts[2];
                filter = name => name.StartsWith(prefix);
            }
            else 
            if (criteria == "EndsWith")
            {
                string suffix = parts[2];
                filter = name => name.EndsWith(suffix);
            }
            else 
            {
                int length = int.Parse(parts[2]);
                filter = name => name.Length == length;
            }
            guests.RemoveAll(new Predicate<string>(filter));
        }
        static void DoubleGuests(List<string> guests, string criteria, string[] parts)
        {
            List<string> toAdd = new List<string>();
            Func<string, bool> filter;
            if (criteria == "StartsWith")
            {
                string prefix = parts[2];
                filter = name => name.StartsWith(prefix);
            }
            else 
            if (criteria == "EndsWith")
            {
                string suffix = parts[2];
                filter = name => name.EndsWith(suffix);
            }
            else 
            {
                int length = int.Parse(parts[2]);
                filter = name => name.Length == length;
            }
            foreach (var guest in guests.Where(filter))
            {
                toAdd.Add(guest);
            }
            guests.AddRange(toAdd);
        }
        static void PrintGuests(List<string> guests)
        {
            if (guests.Count == 0)
            {
                Console.WriteLine("Nobody is going to the party!");
            }
            else
            {
                Console.WriteLine($"{string.Join(", ", guests)} are going to the party!");
            }
        }
    }
}