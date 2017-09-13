namespace WorkFiles
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;

    class Program
    {
        public static void Main(string[] args)
        {
            var contentA = File.ReadAllText(@"C:\Users\vsemp\Desktop\example1.txt", Encoding.Default);
            var contentB = File.ReadAllText(@"C:\Users\vsemp\Desktop\example2.txt", Encoding.Default);
            var contentC = File.ReadAllText(@"C:\Users\vsemp\Desktop\example3.txt", Encoding.Default);
            var contentAll = (contentA + " " + contentB + " " + contentC).ToLower();
            Console.WriteLine("Ваша строка: " + contentAll);

            string[] arrayCharacters = WorkWithSplit(contentAll);

            Console.Write("Ваш массив: ");
            for (var i = 0; i < arrayCharacters.Length; i++)
            {
                Console.Write(arrayCharacters[i] + " ");
            }

            Console.WriteLine(" ");

            var uniqueWords = FindingUniqueWords(arrayCharacters);

            Console.Write("Уникальные слова: ");
            foreach (var uniqueWord in uniqueWords)
            {
                Console.Write(uniqueWord + " ");
            }

            Console.WriteLine(" ");
            Console.WriteLine("Количество неповторяющихся элементов: " + uniqueWords.Count());
        }

        public static string[] WorkWithSplit(string contentAll)
        {
            var arrayCharactersSplit
                = contentAll.Split(
                new char[] { ',', ' ', '-', ';', '/' }, 
                StringSplitOptions.RemoveEmptyEntries);
            return arrayCharactersSplit;
        }

        public static string[] FindingUniqueWords(string[] arrayCharacters)
        {
            var uniqueWords = arrayCharacters.Distinct().ToArray();
            return uniqueWords;
        }
    }
}
