namespace GenericCountMethodString
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());  
            List<Box<string>> list = new List<Box<string>>();  
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();  
                list.Add(new Box<string>(input)); 
            }
            string elementToCompare = Console.ReadLine();  
            Box<string> comparisonBox = new Box<string>(elementToCompare);  
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