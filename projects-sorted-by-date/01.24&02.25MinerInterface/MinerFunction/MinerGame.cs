using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinerFunction
{
    public class MinerGame : IMinerGame
    {
        //..поля данных
        private int[,] _field = null;
        //количество бомб
        private int _bombs = 0;
        //количество пустых клеток
        private int _notBombs = 0;
        private bool _isGoodWork = false;
        private bool _isWorkCompleted = false;
        //количество строк
        private int height = 0;
        //количество столбцов
        private int width = 0;
        /******************/
        //конструктор
        public MinerGame(int m, int n)
        {
            //выделим память
            _field = new int[m, n];
            _bombs = (m * n) / 2;
            _notBombs = (m * n) - _bombs;
            height = m;
            width = n;
        }
        //..методы
        //инициализация поля - пустыми клетками (без бомб)
        public void InitField()
        {
            for (int j = 0; j < this.Height; j++)
                for (int k = 0; k < this.Width; k++)
                    this[j, k] = 0;
        }
        //рандомно выбираем где будут находится бомбы - ГДЕ-ТО здесь баг :(
        public void BombsRandomGeneration(Random rand)
        {
            int bombsLeft = this.NumberOfBombs;
            for (int j = 0; j < this.Height && bombsLeft != 0; j++)
            {
                for (int k = 0; k < this.Width && bombsLeft != 0; k++)
                {
                    this[j, k] = rand.Next(0, 2);
                    if (this[j, k] == 1) bombsLeft--;
                }
            }
        }
        //метод возвращает:
        //1 - если была найдена бомба
        //2 - если была найдена пустая клетка (клетка помечается)
        //0 - если поле было очищено
        public int CheckCell(int idRow, int idColumn)
        {
            //если 1, то в ячейке находится бомба (X)
            if (_field[idRow, idColumn] == 1)
            {
                IsGoodWork = false;
                return 1;
            }
            else
            {
                //если 0 (-), то я в ячейке нету бомбы и в неё записывается 2 (+)
                //для того чтобы указать пользователю какие ячейки он уже открыл
                this[idRow, idColumn] = 2;
                _notBombs--;
                if (_notBombs != 0)
                    return 2;
                else
                {
                    IsGoodWork = true;
                    return 0;
                }
            }
        }
        //..свойства
        public bool IsGoodWork
        {
            get
            {
                return _isGoodWork;
            }
            set
            {
                _isWorkCompleted = true;
                _isGoodWork = value;
            }
        }
        public bool IsWorkCompleted
        {
            get
            {
                return _isWorkCompleted;
            }
        }
        //индексатор
        public int this[int index1, int index2]
        {
            //аксессоры
            set
            {
                _field[index1, index2] = value;
            }
            get
            {
                return _field[index1, index2];
            }
        }
        //свойства
        public int NotBombsLeft
        {
            get
            {
                return _notBombs;
            }
        }
        public int Height
        {
            //аксессоры
            get
            {
                return height;
            }
        }
        public int Width
        {
            //аксессоры
            get
            {
                return width;
            }
        }
        public int NumberOfBombs
        {
            get
            {
                return _bombs;
            }
        }
    }
}
