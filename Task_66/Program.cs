using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_66
{
    //Задача 66: Задайте значения M и N.
    //Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

    internal class Program
    {
        static void Main(string[] args)
        {
            int numberM = 1;
            int numberN = 15;

            
            Console.WriteLine($"Сумма чисел в промежутке от {numberM} до {numberN} = {SummNumber(numberM, numberN)}");

            Console.ReadLine();

            int SummNumber(int nummM, int nummN)
            {
                if (nummM == nummN) return nummM;
                else return nummN + SummNumber(nummM, nummN-1);
            }
        }
    }
}
