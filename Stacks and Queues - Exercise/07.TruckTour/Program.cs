namespace _07.TruckTour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Queue<(int petrol, int distance)> pumps = new Queue<(int petrol, int distance)>();
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();
                int petrol = int.Parse(input[0]);   
                int distance = int.Parse(input[1]);  
                pumps.Enqueue((petrol, distance));
            }
            int startIndex = 0; 
            int totalFuel = 0;   
            int currentFuel = 0; 
            for (int i = 0; i < n; i++)
            {
                var currentPump = pumps.Dequeue();
                int petrol = currentPump.petrol;  
                int distance = currentPump.distance; 
                totalFuel += petrol - distance;
                if (totalFuel < 0)
                {
                    startIndex = i + 1; 
                    totalFuel = 0;       
                }
                pumps.Enqueue(currentPump);
            }
            Console.WriteLine(startIndex);
        }
    }
}