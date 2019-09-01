using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyList
{
    public class MyList<T> : IList<T>, IEnumerable<T>
    {
        T[] array = null;

        int count = 0;

        int capacity = 0;

        public MyList()
        {
            capacity = 5;
            array = new T[capacity];
        }

        public int IndexOf(T item)
        {
            return Array.FindIndex<T>(array, 0, this.Count, (element) => { return element.Equals(item); });
        }

        public void Insert(int index, T item)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            //уменьшаю на 1
            capacity -= 1;
            T[] tmp = new T[capacity];
            for (int i = 0; i < array.Length; i++)
            {
                if (i == index)
                {
                    tmp[i] = array[i + 1];
                }
                else tmp[i] = array[i];
            }
            array = tmp;
            count = count - 1;
        }

        public T this[int index]
        {
            get
            {
                return array[index];
            }
            set
            {
                array[index] = value;
            }
        }

        public void Add(T item)
        {
            if (count < capacity)
            {
                array[count] = item;
            }
            else
            {
                capacity = array.Length * 2;
                T[] tmp = new T[capacity];
                for (int i = 0; i < array.Length; i++)
                {
                    tmp[i] = array[i];
                }
                array = tmp;
                array[count] = item; 
            }
            count++;
        }

        public void Clear()
        {
            //в начальное состояние
            capacity = 5;
            T[] tmp = new T[capacity];
            array = tmp;
            count = 0;
        }

        public bool Contains(T item)
        {
            return this.IndexOf(item) >= 0;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public int Count
        {
            get { return count; }
        }

        public bool IsReadOnly
        {
            get { throw new NotImplementedException(); }
        }

        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();

            //return array[count];
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            //throw new NotImplementedException();
            return this.GetEnumerator();
        }
    }
    class Program
    {
        static void Print<T>(MyList<T> ml)
        {
            for(int i = 0; i < ml.Count; i++)
            {
                Console.Write(ml[i] + " ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            MyList<int> li = new MyList<int>();
            li.Add(23);
            li.Add(12);
            li.Add(242);
            li.Add(241);
            li.Add(41);
            li.Add(51);
            Print(li);
        }
    }
}
