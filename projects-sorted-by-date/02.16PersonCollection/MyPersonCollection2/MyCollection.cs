using System;
using System.Collections.Generic;
using System.Collections;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPersonCollection2
{
    class MyCollection : Collection<string>
    {
        override void InsertItem(int index, string item)
        {
            Console.WriteLine(string.Format("Элемент {0} загружается в коллекцию.", item));
            base.InsertItem(index, item);
        }

        override void Remove(string item)
        {
            Console.WriteLine(string.Format("Элемент {0} удаляется из коллекции.", item));
            base.Remove(item);
        }

        override void SetItem(int index, string item)
        {
            Console.WriteLine(string.Format("Элемент {0} загружается в коллекцию.", item));
            base.SetItem(index, item);
        }
    }
}
