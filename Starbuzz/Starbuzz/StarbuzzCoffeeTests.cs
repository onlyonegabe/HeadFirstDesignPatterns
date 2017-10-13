using NUnit.Framework;
using StarBuzz;
using StarBuzz.ConcreteDecorators;

namespace Starbuzz
{
    [TestFixture]
    class StarbuzzCoffeeTests
    {
        [Test]
        public void Espresso_DisplaysExpectedDescriptionAndCost()
        {
            // Arrange
            Beverage beverage = new Espresso();
            
            // Act
            var result = $"{beverage.GetDescription()} ${beverage.Cost()}";

            // Assert
            Assert.That(result, Is.EqualTo("Espresso $1.99"));
        }

        [Test]
        public void DarkRoastDoubleMochaWithWhip_DisplaysExpectedDescriptionAndCost()
        {
            // Arrange
            Beverage beverage = new DarkRoast();
            beverage = new Mocha(beverage);
            beverage = new Mocha(beverage);
            beverage = new Whip(beverage);

            // Act
            var result = $"{beverage.GetDescription()} ${beverage.Cost()}";

            // Assert
            Assert.That(result, Is.EqualTo("Dark Roast Coffee, Mocha, Mocha, Whip $1.49"));
        }

        [Test]
        public void HouseBlendSoyMochaWhip_DisplaysExpectedDescriptionAndCost()
        {
            // Arrange
            Beverage beverage = new HouseBlend();
            beverage = new Soy(beverage);
            beverage = new Mocha(beverage);
            beverage = new Whip(beverage);

            // Act
            var result = $"{beverage.GetDescription()} ${beverage.Cost()}";

            // Assert
            Assert.That(result, Is.EqualTo("House Blend Coffee, Soy, Mocha, Whip $1.34"));
        }
    }
}
