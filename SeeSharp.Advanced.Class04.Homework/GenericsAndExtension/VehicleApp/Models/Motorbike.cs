namespace VehicleApp.Models
{
    public class MotorBike : Vehicle
    {
        public override string DisplayInfo()
        {
            return "I'm a motorbike and I drive on 2 wheels :)";
        }

        public string Wheelie()
        {
            return "The motorbike is driving on one wheel";
        }
    }
}
