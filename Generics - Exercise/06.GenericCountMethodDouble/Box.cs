using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCountMethodDouble
{
    public class Box<T> : IComparable<Box<T>>
    where T : IComparable<T>
    {
        private T value;
        public Box(T value)
        {
            this.value = value;
        }
        public override string ToString()
        {
            return $"{typeof(T)}: {value}";
        }
        public int CompareTo(Box<T> other)
        {
            return this.value.CompareTo(other.value);
        }
    }
}