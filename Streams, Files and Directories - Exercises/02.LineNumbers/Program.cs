namespace LineNumbers
{
    using System;
    public class LineNumbers
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";
            string outputFilePath = @"..\..\..\output.txt";

            ProcessLines(inputFilePath, outputFilePath);
        }
        public static void ProcessLines(string inputFilePath, string outputFilePath)
        {
            string[] lines = File.ReadAllLines(inputFilePath);
            string[] outputLines = new string[lines.Length];
            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                int letterCount = line.Count(char.IsLetterOrDigit); 
                int punctuationCount = line.Count(char.IsPunctuation); 
                outputLines[i] = $"Line {i + 1}: {line} ({letterCount})({punctuationCount})";
            }
            File.WriteAllLines(outputFilePath, outputLines);
        }
    }
} 