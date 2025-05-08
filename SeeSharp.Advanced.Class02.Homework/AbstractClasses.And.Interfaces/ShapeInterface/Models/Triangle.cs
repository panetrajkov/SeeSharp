using ShapeInterface.Interface;

namespace ShapeInterface.Models
{
    public class Triangle : IShape
    {
        public double Main { get; set; }
        public double Height { get; set; }
        public double Side { get; set; }

        public Triangle(double main, double height, double side)
        {
            Main = main;
            Height = height;
            Side = side;
        }

        public Triangle()
        {
        }

        public void GetArea()
        {
            Console.WriteLine("Would you like to measure the area or perimeter of the triangle? (a/p)");
            string userChoice = Console.ReadLine();

            if (userChoice.ToLower() == "a")
            {
                Console.WriteLine("Enter the main of the triangle: ");
                string mainInput = Console.ReadLine();
                bool mainConversion = double.TryParse(mainInput, out double mainVal);

                Console.WriteLine("Enter the height of the triangle: ");
                string heightInput = Console.ReadLine();
                bool heightConversion = double.TryParse(heightInput, out double heightVal);

                double area = (mainVal * heightVal) / 2;
                Console.WriteLine($"The area of the triangle is: {area}.");
            }
            else if (userChoice.ToLower() == "p")
            {
                Console.WriteLine("Enter the length of side A: ");
                string sideAInput = Console.ReadLine();
                bool sideAConversion = double.TryParse(sideAInput, out double sideA);

                Console.WriteLine("Enter the length of side B: ");
                string sideBInput = Console.ReadLine();
                bool sideBConversion = double.TryParse(sideBInput, out double sideB);

                Console.WriteLine("Enter the length of side C: ");
                string sideCInput = Console.ReadLine();
                bool sideCConversion = double.TryParse(sideCInput, out double sideC);

                double perimeter = sideA + sideB + sideC;
                Console.WriteLine($"The perimeter of the triangle is: {perimeter}.");
            }
        }
    }
}
