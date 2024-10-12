namespace GenericBoxOfInteger
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Box<int> box = new Box<int>();  
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());  
                box.Add(number);  
            }
            Console.WriteLine(box.ToString());
        }
    }
}