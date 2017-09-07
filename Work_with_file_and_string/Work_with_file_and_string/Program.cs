namespace Work_with_file_and_string
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
            //Console.WriteLine(contentA);
            var contentB = File.ReadAllText(@"C:\Users\vsemp\Desktop\example2.txt", Encoding.Default);
            //Console.WriteLine(contentB);
            var contentC = File.ReadAllText(@"C:\Users\vsemp\Desktop\example3.txt", Encoding.Default);
            //Console.WriteLine(contentC);
            var contentAll = contentA + " " + contentB + " " + contentC;
            contentAll = contentAll.ToLower();
            Console.WriteLine("Ваша строка: " + contentAll);
             

            string[] array = contentAll.Split(new char[] { ',', ' ' });

            /*foreach (var a in array)
            {
                Console.WriteLine(a);
            }*/

            Console.WriteLine("Ваш массив: ");
            for (var i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            var countWord = array.Distinct().Count();
            Console.WriteLine("Количество неповторяющихся элементов: " + countWord);
        }
    }
}
