namespace Task6
{
    //Дан двумерный массив.Выведите его на печать с помощью вложенных циклов while.
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

            int rows = array.GetLength(0);
            int columns = array.GetLength(1);

            int i = 0;
            while (i < rows)
            {
                int j = 0;
                while (j < columns)
                {
                    Console.Write(array[i, j] + " ");
                    j++;
                }
                Console.WriteLine();
                i++;
            }
        }
    }
}