using System;
using System.Collections.Generic;
using System.Linq;

namespace PartyCodding
{
    class Program
    {
        static void Main(string[] args)
        {
            var cow = new Cow()
            {
                BreastSize = 7,
                FoodType = AnimalFoodType.Herbivorous,
                Name = "Burenka",
                Weight = 200,
                FlightPower = FlightPower.Magic
            };
            var wolf = new Wolf()
            {
                FavouriteSong = "AAAUUAAAUAUAUAUUUUAA",
                Name = "Barbose Prime",
                Weight = 80,
                FoodType = AnimalFoodType.Carnivorous
            };
            var pegasik = new Pegasus
            {
                FoodType = AnimalFoodType.Ambivorous,
                Weight = 170,
                Name = "Dzhamshut",
                FlightPower = FlightPower.Wings
            };
            //var animals = new List<Animal>() { cow, wolf, pegasik };
            //foreach (var zver in animals)
            //{
            //    Console.WriteLine(zver.StoryAboutYourself());
            //    cow = zver as Cow;
            //    if (cow != null)
            //    {
            //        Console.WriteLine(cow.BreastSize);
            //    }

            //    if (zver is IFlyable)
            //    {
            //        ((IFlyable)zver).Fly();
            //    }
            //}
            var flyers = new List<IFlyable>() { cow, pegasik };
            foreach (var flyer in flyers)
            {
                flyer.Fly();
            }
        }
        
    }
}
