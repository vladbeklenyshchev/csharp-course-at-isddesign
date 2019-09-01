using System;
using System.Collections.Generic;

namespace MyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            MyLinkedList<int> myLList = new MyLinkedList<int>();
            myLList.Add(23);
            myLList.Add(241);
            myLList.Add(5);
            foreach (int ml in myLList)
            {
                Console.WriteLine(ml);
            }
        }
    }
}
