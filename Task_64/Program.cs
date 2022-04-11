using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_64
{
    //Задача 64: Задайте значения M и N.
    //Напишите программу, которая выведет все натуральные числа кратные 3-ём в промежутке от M до N.
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberM = 1; //начало
            int numberN = 20; //конец

            if (numberN - numberM < 3)
                Console.WriteLine($"Натуральных чисел, кратных 3м в промежутке между {numberM} и {numberN}: нет");
            else
            {
                Console.WriteLine($"Натуральные числа, кратные 3м в промежутке между {numberM} и {numberN}: ");
                if (numberM % 3 != 0) numberM += 3 - numberM % 3; //первое число от которого стартуем
                Console.WriteLine(PrintNumber(numberM, numberN));
            }
            Console.ReadLine();

            string PrintNumber(int nummM, int nummN) 
            { 
                if (nummM > nummN) return string.Empty;
                else
                {
                    Console.Write($"{nummM}, ");
                    return PrintNumber(nummM+3, nummN);
                }
            }
        }
    }
}
