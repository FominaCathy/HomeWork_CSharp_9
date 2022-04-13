using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADD_Task_3
{
    //Задача 3. Даны натуральные числа a и b.
    //Рекурсивно описать функцию возведения числа a в степень b,
    //используя только операцию инкрементирования (“++”).

    internal class Program
    {
        static void Main(string[] args)
        {
            int baseA = 5; //основание,
            int degreeB = 3; //степень
            int result = baseA;
            ;
            int step = 1;

            Console.WriteLine( $"{baseA} в степени {degreeB} = {DegreeConcaten(baseA, degreeB)}");
            Console.ReadLine();
            
            int DegreeConcaten(int a, int b, int count = 1)
            {
                if (count == baseA)
                {
                    step++;
                    DegreeConcaten(result, b);
                }
                if (step == b)
                    return result;
        
                for (int i = 0; i < a; i++) result++;
                count++;
                return DegreeConcaten(a, b, count);

            }
        }
    }
}
