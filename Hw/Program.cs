namespace Hw
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = {
            { 7, 3, 2 },
            { 4, 9, 6 },
            { 1, 8, 5 }
        };

            SortArray(array);

            PrintArray(array);
        }

        static void SortArray(int[,] array)
        {
            int rows = array.GetLength(0);
            int columns = array.GetLength(1);

            int totalElements = rows * columns;
            for (int i = 0; i < totalElements - 1; i++)
            {
                for (int j = 0; j < totalElements - i - 1; j++)
                {
                    int row1 = j / columns;
                    int col1 = j % columns;
                    int row2 = (j + 1) / columns;
                    int col2 = (j + 1) % columns;

                    if (array[row1, col1] > array[row2, col2])
                    {
                        int temp = array[row1, col1];
                        array[row1, col1] = array[row2, col2];
                        array[row2, col2] = temp;
                    }
                }
            }
        }

        static void PrintArray(int[,] array)
        {
            int rows = array.GetLength(0);
            int columns = array.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}