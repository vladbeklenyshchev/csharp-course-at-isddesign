using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithGenerics
{
    interface IPopable<out T>
    {
        T Pop();
    }
    class Stack<T> : IPopable<T>
    {

        public T Pop()
        {
            ;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
