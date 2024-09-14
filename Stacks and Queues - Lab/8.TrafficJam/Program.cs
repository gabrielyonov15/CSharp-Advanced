namespace _8.TrafficJam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Queue<string> carsQueue = new Queue<string>();
            int totalCarsPassed = 0;
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "end")
                {
                    Console.WriteLine($"{totalCarsPassed} cars passed the crossroads.");
                    break;
                }
                else 
                if (command == "green")
                {
                    for (int i = 0; i < n && carsQueue.Count > 0; i++)
                    {
                        string car = carsQueue.Dequeue();
                        Console.WriteLine($"{car} passed!");
                        totalCarsPassed++; 
                    }
                }
                else
                {
                    carsQueue.Enqueue(command);
                }
            }
        }
    }
}
