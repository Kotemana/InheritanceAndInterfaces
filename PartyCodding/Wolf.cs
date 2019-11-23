using System;
using System.Collections.Generic;
using System.Text;

namespace PartyCodding
{
    public class Wolf : Animal
    {
        public string FavouriteSong { get; set; }

        public override string StoryAboutYourself()
        {
            return base.StoryAboutYourself() 
                + $". My favourite song under moon is {FavouriteSong}";
        }
    }
}
