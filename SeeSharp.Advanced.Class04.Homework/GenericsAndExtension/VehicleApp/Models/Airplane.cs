namespace VehicleApp.Models
{
    public class Airplane : Vehicle
    {
        public override string DisplayInfo()
        {
            return "I'm a plane and I have a couple of wheels :)";
        }

        public string Fly()
        {
            return "The airplane is flying";
        }
    }
}
