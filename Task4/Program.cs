namespace Task4
{
    //Дан двумерный массив.
    //123
    //456
    //789
    //Выведите его на печать перевернутым на 90 градусов
    //741
    //852
    //963

    class Program
    {
        static void Main(string[] args)
        {
            int[,] a = { { 7, 3, 2 }, { 4, 9, 6 }, { 1, 8, 5 } };

            PrintArray(a);
            Console.WriteLine();
            int[,] b = RotateArray(a);
            PrintArray(b);
            Console.WriteLine();
            int[,] c = RotateArrayAlt(a);
            PrintArray(c);
        }

        static int[,] RotateArray(int[,] array)
        {
            int[,] rotatedArray = new int[array.GetLength(0), array.GetLength(1)];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(0); j++)
                {
                    rotatedArray[j, array.GetLength(1) - 1 - i] = array[i, j];
                }
            }

            return rotatedArray;
        }

        static int[,] RotateArrayAlt(int[,] array)
        {
            int[,] rotatedArray = new int[array.GetLength(0), array.GetLength(1)];

            for (int i = 0; i <  array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    rotatedArray[i, j] = array[array.GetLength(0)- 1 - j, i];
                }
            }

            return rotatedArray;
        }

        static void PrintArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}