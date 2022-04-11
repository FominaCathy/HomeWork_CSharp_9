using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_68
{
    //Задача 68:
    //Напишите программу вычисления функции Аккермана с помощью рекурсии.
    //Даны два неотрицательных числа m и n.
    //m = 2, n = 3 -> A(n, m) = 9 - согласно таблице в википедии https://ru.wikipedia.org/wiki/Функция_Аккермана
    //m = 3, n = 2 -> A(n, m) = 29

    internal class Program
    {
        static void Main(string[] args)
        {
            int numberM = 3;
            int numberN = 3;

            Console.WriteLine($"Значение функции Аккермана для m= {numberM} и n={numberN} -> {Akkermann(numberM, numberN)}");
            Console.ReadLine();

            int Akkermann(int nummM, int nummN)
            {
                if (nummM == 0) return nummN+=1;
                else if ((nummM > 0)&&(nummN == 0)) return Akkermann(nummM-1, 1);
                else return Akkermann(nummM-1, Akkermann(nummM, nummN-1));
            }
        }
    }
}
