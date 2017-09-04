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
            var a = InputСoefficient();

            Console.Write("Введите значение b: ");
            var b = InputСoefficient();

            Console.Write("Введите значение с: ");
            var c = InputСoefficient();

            Console.WriteLine("Ваше уравнение: " + a + " *x^2 + " + b + " *x + " + c + " = 0");

            var discr = Pow(b, 2) - (4 * a * c);
            Console.WriteLine("Дискриминант равен: " + discr);

            if (discr > 0)
            {
                var x1 = (-b - Sqrt(discr)) / (2 * a);
                var x2 = (-b + Sqrt(discr)) / (2 * a);
                Console.WriteLine("Первый корень равен: " + x1);
                Console.WriteLine("Второй корень равен: " + x2);
            }
            else if (discr == 0)
            {
                var x = -b / (2 * a);
                Console.WriteLine("Уравнение имеет один корень: " + x);
            }
            else
            {
                Console.WriteLine("Уравнение не имеет корней.");
            }
        }

        public static double InputСoefficient()
        {
            while (true)
            {
                if (double.TryParse(Console.ReadLine(), out var i))
                {
                    return i;
                }

                Console.Write("Ошибка, введите число: ");
            }
        }
    }
}
