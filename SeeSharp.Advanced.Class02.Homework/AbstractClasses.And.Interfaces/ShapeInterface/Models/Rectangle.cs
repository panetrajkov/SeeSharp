using ShapeInterface.Interface;

namespace ShapeInterface.Models
{
    public class Rectangle : IShape
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public Rectangle()
        {
        }

        public void GetArea()
        {
            Console.WriteLine("Would you like to measure the area or perimeter of the rectangle? (a/p)");
            string userChoice = Console.ReadLine();

            if (userChoice.ToLower() == "a")
            {
                Console.WriteLine("Enter the base of the rectangle: ");
                string baseInput = Console.ReadLine();
                bool baseConversion = double.TryParse(baseInput, out double baseVal);

                Console.WriteLine("Enter the height of the rectangle: ");
                string heightInput = Console.ReadLine();
                bool heightConversion = double.TryParse(heightInput, out double heightVal);

                double area = baseVal * heightVal;
                Console.WriteLine($"The area of the rectangle is: {area}.");
            }
            else if (userChoice.ToLower() == "p")
            {
                Console.WriteLine("Enter the base of the rectangle: ");
                string baseInput = Console.ReadLine();
                bool baseConversion = double.TryParse(baseInput, out double baseVal);

                Console.WriteLine("Enter the height of the rectangle: ");
                string heightInput = Console.ReadLine();
                bool heightConversion = double.TryParse(heightInput, out double heightVal);
                double perimeter = baseVal + baseVal + heightVal + heightVal;

                Console.WriteLine($"The perimeter of the rectangle is: {perimeter}.");

            }
        }
    }
}
