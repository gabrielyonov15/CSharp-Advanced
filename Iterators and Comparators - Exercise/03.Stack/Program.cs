namespace _03.Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomStack<int> stack = new CustomStack<int>();
            string command;
            while ((command = Console.ReadLine()) != "END")
            {
                string[] parts = command.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
                switch (parts[0])
                {
                    case "Push":
                        int[] elements = Array.ConvertAll(parts[1..], int.Parse);
                        stack.Push(elements);
                        break;
                    case "Pop":
                        stack.Pop();
                        break;
                }
            }
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}