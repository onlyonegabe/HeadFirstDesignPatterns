namespace HeadFirstDesignPatterns
{
    public class SimpleRemoteControl
    {
        private ICommand slot;

        public SimpleRemoteControl()
        {

        }

        public void SetCommand(ICommand command)
        {
            slot = command;
        }

        public string ButtonWasPressed()
        {
            return slot.Execute();
        }
    }
}
