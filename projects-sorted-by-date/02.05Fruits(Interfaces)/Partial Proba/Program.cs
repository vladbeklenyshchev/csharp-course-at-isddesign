using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partial_Proba
{
    interface Fruits
    {
        void WhatTheFruit();
    }
    partial class Apple : Fruits
    {
        public void WhatTheFruit()
        {
            Console.WriteLine("This is apple!");
        }
    }
    class Orange : Fruits
    {
        string color = "green";
        public void WhatTheFruit()
        {
            Console.WriteLine("This is orange!");
        }
    }
    class Blackberry : Fruits
    {
        string color = "green";
        public void WhatTheFruit()
        {
            Console.WriteLine("This is blackberry!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Fruits myfruit = new Apple();
            myfruit.WhatTheFruit();
        }
    }
}
