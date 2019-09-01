using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern1
{
    class Program
    {
        /*Error! Covariance!
         * static void Main(string[] args)
        {
            IList<IStudent> l = new List<IStudent>();
            l.Add(new NewStudent("vlad", 20));
            l.Add(new NewStudent("god", 30));
            PrintStudents(l);
        }*/
        static void Main(string[] args)
        {
            List<NewStudent> l = new List<NewStudent>();
            l.Add(new NewStudent("vlad", 20));
            l.Add(new NewStudent("god", 30));
            PrintStudents(l);
        }
        private static void PrintStudents(IReadOnlyList<IReadOnlyStudent> l)
        {
            //l.Name = "fksda";
            //Console.WriteLine(l.Name);

        }
    }
    
}
