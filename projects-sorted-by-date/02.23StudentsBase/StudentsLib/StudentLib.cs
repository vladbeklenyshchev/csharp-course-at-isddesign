using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsLib
{
    public struct Student : IComparable<Subjects>
    {
        string name;
        int age;
        Dictionary<Subjects, bool> dMarks;
        public Student(string name, int age)
        {
            this.name = name;
            this.age = age;
            dMarks = new Dictionary<Subjects, bool>();
        }
        public void SetMark(Subjects s, bool mark)
        {
            dMarks.Add(s, mark);
        }
        public bool GetMark(Subjects s)
        {
            if (dMarks.ContainsKey(s))
            {
                return dMarks[s];
            }
            else
            {
                return false;
            }
        }
        public bool IsPassSession()
        {
            foreach (bool b in dMarks.Values)
            {
                if (!b)
                {
                    return false;
                }
            }
            return true;
        }
        public string Name
        {
            get
            {
                return name;
            }
        }

        public int CompareTo(Subjects other)
        {
            throw new NotImplementedException();
            //Student temp = other as Student;
            //if(temp
            /*if(this.dMarks[other] > other)
            {
                return 1;
            }
            */
        }
    }
    public enum Subjects
    {
        mathematics,
        phisics,
        biology,
        informatics
    }
    struct SubStudent : IComparer
    {
        public int Compare(object x, object y)
        {
            throw new NotImplementedException();
            
        }
    }
}