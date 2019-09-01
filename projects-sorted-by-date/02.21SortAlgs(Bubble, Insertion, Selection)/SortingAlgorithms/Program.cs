using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    class Program
    {
        static void InsertionSort<T>(ref T[] a) where T : IComparable<T>
        {
            T key;
            for (int j = 1, i = 0; j < a.Length; j++)
            {
                key = a[j];
                for (i = j - 1; i >= 0 && a[i].CompareTo(key) > 0; i--)
                {
                    //copy element
                    a[i + 1] = a[i];
                }
                //we have found the place for key
                a[i + 1] = key;
            }
        }
        static void BubbleSort<T>(ref T[] a) where T : IComparable<T>
        {
            for (int i = 0; i < a.Length; i++) // n
            {
                for (int j = 0; j < a.Length - i - 1; j++)
                {
                    if (a[j].CompareTo(a[j+1]) > 0)
                    {
                        //swaping
                        T tmp = a[j+1];
                        a[j+1] = a[j];
                        a[j] = tmp;
                    }
                }
            }
        }
        static void SelectionSort <T> (ref T[] a) where T : IComparable<T>
        {
            for(int i = 0; i < a.Length-1; i++)
                for(int j = i+1; j < a.Length; j++)
                    if (a[i].CompareTo(a[j]) > 0)
                    {
                        //swaping
                        T tmp = a[j];
                        a[j] = a[i];
                        a[i] = tmp;
                    }
        }
        static void Main(string[] args)
        {
            int[] a = {10,23,1,-1,7,3};
            Console.WriteLine("Choose your variant of sort.");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    InsertionSort(ref a);
                    Console.WriteLine("Insertion sort testing...");
                    break;
                case 2:
                    BubbleSort(ref a);
                    Console.WriteLine("Bubble sort testing...");
                    break;
                case 3:
                    SelectionSort(ref a);
                    Console.WriteLine("Selection sort testing...");
                    break;
            }
            foreach (int x in a)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine();
        }
    }
}
