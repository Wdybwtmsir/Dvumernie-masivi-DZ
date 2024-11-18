using System;

class Program
{
    static void Main()
    {
        int[,] mas1 = {
            { 5, 2, 3 },
            { 8, 1, 4 },
            { 6, 7, 1 }
        };
        (int row, int col) = FindFirstMinIndex(mas1);
        Console.WriteLine($"Индексы первого наименьшего элемента: ({row}, {col})");
    }

    static (int, int) FindFirstMinIndex(int[,] array)
    {
        int minValue = int.MaxValue;
        int minRow = -1;
        int minCol = -1;

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[i, j] < minValue)
                {
                    minValue = array[i, j];
                    minRow = i;
                    minCol = j;
                }
            }
        }

        return (minRow, minCol);
    }
}