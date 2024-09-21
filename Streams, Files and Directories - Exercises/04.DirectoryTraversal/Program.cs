namespace DirectoryTraversal
{
    using System;
    public class DirectoryTraversal
    {
        static void Main()
        {
            string path = Console.ReadLine();
            string reportFileName = @"\report.txt";

            string reportContent = TraverseDirectory(path);
            Console.WriteLine(reportContent);

            WriteReportToDesktop(reportContent, reportFileName);
        }
        public static string TraverseDirectory(string inputFolderPath)
        {
            var filesByExtension = new Dictionary<string, List<(string FileName, long Size)>>();
            var files = Directory.GetFiles(inputFolderPath);
            foreach (var file in files)
            {
                string extension = Path.GetExtension(file).ToLower();
                long size = new FileInfo(file).Length;
                if (!filesByExtension.ContainsKey(extension))
                {
                    filesByExtension[extension] = new List<(string, long)>();
                }
                filesByExtension[extension].Add((Path.GetFileName(file), size));
            }
            var sortedExtensions = filesByExtension
                .OrderByDescending(pair => pair.Value.Count)
                .ThenBy(pair => pair.Key);
            var reportContent = new List<string>();
            foreach (var extension in sortedExtensions)
            {
                reportContent.Add(extension.Key);
                var sortedFiles = extension.Value.OrderBy(file => file.Size);
                foreach (var file in sortedFiles)
                {
                    reportContent.Add($"--{file.FileName} - {file.Size / 1024.0:F3}kb");
                }
            }
            return string.Join(Environment.NewLine, reportContent);
        }
        public static void WriteReportToDesktop(string textContent, string reportFileName)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string fullPath = Path.Combine(desktopPath, reportFileName);
            File.WriteAllText(fullPath, textContent);
        }
    }
}