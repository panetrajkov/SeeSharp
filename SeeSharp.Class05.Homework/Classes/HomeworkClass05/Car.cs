using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HomeworkClass05
{
    class Car
    {
        public string Model { get; set; }
        public int Speed { get; set; }
        public Driver Driver { get; set; }
        public Car() { }

        public Car(string model, int speed, Driver Driver)
        {
            Model = model;
            Speed = speed;
            this.Driver = Driver;
        }

        public int CalculateSpeed(Driver Driver) => Driver.Skill * Speed;

        public void RaceCars(Car CarOne, Car CarTwo)
        {
            int speed1 = CalculateSpeed(CarOne.Driver);
            int speed2 = CalculateSpeed(CarTwo.Driver);
            if (speed1 > speed2)
            {
                Console.WriteLine($"First car {CarOne} is faster than the other car");
            }
            else
            {
                Console.WriteLine($"Second car {CarTwo} is faster than the first car");
            }
        }

        public override string ToString()
        {
            return $"Model: {Model}, Speed: {Speed}, Driver: {Driver}";
        }
    }
}
