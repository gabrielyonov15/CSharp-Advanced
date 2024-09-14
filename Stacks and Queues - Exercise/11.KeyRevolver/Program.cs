namespace _11.KeyRevolver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bulletPrice = int.Parse(Console.ReadLine());  
            int barrelSize = int.Parse(Console.ReadLine());  
            Stack<int> bullets = new Stack<int>(Array.ConvertAll(Console.ReadLine().Split(), int.Parse)); 
            Queue<int> locks = new Queue<int>(Array.ConvertAll(Console.ReadLine().Split(), int.Parse));  
            int intelligenceValue = int.Parse(Console.ReadLine());
            int bulletsUsed = 0;  
            int currentBarrel = barrelSize;  
            while (locks.Count > 0 && bullets.Count > 0)
            {
                int currentBullet = bullets.Pop();  
                int currentLock = locks.Peek();    
                bulletsUsed++;  
                currentBarrel--; 
                if (currentBullet <= currentLock)
                {
                    Console.WriteLine("Bang!");
                    locks.Dequeue();  
                }
                else
                {
                    Console.WriteLine("Ping!");
                }
                if (currentBarrel == 0 && bullets.Count > 0)
                {
                    Console.WriteLine("Reloading!");
                    currentBarrel = barrelSize;  
                }
            }
            if (locks.Count == 0)
            {
                int moneyEarned = intelligenceValue - (bulletsUsed * bulletPrice);
                Console.WriteLine($"{bullets.Count} bullets left. Earned ${moneyEarned}");
            }
            else
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
            }
        }
    }
}