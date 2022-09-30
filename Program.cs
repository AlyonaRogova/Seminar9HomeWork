using System;

namespace Seminar9HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
            //Запрос данных от пользователя
            int ReadData(string line)
            {
                Console.Write(line);
                int num = int.Parse(Console.ReadLine() ?? " ");
                return num;
            }

            //Рекурсия числа от M до N
            string NumMN(int M, int N)
            {
                if (M >= N) 
                {
                return N.ToString();
                }
                else
                {
                string number = M + "," + NumMN(M+1,N);
                return number;
                }
            }

            //Вывод результата
            void PrintData(string prefix, string num)
            {
            Console.WriteLine(prefix +  num);
            }


            int M = ReadData("Введите число M:");
            int N = ReadData("Введите число N:");
            string number = (M<N)
            ?(NumMN(M,N))
            :(NumMN(N,M));
            PrintData("Порядок чисел: ", number);
           

            //Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

            //Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.


        }
    }
}
