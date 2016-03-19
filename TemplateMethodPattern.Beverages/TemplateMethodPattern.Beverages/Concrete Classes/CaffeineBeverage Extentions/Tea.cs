using System;
using TemplateMethodPattern.Beverages.Abstract_Classes;

namespace TemplateMethodPattern.Beverages.Concrete_Classes.CaffeineBeverage_Extentions
{
    public class Tea : CaffeineBeverage
    {
        public override void Brew()
        {
            Console.WriteLine("Steeple the tea...");
        }

        public override void AddCondiments()
        {
            Console.WriteLine("Adding lemon...");
        }
    }
}
