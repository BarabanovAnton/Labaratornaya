namespace WorkFiles
{
    using System;
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

            Console.WriteLine("Ваш массив: ");
            for (var i = 0; i < arrayCharacters.Length; i++)
            {
                Console.WriteLine(arrayCharacters[i]);
            }

            var countWord = arrayCharacters.Distinct().Count();
            Console.WriteLine("Количество неповторяющихся элементов: " + countWord);
        }

        public static string[] WorkWithSplit(string contentAll)
        {
            var arrayCharactersSplit
                = contentAll.Split(
                new char[] { ',', ' ', '-', ';', '/' }, 
                StringSplitOptions.RemoveEmptyEntries);
            return arrayCharactersSplit;
        }
    }
}
