namespace _01.ActionPrint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(' ');
            Action<string[]> printNames = namesCollection =>
            {
                foreach (var name in namesCollection)
                {
                    Console.WriteLine(name);
                }
            };
            printNames(names);
        }
    }
}