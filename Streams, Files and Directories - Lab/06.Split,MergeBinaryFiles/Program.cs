namespace SplitMergeBinaryFile
{
    using System;
    using System.IO;
    using System.Linq;

    public class SplitMergeBinaryFile
    {
        static void Main()
        {
            string sourceFilePath = @"..\..\..\Files\example.png";
            string joinedFilePath = @"..\..\..\Files\example-joined.png";
            string partOnePath = @"..\..\..\Files\part-1.bin";
            string partTwoPath = @"..\..\..\Files\part-2.bin";

            SplitBinaryFile(sourceFilePath, partOnePath, partTwoPath);
            MergeBinaryFiles(partOnePath, partTwoPath, joinedFilePath);
        }
        public static void SplitBinaryFile(string sourceFilePath, string partOneFilePath, string partTwoFilePath)
        {
            byte[] fileBytes = File.ReadAllBytes(sourceFilePath);
            int totalBytes = fileBytes.Length;
            int partOneSize = (totalBytes + 1) / 2; 
            int partTwoSize = totalBytes / 2;
            using (FileStream partOneStream = new FileStream(partOneFilePath, FileMode.Create))
            {
                partOneStream.Write(fileBytes, 0, partOneSize);
            }
            using (FileStream partTwoStream = new FileStream(partTwoFilePath, FileMode.Create))
            {
                partTwoStream.Write(fileBytes, partOneSize, partTwoSize);
            }
        }
        public static void MergeBinaryFiles(string partOneFilePath, string partTwoFilePath, string joinedFilePath)
        {
            using (FileStream joinedStream = new FileStream(joinedFilePath, FileMode.Create))
            {
                using (FileStream partOneStream = new FileStream(partOneFilePath, FileMode.Open))
                {
                    partOneStream.CopyTo(joinedStream);
                }
                using (FileStream partTwoStream = new FileStream(partTwoFilePath, FileMode.Open))
                {
                    partTwoStream.CopyTo(joinedStream);
                }
            }
        }
    }
}