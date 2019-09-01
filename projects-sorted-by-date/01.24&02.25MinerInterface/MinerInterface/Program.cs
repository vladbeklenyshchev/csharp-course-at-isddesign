using System;
using MinerFunction;

namespace MinerInterface
{
    class Program
    {
        static void PrintField(IReadOnlyMinerGame field)
        {
            for(int i=0; i<field.Height; i++)
            {
                for(int j=0; j<field.Width;j++)
                {
                    //бомб не видно
                    if(field[i,j] == 2) Console.Write("+");
                    else Console.Write("-");
                    //видно бомбы:
                    /*if (field[i, j] == 1) Console.Write("X");
                    else if(field[i, j] == 2) Console.Write("+");
                    else Console.Write("-");*/
                }
                Console.WriteLine();
            }
        }
        static int CheckInput(string strTip)
        {
            bool checkInput = false;
            int x = 0;
            do
            {
                Console.WriteLine(strTip);
                try
                {
                    x = int.Parse(Console.ReadLine());
                    checkInput = true;
                }
                catch (System.FormatException e)
                {
                    checkInput = false;
                }
            } while (!checkInput);
            return x;
        }
        static void Main(string[] args)
        {   
            //количество полей
            int numberOfFields = 0;
            numberOfFields = CheckInput("Введите количество полей: ");
            IMinerGame[] field = new MinerGame[numberOfFields]; 
            for (int i = 0; i < numberOfFields; i++)
            {
                int n = 0;
                int m = 0;
                n = CheckInput(String.Format("Введите количество строк поля {0}: ", i + 1));
                m = CheckInput(String.Format("Введите количество столбцов поля {0} : ", i + 1));
                field[i] = new MinerGame(n,m);
            }
            //инициализация полей числом 0 - бомбы нету
            for (int i = 0; i < numberOfFields; i++)
                field[i].InitField();
            //инициализация полей псевдослучайными числами - генератор определит где будет бомба
            //размещение бомб
            Random rand = new Random();
            for (int i = 0; i < numberOfFields; i++)
                field[i].BombsRandomGeneration(rand);
            //распечатаем, что вышло в результате рандомизации
            Console.WriteLine("=======================");
            for (int i = 0; i < numberOfFields; i++)
            {
                Console.WriteLine(String.Format("Поле {0} :", i+1));
                PrintField(field[i]);
                Console.WriteLine("_______________________");
            }
            /*********************/
            /***игровой процесс***/
            //пока работа над всеми полями не завершится цикл будет выполняться
            //counterOfProcess увеличивается на 1 если работа над полем закончится
            for (int counterOfProcess = 0; counterOfProcess != numberOfFields; )
            {
                //вводим и проверяем данные для каждого поля
                for (int i = 0; i < numberOfFields; i++)
                {
                    //если работа с полем закончена (неважно какой был результат), то выполняем следующую итерацию
                    if (field[i].IsWorkCompleted)
                    {
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Введите координаты клетки, которую хотите открыть для поля {0}:", i + 1);
                        int j = 0;
                        int k = 0;
                        j = CheckInput("Номер строки: ") - 1;
                        k = CheckInput("Номер столбца: ") - 1;
                        if (field[i].CheckCell(j, k) == 1)
                        {
                            //работа закончена неудачно
                            Console.WriteLine("Вы наткнулись на бомбу! Поле было взорвано :(");
                            ++counterOfProcess;
                        }
                        else if (field[i].CheckCell(j, k) == 0)
                        {
                            //работа закончена удачно
                            Console.WriteLine(String.Format("Поле {0} обезврежено. Хорошая работа! :)", i + 1));
                            counterOfProcess++;
                        }
                        else
                        {
                            //вариант 2 - клетка помечается как просмотренная знаком "+", после этого поле выводится на экран
                            Console.WriteLine(String.Format("Поле {0} :", i + 1));
                            PrintField(field[i]);
                            Console.WriteLine("_______________________");
                        }
                    }
                }
            }
            Console.WriteLine("Статистика игры:");
            for (int i = 0; i < numberOfFields; i++)
            {
                if (field[i].IsGoodWork)
                    Console.WriteLine(String.Format("Поле {0} было успешно обезврежено. Поздравляю :)", i + 1));
                else
                    Console.WriteLine(String.Format("Поле {0} не было обезврежено. Сожалею... :(", i + 1));
                Console.WriteLine();
            }
            Console.ReadKey(true);
        }
    }
}