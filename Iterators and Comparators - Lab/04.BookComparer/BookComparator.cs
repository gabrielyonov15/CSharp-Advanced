using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorsAndComparators
{
    public class BookComparator : IComparer<Book>
    {
        public int Compare(Book x, Book y)
        {
            int titleComparison = x.Title.CompareTo(y.Title);
            if (titleComparison != 0)
            {
                return titleComparison;
            }
            return y.Year.CompareTo(x.Year);
        }
    }
}