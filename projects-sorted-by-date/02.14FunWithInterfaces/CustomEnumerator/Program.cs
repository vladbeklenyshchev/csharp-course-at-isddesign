using System.Collections;
using System;

namespace CustomEnumerator
{
    class Car
    {
        //private string nameOfCar = null;
        //private string color = null;

        public Car()
        {
            Name = "noname";
            Color = "transparent";
        }
        public Car(string nameOfCar, string color)
        {
            Name = nameOfCar;
            Color = color;
        }

        public string Name
        {
            get; 
            set;
        }
        public string Color
        {
            get;
            set;
        }
        
    }
    class Garage : IEnumerable
    {
        private Car[] carArray = new Car[4];

        public Garage()
        {
            carArray[0] = new Car("Bentley", "black");
            carArray[1] = new Car("Mersedes", "white");
            carArray[2] = new Car("Infinity", "violet");
            carArray[3] = new Car("Porshe", "yellow");
        }

        public IEnumerator GetEnumerator()
        {
            return carArray.GetEnumerator();
        }
        /*IEnumerator IEnumerable.GetEnumerator()
        {
            return carArray.GetEnumerator();
        }*/
    }
    class Program
    {
        static void Main(string[] args)
        {
            Garage myGarage = new Garage();
            foreach (Car c in myGarage)
            {
                Console.WriteLine("Name = {0} ; color = {1}", c.Name, c.Color);
            }
            //IEnumerator i = myGarage.GetEnumerator();
        }
    }
}
