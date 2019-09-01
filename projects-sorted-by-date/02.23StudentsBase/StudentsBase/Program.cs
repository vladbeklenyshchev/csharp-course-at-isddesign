using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentsLib;

namespace StudentsBase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сколько будет студентов?");
            int quantity = 0;
            quantity = int.Parse(Console.ReadLine());
            List<Student> s = new List<Student>(10);
            string name = null;
            int age = 0;
            //инициализация студентов
            for (int i = 0; i < quantity; i++)
            {
                Console.Write("Введите имя студента: ");
                name = Console.ReadLine();
                Console.Write("Введите возраст: ");
                age = int.Parse(Console.ReadLine());
                s.Add(new Student(name, age));
            }
            int choice = 0; 
            Subjects subject = Subjects.mathematics;
            do
            {
                Console.Clear();
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Сдать сессию.");
                Console.WriteLine("2. Узнать результаты сессии конкретного студента.");
                Console.WriteLine("3. Список всех студентов сдавших сессию.");
                Console.WriteLine("4. Рейтинг студентов на основе сданных ими экзаменов.");
                Console.WriteLine("0. Выход.");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        //инициализация предметов, которые были сданы/не сданы
                        for (int i = 0; i < quantity; i++)
                        {
                            for (int j = 0; j < 4; j++)
                            {
                                if (j == 0)
                                {
                                    subject = Subjects.mathematics;
                                }
                                else if (j == 1)
                                {
                                    subject = Subjects.phisics;
                                }
                                else if (j == 2)
                                {
                                    subject = Subjects.biology;
                                }
                                else if (j == 3)
                                {
                                    subject = Subjects.informatics;
                                }
                                Console.WriteLine(string.Format("Сдал ли {0} {1}? 0 - не сдал, 1 - сдал", s[i].Name, subject.ToString()));
                                if (int.Parse(Console.ReadLine()) == 0)
                                {
                                    s[i].SetMark(subject, false);
                                }
                                else
                                {
                                    s[i].SetMark(subject, true);
                                }
                            }
                        }
                        break;
                    case 2:
                        //узнать сдал ли студент экзамен
                        Console.Write("Введите имя студента: ");
                        string inputName = Console.ReadLine();
                        Student foundedStudent;
                        if(s.Exists(x => x.Name.Contains(inputName)))
                        {
                            foundedStudent = s.Find(x => x.Name.Contains(inputName));
                        }
                        else
                        {
                            Console.WriteLine("Такого студента в списке нету :(");
                            break;
                        }
                        Console.WriteLine("Какой предмет Вас интересует?");
                        Console.WriteLine("0. Математика.");
                        Console.WriteLine("1. Физика.");
                        Console.WriteLine("2. Биология.");
                        Console.WriteLine("3. Информатика.");
                        subject = (Subjects)Int32.Parse(Console.ReadLine());
                        if (foundedStudent.GetMark(subject))
                        {
                            Console.WriteLine(string.Format("Студент {0} сдал {1}",
                                foundedStudent.Name, subject.ToString()));
                        }
                        else
                        {
                            Console.WriteLine(string.Format("Студент {0} не сдал {1}",
                                foundedStudent.Name, subject.ToString()));
                        }
                        break;
                    case 3:
                        List<Student> passStudents = s.FindAll(x => x.IsPassSession());
                        foreach (Student student in passStudents)
                        {
                            Console.WriteLine(student.Name);
                        }
                        break;
                    case 4:
                        if (s.TrueForAll(x => x.IsPassSession()))
                        {
                            Console.WriteLine("Все студенты сдали сессию! :)");
                        }
                        else
                        {
                            s.Sort();
                        }
                        break;
                    case 0:
                        break;
                }
                Console.Write("Нажмите любую клавишу...");
                Console.ReadKey(true);
            } while (choice!=0);

        }
        private static void PrintStudents(IReadOnlyList<Student> l)
        {
            l.Clear();
        }
    }
}
