using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labaratornaya6_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            char delimiter = ' ';
            string temp = "";
            string sas = "sas";
            Console.Write("Введите строку: ");
            string str1 = Console.ReadLine();
            Console.WriteLine("Ваша строка: " + str1);

            String[] str2 = str1.Split(delimiter);

            for (int i = 0; i < str2.Length; i++)
            {
                temp = str2[i];
                if(temp.Contains(sas)) Console.Write("Слова содержащие sas: " + temp + " ");
            }
        }
    }
}
