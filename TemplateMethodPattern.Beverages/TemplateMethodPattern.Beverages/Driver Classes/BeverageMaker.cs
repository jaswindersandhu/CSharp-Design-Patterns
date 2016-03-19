using System;
using TemplateMethodPattern.Beverages.Abstract_Classes;
using TemplateMethodPattern.Beverages.Concrete_Classes.CaffeineBeverage_Extentions;

namespace TemplateMethodPattern.Beverages.Driver_Classes
{
    public class BeverageMaker
    {
        public static void Main(string[] args)
        {
            CaffeineBeverage caffeinatedBeverage;
            
            caffeinatedBeverage= new Coffee();
            caffeinatedBeverage.PrepareRecipe();

            Console.WriteLine();

            caffeinatedBeverage = new Tea();
            caffeinatedBeverage.PrepareRecipe();
        }
    }
}
