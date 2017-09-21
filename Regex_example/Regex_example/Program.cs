namespace Regex_example
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Введите выражение: ");

            var pattern = @"\d+\,?\d*\s*\+?\-?\*?\:?\s*\d+\,?\d*\s*\=\s*\d+\,?\d*";
            var inputExpression = Console.ReadLine();

            if (Regex.IsMatch(inputExpression, pattern))
            {
                Console.WriteLine("Вы ввели правильно.");
            }

            else
            {
                Console.WriteLine("Вы ввели неправильно.");
            }
        }
    }
}
