namespace WordCount
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    public class WordCount
    {
        static void Main()
        {
            string wordPath = @"..\..\..\Files\words.txt";
            string textPath = @"..\..\..\Files\text.txt";
            string outputPath = @"..\..\..\Files\output.txt";

            CalculateWordCounts(wordPath, textPath, outputPath);
        }
        public static void CalculateWordCounts(string wordsFilePath, string textFilePath, string outputFilePath)
        {
            string[] words = File.ReadAllLines(wordsFilePath);
            string text = File.ReadAllText(textFilePath).ToLower();
            Dictionary<string, int> wordCounts = new Dictionary<string, int>();
            foreach (string word in words)
            {
                wordCounts[word.ToLower()] = 0;
            }
            string[] textWords = text
                .Split(new char[] { ' ', '-', ',', '.', '!', '?', ';', ':' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string word in textWords)
            {
                if (wordCounts.ContainsKey(word))
                {
                    wordCounts[word]++;
                }
            }
            var sortedWordCounts = wordCounts.OrderByDescending(w => w.Value);
            using (StreamWriter writer = new StreamWriter(outputFilePath))
            {
                foreach (var kvp in sortedWordCounts)
                {
                    writer.WriteLine($"{kvp.Key} - {kvp.Value}");
                }
            }
        }
    }
}