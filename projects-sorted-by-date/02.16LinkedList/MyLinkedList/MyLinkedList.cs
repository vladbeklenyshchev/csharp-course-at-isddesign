using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLinkedList
{
    class MyLinkedList<T> : ICollection<T>
    {
        //List<KeyValuePair<int, T>> storage = new List<KeyValuePair<int, T>>();
        struct Elem
        {
            private MyLinkedList<T> next;
            private T info;
        }
        List<Elem> storage = new List<Elem>();
        public void Add(T item)
        {
            //storage.Add(new KeyValuePair<int, T>(0, item));
            //storage.Add(

            Count++;
        }

        public void Clear()
        {
            storage.Clear();
        }
        #region notuseful
        public bool Contains(T item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }
        #endregion
        public int Count
        {
            get;
            private set;
        }


        public bool IsReadOnly
        {
            get { throw new NotImplementedException(); }
        }

        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }

        //метод-итератор
        public IEnumerator<T> GetEnumerator()
        {
            //throw new NotImplementedException();
            foreach (KeyValuePair<int, T> x in storage)
            {
                yield return x.Value;
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
