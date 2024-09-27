namespace _05.FilterByAge
{
    internal class Program
    {
        public class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Person> people = ReadPeople(n);
            string condition = Console.ReadLine();
            int ageThreshold = int.Parse(Console.ReadLine());
            string format = Console.ReadLine();
            Func<Person, bool> filter = CreateFilter(condition, ageThreshold);
            Action<Person> printer = CreatePrinter(format);
            PrintFilteredPeople(people, filter, printer);
        }
        static List<Person> ReadPeople(int n)
        {
            List<Person> people = new List<Person>();
            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split(", ");
                string name = tokens[0];
                int age = int.Parse(tokens[1]);
                people.Add(new Person { Name = name, Age = age });
            }
            return people;
        }
        static Func<Person, bool> CreateFilter(string condition, int ageThreshold)
        {
            if (condition == "younger")
            {
                return person => person.Age < ageThreshold;
            }
            else
            if (condition == "older")
            {
                return person => person.Age >= ageThreshold;
            }
            return null;
        }
        static Action<Person> CreatePrinter(string format)
        {
            if (format == "name")
            {
                return person => Console.WriteLine(person.Name);
            }
            else 
            if (format == "age")
            {
                return person => Console.WriteLine(person.Age);
            }
            else 
            if (format == "name age")
            {
                return person => Console.WriteLine($"{person.Name} - {person.Age}");
            }
            return null;
        }
        static void PrintFilteredPeople(List<Person> people, Func<Person, bool> filter, Action<Person> printer)
        {
            foreach (var person in people)
            {
                if (filter(person))
                {
                    printer(person);
                }
            }
        }
    }
}