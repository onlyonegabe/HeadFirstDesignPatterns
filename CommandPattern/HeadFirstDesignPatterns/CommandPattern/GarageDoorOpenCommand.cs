namespace HeadFirstDesignPatterns.CommandPattern
{
    public class GarageDoorOpenCommand : ICommand
    {
        private GarageDoor garageDoor;

        public GarageDoorOpenCommand(GarageDoor garageDoor)
        {
            this.garageDoor = garageDoor;
        }

        public string Execute()
        {
            return garageDoor.Up();
        }
    }
}
