using ShapeInterface.Interface;

namespace ShapeInterface.Models
{
    public class Circle : IShape
    {
        public double Radius { get; set; } = 0;
        public double Diameter { get; set; } = 0;

        public Circle(double radius, double diameter)
        {
            Radius = radius;
            Diameter = diameter;
        }

        public Circle()
        {
        }

        public void GetArea()
        {
            Console.WriteLine("Would you like to measure the area or diameter of the circle? (a/d)");
            string userChoice = Console.ReadLine();

            if (userChoice.ToLower() == "a")
            {
                Console.WriteLine("Enter the radius of the circle: ");
                string userInput = Console.ReadLine();
                bool radiusConversion = double.TryParse(userInput, out double radius);

                if (radiusConversion)
                {
                    double pi = 3.14;
                    double area = pi * radius * radius;
                    double diameter = 2 * radius;

                    Console.WriteLine($"You entered radius: {radius}. \nThe area of the circle is: {area}.");
                }
            }
            else if (userChoice.ToLower() == "d")
            {
                Console.WriteLine("Enter the radius of the circle: ");
                string userInput = Console.ReadLine();
                bool radiusConversion = double.TryParse(userInput, out double radius);

                if (radiusConversion)
                {
                    double diameter = 2 * radius;
                    Console.WriteLine($"You entered radius: {radius}. \nThe diameter of the circle is: {diameter}.");
                }
            }
        }
    }
}
