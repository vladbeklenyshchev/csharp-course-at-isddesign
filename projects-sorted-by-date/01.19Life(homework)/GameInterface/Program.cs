using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameFunction;

namespace GameInterface
{
    class Program
    {
        static void ReadFieldSize(out int x,out int y)
        {
            Console.Write("M = ");
            while (!int.TryParse(Console.ReadLine(), out x)) ;
            Console.Write("N = ");
            while (!int.TryParse(Console.ReadLine(), out y)) ;
        }
        static void PrintField(bool[,] field, int M, int N)
        {
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    //false - жизни нету, true - жизнь есть.
                    if (field[i, j]) Console.Write("X");
                    else Console.Write("-");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер поля M*N.");
            int M = 0, N = 0;
            ReadFieldSize(out M, out N);
            //создадим и проинициализируем двумерный массив
            bool[,] field = Class1.CreateAndGenerateField(M,N);
            Console.WriteLine("Поле:");
            PrintField(field, M, N);
            Console.WriteLine("=======================");
            Console.WriteLine("Меню");
            Console.WriteLine("1.Сыграть.");
            Console.WriteLine("2.Узнать есть ли жизнь в конкретной ячейки.");
            Console.WriteLine("0.Выход");
            switch(int.Parse(Console.ReadLine()))
            {
                case 1:
                    for (int step = 0; step < M * N; step++)
                    {
                        Console.WriteLine(String.Format("Шаг {0}:", step + 1));
                        PrintField(field, M, N);
                        Console.ReadKey(true);
                    }
                    break;
                case 2:
                    break;
                default:
                    break;
            }
            
            Console.ReadKey(true);
        }
    }
}