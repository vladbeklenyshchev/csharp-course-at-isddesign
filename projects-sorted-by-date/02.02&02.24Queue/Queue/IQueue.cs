using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueNM
{
    public interface IQueue<T> :IReadOnlyQueue<T>
    {
        void Put(T item);
        void AddEmpty();
    }
}
