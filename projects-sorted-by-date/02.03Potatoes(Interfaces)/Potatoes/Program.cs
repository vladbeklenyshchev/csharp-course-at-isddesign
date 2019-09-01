using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Potatoes
{
    interface ISphere
    {
        double Volume { get; }
    }
    interface IPotatoe
    {
        bool IsBad { get; }
    }
    class RoundPotatoe : IPotatoe, ISphere
    {
        private int isBad = 0;
        private double volume = 0.0;
        public RoundPotatoe()
        {
            Random rand = new Random();
            isBad = rand.Next(0, 2);
            volume = rand.Next(1, 6);
            volume = (4 * System.Math.PI * System.Math.Pow(volume,3))/3;
        }
        public bool IsBad 
        { 
            get 
            {
                if (isBad == 0)
                {
                    return false;
                }
                else return true;
            }
        }
        public double Volume 
        { 
            get 
            { 
                return volume;
            }
        }
        public void F()
        {

        }
    }
    class OtherPotatoe : IPotatoe, ISphere
    {
        private int isBad = 0;
        private double volume = 0.0;
        public OtherPotatoe()
        {
            Random rand = new Random();
            isBad = rand.Next(0, 2);
            volume = rand.Next(1, 6);
            volume = (4 * System.Math.PI * System.Math.Pow(volume, 3)) / 3;
        }
        public bool IsBad
        {
            get
            {
                if (isBad == 0)
                {
                    return false;
                }
                else return true;
            }
        }
        public double Volume
        {
            get
            {
                return volume;
            }
        }
        public void F()
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            RoundPotatoe potatoe = new RoundPotatoe();
            if (potatoe.IsBad) Console.WriteLine("Плохая картошка!");
            else Console.WriteLine("Хорошая картошка!");
            Console.WriteLine("Размер картошки: {0}", potatoe.Volume);
            double v = ((ISphere)potatoe).Volume;
            IPotatoe p = new OtherPotatoe();
            //берём тип на который указывает ссылка
            System.Type t = p.GetType();
            if(t.Name == typeof(RoundPotatoe).Name)
            {
                ((RoundPotatoe)p).F();
            }
            
        }
    }
}