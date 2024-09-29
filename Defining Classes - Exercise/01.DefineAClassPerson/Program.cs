using System;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Person person1 = new Person("Peter", 20);
            Person person2 = new Person("George", 18);
            Person person3 = new Person("Jose", 43);
            Console.WriteLine($"Name: {person1.Name}, Age: {person1.Age}");
            Console.WriteLine($"Name: {person2.Name}, Age: {person2.Age}");
            Console.WriteLine($"Name: {person3.Name}, Age: {person3.Age}");
        }
    }
}