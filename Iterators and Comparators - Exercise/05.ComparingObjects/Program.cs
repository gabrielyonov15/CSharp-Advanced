using System;

namespace _05.ComparingObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                string[] parts = input.Split();
                string name = parts[0];
                int age = int.Parse(parts[1]);
                string town = parts[2];
                people.Add(new Person(name, age, town));
            }
            int n = int.Parse(Console.ReadLine()) - 1; 
            Person personToCompare = people[n];
            int matches = 0;
            int nonMatches = 0;
            foreach (var person in people)
            {
                if (person.CompareTo(personToCompare) == 0)
                {
                    matches++;
                }
                else
                {
                    nonMatches++;
                }
            }
            if (matches > 1)
            {
                Console.WriteLine($"{matches} {nonMatches} {people.Count}");
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }
    }
}