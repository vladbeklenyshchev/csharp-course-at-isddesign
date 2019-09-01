using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueNM
{
    public class Queue<T> : IQueue<T>,
        IEnumerable<T> where T : new()
    {
        /***поля***/
        //начало очереди
        private int head = 0;
        //конец очереди
        private int tail = 0;
        //хранилище для элементов
        private List<T> listQueue = new List<T>();
        /************************/
        /***методы***/
        public void Put(T item)
        {
            listQueue.Add(item);
            tail++;
        }
        public void AddEmpty()
        {
            listQueue.Add(new T());
        }
        public T Get()
        {
            //если конец - это не начало
            if (head != tail)
            {
                T tmp = listQueue[head];
                //удаляем элемент с начала очереди
                listQueue.RemoveAt(head);
                //память перераспределилась
                //конец очереди сдвинулся
                tail = tail - 1;
                return tmp;
            }
            else
            {
                throw new System.Exception();
            }
        }
        //свойства
        public int Count
        {
            get
            {
                return listQueue.Count;
            }
        }
        public T this[int index]
        {
            get
            {
                return listQueue[index];
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return listQueue.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
