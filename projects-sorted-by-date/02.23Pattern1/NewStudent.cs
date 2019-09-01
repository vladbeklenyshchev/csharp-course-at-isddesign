using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern1
{
    class NewStudent : IStudent
    {
        private string name = "";

        int age = 0;

        Dictionary<Subjects, bool> dMarks;

        public NewStudent(string name, int age)
        {
            this.name = name;
            this.age = age;
            dMarks = new Dictionary<Subjects, bool>();
        }

        public string Name
        {
            get
            {
                //return name;
                return ((IReadOnlyStudent)this).Name;
            }
            set
            {
                name = value;
            }
        }

        string IReadOnlyStudent.Name
        {
            get
            {
                return name;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
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

        public bool IsSessionPassed()
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
    }
}
