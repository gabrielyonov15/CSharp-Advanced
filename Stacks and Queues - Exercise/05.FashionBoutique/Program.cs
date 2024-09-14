namespace _05.FashionBoutique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> clothes = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            int rackCapacity = int.Parse(Console.ReadLine());
            int racksUsed = 1; 
            int currentRackCapacity = rackCapacity;
            while (clothes.Count > 0)
            {
                int currentClothing = clothes.Pop();
                if (currentClothing <= currentRackCapacity)
                {
                    currentRackCapacity -= currentClothing;
                }
                else
                {
                    racksUsed++;
                    currentRackCapacity = rackCapacity - currentClothing;
                }
            }
            Console.WriteLine(racksUsed);
        }
    }
}