using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinerFunction
{
    public interface IMinerGame : IReadOnlyMinerGame
    {
        //свойства
        new bool IsGoodWork { get; set; }
        new int this[int index1, int index2] { get; set; }
        //методы
        void InitField();
        void BombsRandomGeneration(Random rand);
    }
}
