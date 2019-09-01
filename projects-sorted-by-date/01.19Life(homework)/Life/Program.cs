using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Life
{
    class Program
    {
        private static void PrintField(bool[,] field, int M, int N)
        {
            for (int i = 1; i < M+1; i++)
            {
                for (int j = 1; j < N+1; j++)
                {
                    //генерируем случайные значения. false - жизни нету, true - жизнь есть.
                    if (field[i, j]) Console.Write("X");
                    else Console.Write("-");
                }
                Console.WriteLine();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер поля M*N.");
            int M = 0, N = 0;
            Console.Write("M = ");
            M = int.Parse(Console.ReadLine());
            Console.Write("N = ");
            N = int.Parse(Console.ReadLine());
            //создадим двумерный массив
            bool[,] field = new bool[M+2, N+2];
            Random fieldRand = new Random();
            for(int i = 1; i < M+1; i++) 
            {
                for (int j = 1; j < N+1; j++)
                {
                    //генерируем случайные значения. false - жизни нету, true - жизнь есть.
                    if (fieldRand.Next(0, 2) == 0)
                    {
                        field[i, j] = false;
                    }
                    else
                    {
                        field[i, j] = true;
                    }
                }
            }
            //инициализация остаточных элементов
            for(int i = 0; i < N+2 ;i++)
            {
                field[0, i] = false;
                field[M+1, N + 1] = false;
            }
            for (int i = 1; i < M + 1; i++)
            {
                field[i, 0] = false;
                field[i, N+1] = false;
            }
            //печать всего поля
            Console.WriteLine("Поле:");
            PrintField(field, M, N);
            Console.WriteLine("=======================");
            int number_of_living_cells = 0;
            // 
            for (int i = 1, step = 0; i < M+1; i++)
            {
               // 
                for(int j = 1; j < N+1; j++, step++)
                {
                    number_of_living_cells = 0;
                    // 
                    for (int l = i - 1, lcount = 0; lcount < 3; l++, lcount++)
                    {
                        for (int r = j - 1, rcount = 0; rcount < 3; r++, rcount++)
                        {
                            if (l == i && r == j) 
                                continue;
                            else if (field[l, r]) number_of_living_cells++;
                        }
                    }
                    if (field[i, j] && number_of_living_cells > 3)
                    {
                        field[i, j] = false;
                    }
                    else if (number_of_living_cells == 2 || number_of_living_cells == 3)
                    {
                        field[i, j] = true;
                    }
                    Console.WriteLine(String.Format("Шаг {0}:",step+1));
                    PrintField(field, M, N);
                    Console.WriteLine("=======================");
                    Console.ReadKey(true);
                }
            }
            Console.ReadKey(true);
        }
    }
}