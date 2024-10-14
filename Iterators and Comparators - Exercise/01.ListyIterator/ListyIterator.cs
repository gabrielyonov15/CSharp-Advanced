using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ListyIterator
{
    public class ListyIterator<T>
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
    }
}