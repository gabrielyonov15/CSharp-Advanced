using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Stack
{
    public class CustomStack<T> : IEnumerable<T>
    {
        private List<T> elements;
        public CustomStack()
        {
            this.elements = new List<T>();
        }
        public void Push(params T[] items)
        {
            foreach (var item in items)
            {
                elements.Add(item);
            }
        }
        public void Pop()
        {
            if (elements.Count == 0)
            {
                Console.WriteLine("No elements");
            }
            else
            {
                elements.RemoveAt(elements.Count - 1);
            }
        }
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = elements.Count - 1; i >= 0; i--)
            {
                yield return elements[i];
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}