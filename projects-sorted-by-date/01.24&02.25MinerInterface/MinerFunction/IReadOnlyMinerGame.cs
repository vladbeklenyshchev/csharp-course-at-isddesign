using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinerFunction
{
    public interface IReadOnlyMinerGame
    {
        //свойства
        bool IsGoodWork { get; }
        bool IsWorkCompleted { get; }
        int this[int index1, int index2] { get; }
        int NotBombsLeft { get; }
        int Height { get; }
        int Width { get; }
        int NumberOfBombs { get; }
        //методы
        int CheckCell(int idRow, int idColumn);
    }
}
