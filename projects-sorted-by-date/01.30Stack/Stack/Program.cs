using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Program
    {
        class MyStack <T> : IEnumerable<T>
        {
            public void Push(T number)
            {
                l.Add(number);
                count++;
            }
            public T Pop()
            {
                T tmp = l[count - 1];
                if (count != 0)
                {
                    l.RemoveAt(count - 1);
                    count--;
                }
                return tmp ;
            }
            private List<T> l = new List<T>();
            public T this[int index]
            {
                get { return l[index]; }
            }
            public int Count
            {
                get{ return l.Count;} 
            }
            int count = 0;

            public IEnumerator<T> GetEnumerator()
            {
                //throw new NotImplementedException();
               // return l.GetEnumerator();
                /*foreach (T item in l)
                {
                    yield return item;
                }*/
                return new LocalEnumerator(this);
            }
            System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
            {
                return this.GetEnumerator();
                //throw new NotImplementedException();
            }
            private class LocalEnumerator : IEnumerator<T>
            {
                private MyStack<T> parent;
                private int index = 0;
                public LocalEnumerator(MyStack<T> s)
                {
                    parent = s;
                    index = -1;
                }
                public T Current
                {
                    //get { throw new NotImplementedException(); }
                    get { return parent.l[index];}
                }

                public void Dispose()
                {
                    //throw new NotImplementedException();
                }

                object System.Collections.IEnumerator.Current
                {
                    //get { throw new NotImplementedException(); }
                    get { return this.Current; }
                }

                public bool MoveNext()
                {
                    //throw new NotImplementedException();
                    index++;
                    return index < parent.Count;
                }

                public void Reset()
                {
                    index = -1;
                    //throw new NotImplementedException();
                }
            }
        }
        static void PrintStack<T>(MyStack<T> s)
        {
            for (int i = 0; i < s.Count; i++)
            {
                Console.Write(s[i] + " ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            MyStack<int> s1 = new MyStack<int>();
            s1.Push(3);
            s1.Push(4);
            s1.Push(1);
            PrintStack(s1);
            s1.Push(-2);
            s1.Push(341);
            s1.Pop();
            //PrintStack(s1);
            foreach (int item in s1)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
