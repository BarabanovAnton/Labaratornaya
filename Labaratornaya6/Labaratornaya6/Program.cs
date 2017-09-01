using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labaratornaya6
{
    class Program
    {
        static void Main(string[] args)
        {
            char delimiter = ' ';
            int max = 0;
            string temp = "";
            Console.Write("Введите строку: ");
            string str1 = Console.ReadLine();
            Console.WriteLine("Ваша строка: " + str1);

            String[] str2 = str1.Split(delimiter);

            for(int i = 0; i < str2.Length; i++)
            {
                if (str2[i].Length >= max)
                {
                    max = str2[i].Length;
                    temp = str2[i];
                }
                else
                {
                    max = max;
                }
            }
            Console.WriteLine("Самое длинное слово в строке: " + temp);
        }
    }
}
