namespace _3.PrimaryDiagonal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            int diagonalSum = 0;
            for (int i = 0; i < n; i++)
            {
                var rowElements = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = rowElements[j];
                    if (i == j)
                    {
                        diagonalSum += matrix[i, j];
                    }
                }
            }
            Console.WriteLine(diagonalSum);
        }
    }
}