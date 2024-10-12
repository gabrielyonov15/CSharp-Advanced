using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericBoxOfInteger
{
    public class Box<T>
    {
        private List<T> elements;
        public Box()
        {
            elements = new List<T>();
        }
        public void Add(T element)
        {
            elements.Add(element);
        }
        public override string ToString()
        {
            foreach (var element in elements)
            {
                Console.WriteLine($"{typeof(T)}: {element}");
            }
            return "";
        }
    }
}