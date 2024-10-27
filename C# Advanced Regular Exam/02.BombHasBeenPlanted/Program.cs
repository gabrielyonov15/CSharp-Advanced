using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var dimensions = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
        int n = dimensions[0], m = dimensions[1];
        char[][] map = new char[n][];
        for (int i = 0; i < n; i++)
        {
            map[i] = Console.ReadLine().ToCharArray();
        }
        int startRow = -1, startCol = -1, bombRow = -1, bombCol = -1;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (map[i][j] == 'C')
                {
                    startRow = i;
                    startCol = j;
                }
                else
                if (map[i][j] == 'B')
                {
                    bombRow = i;
                    bombCol = j;
                }
            }
        }
        int currentRow = startRow, currentCol = startCol;
        int timeRemaining = 16;
        string command;
        while ((command = Console.ReadLine()) != null && timeRemaining > 0)
        {
            if (command == "defuse")
            {
                if (currentRow == bombRow && currentCol == bombCol)
                {
                    if (timeRemaining >= 4)
                    {
                        timeRemaining -= 4;
                        map[bombRow][bombCol] = 'D';
                        Console.WriteLine($"Counter-terrorist wins!");
                        Console.WriteLine($"Bomb has been defused: {timeRemaining} second/s remaining.");
                        break;
                    }
                    else
                    {
                        map[bombRow][bombCol] = 'X';
                        Console.WriteLine($"Terrorists win!");
                        Console.WriteLine($"Bomb was not defused successfully!");
                        Console.WriteLine($"Time needed: {4 - timeRemaining} second/s.");
                        break;
                    }
                }
                else
                {
                    timeRemaining -= 2;
                }
            }
            else
            {
                int nextRow = currentRow, nextCol = currentCol;
                switch (command)
                {
                    case "up": nextRow--; break;
                    case "down": nextRow++; break;
                    case "left": nextCol--; break;
                    case "right": nextCol++; break;
                }
                if (nextRow >= 0 && nextRow < n && nextCol >= 0 && nextCol < m)
                {
                    currentRow = nextRow;
                    currentCol = nextCol;
                    if (map[currentRow][currentCol] == 'T')
                    {
                        map[currentRow][currentCol] = '*';
                        map[startRow][startCol] = 'C';
                        Console.WriteLine("Terrorists win!");
                        break;
                    }
                    else 
                    if (map[currentRow][currentCol] == 'B')
                    {
                    }
                }
                timeRemaining--;
            }
            if (timeRemaining == 0)
            {
                Console.WriteLine("Terrorists win!");
                Console.WriteLine($"Bomb was not defused successfully!");
                Console.WriteLine($"Time needed: {timeRemaining} second/s.");
                break;
            }
        }
        map[startRow][startCol] = 'C';
        foreach (var row in map)
        {
            Console.WriteLine(new string(row));
        }
    }
}