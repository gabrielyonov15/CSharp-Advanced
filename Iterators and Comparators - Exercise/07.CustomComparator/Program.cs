namespace _07.CustomComparator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            Array.Sort(numbers, Compare);
            Console.WriteLine(string.Join(" ", numbers));
        }
        public static int Compare(int x, int y)
        {
            if (x % 2 == 0 && y % 2 != 0)
            {
                return -1;
            }
            else
            if (x % 2 != 0 && y % 2 == 0)
            {
                return 1;
            }
            else
            {
                return x.CompareTo(y);
            }
        }
    }
}