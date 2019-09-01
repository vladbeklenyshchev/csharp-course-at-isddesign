using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithInterfaces
{
    interface IDrawToForm
    {
        void Draw();
    }
    interface IDrawToConsole
    {
        void Draw();
    }
    class Circle : IDrawToForm, IDrawToConsole
    {
        double round = 0.0;

        void IDrawToConsole.Draw()
        {
            Console.WriteLine("Drawing circle to Console.");
        }

        void IDrawToForm.Draw()
        {
            Console.WriteLine("Drawing circle to Form.");
        }

        public double Round
        {
            set
            {
                round = value;
            }
            get
            {
                return round;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Circle circle1 = new Circle();
            ((IDrawToForm)circle1).Draw();
            ((IDrawToConsole)circle1).Draw();
        }
    }
}