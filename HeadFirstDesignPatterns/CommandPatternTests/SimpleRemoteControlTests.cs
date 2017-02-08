using NUnit.Framework;

namespace HeadFirstDesignPatterns.CommandPatternTests
{
    [TestFixture]
    public class SimpleRemoteControlTests
    {
        [Test]
        public void ButtonWasPressed_LightIsOn()
        {
            // Arrange
            var simpleRemoteControl = new SimpleRemoteControl();
            var light = new Light();
            var lightOn = new LightOnCommand(light);
            simpleRemoteControl.SetCommand(lightOn);

            // Act
            string actual = simpleRemoteControl.ButtonWasPressed();

            // Arrange
            Assert.That(actual, Is.EqualTo("Light is On"));
        }
    }
}
