﻿namespace CopyDirectory
{
    using System;
    public class CopyDirectory
    {
        static void Main()
        {
            string inputPath = @$"{Console.ReadLine()}";
            string outputPath = @$"{Console.ReadLine()}";
            CopyAllFiles(inputPath, outputPath);
        }
        public static void CopyAllFiles(string inputPath, string outputPath)
        {
            if (!Directory.Exists(inputPath))
            {
                return;
            }
            if (Directory.Exists(outputPath))
            {
                Directory.Delete(outputPath, true);
            }
            Directory.CreateDirectory(outputPath);
            var files = Directory.GetFiles(inputPath);
            foreach (var file in files)
            {
                string fileName = Path.GetFileName(file);
                string destFile = Path.Combine(outputPath, fileName);
                File.Copy(file, destFile);
            }
        }
    }
}