using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(char.IsWhiteSpace("Hello, World!",6));
            DateTime dt = new DateTime(2015,01,17);
            dt = dt.AddMonths(3);
            Console.WriteLine(dt);
        }
    }
}
