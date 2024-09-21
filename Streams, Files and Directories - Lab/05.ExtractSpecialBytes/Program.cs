namespace ExtractSpecialBytes
{
    using System;
    using System.IO;
    public class ExtractSpecialBytes
    {
        static void Main()
        {
            string binaryFilePath = @"..\..\..\Files\example.png";
            string bytesFilePath = @"..\..\..\Files\bytes.txt";
            string outputPath = @"..\..\..\Files\output.bin";

            ExtractBytesFromBinaryFile(binaryFilePath, bytesFilePath, outputPath);
        }
        public static void ExtractBytesFromBinaryFile(string binaryFilePath, string bytesFilePath, string outputPath)
        {
            List<byte> targetBytes = File.ReadAllLines(bytesFilePath)
                                        .Select(byte.Parse)
                                        .ToList();
            byte[] binaryFileContent = File.ReadAllBytes(binaryFilePath);
            List<byte> extractedBytes = new List<byte>();
            foreach (byte b in binaryFileContent)
            {
                if (targetBytes.Contains(b))
                {
                    extractedBytes.Add(b);
                }
            }
            File.WriteAllBytes(outputPath, extractedBytes.ToArray());
        }
    }
}