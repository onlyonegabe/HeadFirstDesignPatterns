namespace HeadFirstDesignPatterns.CommandPattern
{
    public class GarageDoor
    {
        public string Up()
        {
            return "Garage Door is Open";
        }

        public string Down()
        {
            return "Garage Door is Closed";
        }

        public string Stop()
        {
            return "Stop";
        }

        public string LightOn()
        {
            return "LightOn";
        }

        public string LightOff()
        {
            return "LightOff";
        }
    }
}
