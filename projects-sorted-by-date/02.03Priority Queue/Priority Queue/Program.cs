using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Priority_Queue
{
    interface IPriorityQueue<T>
    {
        
        void Enqueue(T item, int priority);

        T Dequeue();

        int Count { get; }

    }
    public class MyPriorityQueue<T> : IPriorityQueue<T>
    {
        /***поля***/
        //начало очереди
        private int head = 0;
        //конец очереди
        private int tail = 0;
        //хранилище для элементов
        private List<T> priorityQueue = new List<T>();
        /************************/
        /***методы***/
        public void Enqueue(T item, int priority)
        {
            priorityQueue.Add(item);
            tail++;
        }
        public T Dequeue()
        {
            //если конец - это не начало
            if (head != tail)
            {
                T tmp = priorityQueue[head];
                //удаляем элемент с начала очереди
                priorityQueue.RemoveAt(head);
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
                return priorityQueue.Count;
            }
        }
        public T this[int index]
        {
            get
            {
                return priorityQueue[index];
            }
        }
    }
    class MyStringPQueue : IPriorityQueue<string>
    {

        public void Enqueue(string item, int priority)
        {
            throw new NotImplementedException();
        }

        public string Dequeue()
        {
            throw new NotImplementedException();
        }

        public int Count
        {
            get { throw new NotImplementedException(); }
        }
    }
    class Part
    {
        string name;
        int d;
        public Part(string name, int d)
        {
            this.name = name;
            this.d = d;
        }
        public string Name
        {
            get
            {
                return name;
            }
        }
    }
    struct Student
    {
        string name;
        int age;
    }
    class Program
    {
        static void GetElementFromPriorityQueue<T>(IPriorityQueue<T> q)
        {
            Console.WriteLine(q.Dequeue());
        }
        static void Main(string[] args)
        {
            List<Part> parts = new List<Part>();
            parts.Add(new Part("Vlad",24));
            parts.Add(new Part("Meggy",252));
            parts.Add(new Part("Ira",412));
            parts.Add(new Part("Lianna",24));
            parts.Add(new Part("Tanya",215));
            //предикат
            //предикат - это метод, который позволяет определить удовлетворяет ли критериям заданный объект
            Part newPart = parts.Find(x => x.Name.Contains("a"));
            Console.WriteLine(newPart.Name);
            Part newPart2 = parts.FindLast(x => x.Name.Contains("a"));
            Console.WriteLine(newPart2.Name);
        }
    }
}
