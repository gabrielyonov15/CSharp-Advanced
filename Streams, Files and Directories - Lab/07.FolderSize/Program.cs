namespace FolderSize
{
    using System;
    using System.IO;
    public class FolderSize
    {
        static void Main(string[] args)
        {
            string folderPath = @"..\..\..\Files\TestFolder";
            string outputPath = @"..\..\..\Files\output.txt";

            GetFolderSize(folderPath, outputPath);
        }
        public static void GetFolderSize(string folderPath, string outputFilePath)
        {
            long totalSize = 0;
            if (Directory.Exists(folderPath))
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(folderPath);
                FileInfo[] files = directoryInfo.GetFiles("*", SearchOption.AllDirectories);
                foreach (FileInfo file in files)
                {
                    totalSize += file.Length; 
                }
                double sizeInKB = totalSize / 1024.0;
                File.WriteAllText(outputFilePath, $"{sizeInKB} KB");
            }
            else
            {
                File.WriteAllText(outputFilePath, "Папката не съществува.");
            }
        }
    }
}