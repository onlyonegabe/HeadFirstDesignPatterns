namespace HeadFirstDesignPatterns
{
    public class LightOnCommand : ICommand
    {
        private Light light;

        public LightOnCommand(Light light)
        {
            this.light = light;
        }

        public string Execute()
        {
            return light.On();
        }
    }
}
