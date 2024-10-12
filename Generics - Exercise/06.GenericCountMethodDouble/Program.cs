namespace GenericCountMethodDouble
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());  
            List<Box<double>> list = new List<Box<double>>();  
            for (int i = 0; i < n; i++)
            {
                double input = double.Parse(Console.ReadLine());  
                list.Add(new Box<double>(input));  
            }
            double elementToCompare = double.Parse(Console.ReadLine());  
            Box<double> comparisonBox = new Box<double>(elementToCompare);  
            int result = CountGreaterThan(list, comparisonBox);
            Console.WriteLine(result);
        }
        public static int CountGreaterThan<T>(List<Box<T>> list, Box<T> element)
            where T : IComparable<T>
        {
            int count = 0;
            foreach (var item in list)
            {
                if (item.CompareTo(element) > 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}