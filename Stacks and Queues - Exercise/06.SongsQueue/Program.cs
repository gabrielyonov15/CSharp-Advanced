namespace _06.SongsQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> songs = new Queue<string>(Console.ReadLine().Split(", "));
            while (songs.Count > 0)
            {
                string command = Console.ReadLine();
                if (command == "Play")
                {
                    songs.Dequeue();
                }
                else
                if (command.StartsWith("Add"))
                {
                    string songToAdd = command.Substring(4);
                    if (songs.Contains(songToAdd))
                    {
                        Console.WriteLine($"{songToAdd} is already contained!");
                    }
                    else
                    {
                        songs.Enqueue(songToAdd);
                    }
                }
                else 
                if (command == "Show")
                {
                    Console.WriteLine(string.Join(", ", songs));
                }
            }
            Console.WriteLine("No more songs!");
        }
    }
}