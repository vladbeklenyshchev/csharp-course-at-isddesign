using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPersonCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            MyPersonCollection c = new MyPersonCollection();
            c.Add(new Person() { firstName = "Vlad", lastName = "Bekleneshev", birthDate = new DateTime(1994, 08, 23), middleName = "Igorovich", gender = GenderType.male });
        }
    }
}
