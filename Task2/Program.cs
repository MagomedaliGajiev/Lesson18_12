namespace Task2
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            int number = Convert.ToInt32(Console.ReadLine());

            string binary = DecimalToBinary(number);
            Console.WriteLine($"Двоичное представление числа {number}: {binary}");
        }

        static string DecimalToBinary(int number)
        {
            string binary = "";

            while (number > 0)
            {
                int remainder = number % 2;
                binary = remainder + binary;
                number /= 2;
            }

            return binary;
        }
    }
}