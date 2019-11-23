using System;
using System.Collections.Generic;
using System.Text;

namespace PartyCodding
{
    public class Cow : Animal, IFlyable
    {
        public int BreastSize { get; set; }
        public FlightPower FlightPower { get; set; }
        public void Fly()
        {
            Console.WriteLine($"Cow flies via {FlightPower}. Cow throws a mine from above");
        }

        public override string StoryAboutYourself()
        {
            return base.StoryAboutYourself()
                + $". My breast size is {BreastSize}";
        }

    }
}
