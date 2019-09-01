using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QueueNM;
namespace QueueNM
{
    class Program
    {
        static void PrintQueue<T>(IReadOnlyQueue<T> q)
        {
            Console.WriteLine("Queue:");
            foreach(T item in q)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            IQueue<int> q1 = new Queue<int>();
            int choice = 0;
            int item = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("1. Put an item.");
                Console.WriteLine("2. Get an item.");
                Console.WriteLine("3. Print queue.");
                Console.WriteLine("0. Exit.");
                Console.Write("Your choice: ");
                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch (System.FormatException e)
                {
                    choice = -1;
                    continue;
                }
                switch (choice)
                {
                    case 1:
                        //добавить элемент
                        try
                        {
                            Console.Write(">");
                            item = int.Parse(Console.ReadLine());
                        }
                        catch(System.FormatException e)
                        {
                            Console.WriteLine("Try to put an item again :)");
                            break;
                        }
                        q1.Put(item);
                        Console.WriteLine(String.Format("Put {0}.", item));
                        break;
                    case 2:
                        //удалить элемент
                        try
                        {
                            item = q1.Get();
                        }
                        catch(System.Exception e)
                        {
                            Console.WriteLine("Underflow!!!");
                            break;
                        }
                        Console.WriteLine(String.Format("Get {0}.", item));
                        break;
                    case 3:
                        //распечатать очередь
                        PrintQueue(q1);
                        break;
                    case 0:
                        //выход
                        Console.WriteLine("Goodbye!");
                        break;
                    default:
                        break;
                }
                Console.ReadKey(true);
            } while (choice != 0);
        }
    }
}
