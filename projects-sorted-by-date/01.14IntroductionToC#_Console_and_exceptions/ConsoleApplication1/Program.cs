using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static int CheckValue(char cval)
        {
            bool check = false;
            int val = 0;
            do
            {
                try
                {
                    val = int.Parse(Console.ReadLine());
                    check = true;
                }
                catch (System.FormatException e)
                {
                    Console.Write(String.Format("Введите еще раз число {0}: ", cval));
                    check = false;
                }
            } while (check == false);
            return val;
        }
        static void Main(string[] args)
        {
            int[] values = new int[4];
            char ch = 'A';
            for (int j = 0; j < 4; j++, ch++)
            {
                Console.Write(String.Format("Введите число {0}: ",ch));
                values[j] = CheckValue(ch);
            }
            Console.WriteLine(String.Format("Вы ввели {0}, {1}, {2}, {3}", values[0], values[1], values[2], values[3]));
            int i = 0;
            for (int j = 0; j < 4; j++)
            {
                if ((values[j] % 2) == 0) 
                {
                    i++;
                }
            }
            if (i == 0)
            {
                Console.WriteLine("Нету четных чисел.");
            }
            else if(i>=2) Console.WriteLine("Есть не менее двух четных чисел.");
            Console.ReadKey(true);//можно любую кнопку нажимать
        }
        
    }
}
