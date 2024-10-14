using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.EqualityLogic
{
    public class Person : IComparable<Person>
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public override bool Equals(object obj)
        {
            if (obj == null || this.GetType() != obj.GetType())
            {
                return false;
            }
            Person other = (Person)obj;
            return this.Name == other.Name && this.Age == other.Age;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(this.Name, this.Age);
        }
        public int CompareTo(Person other)
        {
            int nameComparison = this.Name.CompareTo(other.Name);
            if (nameComparison == 0)
            {
                return this.Age.CompareTo(other.Age);
            }
            return nameComparison;
        }
    }
}