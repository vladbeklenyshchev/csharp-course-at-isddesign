using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern1
{
    interface IStudent : IReadOnlyStudent
    {
        //we know this. We have two properties
        new string Name { get;  set; }
        int Age { get; set; }
        void SetMark(Subjects s, bool mark);
    }
}
