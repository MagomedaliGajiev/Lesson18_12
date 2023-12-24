using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Task5
{
    // Создайте новую строку с тем же содержанием, но без чисел.
    // Используйте класс StringBuilder.
    class Program
    {
        static void Main(string[] args)
        {
            string input = "Эта ст1рока не долж2на содерж345ать цифры67";
            string result = RemoveNumbers(input);
            Console.WriteLine(input);
            Console.WriteLine(result);
        }

        static string RemoveNumbers(string input)
        {
            var sb = new StringBuilder();
            foreach (char c in input)
            {
                if (!char.IsDigit(c))
                {
                    sb.Append(c);
                }
            }

            return sb.ToString();
        }
    }
}