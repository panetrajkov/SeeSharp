namespace VehicleApp.Models
{
    public class Car : Vehicle
    {
        public override string DisplayInfo()
        {
            return "I'm a car and I drive on 4 wheels :)";
        }
        public string Drive()
        {
            return "The car is driving";
        }


    }
}
