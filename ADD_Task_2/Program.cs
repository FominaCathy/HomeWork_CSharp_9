using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADD_Task_2
{
    //Задача 2.
    //Известно, что пароль длиной 3 символа
    //состоит из латинских букв строчного регистра и цифр от 0 до 9.
    //Напишите рекурсивный метод, который перебирает все комбинации паролей

    //сделала по лекции

    internal class Program
    {
        static void Main(string[] args)
        {
            string alfavit = "qwertyuiopasdfghjklzxcvbnm0123456789";
           
            FillRassword(alfavit, new char[3]);

            Console.ReadLine();

            void FillRassword(string str, char[] pass, int lengthPass = 0)
            {
                if (lengthPass == pass.Length)
                {
                    Console.WriteLine(new String(pass));
                    return;
                }

                for (int i = 0; i < str.Length; i++)
                {
                    pass[lengthPass] = str[i];
                    FillRassword(str, pass, lengthPass + 1);
                }
            }

        }
    }
}
