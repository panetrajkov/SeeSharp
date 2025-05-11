namespace VehicleApp.Models
{
    public class Boat : Vehicle
    {
        public override string DisplayInfo()
        {
            return "I'm a boat and I do not have wheels :)";
        }

        public string Sail()
        {
            return "The boat is sailing";
        }
    }
}
