namespace WorkFiles
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;

    public class Program
    {
        public static void Main(string[] args)
        {
            var inputContante1 = File.ReadAllText("Dates/example1.txt");
            var inputContante2 = File.ReadAllText("Dates/example2.txt");
            var inputContante3 = File.ReadAllText("Dates/example3.txt");
            var inputContanteAll = (inputContante1 + " " + inputContante2 + " " + inputContante3).ToLower();
            Console.WriteLine("Ваша строка: " + inputContanteAll);

            var words = SplitStringWords(inputContanteAll);

            Console.Write("Ваш массив: ");
            foreach (var word in words)
            {
                Console.Write(word + " ");
            }

            Console.WriteLine(" ");

            var uniqueWords = FindUniqueWords(words);

            Console.Write("Уникальные слова: ");
            foreach (var uniqueWord in uniqueWords)
            {
                Console.Write(uniqueWord + " ");
            }

            Console.WriteLine(" ");
            Console.WriteLine("Количество неповторяющихся элементов: " + uniqueWords.Count());
        }

        public static string[] SplitStringWords(string contentAll)
        {
            var words
                = contentAll.Split(
                new string[] { ",", " ", "-", ";", "/", "/r", "/n" }, 
                StringSplitOptions.RemoveEmptyEntries);
            return words;
        }

        public static string[] FindUniqueWords(string[] arrayCharacters)
        {
            var uniqueWords = arrayCharacters.Distinct().ToArray();
            return uniqueWords;
        }
    }
}
