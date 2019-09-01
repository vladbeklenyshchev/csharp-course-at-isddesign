using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poly
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public Person(string fName, string lName, int personAge)
        {
            FirstName = fName;
            LastName = lName;
            Age = personAge;
        }
        public Person() { }
        
        public override string ToString()
        {
            string personInfo;
            personInfo = string.Format("First Name = {0}; Last Name = {1}; Age = {2}", FirstName, LastName, Age);
            return personInfo;
        }
        
        public override bool Equals(object obj)
        {
            return obj.ToString() == this.ToString();
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person jason = new Person("Jason", "White", 27);
            Person kimberley = new Person("Kim", "Bower", 26);
            object o = jason;
            o = kimberley;
            if (o.Equals(kimberley))
            {
                Console.WriteLine("Ссылки показывают на один и тот же экземпляр объекта в памяти.");
            }
            else
            {
                Console.WriteLine("Ссылки показывают на разные экземпляры.");
            }
        }
    }
}