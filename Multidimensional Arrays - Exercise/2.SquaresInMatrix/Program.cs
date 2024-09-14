﻿namespace _2.SquaresInMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dimensions = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rows = dimensions[0];
            int cols = dimensions[1];
            char[,] matrix = new char[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                var rowElements = Console.ReadLine().Split(' ');
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = rowElements[j][0];
                }
            }
            int count = 0;
            for (int i = 0; i < rows - 1; i++)
            {
                for (int j = 0; j < cols - 1; j++)
                {
                    if (matrix[i, j] == matrix[i, j + 1] &&
                        matrix[i, j] == matrix[i + 1, j] &&
                        matrix[i, j] == matrix[i + 1, j + 1])
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}