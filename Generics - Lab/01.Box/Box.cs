using System;
using System.Collections.Generic;

namespace BoxOfT
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

        public T Remove()
        {
            if (elements.Count == 0)
            {
                throw new InvalidOperationException("Cannot remove from an empty box.");
            }
            T element = elements[elements.Count - 1];
            elements.RemoveAt(elements.Count - 1);
            return element;
        }
        public int Count
        {
            get { return elements.Count; }
        }
    }
}