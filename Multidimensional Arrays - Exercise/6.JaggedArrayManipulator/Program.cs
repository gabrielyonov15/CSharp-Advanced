namespace _6.JaggedArrayManipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[][] matrix = new int[n][];
            for (int i = 0; i < n; i++)
            {
                matrix[i] = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
            }
            for (int i = 0; i < n - 1; i++)
            {
                if (matrix[i].Length == matrix[i + 1].Length)
                {
                    for (int j = 0; j < matrix[i].Length; j++)
                    {
                        matrix[i][j] *= 2;
                        matrix[i + 1][j] *= 2;
                    }
                }
                else
                {
                    for (int j = 0; j < matrix[i].Length; j++)
                    {
                        matrix[i][j] /= 2;
                    }
                    for (int j = 0; j < matrix[i + 1].Length; j++)
                    {
                        matrix[i + 1][j] /= 2;
                    }
                }
            }
            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                var parts = command.Split();
                if (parts.Length != 4)
                    continue; 
                string action = parts[0];
                if (int.TryParse(parts[1], out int row) && int.TryParse(parts[2], out int col) && int.TryParse(parts[3], out int value))
                {
                    if (row >= 0 && row < matrix.Length && col >= 0 && col < matrix[row].Length)
                    {
                        if (action == "Add")
                        {
                            matrix[row][col] += value;
                        }
                        else if (action == "Subtract")
                        {
                            matrix[row][col] -= value;
                        }
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(string.Join(" ", matrix[i]));
            }
        }
    }
}