namespace _4.MatrixShuffling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int rows = dimensions[0];
            int cols = dimensions[1];
            var matrix = new string[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                var rowElements = Console.ReadLine()
                    .Split();
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = rowElements[j];
                }
            }
            string command;
            while ((command = Console.ReadLine()) != "END")
            {
                var parts = command.Split();
                if (parts.Length != 5 || parts[0] != "swap")
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }
                int row1, col1, row2, col2;
                if (!int.TryParse(parts[1], out row1) ||
                    !int.TryParse(parts[2], out col1) ||
                    !int.TryParse(parts[3], out row2) ||
                    !int.TryParse(parts[4], out col2) ||
                    !IsValidCoordinate(row1, col1, rows, cols) ||
                    !IsValidCoordinate(row2, col2, rows, cols))
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }
                var temp = matrix[row1, col1];
                matrix[row1, col1] = matrix[row2, col2];
                matrix[row2, col2] = temp;
                PrintMatrix(matrix, rows, cols);
            }
        }
        static bool IsValidCoordinate(int row, int col, int maxRows, int maxCols)
        {
            return row >= 0 && row < maxRows && col >= 0 && col < maxCols;
        }
        static void PrintMatrix(string[,] matrix, int rows, int cols)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}