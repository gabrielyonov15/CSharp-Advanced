using System.Text;

namespace _3.MaximalSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
                int rows = size[0];
                int cols = size[1];
                var matrix = new int[rows, cols];
                for (int i = 0; i < rows; i++)
                {
                    var colEl = Console.ReadLine()
                        .Split(" ", StringSplitOptions.RemoveEmptyEntries) 
                        .Select(int.Parse)
                        .ToArray();
                    for (int j = 0; j < cols; j++)
                    {
                        matrix[i, j] = colEl[j];
                    }
                }
                int startRow = 0;
                int startCol = 0;
                int largestSum = int.MinValue; 
                for (int i = 0; i <= rows - 3; i++)
                {
                    for (int j = 0; j <= cols - 3; j++)
                    {
                        int currentSum = 0;
                        for (int x = i; x < i + 3; x++)
                        {
                            for (int y = j; y < j + 3; y++)
                            {
                                currentSum += matrix[x, y];
                            }
                        }
                        if (currentSum > largestSum)
                        {
                            largestSum = currentSum;
                            startRow = i;
                            startCol = j;
                        }
                    }
                }
                var sb = new StringBuilder();
                sb.AppendLine($"Sum = {largestSum}");
                for (int i = startRow; i < startRow + 3; i++)
                {
                    for (int j = startCol; j < startCol + 3; j++)
                    {
                        sb.Append(matrix[i, j] + " ");
                    }
                    sb.AppendLine();
                }
                Console.WriteLine(sb.ToString().Trim());
            }
        }
    }