using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADD_Task_1
{
    //Задача 1. Дано предложение.
    //Напишите рекурсивный метод, подсчитывающий количество слов в данном предложении.
    //Словом считается последовательность символов без пробелов.

    internal class Program
    {
        static void Main(string[] args)
        {
            string letter = "Функция Аккермана это простой пример всюду определённой вычислимой функции";
            int count = 1; 

            Console.WriteLine($"кол-во слов = {CalcWord(letter)}");
            Console.ReadLine();


            int CalcWord(string str)
            {
                if (str.Contains(' ') == false)
                     return count;
                else
                    return (count + CalcWord(str.Substring(str.IndexOf(' ') + 1)));
            }
        }
    }
}
