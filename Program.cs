using System;

namespace Seminar9HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
            //Запрос данных от пользователя
            // int ReadData(string line)
            // {
            //     Console.Write(line);
            //     int num = int.Parse(Console.ReadLine() ?? " ");
            //     return num;
            // }

            // //Рекурсия числа от M до N
            // string NumMN(int M, int N)
            // {
            //     if (M >= N){ 
            //         return N.ToString();
            //     }
            //     else{
            //         string number = M + "," + NumMN(M+1,N);
            //         return number;
            //     }
            // }

            // //Вывод результата
            // void PrintData(string prefix, string num)
            // {
            // Console.WriteLine(prefix +  num);
            // }


            // int M = ReadData("Введите число M:");
            // int N = ReadData("Введите число N:");
            // string number = (M<N)
            // ?(NumMN(M,N))
            // :(NumMN(N,M));
            // PrintData("Порядок чисел: ", number);
           

            //Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
            // int ReadData(string line)
            // {
            //     Console.Write(line);
            //     int num = int.Parse(Console.ReadLine() ?? " ");
            //     return num;
            // }

            // //Рекурсия суммы чисел от M до N
            // int SumMN(int M, int N)
            // {
            //     if (M >= N) return N;
            //     return M + SumMN(M+1,N);
            // }

            // //Вывод результата
            // void PrintData(string prefix, int num)
            // {
            // Console.WriteLine(prefix +  num);
            // }


            // int M = ReadData("Введите число M:");
            // int N = ReadData("Введите число N:");
            // int sum  = (M<N)
            // ?(SumMN(M,N))
            // :(SumMN(N,M));
            // PrintData("Сумма чисел от M до N: ", sum);
           
            //Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа M и N.

            int ReadData(string line)
            {
                Console.Write(line);
                int num = int.Parse(Console.ReadLine() ?? " ");
                return num;
            }

            //Рекурсия функции
            int Akkerman(int M, int N)
            {
                if (M == 0)
                {
                    return N + 1;
                }
                else if (N == 0 && M > 0)
                {
                    return Akkerman(M - 1, 1);
                }
                else
                {
                    return (Akkerman(M - 1, Akkerman(M, N - 1)));
                }
            }
            //Вывод результата
            void PrintData(string prefix, int num)
            {
            Console.WriteLine(prefix +  num);
            }


            int M = ReadData("Введите число M:");
            int N = ReadData("Введите число N:");
            int function = Akkerman (M,N); 
            PrintData("Функция Аккермана равна: ", function);
           

        }
    }
}
