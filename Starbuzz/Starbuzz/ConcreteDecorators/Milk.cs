using System;

namespace StarBuzz.ConcreteDecorators
{
    class Milk : CondimentDecorator
    {
        public Milk()
        {
            description = "Milk";
        }

        public override double Cost()
        {
            return .10;
        }

        public override string GetDescription()
        {
            return description;
        }
    }
}
