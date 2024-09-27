namespace _03.CountUppercaseWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine()
                                .Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Func<string, bool> isUppercase = word => char.IsUpper(word[0]);
            var uppercaseWords = words.Where(isUppercase);
            foreach (var word in uppercaseWords)
            {
                Console.WriteLine(word);
            }
        }
    }
}