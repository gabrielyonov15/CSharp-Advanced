using System;
using System.IO;

namespace OddLines
{
    public class OddLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\Files\input.txt";
            string outputFilePath = @"..\..\..\Files\output.txt";

            ExtractOddLines(inputFilePath, outputFilePath);
        }

        public static void ExtractOddLines(string inputFilePath, string outputFilePath)
        {
            string[] lines = File.ReadAllLines(inputFilePath);

            using (StreamWriter writer = new StreamWriter(outputFilePath))
            {
                for (int i = 0; i < lines.Length; i++)
                {
                    if (i % 2 != 0)
                    {
                        writer.WriteLine(lines[i]);
                    }
                }
            }
        }
    }
}