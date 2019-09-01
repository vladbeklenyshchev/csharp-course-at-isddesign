using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueNM
{
    public interface IReadOnlyQueue<T>
    {
        //properties
        int Count { get; }
        T this[int index] { get; }
        //methods
        T Get();
        IEnumerator<T> GetEnumerator();
    }
}
