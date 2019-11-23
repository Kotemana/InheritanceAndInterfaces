using System;
using System.Collections.Generic;
using System.Text;

namespace PartyCodding
{
    public class Pegasus : Animal, IFlyable
    {
        public FlightPower FlightPower { get ; set; }

        public void Fly()
        {
            Console.WriteLine($"I'm pegasus. I fly using {FlightPower} I can fly and can have 1 rider on my back");
        }

        public override string StoryAboutYourself()
        {
            return base.StoryAboutYourself()+". And I can fly";
        }
    }
}
