using System;

namespace GameFunction
{
    public class Class1
    {
        public enum CellValueType{isAlive, isDead}; 
        public static bool[,] CreateAndGenerateField(int x, int y)
        {
            bool[,] field = new bool[x, y];
            Random fieldRand = new Random();
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
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
            return field;
        }
    }
}
