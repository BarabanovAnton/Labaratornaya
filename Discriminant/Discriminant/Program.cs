namespace Discriminant
{
    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics.CodeAnalysis;

    using static System.Math;
    
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Введите значение a: ");
            var a = Console.ReadLine();
            var resultA = double.TryParse(a, out var a1);
            if (resultA == false)
            {
                Console.WriteLine("Ошибка, введите число.");
            }

            Console.Write("Введите значение b: ");
            var b = Console.ReadLine();
            var resultB = double.TryParse(b, out var b1);
            if (resultB == false)
            {
                Console.WriteLine("Ошибка, введите число.");
            }

            Console.Write("Введите значение с: ");
            var c = Console.ReadLine();
            var resultC = double.TryParse(c, out var c1);
            if (resultC == false)
            {
                Console.WriteLine("Ошибка, введите число.");
            }

            var discr = Pow(b1, 2) - 4 * a1 * c1;
            Console.WriteLine("Дискриминант равен: " + discr);

            if (discr > 0)
            {
                var x1 = (-b1 - Sqrt(discr)) / (2 * a1);
                var x2 = (-b1 + Sqrt(discr)) / (2 * a1);
                Console.WriteLine("Первый корень равен: " + x1);
                Console.WriteLine("Второй корень равен: " + x2);
            }

            else if (discr == 0)
            {
                var x = -b1 / (2 * a1);
                Console.WriteLine("Уравнение имеет один корень: " + x);
            }

            else
            {
                Console.WriteLine("Уравнение не имеет корней.");
            }

        }
    }
}
