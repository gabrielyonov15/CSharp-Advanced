using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorsAndComparators
{
    public class Library : IEnumerable<Book>
    {
        private List<Book> books;
        public Library(params Book[] books)
        {
            this.books = new List<Book>(books);
            this.books.Sort(); 
        }
        public IEnumerator<Book> GetEnumerator()
        {
            return new LibraryIterator(this.books);
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
        private class LibraryIterator : IEnumerator<Book>
        {
            private List<Book> books;
            private int currentIndex;
            public LibraryIterator(List<Book> books)
            {
                this.books = books;
                this.currentIndex = -1;
            }
            public Book Current
            {
                get
                {
                    if (currentIndex < 0 || currentIndex >= books.Count)
                    {
                        throw new InvalidOperationException();
                    }
                    return books[currentIndex];
                }
            }
            object IEnumerator.Current => this.Current;
            public bool MoveNext()
            {
                return ++currentIndex < books.Count;
            }
            public void Reset()
            {
                currentIndex = -1;
            }
            public void Dispose() { }
        }
    }
}