namespace _5.SnakeMoves
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
            string snake = Console.ReadLine();
            char[,] matrix = new char[rows, cols];
            int snakeLength = snake.Length;
            int snakeIndex = 0;
            for (int i = 0; i < rows; i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        matrix[i, j] = snake[snakeIndex];
                        snakeIndex = (snakeIndex + 1) % snakeLength;
                    }
                }
                else
                {
                    for (int j = cols - 1; j >= 0; j--)
                    {
                        matrix[i, j] = snake[snakeIndex];
                        snakeIndex = (snakeIndex + 1) % snakeLength;
                    }
                }
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}