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
                Weight = 200
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
                Name = "Dzhamshut"
            };
            var animals = new List<Animal>() { cow, wolf, pegasik };
            foreach (var zver in animals)
            {
                Console.WriteLine(zver.StoryAboutYourself());
                //if(zver is Cow)
                //{
                //    Console.WriteLine("Mooo");
                //}
                cow = zver as Cow;
                if (cow != null)
                {
                    Console.WriteLine(cow.BreastSize);
                }

                if (zver is IFlyable)
                {
                    ((IFlyable)zver).Fly();
                }
            }

        }
        
    }
}
