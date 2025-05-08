namespace ShapeAbstractClass.Classes
{
    public class Triangle : Shape
    {
        public double Main { get; set; } = 0;
        public double Height { get; set; } = 0;
        public double Side { get; set; } = 0;

        public Triangle(double main, double height, double side)
        {
            Main = main;
            Height = height;
            Side = side;
        }

        public Triangle() { }

        public override double CalculateArea()
        {
            Console.Write("Enter the main side of the triangle: ");
            string mainInput = Console.ReadLine();
            bool mainConversion = double.TryParse(mainInput, out double mainVal);

            Console.Write("Enter the height of the triangle: ");
            string heightInput = Console.ReadLine();
            bool heightConversion = double.TryParse(heightInput, out double heightVal);

            double area = (mainVal * heightVal) / 2;
            Console.WriteLine($"For base {mainVal} and height {heightVal}, the area is: {area}.");
            return area;
        }

        public override double CalculatePerimeter()
        {
            Console.Write("Enter the main side of the triangle: ");
            string mainInput = Console.ReadLine();
            bool mainConversion = double.TryParse(mainInput, out double mainVal);

            Console.Write("Enter the side of the triangle: ");
            string sideInput = Console.ReadLine();
            bool sideConversion = double.TryParse(sideInput, out double sideVal);

            double perimeter = mainVal + (2 * sideVal);
            Console.WriteLine($"For base {mainVal} and side {sideVal}, the perimeter is: {perimeter}.");
            return perimeter;
        }
    }
}
