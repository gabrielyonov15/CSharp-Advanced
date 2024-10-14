using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Collection
{
    public class ListyIterator<T> : IEnumerable<T>
    {
        private List<T> elements;
        private int currentIndex;
        public ListyIterator(params T[] elements)
        {
            this.elements = new List<T>(elements);
            this.currentIndex = 0;
        }
        public bool Move()
        {
            if (HasNext())
            {
                currentIndex++;
                return true;
            }
            return false;
        }
        public bool HasNext()
        {
            return currentIndex < elements.Count - 1;
        }
        public void Print()
        {
            if (elements.Count == 0)
            {
                throw new InvalidOperationException("Invalid Operation!");
            }
            Console.WriteLine(elements[currentIndex]);
        }
        public void PrintAll()
        {
            if (elements.Count == 0)
            {
                throw new InvalidOperationException("Invalid Operation!");
            }
            Console.WriteLine(string.Join(" ", elements));
        }
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < elements.Count; i++)
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