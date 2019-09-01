using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloneablePoint
{
    public class Point : ICloneable
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int xPos, int yPos)
        {
            X = xPos;
            Y = yPos;
        }
        public Point() { }

        public string ToString()
        {
            return string.Format(" X = {0}; Y = {1}", X, Y);
        }

        public object Clone()
        {
            return new Point(this.X, this.Y);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(23, 1);
            Point p2 = (Point)p1.Clone();

            Console.WriteLine(p1.ToString());
            Console.WriteLine(p2.ToString());
        }
    }
}
