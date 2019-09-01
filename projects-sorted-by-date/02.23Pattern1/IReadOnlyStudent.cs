using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern1
{
    public enum Subjects
    {
        mathematics,
        phisics,
        biology,
        informatics
    }
    interface IReadOnlyStudent
    {
        string Name { get; }
        bool GetMark(Subjects s);
        bool IsSessionPassed();
    }
}
