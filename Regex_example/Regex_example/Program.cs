namespace Regex_example
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    public class Program
    {
        [SuppressMessage("StyleCop.CSharp.LayoutRules", "SA1510:ChainedStatementBlocksMustNotBePrecededByBlankLine", Justification = "Reviewed. Suppression is OK here.")]
        public static void Main(string[] args)
        {
            Console.Write("Введите выражение: ");

            var number = @"\d+\,?\d*";
            var space = @"\s*";
            var sign = @"\+?\-?\*?\:?";
            var equalSign = @"\=";
            var regex = $"{number}{space}{sign}{space}{number}{space}{equalSign}{space}{number}";
            var inputExpression = Console.ReadLine();

            if (inputExpression != null && Regex.IsMatch(inputExpression, regex))
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
