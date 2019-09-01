using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace MyPersonCollection
{
    enum GenderType
    {
        male,
        female
    }
    struct Person
    {
        public string firstName;
        public string lastName;
        public string middleName;

        public DateTime birthDate;
        public GenderType gender;
    }
    class MyPersonCollection : KeyedCollection<Tuple<string, string, string, DateTime>,Person>
    {
        Tuple<string, string, string, DateTime> storage;

        public MyPersonCollection()
        {

        }
        
        public new void Add(Person p)
        {
            storage = new Tuple<string, string, string, DateTime>(p.firstName, p.lastName, p.middleName, p.birthDate);
        }

        protected override Tuple<string, string, string, DateTime> GetKeyForItem(Person item)
        {
            return storage;
        }
    }
}
