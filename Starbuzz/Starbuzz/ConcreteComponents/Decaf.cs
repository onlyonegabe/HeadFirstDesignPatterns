using System;

namespace StarBuzz
{
    public class Decaf : Beverage
    {
        public Decaf()
        {
            description = "Decaf";
        }

        public override double Cost()
        {
            return 1.05;
        }
    }
}
