namespace _04.FastFood
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int foodQuantity = int.Parse(Console.ReadLine());
            Queue<int> orders = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            Console.WriteLine(orders.Max());
            while (orders.Count > 0)
            {
                int currentOrder = orders.Peek();
                if (foodQuantity >= currentOrder)
                {
                    foodQuantity -= currentOrder;
                    orders.Dequeue(); 
                }
                else
                {
                    Console.WriteLine($"Orders left: {string.Join(" ", orders)}");
                    return;
                }
            }
            Console.WriteLine("Orders complete");
        }
    }
}