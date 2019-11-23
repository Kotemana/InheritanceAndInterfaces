using System;
using System.Collections.Generic;
using System.Text;

namespace PartyCodding
{
    public class Animal
    {
        public int Weight { get; set; }
        public AnimalFoodType FoodType { get; set; }
        public string Name { get; set; }

        public virtual string StoryAboutYourself()
        {
            return $"I'm {Name}, I weigh {Weight} kgs and eat {FoodTypeToEat(FoodType)}";
        }

        private string FoodTypeToEat(AnimalFoodType foodType)
        {
            switch (foodType)
            {
                case AnimalFoodType.Carnivorous:
                    return "meat";
                case AnimalFoodType.Herbivorous:
                    return "grass and vegetables";
                case AnimalFoodType.Ambivorous:
                    return "everything eadible";
                default:
                    return "some illegall stuff";
            }
        }
    }
}
