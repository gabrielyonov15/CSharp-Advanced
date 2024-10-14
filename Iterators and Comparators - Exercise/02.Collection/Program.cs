namespace _02.Collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListyIterator<string> iterator = null;
            string command;
            while ((command = Console.ReadLine()) != "END")
            {
                string[] parts = command.Split();
                switch (parts[0])
                {
                    case "Create":
                        if (parts.Length > 1)
                        {
                            iterator = new ListyIterator<string>(parts[1..]);
                        }
                        else
                        {
                            iterator = new ListyIterator<string>();
                        }
                        break;
                    case "Move":
                        Console.WriteLine(iterator.Move());
                        break;
                    case "HasNext":
                        Console.WriteLine(iterator.HasNext());
                        break;
                    case "Print":
                        try
                        {
                            iterator.Print();
                        }
                        catch (InvalidOperationException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                    case "PrintAll":
                        try
                        {
                            iterator.PrintAll();
                        }
                        catch (InvalidOperationException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                }
            }
        }
    }
}