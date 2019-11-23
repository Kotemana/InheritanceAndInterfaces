using System;
using System.Collections.Generic;
using System.Text;

namespace PartyCodding
{
    public class Cow : Animal
    {
        public int BreastSize { get; set; }

        public override string StoryAboutYourself()
        {
            return base.StoryAboutYourself()
                + $". My breast size is {BreastSize}";
        }

    }
}
