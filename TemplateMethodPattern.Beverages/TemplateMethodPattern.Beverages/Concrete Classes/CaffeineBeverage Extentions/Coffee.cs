using System;
using TemplateMethodPattern.Beverages.Abstract_Classes;

namespace TemplateMethodPattern.Beverages.Concrete_Classes.CaffeineBeverage_Extentions
{
    public class Coffee : CaffeineBeverage
    {
        public override void Brew()
        {
            Console.WriteLine("Dripping coffee through filter...");
        }

        public override void AddCondiments()
        {
            Console.WriteLine("Adding milk and sugar...");
        }
    }
}
