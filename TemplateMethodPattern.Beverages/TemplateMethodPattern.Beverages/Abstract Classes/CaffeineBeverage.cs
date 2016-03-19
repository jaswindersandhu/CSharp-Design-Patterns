using System;

namespace TemplateMethodPattern.Beverages.Abstract_Classes
{
    public abstract class CaffeineBeverage
    {
        public void PrepareRecipe()
        {
            BoilWater();
            Brew();
            PourInCup();
            if (CustomerWantsCondiments())
            {
                AddCondiments();
            }
        }

        public abstract void Brew();
        public abstract void AddCondiments();

        public void BoilWater()
        {
            Console.WriteLine("Boiling water...");
        }

        public void PourInCup()
        {
            Console.WriteLine("Pouring in cup...");
        }

        public virtual bool CustomerWantsCondiments()
        {
            return true;
        }
    }
}
