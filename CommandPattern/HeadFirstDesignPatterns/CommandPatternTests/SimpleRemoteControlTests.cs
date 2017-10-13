using HeadFirstDesignPatterns.CommandPattern;
using NUnit.Framework;

namespace HeadFirstDesignPatterns.CommandPatternTests
{
    [TestFixture]
    public class SimpleRemoteControlTests
    {
        private SimpleRemoteControl simpleRemoteControl;

        [SetUp]
        public void SetUp()
        {
            simpleRemoteControl = new SimpleRemoteControl();
        }

        [Test]
        public void ButtonWasPressed_ForLight_LightIsOn()
        {
            // Arrange
            var light = new Light();
            var lightOn = new LightOnCommand(light);
            simpleRemoteControl.SetCommand(lightOn);

            // Act
            string actual = simpleRemoteControl.ButtonWasPressed();

            // Assert
            Assert.That(actual, Is.EqualTo("Light is On"));
        }

        [Test]
        public void ButtonWasPressed_ForGarageDoor_GarageDoorIsOpen()
        {
            // Arrange
            var garageDoor = new GarageDoor();
            var garageDoorOpenCommand = new GarageDoorOpenCommand(garageDoor);
            simpleRemoteControl.SetCommand(garageDoorOpenCommand);

            // Act
            string actual = simpleRemoteControl.ButtonWasPressed();

            // Assert
            Assert.That(actual, Is.EqualTo("Garage Door is Open"));
        }
    }
}
