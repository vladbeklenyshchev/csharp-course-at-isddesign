using System;

namespace Two_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 0;
            int output = 1;
            do
            {
                try
                {
                    input = int.Parse(Console.ReadLine());
                }
                catch(System.FormatException e)
                {
                    continue;
                }
            }while(input < 1 || input >30);
            if (input == 1 || input == 2)
            {
                output = 2 * input;
            }
            else
            {
                for (int i = 0; i < input; i++)
                {
                    output = output * 2;
                }
                output /= 2;
            }
            Console.WriteLine(output);
        }
    }
}