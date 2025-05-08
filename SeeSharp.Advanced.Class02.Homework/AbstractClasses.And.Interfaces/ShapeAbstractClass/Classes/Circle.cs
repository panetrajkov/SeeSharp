namespace ShapeAbstractClass.Classes
{
    public class Circle : Shape
    {
        public double Radius { get; set; } = 0;

        public Circle(double radius)
        {
            Radius = radius;
        }

        public Circle() { }

        public override double CalculateArea()
        {
            Console.Write("Enter the radius of the circle: ");
            string input = Console.ReadLine();
            bool radiusConversion = double.TryParse(input, out double radius);

            double pi = 3.14;
            double area = pi * radius * radius;

            Console.WriteLine($"For radius {radius}, the area is: {area}.");
            return area;
        }

        public override double CalculatePerimeter()
        {
            Console.Write("Enter the radius of the circle: ");
            string input = Console.ReadLine();
            bool radiusConversion = double.TryParse(input, out double radius);

            double diameter = 2 * radius;
            double pi = 3.14;
            double perimeter = pi * diameter;

            Console.WriteLine($"For radius {radius}, the perimeter is: {perimeter}.");
            return perimeter;
        }
    }
}
