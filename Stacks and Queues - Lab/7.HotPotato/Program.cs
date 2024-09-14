namespace _7.HotPotato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> children = new Queue<string>(Console.ReadLine().Split());
            int n = int.Parse(Console.ReadLine());
            while (children.Count > 1)
            {
                for (int i = 1; i < n; i++)
                {
                    string currentChild = children.Dequeue(); 
                    children.Enqueue(currentChild);          
                }
                Console.WriteLine($"Removed {children.Dequeue()}");
            }
            Console.WriteLine($"Last is {children.Dequeue()}");
        }
    }
}