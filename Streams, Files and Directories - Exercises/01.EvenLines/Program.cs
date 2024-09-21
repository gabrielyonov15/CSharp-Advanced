namespace EvenLines
{
    using System;
    public class EvenLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";

            Console.WriteLine(ProcessLines(inputFilePath));
        }
        public static string ProcessLines(string inputFilePath)
        {
            string result = "";
            int lineNumber = 0;
            using (StreamReader reader = new StreamReader(inputFilePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (lineNumber % 2 == 0)
                    {
                        line = line.Replace("-", "@")
                                   .Replace(", ", "@")
                                   .Replace(". ", "@")
                                   .Replace("! ", "@")
                                   .Replace("? ", "@");
                        string[] words = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                        Array.Reverse(words);
                        result += string.Join(" ", words) + Environment.NewLine;
                    }
                    lineNumber++;
                }
            }
            return result.Trim(); 
        }
    }
}