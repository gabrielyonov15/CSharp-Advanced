namespace _10.Crossroads
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int greenLightDuration = int.Parse(Console.ReadLine());
            int freeWindowDuration = int.Parse(Console.ReadLine());
            Queue<string> carsQueue = new Queue<string>();
            int totalCarsPassed = 0;
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "END")
                {
                    Console.WriteLine("Everyone is safe.");
                    Console.WriteLine($"{totalCarsPassed} total cars passed the crossroads.");
                    break;
                }
                if (input == "green")
                {
                    int currentGreenTime = greenLightDuration;
                    while (carsQueue.Count > 0 && currentGreenTime > 0)
                    {
                        string currentCar = carsQueue.Dequeue();
                        if (currentCar.Length <= currentGreenTime)
                        {
                            currentGreenTime -= currentCar.Length;
                            totalCarsPassed++;
                        }
                        else
                        {
                            int remainingTime = currentGreenTime;
                            int remainingLength = currentCar.Length - remainingTime;
                            if (remainingLength <= freeWindowDuration)
                            {
                                totalCarsPassed++;
                            }
                            else
                            {
                                char hitChar = currentCar[remainingTime + freeWindowDuration];
                                Console.WriteLine("A crash happened!");
                                Console.WriteLine($"{currentCar} was hit at {hitChar}.");
                                return;
                            }
                            break;
                        }
                    }
                }
                else
                {
                    carsQueue.Enqueue(input);
                }
            }
        }
    }
}