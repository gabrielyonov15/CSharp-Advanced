namespace _2.StackSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            string command;
            while ((command = Console.ReadLine().ToLower()) != "end")
            {
                string[] commandArgs = command.Split();
                if (commandArgs[0] == "add")
                {
                    int firstNumber = int.Parse(commandArgs[1]);
                    int secondNumber = int.Parse(commandArgs[2]);
                    stack.Push(firstNumber);
                    stack.Push(secondNumber);
                }
                else 
                if (commandArgs[0] == "remove")
                {
                    int count = int.Parse(commandArgs[1]);
                    if (stack.Count >= count)
                    {
                        for (int i = 0; i < count; i++)
                        {
                            stack.Pop();
                        }
                    }
                }
            }
            Console.WriteLine($"Sum: {stack.Sum()}");
        }
    }
}