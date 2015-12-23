using System;
using DecoratorPattern.StarbuzzCoffee.Abstract_Classes;
using DecoratorPattern.StarbuzzCoffee.Concrete_Classes.Beverage_Extensions;
using DecoratorPattern.StarbuzzCoffee.Concrete_Classes.CondimentDecorator_Extensions;
using DecoratorPattern.StarbuzzCoffee.Concrete_Classes.BeverageSize_Implementations;

namespace DecoratorPattern.StarbuzzCoffee.Driver_Classes {
    class StarbuzzCoffee {
        static void Main(string[] args) {
            Beverage beverage = new Espresso(new TallSize());
            Console.WriteLine(beverage.Description + " $" + beverage.Cost());

            Beverage beverage2 = new DarkRoast(new VentiSize());
            beverage2 = new Soy(beverage2);
            beverage2 = new Mocha(beverage2);
            beverage2 = new Mocha(beverage2);
            beverage2 = new Whip(beverage2);
            Console.WriteLine(beverage2.Description + " $" + beverage2.Cost());

            Beverage beverage3 = new HouseBlend(new GrandeSize());
            beverage3 = new Soy(beverage3);
            beverage3 = new Mocha(beverage3);
            beverage3 = new Whip(beverage3);
            Console.WriteLine(beverage3.Description + " $" + beverage3.Cost());

            Console.ReadLine();
        }
    }
}
